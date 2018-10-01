namespace MainStoreFunctionality
{
    partial class FormGetEmployees
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
            this.richTextBoxGetEmployees = new System.Windows.Forms.RichTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboBoxShops = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelGetEmployees
            // 
            this.labelGetEmployees.AutoSize = true;
            this.labelGetEmployees.Enabled = false;
            this.labelGetEmployees.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGetEmployees.Location = new System.Drawing.Point(119, 54);
            this.labelGetEmployees.Name = "labelGetEmployees";
            this.labelGetEmployees.Size = new System.Drawing.Size(204, 26);
            this.labelGetEmployees.TabIndex = 7;
            this.labelGetEmployees.Text = "Choose the shop:";
            // 
            // richTextBoxGetEmployees
            // 
            this.richTextBoxGetEmployees.Enabled = false;
            this.richTextBoxGetEmployees.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxGetEmployees.Location = new System.Drawing.Point(144, 121);
            this.richTextBoxGetEmployees.Name = "richTextBoxGetEmployees";
            this.richTextBoxGetEmployees.Size = new System.Drawing.Size(450, 267);
            this.richTextBoxGetEmployees.TabIndex = 6;
            this.richTextBoxGetEmployees.Text = "";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSearch.Location = new System.Drawing.Point(615, 54);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 46);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comboBoxShops
            // 
            this.comboBoxShops.FormattingEnabled = true;
            this.comboBoxShops.Location = new System.Drawing.Point(343, 54);
            this.comboBoxShops.Name = "comboBoxShops";
            this.comboBoxShops.Size = new System.Drawing.Size(236, 24);
            this.comboBoxShops.TabIndex = 11;
            // 
            // FormGetEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(756, 453);
            this.Controls.Add(this.comboBoxShops);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.labelGetEmployees);
            this.Controls.Add(this.richTextBoxGetEmployees);
            this.Name = "FormGetEmployees";
            this.Text = "FormGetEmployees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelGetEmployees;
        private System.Windows.Forms.RichTextBox richTextBoxGetEmployees;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboBoxShops;
    }
}