namespace socTests
{
    partial class HelpWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpWindow));
            this.labelTest = new System.Windows.Forms.Label();
            this.gotItButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTest
            // 
            this.labelTest.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTest.Location = new System.Drawing.Point(12, -20);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(649, 407);
            this.labelTest.TabIndex = 8;
            this.labelTest.Text = resources.GetString("labelTest.Text");
            this.labelTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gotItButton
            // 
            this.gotItButton.BackColor = System.Drawing.Color.Silver;
            this.gotItButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.gotItButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.gotItButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gotItButton.Font = new System.Drawing.Font("Gabriola", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gotItButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gotItButton.Location = new System.Drawing.Point(193, 365);
            this.gotItButton.Name = "gotItButton";
            this.gotItButton.Size = new System.Drawing.Size(286, 69);
            this.gotItButton.TabIndex = 12;
            this.gotItButton.Text = "Зрозуміло";
            this.gotItButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gotItButton.UseVisualStyleBackColor = false;
            this.gotItButton.Click += new System.EventHandler(this.gotItButton_Click);
            // 
            // HelpWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 457);
            this.Controls.Add(this.gotItButton);
            this.Controls.Add(this.labelTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Як користуватись";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.Button gotItButton;
    }
}