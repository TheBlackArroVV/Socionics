using System ;
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
    public partial class Test1 : Form
    {

        public int i;
        public static string result = "";
        public static string resnewform = "";

        public Test1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (i == 1 && ans1Radio.Checked == true)
            {
                ans1Radio.Text = "Абстракція, теорія, цікаві завдання, зрозуміти\n сенс того, що відбувається, поступатися в \nдрібницях, все життя в майбутньому";
                ans2Radio.Text = "Конкретна практика, корисні справи, \nзрозуміти розміщення сил, добитися свого,\n моє життя - сьогодні";
                i = 2;
            }
            else
            if (i == 2 && ans1Radio.Checked == true)
            {
                ans1Radio.Text = "Спрага до відкриттів, захоплення  людьми та \n починаннями";
                ans2Radio.Text = "Інтуїція, духовність, самопізнання, час та історія";
                i = 3;
            }
            else
            if (i == 3 && ans1Radio.Checked == true)
            {
                ans1Radio.Text = "Вдохновляючі ідеї, починання та теорії";
                ans2Radio.Text = "Цікаві, талановиті люди, спілкування";
                i = 4;
            }
            else
            if (i == 4 && ans1Radio.Checked == true)
            {
                result = "ILE";
            }
            else
            if (i == 4 && ans2Radio.Checked == true) result = "IEE";
            else
            if (i == 3 && ans2Radio.Checked == true)
            {
                ans1Radio.Text = "Скептичне передбачення, професіанолізм";
                ans2Radio.Text = "Емоційне передчуття, поетичність";
                i = 5;
            }
            else
            if (i == 5 && ans1Radio.Checked == true) result = "ILI";
            else
            if (i == 5 && ans2Radio.Checked == true) result = "IEI";
            else
            if (i == 2 && ans2Radio.Checked == true)
            {
                ans1Radio.Text = "Сила волі, переборення труднощів, сила і краса";
                ans2Radio.Text = "Відчуття моменту, інтереси близьки, естетика";
                i = 6;
            }
            else
            if (i == 6 && ans1Radio.Checked == true)
            {
                ans1Radio.Text = "Хто бажає, той отримає; Логіка боротьби";
                ans2Radio.Text = "Енергія, вплив на людей, на їх почуття";
                i = 7;
            }
            else
            if (i == 7 && ans1Radio.Checked == true) result = "SLE";
            else
            if (i == 7 && ans2Radio.Checked == true) result = "SEE";
            else
            if (i == 6 && ans2Radio.Checked == true)
            {
                ans1Radio.Text = "Умови життя, умілі руки, незалежність";
                ans2Radio.Text = "Відчуття, природа, тепле спілкування і емоції";
                i = 8;
            }
            else
            if (i == 8 && ans1Radio.Checked == true) result = "SLI";
            else
            if (i == 8 && ans2Radio.Checked == true) result = "SEI";
            else
            if (i == 1 && ans2Radio.Checked == true)
            {
                ans1Radio.Text = "Розум, холодний аналіз, логіка, об'єктивний \n підхід, тверезе мишлення, непредвзятість \n , стриманість";
                ans2Radio.Text = "Почуття, емоції, емпатія, симпатії і антипатії \n, небайдужість, сердечність";
                i = 9;
            }
            else
            if (i == 9 && ans1Radio.Checked == true)
            {
                ans1Radio.Text = "Правильні дії, логіка дій, моє право";
                ans2Radio.Text = "Спокійне мишлення, логіка відносин, моє місце";
                i = 10;
            }
            else 
            if (i == 9 && ans2Radio.Checked == true)
            {
                ans1Radio.Text = "Емоційна відкритість, пориви кохання і гніву";
                ans2Radio.Text = "Схований світ почуттів, добро і зло, \n прийняття і осудження";
                i = 11;
            }
            else
            if (i == 10 && ans1Radio.Checked == true)
            {
                ans1Radio.Text = "Я всьо зроблю швидко, ефективно і з користю";
                ans2Radio.Text = "Якість, надійність, добросовістність в \n виконанні справ";
                i = 12;
            }
            else
            if (i == 10 && ans2Radio.Checked == true)
            {
                ans1Radio.Text = "Рівність, справедливість, система знань";
                ans2Radio.Text = "Логіка системи, вольове впровадження";
                i = 13;
            }
            else
            if (i == 11 && ans1Radio.Checked == true)
            {
                ans1Radio.Text = "Драматизм, трагедія, співпереживання";
                ans2Radio.Text = "Радість, емоції, свято, хороший настрій";
                i = 14;
            }
            else
            if (i == 11 && ans2Radio.Checked == true)
            {
                ans1Radio.Text = "Віра, надія, кохання, відданість близьким";
                ans2Radio.Text = "Неприйняття зла, воля до моральної чистоти";
                i = 15;
            }
            else
            if (i == 12 && ans1Radio.Checked == true) result = "LIE";
            else
            if (i == 12 && ans2Radio.Checked == true) result = "LSE";
            else
            if (i == 13 && ans1Radio.Checked == true) result = "LII";
            else
            if (i == 13 && ans2Radio.Checked == true) result = "LSI";
            else
            if (i == 14 && ans1Radio.Checked == true) result = "EIE";
            else
            if (i == 14 && ans2Radio.Checked == true) result = "ESE";
            else
            if (i == 15 && ans1Radio.Checked == true) result = "EII";
            else
            if (i == 15 && ans2Radio.Checked == true) result = "ESI";
            //MessageBox.Show(result);
            if (result != "")
            {
                resnewform = result;
                result = "";
                Resultsocionics resultsocionics = new Resultsocionics();
                resultsocionics.Show();
                this.Hide();
            }  
         }

        private void Test1_Load(object sender, EventArgs e)
        {           
            ans1Radio.Text = "Імпровізація, свобода від обов'язків, дії по ситуації,\n мінлива воля, реальність, а не догмати, \n праця по натхненню,\n пристосування до мінливого світу";
            ans2Radio.Text = "Планування, системна робота, довести почате \n до кінця, зробити і полюбуватися результатом, \nзадоволення від завершення";
            i = 1;
        }

        private void ans1Radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Test1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
