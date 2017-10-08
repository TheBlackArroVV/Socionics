namespace socTests
{
    partial class ResPsyho
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
            this.resCloseButton = new System.Windows.Forms.Button();
            this.typePicture = new System.Windows.Forms.PictureBox();
            this.resultInfo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.typePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // resCloseButton
            // 
            this.resCloseButton.BackColor = System.Drawing.Color.Gainsboro;
            this.resCloseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.resCloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.resCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resCloseButton.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resCloseButton.Location = new System.Drawing.Point(579, 518);
            this.resCloseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resCloseButton.Name = "resCloseButton";
            this.resCloseButton.Size = new System.Drawing.Size(245, 69);
            this.resCloseButton.TabIndex = 5;
            this.resCloseButton.Text = "Завершити";
            this.resCloseButton.UseVisualStyleBackColor = false;
            this.resCloseButton.Click += new System.EventHandler(this.resCloseButton_Click);
            // 
            // typePicture
            // 
            this.typePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.typePicture.Location = new System.Drawing.Point(4, 1);
            this.typePicture.Margin = new System.Windows.Forms.Padding(4);
            this.typePicture.Name = "typePicture";
            this.typePicture.Size = new System.Drawing.Size(407, 597);
            this.typePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.typePicture.TabIndex = 3;
            this.typePicture.TabStop = false;
            // 
            // resultInfo
            // 
            this.resultInfo.BackColor = System.Drawing.Color.White;
            this.resultInfo.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultInfo.Location = new System.Drawing.Point(430, 23);
            this.resultInfo.Multiline = true;
            this.resultInfo.Name = "resultInfo";
            this.resultInfo.ReadOnly = true;
            this.resultInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultInfo.Size = new System.Drawing.Size(520, 481);
            this.resultInfo.TabIndex = 6;
            // 
            // ResPsyho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 608);
            this.Controls.Add(this.resultInfo);
            this.Controls.Add(this.resCloseButton);
            this.Controls.Add(this.typePicture);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ResPsyho";
            this.Text = "Результат тестування";
            this.Load += new System.EventHandler(this.ResPsyho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.typePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resCloseButton;
        private System.Windows.Forms.PictureBox typePicture;
        private System.Windows.Forms.TextBox resultInfo;
    }
}