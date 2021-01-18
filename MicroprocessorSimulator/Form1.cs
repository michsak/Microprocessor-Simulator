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
    public partial class Form1 : Form
    {
        private List<TextBox> textBoxes = new List<TextBox>();
        private int adressingType = 0;  //0 - register; 1- immediate
        private int instructionType;   //0 - ADD, 1 - SUB, 2 - MOV
        private int destinationType;     //0 - AX, 1 - BX, 2 - CX, 3 - DX
        private int sourceType;
        private Int16[] registers = { 0, 0, 0, 0 };

        public Form1()
        { 
            InitializeComponent();
            InitializeTextBoxList();
            FillRegistersWithZeros();
        }

        private void CleanRegistersButton_Click(object sender, EventArgs e)
        {
            FillRegistersWithZeros();
        }

        private string CheckIfOctet(int number)
        {
            string uintString = Convert.ToString(number, toBase: 2);
            string convertedString = uintString;


            if (uintString.Length < 8)
            {
                for (int i=0; i<(8-uintString.Length); i++)
                {
                    convertedString = "0" + convertedString;
                }
            }

            return convertedString;
        }

        private string ConvertToBites(Int16 number)
        {
            string finalRegisterValue = "";

            finalRegisterValue = (number >= 0) ? "0" : "1";

            string intString = Convert.ToString(Math.Abs(number), toBase: 2);
            string convertedString = intString;


            if (intString.Length < 15)
            {
                for (int i = 0; i < (15 - intString.Length); i++)
                {
                    convertedString = "0" + convertedString;
                }
            }

            return finalRegisterValue + convertedString;
        }

        private void DivideInt16NumberAndWriteToRegister(string stringBytes, TextBox hTextBox, TextBox lTextBox)
        {
            hTextBox.Text = stringBytes.Substring(0, 8);
            lTextBox.Text = stringBytes.Substring(8, 8);
        }


        private void FillRegistersWithZeros()
        {
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Text = CheckIfOctet(0b_00000000);
            }
        }

        private void InitializeTextBoxList()
        {
            textBoxes.Add(textBox1);
            textBoxes.Add(textBox2);
            textBoxes.Add(textBox3);
            textBoxes.Add(textBox4);
            textBoxes.Add(textBox5);
            textBoxes.Add(textBox6);
            textBoxes.Add(textBox7);
            textBoxes.Add(textBox8);
        }

        private void AdressingType(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            adressingType = int.Parse(radioButton.Tag.ToString());
            if (adressingType == 1)
            {
                groupBox1.Enabled = false;
                numericBox.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = true;
                numericBox.Enabled = false;
            }
        }

        private void ChangeInitialValue(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            instructionType = int.Parse(radioButton.Tag.ToString());
        }

        private void CheckDestinationRegister(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            destinationType = int.Parse(radioButton.Tag.ToString());
        }

        private void CheckSourceRegister(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            sourceType = int.Parse(radioButton.Tag.ToString());
        }

        private void StartActionButton_Click(object sender, EventArgs e)
        {
            Int16 registerValue = (adressingType == 0) ? registers[sourceType] : (Int16)numericBox.Value;

            switch (instructionType)
            {
                case 0:
                    registers[destinationType] += registerValue;
                    break;
                case 1:
                    registers[destinationType] -= registerValue;
                    break;
                case 2:
                    registers[destinationType] = registerValue;
                    break;

            }
            string stringBytes = ConvertToBites(registers[destinationType]);
            DivideInt16NumberAndWriteToRegister(stringBytes, textBoxes[2*destinationType], textBoxes[2*destinationType+1]);
        }
    }
}
