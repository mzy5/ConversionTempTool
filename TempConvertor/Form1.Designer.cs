namespace TempConvertor
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
            this.txtFromC = new System.Windows.Forms.TextBox();
            this.txtFromF = new System.Windows.Forms.TextBox();
            this.txtToC = new System.Windows.Forms.TextBox();
            this.txtToF = new System.Windows.Forms.TextBox();
            this.btnCtoF = new System.Windows.Forms.Button();
            this.btnFtoC = new System.Windows.Forms.Button();
            this.lblfromC = new System.Windows.Forms.Label();
            this.lbltoF = new System.Windows.Forms.Label();
            this.lblFromF = new System.Windows.Forms.Label();
            this.lblToC = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFromC
            // 
            this.txtFromC.Location = new System.Drawing.Point(56, 74);
            this.txtFromC.Name = "txtFromC";
            this.txtFromC.Size = new System.Drawing.Size(100, 20);
            this.txtFromC.TabIndex = 0;
            // 
            // txtFromF
            // 
            this.txtFromF.Location = new System.Drawing.Point(56, 153);
            this.txtFromF.Name = "txtFromF";
            this.txtFromF.Size = new System.Drawing.Size(100, 20);
            this.txtFromF.TabIndex = 1;
            // 
            // txtToC
            // 
            this.txtToC.Location = new System.Drawing.Point(364, 153);
            this.txtToC.Name = "txtToC";
            this.txtToC.Size = new System.Drawing.Size(100, 20);
            this.txtToC.TabIndex = 3;
            // 
            // txtToF
            // 
            this.txtToF.Location = new System.Drawing.Point(364, 74);
            this.txtToF.Name = "txtToF";
            this.txtToF.Size = new System.Drawing.Size(100, 20);
            this.txtToF.TabIndex = 2;
            // 
            // btnCtoF
            // 
            this.btnCtoF.Location = new System.Drawing.Point(222, 71);
            this.btnCtoF.Name = "btnCtoF";
            this.btnCtoF.Size = new System.Drawing.Size(75, 23);
            this.btnCtoF.TabIndex = 4;
            this.btnCtoF.Text = "C to F";
            this.btnCtoF.UseVisualStyleBackColor = true;
            this.btnCtoF.Click += new System.EventHandler(this.btnCtoF_Click);
            // 
            // btnFtoC
            // 
            this.btnFtoC.Location = new System.Drawing.Point(222, 150);
            this.btnFtoC.Name = "btnFtoC";
            this.btnFtoC.Size = new System.Drawing.Size(75, 23);
            this.btnFtoC.TabIndex = 5;
            this.btnFtoC.Text = "F to C";
            this.btnFtoC.UseVisualStyleBackColor = true;
            this.btnFtoC.Click += new System.EventHandler(this.btnFtoC_Click);
            // 
            // lblfromC
            // 
            this.lblfromC.AutoSize = true;
            this.lblfromC.Location = new System.Drawing.Point(56, 55);
            this.lblfromC.Name = "lblfromC";
            this.lblfromC.Size = new System.Drawing.Size(40, 13);
            this.lblfromC.TabIndex = 6;
            this.lblfromC.Text = "Celsius";
            // 
            // lbltoF
            // 
            this.lbltoF.AutoSize = true;
            this.lbltoF.Location = new System.Drawing.Point(361, 58);
            this.lbltoF.Name = "lbltoF";
            this.lbltoF.Size = new System.Drawing.Size(57, 13);
            this.lbltoF.TabIndex = 7;
            this.lbltoF.Text = "Fahrenheit";
            // 
            // lblFromF
            // 
            this.lblFromF.AutoSize = true;
            this.lblFromF.Location = new System.Drawing.Point(56, 137);
            this.lblFromF.Name = "lblFromF";
            this.lblFromF.Size = new System.Drawing.Size(57, 13);
            this.lblFromF.TabIndex = 8;
            this.lblFromF.Text = "Fahrenheit";
            // 
            // lblToC
            // 
            this.lblToC.AutoSize = true;
            this.lblToC.Location = new System.Drawing.Point(361, 137);
            this.lblToC.Name = "lblToC";
            this.lblToC.Size = new System.Drawing.Size(40, 13);
            this.lblToC.TabIndex = 9;
            this.lblToC.Text = "Celsius";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(451, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 263);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblToC);
            this.Controls.Add(this.lblFromF);
            this.Controls.Add(this.lbltoF);
            this.Controls.Add(this.lblfromC);
            this.Controls.Add(this.btnFtoC);
            this.Controls.Add(this.btnCtoF);
            this.Controls.Add(this.txtToC);
            this.Controls.Add(this.txtToF);
            this.Controls.Add(this.txtFromF);
            this.Controls.Add(this.txtFromC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFromC;
        private System.Windows.Forms.TextBox txtFromF;
        private System.Windows.Forms.TextBox txtToC;
        private System.Windows.Forms.TextBox txtToF;
        private System.Windows.Forms.Button btnCtoF;
        private System.Windows.Forms.Button btnFtoC;
        private System.Windows.Forms.Label lblfromC;
        private System.Windows.Forms.Label lbltoF;
        private System.Windows.Forms.Label lblFromF;
        private System.Windows.Forms.Label lblToC;
        private System.Windows.Forms.Button button1;
    }
}

