using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroprocessorSimulator
{
    public partial class ErrorForm : Form
    {
        public ErrorForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle; //restrict from resizing
            MaximizeBox = false;  //disable maximize button
            InitializeErrorMessage();
        }

        private void InitializeErrorMessage()
        {
            string errorMessage = "Uzytkowniku, wybierz poprawny format pliku!";
            errorLabel.Text = errorMessage;
        }
    }
}
