namespace MainStoreFunctionality
{
    partial class ShopsPanel
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
            this.btnDeleteShop = new System.Windows.Forms.Button();
            this.btnAddShop = new System.Windows.Forms.Button();
            this.btnGetShops = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeleteShop
            // 
            this.btnDeleteShop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteShop.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteShop.Location = new System.Drawing.Point(208, 297);
            this.btnDeleteShop.Name = "btnDeleteShop";
            this.btnDeleteShop.Size = new System.Drawing.Size(330, 116);
            this.btnDeleteShop.TabIndex = 5;
            this.btnDeleteShop.Text = "Delete Shop";
            this.btnDeleteShop.UseVisualStyleBackColor = false;
            this.btnDeleteShop.Click += new System.EventHandler(this.btnDeleteShop_Click);
            // 
            // btnAddShop
            // 
            this.btnAddShop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddShop.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddShop.Location = new System.Drawing.Point(208, 161);
            this.btnAddShop.Name = "btnAddShop";
            this.btnAddShop.Size = new System.Drawing.Size(330, 113);
            this.btnAddShop.TabIndex = 4;
            this.btnAddShop.Text = "Add Shop";
            this.btnAddShop.UseVisualStyleBackColor = false;
            this.btnAddShop.Click += new System.EventHandler(this.btnAddShop_Click);
            // 
            // btnGetShops
            // 
            this.btnGetShops.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetShops.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGetShops.Location = new System.Drawing.Point(208, 29);
            this.btnGetShops.Name = "btnGetShops";
            this.btnGetShops.Size = new System.Drawing.Size(330, 111);
            this.btnGetShops.TabIndex = 3;
            this.btnGetShops.Text = "Get Shops";
            this.btnGetShops.UseVisualStyleBackColor = false;
            this.btnGetShops.Click += new System.EventHandler(this.btnGetShops_Click);
            // 
            // ShopsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(751, 467);
            this.Controls.Add(this.btnDeleteShop);
            this.Controls.Add(this.btnAddShop);
            this.Controls.Add(this.btnGetShops);
            this.Name = "ShopsPanel";
            this.Text = "ShopsPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteShop;
        private System.Windows.Forms.Button btnAddShop;
        private System.Windows.Forms.Button btnGetShops;
    }
}