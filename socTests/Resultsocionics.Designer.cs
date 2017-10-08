namespace socTests
{
    partial class Resultsocionics
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
            this.resultInfo = new System.Windows.Forms.Label();
            this.typePicture = new System.Windows.Forms.PictureBox();
            this.resCloseButton = new System.Windows.Forms.Button();
            this.dualButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.typePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // resultInfo
            // 
            this.resultInfo.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultInfo.ForeColor = System.Drawing.Color.Black;
            this.resultInfo.Location = new System.Drawing.Point(329, 50);
            this.resultInfo.Name = "resultInfo";
            this.resultInfo.Size = new System.Drawing.Size(319, 380);
            this.resultInfo.TabIndex = 1;
            this.resultInfo.Text = "resultInfo";
            this.resultInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resultInfo.Click += new System.EventHandler(this.resultInfo_Click);
            // 
            // typePicture
            // 
            this.typePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.typePicture.Location = new System.Drawing.Point(10, 28);
            this.typePicture.Name = "typePicture";
            this.typePicture.Size = new System.Drawing.Size(305, 485);
            this.typePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.typePicture.TabIndex = 0;
            this.typePicture.TabStop = false;
            this.typePicture.Click += new System.EventHandler(this.typePicture_Click);
            // 
            // resCloseButton
            // 
            this.resCloseButton.BackColor = System.Drawing.Color.Gainsboro;
            this.resCloseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.resCloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.resCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resCloseButton.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resCloseButton.Location = new System.Drawing.Point(320, 457);
            this.resCloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.resCloseButton.Name = "resCloseButton";
            this.resCloseButton.Size = new System.Drawing.Size(156, 56);
            this.resCloseButton.TabIndex = 2;
            this.resCloseButton.Text = "Завершити";
            this.resCloseButton.UseVisualStyleBackColor = false;
            this.resCloseButton.Click += new System.EventHandler(this.resCloseButton_Click);
            // 
            // dualButton
            // 
            this.dualButton.BackColor = System.Drawing.Color.Gainsboro;
            this.dualButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dualButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.dualButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dualButton.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dualButton.Location = new System.Drawing.Point(480, 457);
            this.dualButton.Margin = new System.Windows.Forms.Padding(2);
            this.dualButton.Name = "dualButton";
            this.dualButton.Size = new System.Drawing.Size(168, 56);
            this.dualButton.TabIndex = 3;
            this.dualButton.Text = "Показати дуала";
            this.dualButton.UseVisualStyleBackColor = false;
            this.dualButton.Click += new System.EventHandler(this.dualButton_Click);
            // 
            // Resultsocionics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(658, 548);
            this.Controls.Add(this.dualButton);
            this.Controls.Add(this.resCloseButton);
            this.Controls.Add(this.resultInfo);
            this.Controls.Add(this.typePicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Resultsocionics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результат тестування";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Resultsocionics_FormClosing);
            this.Load += new System.EventHandler(this.Resultsocionics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.typePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox typePicture;
        private System.Windows.Forms.Label resultInfo;
        private System.Windows.Forms.Button resCloseButton;
        private System.Windows.Forms.Button dualButton;
    }
}