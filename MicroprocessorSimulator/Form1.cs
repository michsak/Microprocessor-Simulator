using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


//TODO
//start registers value not always zero
//max number of commands
//add to registers as class
//frontend

namespace MicroprocessorSimulator
{
    public partial class Form1 : Form
    {
        //current choosen type and commands variables
        private int currentAddressingType;
        private int currentInstructionType;
        private int currentDestinationType;
        private int currentSourceType;
        private int currentCommandsExecutingType;
        private int currentExecutingCommand = 0;
        private int totalCommendsNumber = 0;

        //color variables
        private readonly Color backExecutedCommandsColor = Color.LightSlateGray;
        private readonly Color backCommandBoxColor = Color.Cornsilk;

        //registers and whole instruction content holders
        private Int16[] registers = { 0, 0, 0, 0 };
        private List<TextBox> textBoxes = new List<TextBox>();
        private Dictionary<int, string> addresingTypeDic = new Dictionary<int, string>();
        private Dictionary<int, string> instructionTypeDic = new Dictionary<int, string>();
        private Dictionary<int, string> sourceTypeDic = new Dictionary<int, string>();
        private Dictionary<int, string> destinationTypeDic = new Dictionary<int, string>();
        private List<int[]> registersCommands = new List<int[]>();


        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle; //restrict from resizing
            MaximizeBox = false;  //disable maximize button

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
            addresingTypeDic.Add(0, Enum.GetName(typeof(AddressingTypes), AddressingTypes.REG));
            addresingTypeDic.Add(1, Enum.GetName(typeof(AddressingTypes), AddressingTypes.IMM));
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

        private void SaveToFile(object sender, EventArgs e)
        {
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog1.FileName = "commands";
            saveFileDialog1.ShowDialog();

            FileWriter fileWriter = new FileWriter(saveFileDialog1.FileName, commandsRichTextBox.Text);
            fileWriter.WriteToFile();
        }

        private void ReadFromFile(object sender, EventArgs e)
        {
            ClearTextBoxResetCommandNumberAndDisableButton();
            openFileDialog1.CheckFileExists = false;
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();

            FileReader fileReader = new FileReader(openFileDialog1.FileName);
            commandsRichTextBox.Text = fileReader.ReturnText();

            string regexPattern = @"\d+.\s\b(IMM|REG)\b\s\b(ADD|SUB|MOV)\b\s\b(AX|BX|CX|DX)\b\s";   //to be improved
            Regex regex = new Regex(regexPattern);
            bool firstLineIsValid = regex.IsMatch(commandsRichTextBox.Lines[0]);

            if (firstLineIsValid)
            {
                IterateThroughAllLines(regex);
                this.loadButton.Enabled = false;
            }
            else
            {
                string errorMessage = "Uzytkowniku, wybierz poprawny plik!";
                commandsRichTextBox.Text = errorMessage;
            }
        }

        private void IterateThroughAllLines(Regex regex)
        {
            for (int i = 0; i < commandsRichTextBox.Lines.Count() - 1; i++)   //-1 cause last line in this formatting method always empty
            {
                string currentCommand = commandsRichTextBox.Lines[i];
                string[] seperateCommandComponents = currentCommand.Split(' ');

                try
                {
                    bool isAnyLineBad = !regex.IsMatch(commandsRichTextBox.Lines[i]);
                    if (isAnyLineBad) { break; }
                    int adressingType = changeTypesToInt(seperateCommandComponents[1]);
                    int instructionType = changeTypesToInt(seperateCommandComponents[2]);
                    int sourceType = changeTypesToInt(seperateCommandComponents[seperateCommandComponents.Length - 2]);
                    int destinationType = 0;
                    int value = 0;

                    if (adressingType == (int)AddressingTypes.REG)
                    {
                        destinationType = changeTypesToInt(seperateCommandComponents[seperateCommandComponents.Length - 1].Replace(";", String.Empty));
                    }
                    else
                    {
                        destinationType = changeTypesToInt(seperateCommandComponents[seperateCommandComponents.Length - 2]);
                        value = int.Parse(seperateCommandComponents[seperateCommandComponents.Length - 1].Replace(";", String.Empty));
                    }

                    registersCommands.Add(new int[5] { adressingType, instructionType, sourceType, destinationType, value });
                    totalCommendsNumber++;
                }
                catch
                {
                    ErrorForm errorForm = new ErrorForm();
                    errorForm.ShowDialog();
                }
            }
        }

