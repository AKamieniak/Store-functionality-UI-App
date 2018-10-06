namespace MainStoreFunctionality
{
    partial class FormGetShops
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelGetShops = new System.Windows.Forms.Label();
            this.richTextBoxGetShops = new System.Windows.Forms.RichTextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSearch.Location = new System.Drawing.Point(576, 59);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 46);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelGetShops
            // 
            this.labelGetShops.AutoSize = true;
            this.labelGetShops.Enabled = false;
            this.labelGetShops.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGetShops.Location = new System.Drawing.Point(100, 59);
            this.labelGetShops.Name = "labelGetShops";
            this.labelGetShops.Size = new System.Drawing.Size(166, 26);
            this.labelGetShops.TabIndex = 13;
            this.labelGetShops.Text = "Type the city:";
            // 
            // richTextBoxGetShops
            // 
            this.richTextBoxGetShops.Enabled = false;
            this.richTextBoxGetShops.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxGetShops.Location = new System.Drawing.Point(105, 126);
            this.richTextBoxGetShops.Name = "richTextBoxGetShops";
            this.richTextBoxGetShops.Size = new System.Drawing.Size(500, 273);
            this.richTextBoxGetShops.TabIndex = 12;
            this.richTextBoxGetShops.Text = "";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCity.Location = new System.Drawing.Point(295, 62);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(237, 27);
            this.textBoxCity.TabIndex = 15;
            // 
            // FormGetShops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(756, 453);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.labelGetShops);
            this.Controls.Add(this.richTextBoxGetShops);
            this.Name = "FormGetShops";
            this.Text = "FormGetShops";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelGetShops;
        private System.Windows.Forms.RichTextBox richTextBoxGetShops;
        private System.Windows.Forms.TextBox textBoxCity;
    }
}