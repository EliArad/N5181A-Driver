namespace SignalGeneratorTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnect = new System.Windows.Forms.Button();
            this.cmbLanVisaAddress = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSetFreq = new System.Windows.Forms.Button();
            this.btnSetPower = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(428, 44);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "&Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // cmbLanVisaAddress
            // 
            this.cmbLanVisaAddress.FormattingEnabled = true;
            this.cmbLanVisaAddress.Location = new System.Drawing.Point(60, 44);
            this.cmbLanVisaAddress.Name = "cmbLanVisaAddress";
            this.cmbLanVisaAddress.Size = new System.Drawing.Size(362, 21);
            this.cmbLanVisaAddress.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnSetFreq
            // 
            this.btnSetFreq.Location = new System.Drawing.Point(187, 144);
            this.btnSetFreq.Name = "btnSetFreq";
            this.btnSetFreq.Size = new System.Drawing.Size(86, 23);
            this.btnSetFreq.TabIndex = 3;
            this.btnSetFreq.Text = "&Set Frequnecy";
            this.btnSetFreq.UseVisualStyleBackColor = true;
            // 
            // btnSetPower
            // 
            this.btnSetPower.Location = new System.Drawing.Point(187, 186);
            this.btnSetPower.Name = "btnSetPower";
            this.btnSetPower.Size = new System.Drawing.Size(75, 23);
            this.btnSetPower.TabIndex = 5;
            this.btnSetPower.Text = "&Set Power";
            this.btnSetPower.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 186);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(72, 230);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Power On Off";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 349);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnSetPower);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnSetFreq);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbLanVisaAddress);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cmbLanVisaAddress;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSetFreq;
        private System.Windows.Forms.Button btnSetPower;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

