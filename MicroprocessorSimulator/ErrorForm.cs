using System;
using System.Text;
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
            string errorMessage = "Please choose the proper format file!";
            errorLabel.Text = errorMessage;
        }
    }
}
