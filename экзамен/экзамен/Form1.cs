using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace экзамен
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            openFileDialog1.Filter = "CSV Files(*.csv)|*.csv|All files(*.*)|*.*";
            saveFileDialog1.Filter = "CSV Files(*.csv)|*.csv|All files(*.*)|*.*";
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(filename, tbText.Text);
            tbText.Text = " ";
            MessageBox.Show("Файл сохранен");
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            tbText.Text = fileText;
            MessageBox.Show("Файл открыт");
        }

        private void tbText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
