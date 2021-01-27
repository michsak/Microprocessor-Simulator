using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


//DESTINATION IS PLACE WHICH IS ALWAYS THE DESTINATION OF COMMAND

//TODO
//save to file, read from file, frontend, start registers value not always zero
//max number of commands

namespace MicroprocessorSimulator
{
    public partial class Form1 : Form
    {
        private List<TextBox> textBoxes = new List<TextBox>();
        private int currentAddressingType;
        private int currentInstructionType;
        private int currentDestinationType;
        private int currentSourceType;
        private int currentCommandsExecutingType;
        private Int16[] registers = { 0, 0, 0, 0 };
        private int commandNumber = 0;
        private int currentExecutingCommand = 0;

        private readonly Color backExecutedCommandsColor = Color.LightSlateGray;
        private readonly Color backCommandBoxColor = Color.Cornsilk;

        private Dictionary<int, string> addresingTypeDic = new Dictionary<int, string>();
        private Dictionary<int, string> instructionTypeDic = new Dictionary<int, string>();
        private Dictionary<int, string> destinationTypeDic = new Dictionary<int, string>();
        private Dictionary<int, string> sourceTypeDic = new Dictionary<int, string>();
        private List<int[]> registersCommands = new List<int[]>();


        public Form1()
        {
            InitializeComponent();
            InitializeTextBoxList();
            FillRegistersWithZeros();
            InitializeRegisterTypeDict();
            InitializeInstructionTypeDict();
            InitializeSourceDict();
            InitializeDestinationDict();
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

        private void InitializeRegisterTypeDict()
        {
            addresingTypeDic.Add(0, Enum.GetName(typeof(AdressingTypes), AdressingTypes.REG));
            addresingTypeDic.Add(1, Enum.GetName(typeof(AdressingTypes), AdressingTypes.IMM));
        }

        private void InitializeInstructionTypeDict()
        {
            instructionTypeDic.Add(0, Enum.GetName(typeof(InstructionTypes), InstructionTypes.ADD));
            instructionTypeDic.Add(1, Enum.GetName(typeof(InstructionTypes), InstructionTypes.SUB));
            instructionTypeDic.Add(2, Enum.GetName(typeof(InstructionTypes), InstructionTypes.MOV));
        }

        private void InitializeSourceDict()
        {
            sourceTypeDic.Add(0, Enum.GetName(typeof(Registers), Registers.AX));
            sourceTypeDic.Add(1, Enum.GetName(typeof(Registers), Registers.BX));
            sourceTypeDic.Add(2, Enum.GetName(typeof(Registers), Registers.CX));
            sourceTypeDic.Add(3, Enum.GetName(typeof(Registers), Registers.DX));
        }

        private void InitializeDestinationDict()
        {
            destinationTypeDic.Add(0, Enum.GetName(typeof(Registers), Registers.AX));
            destinationTypeDic.Add(1, Enum.GetName(typeof(Registers), Registers.BX));
            destinationTypeDic.Add(2, Enum.GetName(typeof(Registers), Registers.CX));
            destinationTypeDic.Add(3, Enum.GetName(typeof(Registers), Registers.DX));
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
            hTextBox.Text = stringBytes.Substring(0, stringBytes.Length/2);
            lTextBox.Text = stringBytes.Substring(stringBytes.Length/2, stringBytes.Length/2);
        }

        private void FillRegistersWithZeros()
        {
            for (int i=0; i<registers.Length; i++)
            {
                registers[i] = 0;
            }

            foreach (TextBox textBox in textBoxes)
            {
                textBox.Text = CheckIfOctet(0b_00000000);
            }
        }

        private void ChooseAdressingTypeViaRadioButton(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            currentAddressingType = int.Parse(radioButton.Tag.ToString());
            if (currentAddressingType == 1)
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

        private void ChooseInstructionTypeViaRadioButton(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            currentInstructionType = int.Parse(radioButton.Tag.ToString());
        }

        private void ChooseDestinationRegisterViaRadioButton(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            currentDestinationType = int.Parse(radioButton.Tag.ToString());
        }

        private void ChooseSourceRegisterViaRadioButton(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            currentSourceType = int.Parse(radioButton.Tag.ToString());
        }

        private void ChooseCommandsExecutingTypeViaRadioButton(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            currentCommandsExecutingType = int.Parse(radioButton.Tag.ToString());
        }

        private void ExecuteAction(object sender, EventArgs e)
        {
            if (currentCommandsExecutingType == (int)CommandExecutingType.TOTAL)
            {
                for (int i = 0; i < registersCommands.Count; i++)
                {
                    ExecuteCurrentCommand(i);
                }

                currentExecutingCommand = 0;
                System.Threading.Thread.Sleep(300);     //sleep for 300ms to enable user see performed action
                ChangeAllTextBacgroundColor(backCommandBoxColor);
            }

            else if(currentExecutingCommand < commandNumber && currentCommandsExecutingType == (int)CommandExecutingType.STEP_BY_STEP)
            {
                ExecuteCurrentCommand(currentExecutingCommand);
                ChangeCommandsColor(currentExecutingCommand, backExecutedCommandsColor);
                currentExecutingCommand++;

                if (currentExecutingCommand >= commandNumber)
                {
                    currentExecutingCommand = 0;
                    System.Threading.Thread.Sleep(300); //sleep for 300ms to enable user see performed action
                    ChangeRichTextBoxBackColor();
                }
            }
        }

        private void ChangeRichTextBoxBackColor()
        {
            for (int i = 0; i < registersCommands.Count; i++)
            {
                ChangeCommandsColor(i, backCommandBoxColor);
            }
        }

        private void ExecuteCurrentCommand(int i)
        {
            Int16 registerValue = (Int16)registersCommands[i][3];

            switch (registersCommands[i][1])
            {
                case 0:
                    registers[registersCommands[i][2]] += registerValue;
                    break;
                case 1:
                    registers[registersCommands[i][2]] -= registerValue;
                    break;
                case 2:
                    registers[registersCommands[i][2]] = registerValue;
                    break;
            }

            string stringBytes = ConvertToBites(registers[registersCommands[i][2]]);
            DivideInt16NumberAndWriteToRegister(stringBytes, textBoxes[2 * registersCommands[i][2]], textBoxes[2 * registersCommands[i][2] + 1]);
        }

        private void ChangeCommandsColor(int i, Color color)
        {
            commandsRichTextBox.SelectionStart = commandsRichTextBox.GetFirstCharIndexFromLine(i);
            commandsRichTextBox.SelectionLength = commandsRichTextBox.Lines[i].Length;
            commandsRichTextBox.SelectionBackColor = color;
        }

        private void ChangeAllTextBacgroundColor (Color color)
        {
            commandsRichTextBox.SelectionStart = commandsRichTextBox.GetFirstCharIndexFromLine(0);
            commandsRichTextBox.SelectionLength = commandsRichTextBox.TextLength;
            commandsRichTextBox.SelectionBackColor = color;
        }

        private void LoadActionsIntoMemory(object sender, EventArgs e)
        {
            string command = "";
            int value = currentAddressingType == (int)AdressingTypes.REG ? registers[currentSourceType] : (Int16)numericBox.Value;   //THERE WAS A MISTAKE --> sourcetype was always zero
            string sourceTypeTextBox = currentAddressingType == (int)AdressingTypes.IMM ? "" : $"{sourceTypeDic[currentSourceType]} ";

            registersCommands.Add(new int[4] { currentAddressingType, currentInstructionType, currentDestinationType, value });
            command = $"{commandNumber}. {addresingTypeDic[currentAddressingType]} {instructionTypeDic[currentInstructionType]} {sourceTypeTextBox}"+
                $"{destinationTypeDic[currentDestinationType]} {numericBox.Value};";

            command = commandNumber == 0 ? command : (" " + command);

            commandsRichTextBox.AppendText(command);
            commandsRichTextBox.AppendText(Environment.NewLine);
            commandNumber++;
        }

        private void ClearCommands(object sender, EventArgs e)
        {
            commandsRichTextBox.Clear();
            commandNumber = 0;
            registersCommands.Clear();
            currentExecutingCommand = 0;
        }
    }
}
