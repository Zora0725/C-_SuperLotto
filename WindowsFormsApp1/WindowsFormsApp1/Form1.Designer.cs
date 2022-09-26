namespace WindowsFormsApp1
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
            this.lbl_LottoSystemTitle = new System.Windows.Forms.Label();
            this.btn_RandomNumber = new System.Windows.Forms.Button();
            this.lbl_RandomNumber = new System.Windows.Forms.Label();
            this.lbl_SpecialNumber = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.num3 = new System.Windows.Forms.Label();
            this.num4 = new System.Windows.Forms.Label();
            this.num5 = new System.Windows.Forms.Label();
            this.num6 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_LottoSystemTitle
            // 
            this.lbl_LottoSystemTitle.AutoSize = true;
            this.lbl_LottoSystemTitle.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.lbl_LottoSystemTitle.Font = new System.Drawing.Font("微軟正黑體", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_LottoSystemTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_LottoSystemTitle.Location = new System.Drawing.Point(206, 29);
            this.lbl_LottoSystemTitle.Name = "lbl_LottoSystemTitle";
            this.lbl_LottoSystemTitle.Size = new System.Drawing.Size(325, 55);
            this.lbl_LottoSystemTitle.TabIndex = 0;
            this.lbl_LottoSystemTitle.Text = "台灣大樂透系統";
            // 
            // btn_RandomNumber
            // 
            this.btn_RandomNumber.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_RandomNumber.Location = new System.Drawing.Point(256, 134);
            this.btn_RandomNumber.Name = "btn_RandomNumber";
            this.btn_RandomNumber.Size = new System.Drawing.Size(226, 73);
            this.btn_RandomNumber.TabIndex = 1;
            this.btn_RandomNumber.Text = "按此產生隨機數";
            this.btn_RandomNumber.UseVisualStyleBackColor = true;
            this.btn_RandomNumber.Click += new System.EventHandler(this.btn_RandomNumber_Click);
            // 
            // lbl_RandomNumber
            // 
            this.lbl_RandomNumber.BackColor = System.Drawing.Color.Snow;
            this.lbl_RandomNumber.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_RandomNumber.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbl_RandomNumber.Location = new System.Drawing.Point(27, 280);
            this.lbl_RandomNumber.Name = "lbl_RandomNumber";
            this.lbl_RandomNumber.Size = new System.Drawing.Size(511, 39);
            this.lbl_RandomNumber.TabIndex = 2;
            this.lbl_RandomNumber.Text = "號碼：";
            this.lbl_RandomNumber.Click += new System.EventHandler(this.lbl_RandomNumber_Click);
            // 
            // lbl_SpecialNumber
            // 
            this.lbl_SpecialNumber.BackColor = System.Drawing.Color.Snow;
            this.lbl_SpecialNumber.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_SpecialNumber.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbl_SpecialNumber.Location = new System.Drawing.Point(564, 279);
            this.lbl_SpecialNumber.Name = "lbl_SpecialNumber";
            this.lbl_SpecialNumber.Size = new System.Drawing.Size(184, 41);
            this.lbl_SpecialNumber.TabIndex = 3;
            this.lbl_SpecialNumber.Text = "特別號：";
            this.lbl_SpecialNumber.Click += new System.EventHandler(this.lbl_SpecialNumber_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(256, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 64);
            this.button1.TabIndex = 4;
            this.button1.Text = "開啟對獎器";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(126, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 47);
            this.label1.TabIndex = 5;
            this.label1.Text = "台灣樂透祝您中大獎！";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.num2.Location = new System.Drawing.Point(189, 283);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(56, 32);
            this.num2.TabIndex = 6;
            this.num2.Text = "　　";
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num3
            // 
            this.num3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.num3.Location = new System.Drawing.Point(251, 283);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(56, 32);
            this.num3.TabIndex = 7;
            this.num3.Text = "　　";
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num4
            // 
            this.num4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.num4.Location = new System.Drawing.Point(313, 283);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(56, 32);
            this.num4.TabIndex = 8;
            this.num4.Text = "　　";
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num5
            // 
            this.num5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.num5.Location = new System.Drawing.Point(375, 283);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(56, 32);
            this.num5.TabIndex = 9;
            this.num5.Text = "　　";
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num6
            // 
            this.num6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.num6.Location = new System.Drawing.Point(437, 283);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(56, 32);
            this.num6.TabIndex = 10;
            this.num6.Text = "　　";
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.num1.Location = new System.Drawing.Point(127, 283);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(56, 32);
            this.num1.TabIndex = 11;
            this.num1.Text = "　　";
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(769, 550);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_SpecialNumber);
            this.Controls.Add(this.lbl_RandomNumber);
            this.Controls.Add(this.btn_RandomNumber);
            this.Controls.Add(this.lbl_LottoSystemTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_LottoSystemTitle;
        private System.Windows.Forms.Button btn_RandomNumber;
        private System.Windows.Forms.Label lbl_RandomNumber;
        private System.Windows.Forms.Label lbl_SpecialNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Label num3;
        private System.Windows.Forms.Label num4;
        private System.Windows.Forms.Label num5;
        private System.Windows.Forms.Label num6;
        private System.Windows.Forms.Label num1;
    }
}

