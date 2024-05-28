namespace TRVC
{
    partial class ShowCashVND
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
            this.dataGridViewShowCashVND = new System.Windows.Forms.DataGridView();
            this.dateTimePickershowCashVND = new System.Windows.Forms.DateTimePicker();
            this.txtSeachShowCashVND = new System.Windows.Forms.TextBox();
            this.btnSeachShowVND = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowCashVND)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShowCashVND
            // 
            this.dataGridViewShowCashVND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowCashVND.Location = new System.Drawing.Point(12, 122);
            this.dataGridViewShowCashVND.Name = "dataGridViewShowCashVND";
            this.dataGridViewShowCashVND.RowHeadersWidth = 51;
            this.dataGridViewShowCashVND.RowTemplate.Height = 24;
            this.dataGridViewShowCashVND.Size = new System.Drawing.Size(1039, 447);
            this.dataGridViewShowCashVND.TabIndex = 0;
            this.dataGridViewShowCashVND.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShowCashVND_CellContentClick);
            // 
            // dateTimePickershowCashVND
            // 
            this.dateTimePickershowCashVND.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickershowCashVND.Location = new System.Drawing.Point(12, 67);
            this.dateTimePickershowCashVND.Name = "dateTimePickershowCashVND";
            this.dateTimePickershowCashVND.Size = new System.Drawing.Size(317, 30);
            this.dateTimePickershowCashVND.TabIndex = 1;
            // 
            // txtSeachShowCashVND
            // 
            this.txtSeachShowCashVND.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeachShowCashVND.Location = new System.Drawing.Point(335, 70);
            this.txtSeachShowCashVND.Name = "txtSeachShowCashVND";
            this.txtSeachShowCashVND.Size = new System.Drawing.Size(608, 30);
            this.txtSeachShowCashVND.TabIndex = 2;
            // 
            // btnSeachShowVND
            // 
            this.btnSeachShowVND.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeachShowVND.Location = new System.Drawing.Point(949, 67);
            this.btnSeachShowVND.Name = "btnSeachShowVND";
            this.btnSeachShowVND.Size = new System.Drawing.Size(102, 33);
            this.btnSeachShowVND.TabIndex = 3;
            this.btnSeachShowVND.Text = "Seach";
            this.btnSeachShowVND.UseVisualStyleBackColor = true;
            this.btnSeachShowVND.Click += new System.EventHandler(this.btnSeachShowVND_Click);
            // 
            // ShowCashVND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 607);
            this.Controls.Add(this.btnSeachShowVND);
            this.Controls.Add(this.txtSeachShowCashVND);
            this.Controls.Add(this.dateTimePickershowCashVND);
            this.Controls.Add(this.dataGridViewShowCashVND);
            this.Name = "ShowCashVND";
            this.Text = "ShowCashVND";
            this.Load += new System.EventHandler(this.ShowCashVND_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowCashVND)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShowCashVND;
        private System.Windows.Forms.DateTimePicker dateTimePickershowCashVND;
        private System.Windows.Forms.TextBox txtSeachShowCashVND;
        private System.Windows.Forms.Button btnSeachShowVND;
    }
}