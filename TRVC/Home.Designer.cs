namespace TRVC
{
    partial class Home
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
            this.btnCode = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCashVND = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCode
            // 
            this.btnCode.Location = new System.Drawing.Point(45, 18);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(107, 51);
            this.btnCode.TabIndex = 0;
            this.btnCode.Text = "Code";
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnCode);
            this.panel1.Location = new System.Drawing.Point(44, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 354);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnCashVND);
            this.panel2.Location = new System.Drawing.Point(280, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 352);
            this.panel2.TabIndex = 2;
            // 
            // btnCashVND
            // 
            this.btnCashVND.Location = new System.Drawing.Point(16, 16);
            this.btnCashVND.Name = "btnCashVND";
            this.btnCashVND.Size = new System.Drawing.Size(107, 51);
            this.btnCashVND.TabIndex = 1;
            this.btnCashVND.Text = "CashVND";
            this.btnCashVND.UseVisualStyleBackColor = true;
            this.btnCashVND.Click += new System.EventHandler(this.btnCashVND_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 692);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCashVND;
    }
}

