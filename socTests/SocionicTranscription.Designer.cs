namespace socTests
{
    partial class SocionicTranscription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SocionicTranscription));
            this.transcriptionSocionic = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // transcriptionSocionic
            // 
            this.transcriptionSocionic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transcriptionSocionic.Font = new System.Drawing.Font("Gabriola", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transcriptionSocionic.Location = new System.Drawing.Point(12, 12);
            this.transcriptionSocionic.Name = "transcriptionSocionic";
            this.transcriptionSocionic.Size = new System.Drawing.Size(772, 494);
            this.transcriptionSocionic.TabIndex = 10;
            this.transcriptionSocionic.Text = resources.GetString("transcriptionSocionic.Text");
            // 
            // SocionicTranscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 518);
            this.Controls.Add(this.transcriptionSocionic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SocionicTranscription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Розшифровка результатів";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox transcriptionSocionic;
    }
}