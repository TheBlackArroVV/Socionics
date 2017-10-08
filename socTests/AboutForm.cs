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
    public partial class AboutForm : Form
    {
        Bitmap MyImage;
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            MyImage = (Bitmap)Image.FromFile(@"Data\harmony.png", true);
            pictureBox1.Image = (Image)MyImage;
        }
    }
}
