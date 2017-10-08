namespace socTests
{
    partial class Test2
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
            this.noButton = new System.Windows.Forms.RadioButton();
            this.stButton = new System.Windows.Forms.RadioButton();
            this.mbButton = new System.Windows.Forms.RadioButton();
            this.yesButton = new System.Windows.Forms.RadioButton();
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // noButton
            // 
            this.noButton.AutoSize = true;
            this.noButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noButton.Location = new System.Drawing.Point(87, 144);
            this.noButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(53, 28);
            this.noButton.TabIndex = 0;
            this.noButton.TabStop = true;
            this.noButton.Text = "Ні";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // stButton
            // 
            this.stButton.AutoSize = true;
            this.stButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stButton.Location = new System.Drawing.Point(87, 201);
            this.stButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stButton.Name = "stButton";
            this.stButton.Size = new System.Drawing.Size(79, 28);
            this.stButton.TabIndex = 1;
            this.stButton.TabStop = true;
            this.stButton.Text = "Іноді";
            this.stButton.UseVisualStyleBackColor = true;
            // 
            // mbButton
            // 
            this.mbButton.AutoSize = true;
            this.mbButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mbButton.Location = new System.Drawing.Point(358, 144);
            this.mbButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mbButton.Name = "mbButton";
            this.mbButton.Size = new System.Drawing.Size(112, 28);
            this.mbButton.TabIndex = 2;
            this.mbButton.TabStop = true;
            this.mbButton.Text = "Напевно";
            this.mbButton.UseVisualStyleBackColor = true;
            this.mbButton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // yesButton
            // 
            this.yesButton.AutoSize = true;
            this.yesButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yesButton.Location = new System.Drawing.Point(358, 201);
            this.yesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(64, 28);
            this.yesButton.TabIndex = 3;
            this.yesButton.TabStop = true;
            this.yesButton.Text = "Так";
            this.yesButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.Silver;
            this.okButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.okButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Gabriola", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.ForeColor = System.Drawing.Color.Black;
            this.okButton.Location = new System.Drawing.Point(141, 281);
            this.okButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(236, 73);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "Обрати";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Gabriola", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 115);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // resultButton
            // 
            this.resultButton.BackColor = System.Drawing.Color.Silver;
            this.resultButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.resultButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.resultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultButton.Font = new System.Drawing.Font("Gabriola", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultButton.ForeColor = System.Drawing.Color.Black;
            this.resultButton.Location = new System.Drawing.Point(141, 281);
            this.resultButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(236, 73);
            this.resultButton.TabIndex = 6;
            this.resultButton.Text = "Результат";
            this.resultButton.UseVisualStyleBackColor = false;
            this.resultButton.Visible = false;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // Test2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(536, 370);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.mbButton);
            this.Controls.Add(this.stButton);
            this.Controls.Add(this.noButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Test2";
            this.Text = "Психософія";
            this.Load += new System.EventHandler(this.Test2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton noButton;
        private System.Windows.Forms.RadioButton stButton;
        private System.Windows.Forms.RadioButton mbButton;
        private System.Windows.Forms.RadioButton yesButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resultButton;
    }
}