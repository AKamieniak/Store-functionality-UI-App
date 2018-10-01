namespace MainStoreFunctionality
{
    partial class FormDeleteEmployee
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
            this.labelGetEmployees = new System.Windows.Forms.Label();
            this.comboBoxShops = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listBoxEmployees = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelGetEmployees
            // 
            this.labelGetEmployees.AutoSize = true;
            this.labelGetEmployees.Enabled = false;
            this.labelGetEmployees.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGetEmployees.Location = new System.Drawing.Point(71, 49);
            this.labelGetEmployees.Name = "labelGetEmployees";
            this.labelGetEmployees.Size = new System.Drawing.Size(204, 26);
            this.labelGetEmployees.TabIndex = 8;
            this.labelGetEmployees.Text = "Choose the shop:";
            // 
            // comboBoxShops
            // 
            this.comboBoxShops.FormattingEnabled = true;
            this.comboBoxShops.Location = new System.Drawing.Point(292, 54);
            this.comboBoxShops.Name = "comboBoxShops";
            this.comboBoxShops.Size = new System.Drawing.Size(236, 24);
            this.comboBoxShops.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSearch.Location = new System.Drawing.Point(580, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 46);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.ItemHeight = 16;
            this.listBoxEmployees.Location = new System.Drawing.Point(122, 102);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(435, 212);
            this.listBoxEmployees.TabIndex = 14;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.Location = new System.Drawing.Point(456, 330);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(101, 46);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormDeleteEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(751, 467);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listBoxEmployees);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.comboBoxShops);
            this.Controls.Add(this.labelGetEmployees);
            this.Name = "FormDeleteEmployee";
            this.Text = "FormDeleteEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGetEmployees;
        private System.Windows.Forms.ComboBox comboBoxShops;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox listBoxEmployees;
        private System.Windows.Forms.Button buttonDelete;
    }
}