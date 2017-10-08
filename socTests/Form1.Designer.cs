namespace socTests
{
    partial class Form1
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
            this.test1Radio = new System.Windows.Forms.RadioButton();
            this.labelTest = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переглянутиОстанніРезультатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вийтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.допомогаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.якКористуватисьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.розшифровкаРезультатівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.інформаціяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контактнаІнформаціяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test2Radio = new System.Windows.Forms.RadioButton();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // test1Radio
            // 
            this.test1Radio.AutoSize = true;
            this.test1Radio.Checked = true;
            this.test1Radio.Font = new System.Drawing.Font("Gabriola", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.test1Radio.Location = new System.Drawing.Point(450, 160);
            this.test1Radio.Margin = new System.Windows.Forms.Padding(2);
            this.test1Radio.Name = "test1Radio";
            this.test1Radio.Size = new System.Drawing.Size(125, 54);
            this.test1Radio.TabIndex = 10;
            this.test1Radio.TabStop = true;
            this.test1Radio.Text = "Соціоніка";
            this.test1Radio.UseVisualStyleBackColor = true;
            this.test1Radio.Visible = false;
            this.test1Radio.CheckedChanged += new System.EventHandler(this.test1Radio_CheckedChanged);
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Font = new System.Drawing.Font("Gabriola", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTest.Location = new System.Drawing.Point(228, 160);
            this.labelTest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(210, 50);
            this.labelTest.TabIndex = 7;
            this.labelTest.Text = "Оберіть тестування:";
            this.labelTest.Visible = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Gabriola", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(99, 58);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(146, 55);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Введіть ПІБ:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(311, 63);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(418, 48);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Silver;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Gabriola", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startButton.Location = new System.Drawing.Point(278, 292);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(267, 74);
            this.startButton.TabIndex = 11;
            this.startButton.Text = "Розпочати тестування";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.White;
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.допомогаToolStripMenuItem,
            this.інформаціяToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(815, 24);
            this.mainMenu.TabIndex = 12;
            this.mainMenu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переглянутиОстанніРезультатиToolStripMenuItem,
            this.вийтиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // переглянутиОстанніРезультатиToolStripMenuItem
            // 
            this.переглянутиОстанніРезультатиToolStripMenuItem.Name = "переглянутиОстанніРезультатиToolStripMenuItem";
            this.переглянутиОстанніРезультатиToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.переглянутиОстанніРезультатиToolStripMenuItem.Text = "Переглянути останні результати";
            this.переглянутиОстанніРезультатиToolStripMenuItem.Click += new System.EventHandler(this.переглянутиОстанніРезультатиToolStripMenuItem_Click);
            // 
            // вийтиToolStripMenuItem
            // 
            this.вийтиToolStripMenuItem.Name = "вийтиToolStripMenuItem";
            this.вийтиToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.вийтиToolStripMenuItem.Text = "Вийти";
            this.вийтиToolStripMenuItem.Click += new System.EventHandler(this.вийтиToolStripMenuItem_Click);
            // 
            // допомогаToolStripMenuItem
            // 
            this.допомогаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.якКористуватисьToolStripMenuItem,
            this.розшифровкаРезультатівToolStripMenuItem});
            this.допомогаToolStripMenuItem.Name = "допомогаToolStripMenuItem";
            this.допомогаToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.допомогаToolStripMenuItem.Text = "Допомога";
            // 
            // якКористуватисьToolStripMenuItem
            // 
            this.якКористуватисьToolStripMenuItem.Name = "якКористуватисьToolStripMenuItem";
            this.якКористуватисьToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.якКористуватисьToolStripMenuItem.Text = "Як користуватись";
            this.якКористуватисьToolStripMenuItem.Click += new System.EventHandler(this.якКористуватисьToolStripMenuItem_Click);
            // 
            // розшифровкаРезультатівToolStripMenuItem
            // 
            this.розшифровкаРезультатівToolStripMenuItem.Name = "розшифровкаРезультатівToolStripMenuItem";
            this.розшифровкаРезультатівToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.розшифровкаРезультатівToolStripMenuItem.Text = "Розшифровка результатів";
            this.розшифровкаРезультатівToolStripMenuItem.Click += new System.EventHandler(this.розшифровкаРезультатівToolStripMenuItem_Click);
            // 
            // інформаціяToolStripMenuItem
            // 
            this.інформаціяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проПрограмуToolStripMenuItem,
            this.контактнаІнформаціяToolStripMenuItem});
            this.інформаціяToolStripMenuItem.Name = "інформаціяToolStripMenuItem";
            this.інформаціяToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.інформаціяToolStripMenuItem.Text = "Інформація";
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // контактнаІнформаціяToolStripMenuItem
            // 
            this.контактнаІнформаціяToolStripMenuItem.Name = "контактнаІнформаціяToolStripMenuItem";
            this.контактнаІнформаціяToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.контактнаІнформаціяToolStripMenuItem.Text = "Контакти";
            this.контактнаІнформаціяToolStripMenuItem.Click += new System.EventHandler(this.контактнаІнформаціяToolStripMenuItem_Click);
            // 
            // test2Radio
            // 
            this.test2Radio.AutoSize = true;
            this.test2Radio.Cursor = System.Windows.Forms.Cursors.Default;
            this.test2Radio.Font = new System.Drawing.Font("Gabriola", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.test2Radio.Location = new System.Drawing.Point(450, 207);
            this.test2Radio.Margin = new System.Windows.Forms.Padding(2);
            this.test2Radio.Name = "test2Radio";
            this.test2Radio.Size = new System.Drawing.Size(141, 54);
            this.test2Radio.TabIndex = 10;
            this.test2Radio.Text = "Психософія";
            this.test2Radio.UseVisualStyleBackColor = true;
            this.test2Radio.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(815, 423);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.test2Radio);
            this.Controls.Add(this.test1Radio);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.nameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Психологічні тести";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton test1Radio;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вийтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem допомогаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem якКористуватисьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem інформаціяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переглянутиОстанніРезультатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контактнаІнформаціяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem розшифровкаРезультатівToolStripMenuItem;
        private System.Windows.Forms.RadioButton test2Radio;
    }
}

