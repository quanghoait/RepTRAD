namespace TRVC
{
    partial class ShowCode
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
            this.dataGridViewShowCode = new System.Windows.Forms.DataGridView();
            this.txtSeachCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowCode)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShowCode
            // 
            this.dataGridViewShowCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowCode.Location = new System.Drawing.Point(13, 138);
            this.dataGridViewShowCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewShowCode.Name = "dataGridViewShowCode";
            this.dataGridViewShowCode.RowHeadersWidth = 51;
            this.dataGridViewShowCode.Size = new System.Drawing.Size(1125, 373);
            this.dataGridViewShowCode.TabIndex = 0;
            this.dataGridViewShowCode.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShowCode_CellContentClick);
            // 
            // txtSeachCode
            // 
            this.txtSeachCode.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeachCode.Location = new System.Drawing.Point(190, 55);
            this.txtSeachCode.Name = "txtSeachCode";
            this.txtSeachCode.Size = new System.Drawing.Size(553, 33);
            this.txtSeachCode.TabIndex = 18;
            this.txtSeachCode.TextChanged += new System.EventHandler(this.txtSeachCode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Seach";
            // 
            // ShowCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSeachCode);
            this.Controls.Add(this.dataGridViewShowCode);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ShowCode";
            this.Text = "ShowCode";
            this.Load += new System.EventHandler(this.ShowCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewShowCode;
        private System.Windows.Forms.TextBox txtSeachCode;
        private System.Windows.Forms.Label label1;
    }
}