using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IF4101_Lab1_Winform
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CalculatorForm calculatorWindow = new CalculatorForm();
            calculatorWindow.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ManagerForm managerWindow = new ManagerForm();
            managerWindow.Show();
        }
    }
}
