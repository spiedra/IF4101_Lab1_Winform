using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IF4101_Lab1_Winform.UserInterface
{
    public partial class MessageForm : Form
    {
        public MessageForm(string newContent)
        {
            InitializeComponent();
            this.changeTextBoxContent(newContent);
        }

        private void changeTextBoxContent(string newContent)
        {
            this.textBox1.Text = newContent;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
