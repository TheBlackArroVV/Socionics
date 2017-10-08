using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace socTests
{
    public partial class Form1 : Form
    {
        public static string userName = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            labelTest.Visible = true;
            test1Radio.Visible = true;
            test2Radio.Visible = true;
        }

        public bool checkName(string name)
        {
            int splitCount = 0;

            for (int i = 0; i < name.Length; i++)
                if (name[i] == ' ')
                    splitCount++;

            if (splitCount == 2)
                return true;
            else
                return false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Test1 test1 = new Test1();
            Test2 test2 = new Test2();
            userName = nameTextBox.Text;

            if (test1Radio.Checked && checkName(nameTextBox.Text))
                {
                    test1.Show();
                this.Hide();
            }
            else
            if (test2Radio.Checked && checkName(nameTextBox.Text))
            {
                test2.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Дані заповнено некоректно!", "Помилка!");
        }

        private void вийтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ExitCode = 0;
            Environment.Exit(ExitCode);
        }

        private void контактнаІнформаціяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("    Програма соціального тестування\n\nAuthor`s:  \n\n Vasyl Kuzmik\n    e-mail:  theblackarrovv@gmail.com\n Yevhen Kykyna\n    e-mail:   jecka0198@gmail.com", "Контакти");
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void якКористуватисьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();
            helpWindow.ShowDialog();
        }

        private void розшифровкаРезультатівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SocionicTranscription socionicTrans = new SocionicTranscription();
            socionicTrans.ShowDialog();
        }

        private void переглянутиОстанніРезультатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllResultsTest1 allRes = new AllResultsTest1();
            allRes.ShowDialog();
        }

        private void test1Radio_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
