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
            this.txtFrequency = new System.Windows.Forms.TextBox();
            this.btnSetFreq = new System.Windows.Forms.Button();
            this.btnSetPower = new System.Windows.Forms.Button();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.chkOnOff = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
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
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cmbLanVisaAddress
            // 
            this.cmbLanVisaAddress.FormattingEnabled = true;
            this.cmbLanVisaAddress.Location = new System.Drawing.Point(60, 44);
            this.cmbLanVisaAddress.Name = "cmbLanVisaAddress";
            this.cmbLanVisaAddress.Size = new System.Drawing.Size(362, 21);
            this.cmbLanVisaAddress.TabIndex = 1;
            // 
            // txtFrequency
            // 
            this.txtFrequency.Location = new System.Drawing.Point(20, 32);
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.Size = new System.Drawing.Size(100, 20);
            this.txtFrequency.TabIndex = 2;
            // 
            // btnSetFreq
            // 
            this.btnSetFreq.Location = new System.Drawing.Point(135, 32);
            this.btnSetFreq.Name = "btnSetFreq";
            this.btnSetFreq.Size = new System.Drawing.Size(86, 23);
            this.btnSetFreq.TabIndex = 3;
            this.btnSetFreq.Text = "&Set Frequnecy";
            this.btnSetFreq.UseVisualStyleBackColor = true;
            this.btnSetFreq.Click += new System.EventHandler(this.btnSetFreq_Click);
            // 
            // btnSetPower
            // 
            this.btnSetPower.Location = new System.Drawing.Point(135, 74);
            this.btnSetPower.Name = "btnSetPower";
            this.btnSetPower.Size = new System.Drawing.Size(75, 23);
            this.btnSetPower.TabIndex = 5;
            this.btnSetPower.Text = "&Set Power";
            this.btnSetPower.UseVisualStyleBackColor = true;
            this.btnSetPower.Click += new System.EventHandler(this.btnSetPower_Click);
            // 
            // txtPower
            // 
            this.txtPower.Location = new System.Drawing.Point(20, 74);
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(100, 20);
            this.txtPower.TabIndex = 4;
            // 
            // chkOnOff
            // 
            this.chkOnOff.AutoSize = true;
            this.chkOnOff.Location = new System.Drawing.Point(20, 118);
            this.chkOnOff.Name = "chkOnOff";
            this.chkOnOff.Size = new System.Drawing.Size(90, 17);
            this.chkOnOff.TabIndex = 6;
            this.chkOnOff.Text = "Power On Off";
            this.chkOnOff.UseVisualStyleBackColor = true;
            this.chkOnOff.CheckedChanged += new System.EventHandler(this.chkOnOff_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSetFreq);
            this.groupBox1.Controls.Add(this.chkOnOff);
            this.groupBox1.Controls.Add(this.txtFrequency);
            this.groupBox1.Controls.Add(this.btnSetPower);
            this.groupBox1.Controls.Add(this.txtPower);
            this.groupBox1.Location = new System.Drawing.Point(60, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 181);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 349);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbLanVisaAddress);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cmbLanVisaAddress;
        private System.Windows.Forms.TextBox txtFrequency;
        private System.Windows.Forms.Button btnSetFreq;
        private System.Windows.Forms.Button btnSetPower;
        private System.Windows.Forms.TextBox txtPower;
        private System.Windows.Forms.CheckBox chkOnOff;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

