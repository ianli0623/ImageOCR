using IronOcr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using Tesseract;

namespace ImageOCR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<string> GetProductNumberFromImage(string imagePath)
        {
            List<string> resultList = new List<string>();
            using (var ocr = new TesseractEngine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tessdata"), "chi_sim", EngineMode.Default))
            {
                var pix = PixConverter.ToPix(new Bitmap(imagePath));
                using (var page = ocr.Process(pix))
                {
                    string text = page.GetText();
                    if (!string.IsNullOrEmpty(text))
                    {
                        string pattern = @"品號([\s\S])(\d+)";
                        Regex regex = new Regex(pattern);
                        var mathResult = regex.Matches(text);
                        foreach (Match item in mathResult)
                        {
                            if (item.Groups.Count >= 2)
                            {
                                resultList.Add(item.Groups[2].Value);
                            }
                            else
                            {
                                resultList.Add(item.Value);
                            }
                        }
                    }
                }
            }
            return resultList;
        }

        private void GetText_Tesseract_Click(object sender, EventArgs e)
        {
            string imagePath = FolderPath.Text;
            using (var ocr = new TesseractEngine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tessdata"), "eng", EngineMode.Default))
            {
                var pix = PixConverter.ToPix(new Bitmap(imagePath));
                using (var page = ocr.Process(pix))
                {
                    string text = page.GetText();
                    if (!string.IsNullOrEmpty(text))
                    {
                        textBox1.Text = text;
                        string tr = TranslateText(text);
                        textBox2.Text = tr;
                    }
                }
            }
        }

        private void GetText_IronOCR_Click(object sender, EventArgs e)
        {
            var Ocr = new IronTesseract();
            Ocr.Language = OcrLanguage.ChineseTraditional;
            string imagePath = FolderPath.Text;
            using (var Input = new OcrInput(imagePath))
            {
                var Result = Ocr.Read(Input);
                textBox1.Text = Result.Text;
            }
        }

        public string TranslateText(string input)
        {
            string url = String.Format
            ("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
             "en", "zh-TW", Uri.EscapeUriString(input));
            HttpClient httpClient = new HttpClient();
            string result = httpClient.GetStringAsync(url).Result;

            var jsonData = new JavaScriptSerializer().Deserialize<List<dynamic>>(result);

            var translationItems = jsonData[0];

            string translation = "";

            foreach (object item in translationItems)
            {
                IEnumerable translationLineObject = item as IEnumerable;

                IEnumerator translationLineString = translationLineObject.GetEnumerator();

                translationLineString.MoveNext();

                translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
            }
            if (translation.Length > 1) { translation = translation.Substring(1); };
            return translation;
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;";
            file.ShowDialog();
            FolderPath.Text = file.FileName;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (Start.Text == "取消")
            {
                Open.Enabled = true;
                Start.Text = "鎖定";
            }
            else
            {
                string filePath = FolderPath.Text;
                if (!string.IsNullOrEmpty(filePath))
                {
                    // 檢查檔案是否存在
                    if (File.Exists(filePath))
                    {
                        // 檢查副檔名是否為圖片格式
                        string extension = Path.GetExtension(filePath).ToLower();
                        if (extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".gif")
                        {
                            Open.Enabled = false;
                            Start.Text = "取消";
                        }
                        else
                        {
                            MessageBox.Show("這不是一個圖片檔案");

                        }
                    }
                    else
                    {
                        MessageBox.Show("請選擇已存在資料夾");
                    }
                }
                else
                {
                    MessageBox.Show("請選擇路徑");
                }
            }
        }
    }
}
