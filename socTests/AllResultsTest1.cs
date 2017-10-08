using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace socTests
{
    public partial class AllResultsTest1 : Form
    {
        public AllResultsTest1()
        {
            InitializeComponent();
        }

        public void FileLoad(string fileName, DataGridView grid)
        {
            using (var reader = new StreamReader(fileName))
                while (!reader.EndOfStream)
                {
                    var words = reader.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    if (grid.ColumnCount < words.Length)
                        grid.ColumnCount = words.Length;
                    
                    grid.Rows.Add(words);
                }

            grid.Columns[0].Width = 110;
            grid.Columns[1].Width = 110;
            grid.Columns[2].Width = 110;
            grid.Columns[3].Width = 80;
            grid.Columns[4].Width = 90;
            grid.Columns[5].Width = 80;
        }

        private void AllResultsTest1_Load(object sender, EventArgs e)
        {
            string fileName1 = @"Data\Results.txt";
            string fileName2 = @"Data\ResultsPsyho.txt";

            FileLoad(fileName1, resGrid);
            FileLoad(fileName2, psyhogrid);
        }
    }
}
