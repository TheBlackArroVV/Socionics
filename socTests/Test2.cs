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
    public partial class Test2 : Form
    {
        public static int i = 1;
        public static int logic = 0;
        public static int emotion = 0;
        public static int physics = 0;
        public static int will = 0;
        public Test2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Test2_Load(object sender, EventArgs e)
        {
          i = 1;
          label1.Text = "Ви вважаєте себе вдумливою людиною?";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (i <= 10)
            {
                if (yesButton.Checked) logic += 3;
                else if (mbButton.Checked) logic += 2;
                else if (stButton.Checked) logic += 1;
            }
            else if (i > 10 && i <= 20)
            {
                if (yesButton.Checked) emotion += 3;
                else if (mbButton.Checked) emotion += 2;
                else if (stButton.Checked) emotion += 1;
            }
            else if (i > 20 && i <= 30)
            {
                if (yesButton.Checked) physics += 3;
                else if (mbButton.Checked) physics += 2;
                else if (stButton.Checked) physics += 1;
            }
            else
            {
                if (yesButton.Checked) will += 3;
                else if (mbButton.Checked) will += 2;
                else if (stButton.Checked) will += 1;
            }
            i++;
            if (i == 40)
            {
                okButton.Visible = false;
                resultButton.Visible = true;
            }
            //if (i == 1) label1.Text = "Ви вважаєте себе вдумливою людиною?";
            if (i == 2) label1.Text = "Ви довіряєте своєму розуму?";
            if (i == 3) label1.Text = "Вас дратує дурість?";
            if (i == 4) label1.Text = "Ви з довірою ставитеся до логіки?";
            if (i == 5) label1.Text = "Ви самостійні в своєму мисленні?";
            if (i == 6) label1.Text = "Ви підкоряєте своє життя своїм поглядам?";
            if (i == 7) label1.Text = "Вам цікава наукова інформація?";
            if (i == 8) label1.Text = "Чи радують Вас прояви сильної думки?";
            if (i == 9) label1.Text = "Ви впевнено почуваєте себе під час дискусій?";
            if (i == 10) label1.Text = "Ви вірите в строгість своїх логічних побудов?";
            if (i == 11) label1.Text = "Ви вважаєте себе емоційною людиною?";
            if (i == 12) label1.Text = "Ви любите театр?";
            if (i == 13) label1.Text = "Ви легко закохуєтесь?";
            if (i == 14) label1.Text = "Чи різко змінюється Ваш настрій?";
            if (i == 15) label1.Text = "Ви забобонні?";
            if (i == 16) label1.Text = "Почуття владні над Вами?";
            if (i == 17) label1.Text = "Чи схильні Ви до акторства?";
            if (i == 18) label1.Text = "Вам притаманна реакція сльозами на те, що відбувається?";
            if (i == 19) label1.Text = "Ви довіряєте астрології?";
            if (i == 20) label1.Text = "Чи є у Вас тяга до мистецтва?";
            if (i == 21) label1.Text = "Ви вважаєте себе фізично міцною людиною?";
            if (i == 22) label1.Text = "Ви скупі?";
            if (i == 23) label1.Text = "Тяга до фізичних навантажень властива Вам?";
            if (i == 24) label1.Text = "Ви схильні до насильства?";
            if (i == 25) label1.Text = "Спорт займає у Вашому житті значне місце?";
            if (i == 26) label1.Text = "Чи серйозно Ви ставитеся до грошей?";
            if (i == 27) label1.Text = "Ви владні?";
            if (i == 28) label1.Text = "Чи можна Вас назвати гурманом?";
            if (i == 29) label1.Text = "Вас турбує Ваше здоров'я?";
            if (i == 30) label1.Text = "Ви сексуальні?";
            if (i == 31) label1.Text = "Ви вважаєте себе вольовою людиною?";
            if (i == 32) label1.Text = "Вам легко керувати людьми?";
            if (i == 33) label1.Text = "Ви людина незалежна?";
            if (i == 34) label1.Text = "Ви рішучі?";
            if (i == 35) label1.Text = "Ви завжди контролюєте свою поведінку?";
            if (i == 36) label1.Text = "Чи вважаєте Ви себе наполегливою людиною?";
            if (i == 37) label1.Text = "Вам завжди вдається виконувати прийняті рішення?";
            if (i == 38) label1.Text = "Ви відповідальна людина?";
            if (i == 39) label1.Text = "Ви цікаві?";
            if (i == 40) label1.Text = "Ви впевнені в своєму праві вести за собою людей?";
            
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(logic.ToString() + emotion.ToString() + physics.ToString() + will.ToString());
            ResPsyho ResPsyho = new ResPsyho();
            ResPsyho.Show();
            this.Hide();
        }
    }
}
