namespace socTests
{
    partial class ShowDual
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
            this.typePicture = new System.Windows.Forms.PictureBox();
            this.resultInfo = new System.Windows.Forms.Label();
            this.resCloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.typePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // typePicture
            // 
            this.typePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.typePicture.Location = new System.Drawing.Point(12, 12);
            this.typePicture.Name = "typePicture";
            this.typePicture.Size = new System.Drawing.Size(305, 485);
            this.typePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.typePicture.TabIndex = 4;
            this.typePicture.TabStop = false;
            // 
            // resultInfo
            // 
            this.resultInfo.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultInfo.ForeColor = System.Drawing.Color.Black;
            this.resultInfo.Location = new System.Drawing.Point(331, 34);
            this.resultInfo.Name = "resultInfo";
            this.resultInfo.Size = new System.Drawing.Size(319, 380);
            this.resultInfo.TabIndex = 5;
            this.resultInfo.Text = "resultInfo";
            this.resultInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // resCloseButton
            // 
            this.resCloseButton.BackColor = System.Drawing.Color.Gainsboro;
            this.resCloseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.resCloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.resCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resCloseButton.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resCloseButton.Location = new System.Drawing.Point(398, 441);
            this.resCloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.resCloseButton.Name = "resCloseButton";
            this.resCloseButton.Size = new System.Drawing.Size(156, 56);
            this.resCloseButton.TabIndex = 6;
            this.resCloseButton.Text = "Завершити";
            this.resCloseButton.UseVisualStyleBackColor = false;
            this.resCloseButton.Click += new System.EventHandler(this.resCloseButton_Click);
            // 
            // ShowDual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 503);
            this.Controls.Add(this.resCloseButton);
            this.Controls.Add(this.resultInfo);
            this.Controls.Add(this.typePicture);
            this.Name = "ShowDual";
            this.Text = "ShowDual";
            this.Load += new System.EventHandler(this.ShowDual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.typePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox typePicture;
        private System.Windows.Forms.Label resultInfo;
        private System.Windows.Forms.Button resCloseButton;
    }
}