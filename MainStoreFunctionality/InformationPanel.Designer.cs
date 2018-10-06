namespace MainStoreFunctionality
{
    partial class InformationPanel
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
            this.btnPositions = new System.Windows.Forms.Button();
            this.btnShops = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.linkLabelLogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnPositions
            // 
            this.btnPositions.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPositions.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPositions.Location = new System.Drawing.Point(194, 298);
            this.btnPositions.Name = "btnPositions";
            this.btnPositions.Size = new System.Drawing.Size(330, 114);
            this.btnPositions.TabIndex = 5;
            this.btnPositions.Text = "Positions";
            this.btnPositions.UseVisualStyleBackColor = false;
            this.btnPositions.Click += new System.EventHandler(this.btnPositions_Click);
            // 
            // btnShops
            // 
            this.btnShops.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShops.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShops.Location = new System.Drawing.Point(194, 161);
            this.btnShops.Name = "btnShops";
            this.btnShops.Size = new System.Drawing.Size(330, 113);
            this.btnShops.TabIndex = 4;
            this.btnShops.Text = "Shops";
            this.btnShops.UseVisualStyleBackColor = false;
            this.btnShops.Click += new System.EventHandler(this.btnShops_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.AllowDrop = true;
            this.btnEmployees.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEmployees.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEmployees.Location = new System.Drawing.Point(194, 29);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(330, 111);
            this.btnEmployees.TabIndex = 3;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // linkLabelLogin
            // 
            this.linkLabelLogin.AutoSize = true;
            this.linkLabelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLogin.Location = new System.Drawing.Point(695, 9);
            this.linkLabelLogin.Name = "linkLabelLogin";
            this.linkLabelLogin.Size = new System.Drawing.Size(44, 18);
            this.linkLabelLogin.TabIndex = 6;
            this.linkLabelLogin.TabStop = true;
            this.linkLabelLogin.Text = "Login";
            this.linkLabelLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogin_LinkClicked);
            // 
            // InformationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(751, 467);
            this.Controls.Add(this.linkLabelLogin);
            this.Controls.Add(this.btnPositions);
            this.Controls.Add(this.btnShops);
            this.Controls.Add(this.btnEmployees);
            this.Name = "InformationPanel";
            this.Text = "InformationPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPositions;
        private System.Windows.Forms.Button btnShops;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.LinkLabel linkLabelLogin;
    }
}