        private int changeTypesToInt(string type)
        {
            var changeDict = new Dictionary<string, int>()
            {
                {Enum.GetName(typeof(AddressingTypes), AddressingTypes.REG), (int)AddressingTypes.REG },
                {Enum.GetName(typeof(AddressingTypes), AddressingTypes.IMM), (int)AddressingTypes.IMM },
                {Enum.GetName(typeof(InstructionTypes), InstructionTypes.ADD), (int)InstructionTypes.ADD },
                {Enum.GetName(typeof(InstructionTypes), InstructionTypes.SUB), (int)InstructionTypes.SUB },
                {Enum.GetName(typeof(InstructionTypes), InstructionTypes.MOV), (int)InstructionTypes.MOV },
                {Enum.GetName(typeof(Registers), Registers.AX), (int)Registers.AX },
                {Enum.GetName(typeof(Registers), Registers.BX), (int)Registers.BX },
                {Enum.GetName(typeof(Registers), Registers.CX), (int)Registers.CX },
                {Enum.GetName(typeof(Registers), Registers.DX), (int)Registers.DX },
            };

            return changeDict[type];
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

            else if(currentExecutingCommand < totalCommendsNumber && currentCommandsExecutingType == (int)CommandExecutingType.STEP_BY_STEP)
            {
                ExecuteCurrentCommand(currentExecutingCommand);
                ChangeCommandFontColor(currentExecutingCommand-1, Color.Black);     //change color back to black
                ChangeCommandsBackgroundColor(currentExecutingCommand, backExecutedCommandsColor);
                currentExecutingCommand++;

                if (currentExecutingCommand >= totalCommendsNumber)
                {
                    currentExecutingCommand = 0;
                    System.Threading.Thread.Sleep(300);     //sleep for 300ms to enable user see performed action
                    ChangeRichTextBoxBackColor();
                }
                else
                {
                    ChangeCommandFontColor(currentExecutingCommand-1, Color.Red);
                }
            }
        }

        private void ChangeRichTextBoxBackColor()
        {
            for (int i = 0; i < registersCommands.Count; i++)
            {
                ChangeCommandsBackgroundColor(i, backCommandBoxColor);
            }
        }

        private void ExecuteCurrentCommand(int i)
        {
            Int16 registerValue = (Int16)registersCommands[i][4];
            if (registersCommands[i][0] == (int)AddressingTypes.REG)
            {
                registerValue = registers[registersCommands[i][2]];
            }

            switch (registersCommands[i][1])
            {
                case 0:
                    registers[registersCommands[i][3]] += registerValue;
                    break;
                case 1:
                    registers[registersCommands[i][3]] -= registerValue;
                    break;
                case 2:
                    registers[registersCommands[i][3]] = registerValue;
                    break;
            }

            string stringBytes = ConvertToBites(registers[registersCommands[i][3]]);
            DivideInt16NumberAndWriteToRegister(stringBytes, textBoxes[2 * registersCommands[i][3]], textBoxes[2 * registersCommands[i][3] + 1]);
        }

        private void ChangeCommandsBackgroundColor(int i, Color color)
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

        private void ChangeCommandFontColor(int i, Color color)
        {
            commandsRichTextBox.SelectionStart = commandsRichTextBox.GetFirstCharIndexFromLine(i+1);
            commandsRichTextBox.SelectionLength = commandsRichTextBox.Lines[i+1].Length;
            commandsRichTextBox.SelectionColor = color;
        }

        private void LoadActionsIntoMemory(object sender, EventArgs e)
        {
            string command = "";
            int currentSourceType = 0;
            string sourceTypeInText = "";
            string destinationTypeInText = "";
            int value = 0;
            string valueInText = "0";

            if (currentAddressingType == (int)AddressingTypes.REG)
            {
                currentSourceType = this.currentSourceType;
                sourceTypeInText = sourceTypeDic[this.currentSourceType];
                destinationTypeInText = $" {destinationTypeDic[currentDestinationType]}";
                valueInText = value.ToString().Replace("0", String.Empty);
            }
            else
            {
                value = (Int16)numericBox.Value;
                currentSourceType = currentAddressingType;      //actually null is enough
                destinationTypeInText = $"{destinationTypeDic[currentDestinationType]}";
                valueInText = value.ToString();
            }

            command = $"{totalCommendsNumber}. {addresingTypeDic[currentAddressingType]} {instructionTypeDic[currentInstructionType]} {sourceTypeInText}" +
                $"{destinationTypeInText} {valueInText};";
            WriteCommandIntoTextbox(command, valueInText);

            registersCommands.Add(new int[5] { currentAddressingType, currentInstructionType, currentSourceType, currentDestinationType, value }); //would better look as class
            totalCommendsNumber++;
        }

        private void WriteCommandIntoTextbox(string command, string valueInText)
        {
            if (valueInText.Equals(String.Empty))
            {
                command = command.Substring(0, command.Length - 2) + ";";
            }

            commandsRichTextBox.AppendText(command);
            commandsRichTextBox.AppendText(Environment.NewLine);
        }

        private void ClearCommands(object sender, EventArgs e)
        {
            ClearTextBoxResetCommandNumberAndDisableButton();
        }

        private void ClearTextBoxResetCommandNumberAndDisableButton()
        {
            commandsRichTextBox.Clear();
            totalCommendsNumber = 0;
            registersCommands.Clear();
            currentExecutingCommand = 0;
            this.loadButton.Enabled = true;
        }
    }
}
