
namespace ImageOCR
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.GetText_Tesseract = new System.Windows.Forms.Button();
            this.GetText_IronOCR = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FolderPath = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GetText_Tesseract
            // 
            this.GetText_Tesseract.Location = new System.Drawing.Point(26, 90);
            this.GetText_Tesseract.Name = "GetText_Tesseract";
            this.GetText_Tesseract.Size = new System.Drawing.Size(131, 56);
            this.GetText_Tesseract.TabIndex = 0;
            this.GetText_Tesseract.Text = "Tesseract(英翻中)";
            this.GetText_Tesseract.UseVisualStyleBackColor = true;
            this.GetText_Tesseract.Click += new System.EventHandler(this.GetText_Tesseract_Click);
            // 
            // GetText_IronOCR
            // 
            this.GetText_IronOCR.Location = new System.Drawing.Point(176, 90);
            this.GetText_IronOCR.Name = "GetText_IronOCR";
            this.GetText_IronOCR.Size = new System.Drawing.Size(147, 56);
            this.GetText_IronOCR.TabIndex = 1;
            this.GetText_IronOCR.Text = "IronOCR(讀取中文)";
            this.GetText_IronOCR.UseVisualStyleBackColor = true;
            this.GetText_IronOCR.Click += new System.EventHandler(this.GetText_IronOCR_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(388, 35);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(84, 46);
            this.Open.TabIndex = 8;
            this.Open.Text = "開啟";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(478, 35);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(84, 46);
            this.Start.TabIndex = 7;
            this.Start.Text = "鎖定";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "資料夾路徑";
            // 
            // FolderPath
            // 
            this.FolderPath.Enabled = false;
            this.FolderPath.Location = new System.Drawing.Point(11, 35);
            this.FolderPath.Multiline = true;
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.Size = new System.Drawing.Size(371, 49);
            this.FolderPath.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 163);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 188);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(309, 163);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(292, 188);
            this.textBox2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 374);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FolderPath);
            this.Controls.Add(this.GetText_IronOCR);
            this.Controls.Add(this.GetText_Tesseract);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetText_Tesseract;
        private System.Windows.Forms.Button GetText_IronOCR;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FolderPath;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

