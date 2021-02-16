using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MicroprocessorSimulator
{
    public partial class KeyReader : Form
    {
        public int keyValue;

        public KeyReader()
        {
            InitializeComponent();
            InitializeText();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            keyValue = e.KeyValue;
            this.Close();
        }

        private void InitializeText()
        {
            string text = "Push down the keyboard to read it, its value will be saved in ASCII code in the AL register.";
            label1.Text = text;
        }
    }
}
