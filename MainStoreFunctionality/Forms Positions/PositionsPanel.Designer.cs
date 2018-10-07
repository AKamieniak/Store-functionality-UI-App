namespace MainStoreFunctionality.Forms_Positions
{
    partial class PositionsPanel
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
            this.btnDeletePosition = new System.Windows.Forms.Button();
            this.btnAddPosition = new System.Windows.Forms.Button();
            this.btnGetPositions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeletePosition
            // 
            this.btnDeletePosition.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeletePosition.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeletePosition.Location = new System.Drawing.Point(210, 309);
            this.btnDeletePosition.Name = "btnDeletePosition";
            this.btnDeletePosition.Size = new System.Drawing.Size(330, 116);
            this.btnDeletePosition.TabIndex = 8;
            this.btnDeletePosition.Text = "Delete Position";
            this.btnDeletePosition.UseVisualStyleBackColor = false;
            this.btnDeletePosition.Click += new System.EventHandler(this.btnDeletePosition_Click);
            // 
            // btnAddPosition
            // 
            this.btnAddPosition.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddPosition.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddPosition.Location = new System.Drawing.Point(210, 173);
            this.btnAddPosition.Name = "btnAddPosition";
            this.btnAddPosition.Size = new System.Drawing.Size(330, 113);
            this.btnAddPosition.TabIndex = 7;
            this.btnAddPosition.Text = "Add Position";
            this.btnAddPosition.UseVisualStyleBackColor = false;
            this.btnAddPosition.Click += new System.EventHandler(this.btnAddPosition_Click);
            // 
            // btnGetPositions
            // 
            this.btnGetPositions.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetPositions.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGetPositions.Location = new System.Drawing.Point(210, 41);
            this.btnGetPositions.Name = "btnGetPositions";
            this.btnGetPositions.Size = new System.Drawing.Size(330, 111);
            this.btnGetPositions.TabIndex = 6;
            this.btnGetPositions.Text = "Get Positions";
            this.btnGetPositions.UseVisualStyleBackColor = false;
            this.btnGetPositions.Click += new System.EventHandler(this.btnGetPositions_Click);
            // 
            // PositionsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(751, 467);
            this.Controls.Add(this.btnDeletePosition);
            this.Controls.Add(this.btnAddPosition);
            this.Controls.Add(this.btnGetPositions);
            this.Name = "PositionsPanel";
            this.Text = "PositionsPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeletePosition;
        private System.Windows.Forms.Button btnAddPosition;
        private System.Windows.Forms.Button btnGetPositions;
    }
}