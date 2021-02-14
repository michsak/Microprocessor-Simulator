using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Text;

//TODO
//corect MOV issue

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
        private int totalCommandsNumber = 0;
        private readonly int maxNumberOfCommands = 50;

        //color variables
        private readonly Color fontColor = Color.White;
        private readonly Color backExecutedCommandsColor = Color.Gray;
        private readonly Color backCommandBoxColor = Color.Black;

        //registers and whole instruction content holders
        private Int16[] registers = { 0, 0, 0, 0 };
        private List<TextBox> textBoxes = new List<TextBox>();
        private List<NumericUpDown> numericBoxes = new List<NumericUpDown>();
        private AddressingTypeContainer addresses = new AddressingTypeContainer();
        private InstructionTypeContainer instructions = new InstructionTypeContainer();
        private SourceAndDestinationTypeContainer sourcesAndDestinations = new SourceAndDestinationTypeContainer();
        private AHValuesContainer ahValuesInBinary = new AHValuesContainer();
        private List<RegistersAdder> registryCommander = new List<RegistersAdder>();
        private Stack<int> interruptsStack = new Stack<int>();

        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle; //restrict from resizing
            MaximizeBox = false;  //disable maximize button
            InitializeTextBoxList();
            FillRegistersWithZeros();
            InitializeNumericBoxList();
            interruptsComboBox.SelectedIndex = 0;
            aHValueComboBox.SelectedIndex = 0;
        }

        private void InitializeNumericBoxList()
        {
            numericBoxes.Add(numericUpDown1);
            numericBoxes.Add(numericUpDown2);
            numericBoxes.Add(numericUpDown3);
            numericBoxes.Add(numericUpDown4);
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

        private void CleanRegistersButton_Click(object sender, EventArgs e)
        {
            FillRegistersWithZeros();
            for (int j = 0; j < numericBoxes.Count; j++)
            {
                numericBoxes[j].Value = registers[j];
            }
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
            if (currentCommandsExecutingType == (int)CommandExecutingType.TOTAL)
            {
                for (int i = 0; i < registryCommander.Count; i++)
                {
                    ChangeCommandFontColor(i, fontColor);
                    ChangeCommandsBackgroundColor(i, backCommandBoxColor);
                }
            }
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

            try
            {
                string regexPattern = @"^\d+. (IMM|REG)|(ADD|SUB|MOV)|(PUSH|POP)|INT";
                Regex regex = new Regex(regexPattern);
                int secondToLast = commandsRichTextBox.Lines.Count() - 2;
                bool firstAndSecondToLastLinesAreValid = regex.IsMatch(commandsRichTextBox.Lines[0]) && 
                    regex.IsMatch(commandsRichTextBox.Lines[secondToLast]);

                if (firstAndSecondToLastLinesAreValid)
                {
                    IterateThroughAllLines(regex);
                }
                else
                {
                    string errorMessage = "Uzytkowniku, wybierz poprawny plik!";
                    commandsRichTextBox.Text = errorMessage;
                }
            }
            catch (System.IndexOutOfRangeException) { }
        }

        private void IterateThroughAllLines(Regex regex)
        {
            int lastLine = commandsRichTextBox.Lines.Count() - 1;   //-1 cause last line in this formatting method always empty
            for (int i = 0; i < lastLine; i++)
            {
                string currentCommand = commandsRichTextBox.Lines[i];
                currentCommand = Regex.Replace(currentCommand, @"\(.*?\)", "");     //replace every bracket
                string[] seperateCommandComponents = currentCommand.Split(' ');
                bool isAnyLineBad = !regex.IsMatch(commandsRichTextBox.Lines[i]);
                if (isAnyLineBad) { break; }

                if (seperateCommandComponents.Count() == 2)  //interrupt
                {
                    registryCommander.Add(new RegistersAdder(true, ChangeTypesToInt(seperateCommandComponents[1].Replace(";",""))));
                    totalCommandsNumber++;
                }

                else if (seperateCommandComponents.Count() == 3) //push or pop
                {
                    int pushOrPopType = ChangeTypesToInt(seperateCommandComponents[1].Replace(";",""));
                    int registerType = ChangeTypesToInt(seperateCommandComponents[2].Replace(";",""));

                    registryCommander.Add(new RegistersAdder(pushOrPopType, registerType));
                    totalCommandsNumber++;
                }

                else if (seperateCommandComponents.Count() == 4)  //add,mov,sub
                {
                    int destinationType = 0;
                    string value = seperateCommandComponents[3];
                    value = value.Replace(";", "");
                    registryCommander.Add(new RegistersAdder(destinationType, value));
                    totalCommandsNumber++;
                }

                else
                {
                    int addressingType = ChangeTypesToInt(seperateCommandComponents[1]);
                    int instructionType = ChangeTypesToInt(seperateCommandComponents[2]);
                    int sourceType = ChangeTypesToInt(seperateCommandComponents[seperateCommandComponents.Length - 2]);
                    int destinationType = 0;
                    int value = 0;

                    if (addressingType == (int)AddressingTypes.REG)
                    {
                        destinationType = ChangeTypesToInt(seperateCommandComponents[seperateCommandComponents.Length - 1].Replace(";", String.Empty));
                    }

                    //MOV przy wczytaniu z pliku zle dziala
                    else
                    {
                        destinationType = ChangeTypesToInt(seperateCommandComponents[seperateCommandComponents.Length - 2]);
                        value = int.Parse(seperateCommandComponents[seperateCommandComponents.Length - 1].Replace(";", String.Empty));
                    }

                    registryCommander.Add(new RegistersAdder(addressingType, destinationType, sourceType, destinationType, value));
                    totalCommandsNumber++;
                }
            }
        }

        private int ChangeTypesToInt(string type)
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
                {Enum.GetName(typeof(Interrupts), Interrupts.NONE), (int)Interrupts.NONE },
                {Enum.GetName(typeof(Interrupts), Interrupts.INT10), (int)Interrupts.INT10 },
                {Enum.GetName(typeof(Interrupts), Interrupts.INT13), (int)Interrupts.INT13 },
                {Enum.GetName(typeof(Interrupts), Interrupts.INT14), (int)Interrupts.INT14 },
                {Enum.GetName(typeof(Interrupts), Interrupts.INT16), (int)Interrupts.INT16 },
                {Enum.GetName(typeof(Interrupts), Interrupts.INT17), (int)Interrupts.INT17 },
                {Enum.GetName(typeof(Interrupts), Interrupts.INT19), (int)Interrupts.INT19 },
                {Enum.GetName(typeof(Interrupts), Interrupts.INT1A), (int)Interrupts.INT1A },
                {Enum.GetName(typeof(Interrupts), Interrupts.INT20), (int)Interrupts.INT20 },
                {Enum.GetName(typeof(PushAndPopStack), PushAndPopStack.PUSH), (int)PushAndPopStack.PUSH },
                {Enum.GetName(typeof(PushAndPopStack), PushAndPopStack.POP), (int)PushAndPopStack.POP },
            };

            return changeDict[type];
        }

        private void ExecuteAction(object sender, EventArgs e)
        {
            if (currentCommandsExecutingType == (int)CommandExecutingType.TOTAL)
            {
                for (int i = 0; i < registryCommander.Count; i++)
                {
                    ExecuteCurrentCommand(i);
                }

                currentExecutingCommand = 0;
                System.Threading.Thread.Sleep(300);     //sleep for 300ms to enable user see performed action
                ChangeAllTextBackgroundColor(backCommandBoxColor);
            }

            else if(currentExecutingCommand < totalCommandsNumber && currentCommandsExecutingType == (int)CommandExecutingType.STEP_BY_STEP)
            {
                ExecuteCurrentCommand(currentExecutingCommand);
                ChangeCommandFontColor(currentExecutingCommand-1, Color.White);
                ChangeCommandsBackgroundColor(currentExecutingCommand, backExecutedCommandsColor);
                currentExecutingCommand++;

                if (currentExecutingCommand >= totalCommandsNumber)
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
            for (int i = 0; i < registryCommander.Count; i++)
            {
                ChangeCommandsBackgroundColor(i, backCommandBoxColor);
            }
        }

        private void ExecuteCurrentCommand(int i)
        {
            if (registryCommander[i].GetPushOrPopType() == 0)
            {
                interruptsStack.Push(registers[registryCommander[i].GetRegisterType()]);
            }
            else if(registryCommander[i].GetPushOrPopType() == 1)
            {
                try
                {
                    registers[registryCommander[i].GetRegisterType()]=(short)interruptsStack.Pop();
                }
                catch (InvalidOperationException) { }

                string stringBytes = ConvertToBites(registers[registryCommander[i].GetRegisterType()]);
                DivideInt16NumberAndWriteToRegister(stringBytes, textBoxes[2 * registryCommander[i].GetRegisterType()],
                    textBoxes[2 * registryCommander[i].GetRegisterType() + 1]);

                IterateThroughAllNumericBoxes();
            }
            else if (registryCommander[i].GetAHValue() != "NONE")
            {
                registers[registryCommander[i].GetDestinationType()] = ahValuesInBinary.AHValues[registryCommander[i].GetAHValue()];
                string stringBytes = ConvertToBites(registers[registryCommander[i].GetDestinationType()]);
                DivideInt16NumberAndWriteToRegister(stringBytes, textBoxes[2 * registryCommander[i].GetDestinationType()],
                    textBoxes[2 * registryCommander[i].GetDestinationType() + 1]);

                IterateThroughAllNumericBoxes();
            }
            else if (registryCommander[i].GetIsInterrupt())
            {
                ChooseProperExecutingInterrupt(i);
            }
            else if (registryCommander[i].GetAddressingType() != -1)
            {
                Int16 registerValue = (registryCommander[i].GetAddressingType() == (int)AddressingTypes.REG) ?
                    registers[registryCommander[i].GetSourceType()] : (Int16)registryCommander[i].GetValue();

                switch (registryCommander[i].GetInstructionType())
                {
                    case 0:
                        registers[registryCommander[i].GetDestinationType()] += registerValue;
                        break;
                    case 1:
                        registers[registryCommander[i].GetDestinationType()] -= registerValue;
                        break;
                    case 2:
                        registers[registryCommander[i].GetDestinationType()] = registerValue;
                        break;
                }

                string stringBytes = ConvertToBites(registers[registryCommander[i].GetDestinationType()]);
                DivideInt16NumberAndWriteToRegister(stringBytes, textBoxes[2 * registryCommander[i].GetDestinationType()],
                    textBoxes[2 * registryCommander[i].GetDestinationType() + 1]);

                IterateThroughAllNumericBoxes();
            }
        }

        private void ChooseProperExecutingInterrupt(int i)
        {
            switch (registryCommander[i].GetInterruptIndex())
            {
                case 1:
                    CursorPositionReader cursorPositionReader = new CursorPositionReader(registers[0], Cursor.Position.X, Cursor.Position.Y);
                    break;
                case 2:
                    DriverStatusChecker driverStatusChecker = new DriverStatusChecker(registers[0]);
                    break;
                case 3:
                    SerialPortServices serialPortServices = new SerialPortServices(registers[0]);
                    break;
                case 4:
                    KeyboardServices keyboardServices = new KeyboardServices(registers[0]);
                    registers[0] = (short)keyboardServices.keyValue;
                    string stringBytes = ConvertToBites(registers[0]);
                    DivideInt16NumberAndWriteToRegister(stringBytes, textBoxes[0], textBoxes[1]);
                    numericBoxes[0].Value = registers[0];
                    break;
                case 5:
                    PrinterServices printerServices = new PrinterServices(registers[0]);
                    break;
                case 6:
                    SystemRebooter systemRebooter = new SystemRebooter();
                    break;
                case 7:
                    TimeReader timeReader = new TimeReader(registers[0]);
                    break;
                case 8:
                    SystemSwitcher systemSwitcher = new SystemSwitcher();
                    break;
            }
        }

        private void IterateThroughAllNumericBoxes()
        {
            for (int j = 0; j < numericBoxes.Count; j++)
            {
                numericBoxes[j].Value = registers[j];
            }
        }

        private void ChangeCommandsBackgroundColor(int i, Color color)
        {
            commandsRichTextBox.SelectionStart = commandsRichTextBox.GetFirstCharIndexFromLine(i);
            commandsRichTextBox.SelectionLength = commandsRichTextBox.Lines[i].Length;
            commandsRichTextBox.SelectionBackColor = color;
        }

        private void ChangeAllTextBackgroundColor (Color color)
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
            if (totalCommandsNumber <= maxNumberOfCommands)
            {
                if (interruptsComboBox.SelectedIndex != 0)
                {
                    string command = $"{totalCommandsNumber}. {interruptsComboBox.Text};";
                    registryCommander.Add(new RegistersAdder(true, interruptsComboBox.SelectedIndex));
                    WriteCommandIntoTextbox(command);
                }
                else if (aHValueComboBox.SelectedIndex != 0)
                {
                    string command = $"{totalCommandsNumber}. MOV AH {aHValueComboBox.Text};";
                    registryCommander.Add(new RegistersAdder(0, aHValueComboBox.Text));
                    WriteCommandIntoTextbox(command);
                }
                else
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
                        sourceTypeInText = sourcesAndDestinations.sourcesAndDestinationsData[this.currentSourceType];
                        destinationTypeInText = $"{sourcesAndDestinations.sourcesAndDestinationsData[currentDestinationType]} ";
                        valueInText = value.ToString().Replace("0", String.Empty);
                    }
                    else
                    {
                        value = (Int16)numericBox.Value;
                        currentSourceType = currentAddressingType;      //actually null is enough
                        destinationTypeInText = $"{sourcesAndDestinations.sourcesAndDestinationsData[currentDestinationType]}";
                        valueInText = value.ToString();
                    }

                    command = $"{totalCommandsNumber}. {addresses.addressesData[currentAddressingType]} " +
                        $"{instructions.instructionsData[currentInstructionType]} {destinationTypeInText}{sourceTypeInText} {valueInText};";
                    WriteCommandIntoTextbox(command, valueInText);
                    registryCommander.Add(new RegistersAdder(currentAddressingType, currentInstructionType, 
                        currentSourceType, currentDestinationType, value));
                }
                totalCommandsNumber++;
            }
            interruptsComboBox.SelectedIndex = 0;
            aHValueComboBox.SelectedIndex = 0;
        }

        private void WriteCommandIntoTextbox(string command, string valueInText = " ")
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
            totalCommandsNumber = 0;
            registryCommander.Clear();
            currentExecutingCommand = 0;
        }

        private void setRegisterValueButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < numericBoxes.Count; i++)
            {
                registers[i] = (Int16)numericBoxes[i].Value;
                string stringBytes = ConvertToBites(registers[i]);
                DivideInt16NumberAndWriteToRegister(stringBytes, textBoxes[2 * i], textBoxes[2 * i + 1]);
            }
        }

        private void PushOrPop(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int currentPushOrPullType = int.Parse(button.Tag.ToString());
            int sourceOrDestinationType = (currentPushOrPullType == 0) ? this.currentSourceType : this.currentDestinationType;  //push 0, pop 1
            string destinationOrSourceTypeInText = sourcesAndDestinations.sourcesAndDestinationsData[sourceOrDestinationType];
            string command = $"{totalCommandsNumber}. {button.Text} {destinationOrSourceTypeInText};";

            commandsRichTextBox.AppendText(command);
            commandsRichTextBox.AppendText(Environment.NewLine);
            registryCommander.Add(new RegistersAdder(currentPushOrPullType, sourceOrDestinationType));
            totalCommandsNumber++;
        }
    }
}
