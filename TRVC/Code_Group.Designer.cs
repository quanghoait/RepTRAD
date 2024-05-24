namespace TRVC
{
    partial class Code_Group
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_code_group = new System.Windows.Forms.Button();
            this.txtCode_Group = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewGroupCode = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupCode)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_code_group);
            this.panel1.Controls.Add(this.txtCode_Group);
            this.panel1.Location = new System.Drawing.Point(25, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 109);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Code_Group";
            // 
            // btn_code_group
            // 
            this.btn_code_group.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_code_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_code_group.Location = new System.Drawing.Point(291, 55);
            this.btn_code_group.Name = "btn_code_group";
            this.btn_code_group.Size = new System.Drawing.Size(96, 36);
            this.btn_code_group.TabIndex = 1;
            this.btn_code_group.Text = "Submit";
            this.btn_code_group.UseVisualStyleBackColor = false;
            this.btn_code_group.Click += new System.EventHandler(this.btn_code_group_Click);
            // 
            // txtCode_Group
            // 
            this.txtCode_Group.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode_Group.Location = new System.Drawing.Point(101, 16);
            this.txtCode_Group.Name = "txtCode_Group";
            this.txtCode_Group.Size = new System.Drawing.Size(539, 33);
            this.txtCode_Group.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(139, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 54);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add Code Group";
            // 
            // dataGridViewGroupCode
            // 
            this.dataGridViewGroupCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroupCode.Location = new System.Drawing.Point(25, 207);
            this.dataGridViewGroupCode.Name = "dataGridViewGroupCode";
            this.dataGridViewGroupCode.RowHeadersWidth = 51;
            this.dataGridViewGroupCode.RowTemplate.Height = 24;
            this.dataGridViewGroupCode.Size = new System.Drawing.Size(492, 162);
            this.dataGridViewGroupCode.TabIndex = 2;
            // 
            // Code_Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 495);
            this.Controls.Add(this.dataGridViewGroupCode);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Code_Group";
            this.Text = "Code_Group";
            this.Load += new System.EventHandler(this.Code_Group_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_code_group;
        private System.Windows.Forms.TextBox txtCode_Group;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewGroupCode;
    }
}