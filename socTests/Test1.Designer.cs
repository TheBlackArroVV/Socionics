namespace socTests
{
    partial class Test1
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
            this.ans1Radio = new System.Windows.Forms.RadioButton();
            this.okButton = new System.Windows.Forms.Button();
            this.ans2Radio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ans1Radio
            // 
            this.ans1Radio.AutoSize = true;
            this.ans1Radio.Checked = true;
            this.ans1Radio.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ans1Radio.Location = new System.Drawing.Point(40, 158);
            this.ans1Radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ans1Radio.Name = "ans1Radio";
            this.ans1Radio.Size = new System.Drawing.Size(122, 28);
            this.ans1Radio.TabIndex = 1;
            this.ans1Radio.TabStop = true;
            this.ans1Radio.Text = "answer #1";
            this.ans1Radio.UseVisualStyleBackColor = true;
            this.ans1Radio.CheckedChanged += new System.EventHandler(this.ans1Radio_CheckedChanged);
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.Silver;
            this.okButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.okButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Gabriola", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.ForeColor = System.Drawing.Color.Black;
            this.okButton.Location = new System.Drawing.Point(435, 381);
            this.okButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(236, 73);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Обрати";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ans2Radio
            // 
            this.ans2Radio.AutoSize = true;
            this.ans2Radio.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ans2Radio.Location = new System.Drawing.Point(640, 158);
            this.ans2Radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ans2Radio.Name = "ans2Radio";
            this.ans2Radio.Size = new System.Drawing.Size(122, 28);
            this.ans2Radio.TabIndex = 3;
            this.ans2Radio.Text = "answer #1";
            this.ans2Radio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 63);
            this.label1.TabIndex = 4;
            this.label1.Text = "Оберіть твердження, яке більше характеризує вас:";
            // 
            // Test1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1156, 533);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ans2Radio);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.ans1Radio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Test1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Соціоніка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Test1_FormClosing);
            this.Load += new System.EventHandler(this.Test1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton ans1Radio;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.RadioButton ans2Radio;
        private System.Windows.Forms.Label label1;
    }
}