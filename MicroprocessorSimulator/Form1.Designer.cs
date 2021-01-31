namespace MicroprocessorSimulator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.AXLabel = new System.Windows.Forms.Label();
            this.BXLabel = new System.Windows.Forms.Label();
            this.CXLabel = new System.Windows.Forms.Label();
            this.DXLabel = new System.Windows.Forms.Label();
            this.AHLabel = new System.Windows.Forms.Label();
            this.BHLabel = new System.Windows.Forms.Label();
            this.CHLabel = new System.Windows.Forms.Label();
            this.DHLabel = new System.Windows.Forms.Label();
            this.ALLabel = new System.Windows.Forms.Label();
            this.BLLabel = new System.Windows.Forms.Label();
            this.CLLabel = new System.Windows.Forms.Label();
            this.DLLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CleanRegistersButton = new System.Windows.Forms.Button();
            this.ADDRadioButton = new System.Windows.Forms.RadioButton();
            this.RegisterRadioButton = new System.Windows.Forms.RadioButton();
            this.ImmediateRadioButton = new System.Windows.Forms.RadioButton();
            this.AdressingTypeGroup = new System.Windows.Forms.GroupBox();
            this.IntructionGroupBox = new System.Windows.Forms.GroupBox();
            this.MOVRadioButton = new System.Windows.Forms.RadioButton();
            this.SUBRadioButton = new System.Windows.Forms.RadioButton();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.DGroupBox = new System.Windows.Forms.GroupBox();
            this.DXRadioButton = new System.Windows.Forms.RadioButton();
            this.CXRadioButton = new System.Windows.Forms.RadioButton();
            this.BXRadioButton = new System.Windows.Forms.RadioButton();
            this.AXRadioButton = new System.Windows.Forms.RadioButton();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.numericBox = new System.Windows.Forms.NumericUpDown();
            this.StartActionButton = new System.Windows.Forms.Button();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.loadButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.CommandsExecutingModeLabel = new System.Windows.Forms.Label();
            this.stepByStepRadioButton = new System.Windows.Forms.RadioButton();
            this.totalRadioButton = new System.Windows.Forms.RadioButton();
            this.CommandExecutingOrderPanel = new System.Windows.Forms.Panel();
            this.commandsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.readFromFileButton = new System.Windows.Forms.Button();
            this.saveToFileButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.setRegisterValueButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.AdressingTypeGroup.SuspendLayout();
            this.IntructionGroupBox.SuspendLayout();
            this.DGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.CommandExecutingOrderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Location = new System.Drawing.Point(152, 11);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(139, 20);
            this.RegisterLabel.TabIndex = 0;
            this.RegisterLabel.Text = "Wartosci rejestrow";
            // 
            // AXLabel
            // 
            this.AXLabel.AutoSize = true;
            this.AXLabel.Location = new System.Drawing.Point(8, 53);
            this.AXLabel.Name = "AXLabel";
            this.AXLabel.Size = new System.Drawing.Size(31, 20);
            this.AXLabel.TabIndex = 1;
            this.AXLabel.Text = "AX";
            // 
            // BXLabel
            // 
            this.BXLabel.AutoSize = true;
            this.BXLabel.Location = new System.Drawing.Point(8, 87);
            this.BXLabel.Name = "BXLabel";
            this.BXLabel.Size = new System.Drawing.Size(31, 20);
            this.BXLabel.TabIndex = 2;
            this.BXLabel.Text = "BX";
            // 
            // CXLabel
            // 
            this.CXLabel.AutoSize = true;
            this.CXLabel.Location = new System.Drawing.Point(8, 125);
            this.CXLabel.Name = "CXLabel";
            this.CXLabel.Size = new System.Drawing.Size(31, 20);
            this.CXLabel.TabIndex = 3;
            this.CXLabel.Text = "CX";
            // 
            // DXLabel
            // 
            this.DXLabel.AutoSize = true;
            this.DXLabel.Location = new System.Drawing.Point(8, 159);
            this.DXLabel.Name = "DXLabel";
            this.DXLabel.Size = new System.Drawing.Size(32, 20);
            this.DXLabel.TabIndex = 4;
            this.DXLabel.Text = "DX";
            // 
            // AHLabel
            // 
            this.AHLabel.AutoSize = true;
            this.AHLabel.Location = new System.Drawing.Point(47, 53);
            this.AHLabel.Name = "AHLabel";
            this.AHLabel.Size = new System.Drawing.Size(32, 20);
            this.AHLabel.TabIndex = 5;
            this.AHLabel.Text = "AH";
            // 
            // BHLabel
            // 
            this.BHLabel.AutoSize = true;
            this.BHLabel.Location = new System.Drawing.Point(47, 87);
            this.BHLabel.Name = "BHLabel";
            this.BHLabel.Size = new System.Drawing.Size(32, 20);
            this.BHLabel.TabIndex = 6;
            this.BHLabel.Text = "BH";
            // 
            // CHLabel
            // 
            this.CHLabel.AutoSize = true;
            this.CHLabel.Location = new System.Drawing.Point(47, 125);
            this.CHLabel.Name = "CHLabel";
            this.CHLabel.Size = new System.Drawing.Size(32, 20);
            this.CHLabel.TabIndex = 7;
            this.CHLabel.Text = "CH";
            // 
            // DHLabel
            // 
            this.DHLabel.AutoSize = true;
            this.DHLabel.Location = new System.Drawing.Point(47, 159);
            this.DHLabel.Name = "DHLabel";
            this.DHLabel.Size = new System.Drawing.Size(33, 20);
            this.DHLabel.TabIndex = 8;
            this.DHLabel.Text = "DH";
            // 
            // ALLabel
            // 
            this.ALLabel.AutoSize = true;
            this.ALLabel.Location = new System.Drawing.Point(201, 53);
            this.ALLabel.Name = "ALLabel";
            this.ALLabel.Size = new System.Drawing.Size(29, 20);
            this.ALLabel.TabIndex = 9;
            this.ALLabel.Text = "AL";
            // 
            // BLLabel
            // 
            this.BLLabel.AutoSize = true;
            this.BLLabel.Location = new System.Drawing.Point(201, 87);
            this.BLLabel.Name = "BLLabel";
            this.BLLabel.Size = new System.Drawing.Size(29, 20);
            this.BLLabel.TabIndex = 10;
            this.BLLabel.Text = "BL";
            // 
            // CLLabel
            // 
            this.CLLabel.AutoSize = true;
            this.CLLabel.Location = new System.Drawing.Point(201, 125);
            this.CLLabel.Name = "CLLabel";
            this.CLLabel.Size = new System.Drawing.Size(29, 20);
            this.CLLabel.TabIndex = 11;
            this.CLLabel.Text = "CL";
            // 
            // DLLabel
            // 
            this.DLLabel.AutoSize = true;
            this.DLLabel.Location = new System.Drawing.Point(201, 159);
            this.DLLabel.Name = "DLLabel";
            this.DLLabel.Size = new System.Drawing.Size(30, 20);
            this.DLLabel.TabIndex = 12;
            this.DLLabel.Text = "DL";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(84, 49);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 26);
            this.textBox1.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(85, 83);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(112, 26);
            this.textBox3.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(84, 121);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(112, 26);
            this.textBox5.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(85, 157);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(112, 26);
            this.textBox7.TabIndex = 16;
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(237, 160);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(112, 26);
            this.textBox8.TabIndex = 20;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(235, 125);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(112, 26);
            this.textBox6.TabIndex = 19;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(235, 87);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(112, 26);
            this.textBox4.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(235, 53);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 26);
            this.textBox2.TabIndex = 17;
            // 
            // CleanRegistersButton
            // 
            this.CleanRegistersButton.Location = new System.Drawing.Point(12, 212);
            this.CleanRegistersButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CleanRegistersButton.Name = "CleanRegistersButton";
            this.CleanRegistersButton.Size = new System.Drawing.Size(213, 38);
            this.CleanRegistersButton.TabIndex = 21;
            this.CleanRegistersButton.Text = "Wyczysc rejestry";
            this.CleanRegistersButton.UseVisualStyleBackColor = true;
            this.CleanRegistersButton.Click += new System.EventHandler(this.CleanRegistersButton_Click);
            // 
            // ADDRadioButton
            // 
            this.ADDRadioButton.AutoSize = true;
            this.ADDRadioButton.Checked = true;
            this.ADDRadioButton.Location = new System.Drawing.Point(11, 52);
            this.ADDRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ADDRadioButton.Name = "ADDRadioButton";
            this.ADDRadioButton.Size = new System.Drawing.Size(69, 24);
            this.ADDRadioButton.TabIndex = 26;
            this.ADDRadioButton.TabStop = true;
            this.ADDRadioButton.Tag = "0";
            this.ADDRadioButton.Text = "ADD";
            this.ADDRadioButton.UseVisualStyleBackColor = true;
            this.ADDRadioButton.CheckedChanged += new System.EventHandler(this.ChooseInstructionTypeViaRadioButton);
            // 
            // RegisterRadioButton
            // 
            this.RegisterRadioButton.AutoSize = true;
            this.RegisterRadioButton.Checked = true;
            this.RegisterRadioButton.Location = new System.Drawing.Point(7, 49);
            this.RegisterRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RegisterRadioButton.Name = "RegisterRadioButton";
            this.RegisterRadioButton.Size = new System.Drawing.Size(112, 24);
            this.RegisterRadioButton.TabIndex = 23;
            this.RegisterRadioButton.TabStop = true;
            this.RegisterRadioButton.Tag = "0";
            this.RegisterRadioButton.Text = "Rejestrowy";
            this.RegisterRadioButton.UseVisualStyleBackColor = true;
            this.RegisterRadioButton.CheckedChanged += new System.EventHandler(this.ChooseAdressingTypeViaRadioButton);
            // 
            // ImmediateRadioButton
            // 
            this.ImmediateRadioButton.AutoSize = true;
            this.ImmediateRadioButton.Location = new System.Drawing.Point(133, 49);
            this.ImmediateRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ImmediateRadioButton.Name = "ImmediateRadioButton";
            this.ImmediateRadioButton.Size = new System.Drawing.Size(148, 24);
            this.ImmediateRadioButton.TabIndex = 24;
            this.ImmediateRadioButton.TabStop = true;
            this.ImmediateRadioButton.Tag = "1";
            this.ImmediateRadioButton.Text = "Natychmiastowy";
            this.ImmediateRadioButton.UseVisualStyleBackColor = true;
            this.ImmediateRadioButton.CheckedChanged += new System.EventHandler(this.ChooseAdressingTypeViaRadioButton);
            // 
            // AdressingTypeGroup
            // 
            this.AdressingTypeGroup.Controls.Add(this.ImmediateRadioButton);
            this.AdressingTypeGroup.Controls.Add(this.RegisterRadioButton);
            this.AdressingTypeGroup.Location = new System.Drawing.Point(22, 274);
            this.AdressingTypeGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AdressingTypeGroup.Name = "AdressingTypeGroup";
            this.AdressingTypeGroup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AdressingTypeGroup.Size = new System.Drawing.Size(348, 112);
            this.AdressingTypeGroup.TabIndex = 27;
            this.AdressingTypeGroup.TabStop = false;
            this.AdressingTypeGroup.Text = "Tryb Adresowania";
            // 
            // IntructionGroupBox
            // 
            this.IntructionGroupBox.Controls.Add(this.MOVRadioButton);
            this.IntructionGroupBox.Controls.Add(this.SUBRadioButton);
            this.IntructionGroupBox.Controls.Add(this.ADDRadioButton);
            this.IntructionGroupBox.Location = new System.Drawing.Point(22, 394);
            this.IntructionGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IntructionGroupBox.Name = "IntructionGroupBox";
            this.IntructionGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IntructionGroupBox.Size = new System.Drawing.Size(348, 112);
            this.IntructionGroupBox.TabIndex = 28;
            this.IntructionGroupBox.TabStop = false;
            this.IntructionGroupBox.Text = "Rozkaz";
            // 
            // MOVRadioButton
            // 
            this.MOVRadioButton.AutoSize = true;
            this.MOVRadioButton.Location = new System.Drawing.Point(264, 52);
            this.MOVRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MOVRadioButton.Name = "MOVRadioButton";
            this.MOVRadioButton.Size = new System.Drawing.Size(70, 24);
            this.MOVRadioButton.TabIndex = 28;
            this.MOVRadioButton.Tag = "2";
            this.MOVRadioButton.Text = "MOV";
            this.MOVRadioButton.UseVisualStyleBackColor = true;
            this.MOVRadioButton.CheckedChanged += new System.EventHandler(this.ChooseInstructionTypeViaRadioButton);
            this.MOVRadioButton.Click += new System.EventHandler(this.ChooseInstructionTypeViaRadioButton);
            // 
            // SUBRadioButton
            // 
            this.SUBRadioButton.AutoSize = true;
            this.SUBRadioButton.Location = new System.Drawing.Point(135, 52);
            this.SUBRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SUBRadioButton.Name = "SUBRadioButton";
            this.SUBRadioButton.Size = new System.Drawing.Size(68, 24);
            this.SUBRadioButton.TabIndex = 27;
            this.SUBRadioButton.Tag = "1";
            this.SUBRadioButton.Text = "SUB";
            this.SUBRadioButton.UseVisualStyleBackColor = true;
            this.SUBRadioButton.CheckedChanged += new System.EventHandler(this.ChooseInstructionTypeViaRadioButton);
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Location = new System.Drawing.Point(231, 528);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(21, 20);
            this.DestinationLabel.TabIndex = 29;
            this.DestinationLabel.Text = "D";
            // 
            // DGroupBox
            // 
            this.DGroupBox.Controls.Add(this.DXRadioButton);
            this.DGroupBox.Controls.Add(this.CXRadioButton);
            this.DGroupBox.Controls.Add(this.BXRadioButton);
            this.DGroupBox.Controls.Add(this.AXRadioButton);
            this.DGroupBox.Location = new System.Drawing.Point(202, 552);
            this.DGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGroupBox.Name = "DGroupBox";
            this.DGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGroupBox.Size = new System.Drawing.Size(70, 144);
            this.DGroupBox.TabIndex = 29;
            this.DGroupBox.TabStop = false;
            // 
            // DXRadioButton
            // 
            this.DXRadioButton.AutoSize = true;
            this.DXRadioButton.Location = new System.Drawing.Point(4, 118);
            this.DXRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DXRadioButton.Name = "DXRadioButton";
            this.DXRadioButton.Size = new System.Drawing.Size(57, 24);
            this.DXRadioButton.TabIndex = 29;
            this.DXRadioButton.TabStop = true;
            this.DXRadioButton.Tag = "3";
            this.DXRadioButton.Text = "DX";
            this.DXRadioButton.UseVisualStyleBackColor = true;
            this.DXRadioButton.CheckedChanged += new System.EventHandler(this.ChooseDestinationRegisterViaRadioButton);
            this.DXRadioButton.Click += new System.EventHandler(this.ChooseDestinationRegisterViaRadioButton);
            // 
            // CXRadioButton
            // 
            this.CXRadioButton.AutoSize = true;
            this.CXRadioButton.Location = new System.Drawing.Point(4, 84);
            this.CXRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CXRadioButton.Name = "CXRadioButton";
            this.CXRadioButton.Size = new System.Drawing.Size(56, 24);
            this.CXRadioButton.TabIndex = 28;
            this.CXRadioButton.TabStop = true;
            this.CXRadioButton.Tag = "2";
            this.CXRadioButton.Text = "CX";
            this.CXRadioButton.UseVisualStyleBackColor = true;
            this.CXRadioButton.CheckedChanged += new System.EventHandler(this.ChooseDestinationRegisterViaRadioButton);
            this.CXRadioButton.Click += new System.EventHandler(this.ChooseDestinationRegisterViaRadioButton);
            // 
            // BXRadioButton
            // 
            this.BXRadioButton.AutoSize = true;
            this.BXRadioButton.Location = new System.Drawing.Point(6, 50);
            this.BXRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BXRadioButton.Name = "BXRadioButton";
            this.BXRadioButton.Size = new System.Drawing.Size(56, 24);
            this.BXRadioButton.TabIndex = 27;
            this.BXRadioButton.TabStop = true;
            this.BXRadioButton.Tag = "1";
            this.BXRadioButton.Text = "BX";
            this.BXRadioButton.UseVisualStyleBackColor = true;
            this.BXRadioButton.CheckedChanged += new System.EventHandler(this.ChooseDestinationRegisterViaRadioButton);
            this.BXRadioButton.Click += new System.EventHandler(this.ChooseDestinationRegisterViaRadioButton);
            // 
            // AXRadioButton
            // 
            this.AXRadioButton.AutoSize = true;
            this.AXRadioButton.Checked = true;
            this.AXRadioButton.Location = new System.Drawing.Point(6, 16);
            this.AXRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AXRadioButton.Name = "AXRadioButton";
            this.AXRadioButton.Size = new System.Drawing.Size(56, 24);
            this.AXRadioButton.TabIndex = 26;
            this.AXRadioButton.TabStop = true;
            this.AXRadioButton.Tag = "0";
            this.AXRadioButton.Text = "AX";
            this.AXRadioButton.UseVisualStyleBackColor = true;
            this.AXRadioButton.CheckedChanged += new System.EventHandler(this.ChooseDestinationRegisterViaRadioButton);
            this.AXRadioButton.Click += new System.EventHandler(this.ChooseDestinationRegisterViaRadioButton);
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(98, 728);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(68, 20);
            this.ValueLabel.TabIndex = 30;
            this.ValueLabel.Text = "Wartosc";
            // 
            // numericBox
            // 
            this.numericBox.Enabled = false;
            this.numericBox.Location = new System.Drawing.Point(187, 728);
            this.numericBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericBox.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numericBox.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.numericBox.Name = "numericBox";
            this.numericBox.Size = new System.Drawing.Size(86, 26);
            this.numericBox.TabIndex = 31;
            // 
            // StartActionButton
            // 
            this.StartActionButton.Location = new System.Drawing.Point(465, 788);
            this.StartActionButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartActionButton.Name = "StartActionButton";
            this.StartActionButton.Size = new System.Drawing.Size(234, 50);
            this.StartActionButton.TabIndex = 32;
            this.StartActionButton.Text = "Wykonaj";
            this.StartActionButton.UseVisualStyleBackColor = true;
            this.StartActionButton.Click += new System.EventHandler(this.ExecuteAction);
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Location = new System.Drawing.Point(128, 528);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(20, 20);
            this.SourceLabel.TabIndex = 33;
            this.SourceLabel.Text = "S";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Location = new System.Drawing.Point(100, 552);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(70, 144);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(4, 118);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 24);
            this.radioButton1.TabIndex = 29;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "3";
            this.radioButton1.Text = "DX";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.ChooseSourceRegisterViaRadioButton);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(4, 84);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 24);
            this.radioButton2.TabIndex = 28;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "2";
            this.radioButton2.Text = "CX";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.ChooseSourceRegisterViaRadioButton);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(4, 50);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(56, 24);
            this.radioButton3.TabIndex = 27;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "1";
            this.radioButton3.Text = "BX";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.ChooseSourceRegisterViaRadioButton);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 16);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(56, 24);
            this.radioButton4.TabIndex = 26;
            this.radioButton4.TabStop = true;
            this.radioButton4.Tag = "0";
            this.radioButton4.Text = "AX";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.ChooseSourceRegisterViaRadioButton);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(17, 788);
            this.loadButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(338, 50);
            this.loadButton.TabIndex = 35;
            this.loadButton.Text = "Załaduj";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadActionsIntoMemory);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(705, 788);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(234, 50);
            this.clearButton.TabIndex = 36;
            this.clearButton.Text = "Wyczyść";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearCommands);
            // 
            // CommandsExecutingModeLabel
            // 
            this.CommandsExecutingModeLabel.Location = new System.Drawing.Point(471, 734);
            this.CommandsExecutingModeLabel.Name = "CommandsExecutingModeLabel";
            this.CommandsExecutingModeLabel.Size = new System.Drawing.Size(215, 29);
            this.CommandsExecutingModeLabel.TabIndex = 37;
            this.CommandsExecutingModeLabel.Text = "Tryb wykonywania instrukcji";
            // 
            // stepByStepRadioButton
            // 
            this.stepByStepRadioButton.AutoSize = true;
            this.stepByStepRadioButton.Location = new System.Drawing.Point(129, 4);
            this.stepByStepRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stepByStepRadioButton.Name = "stepByStepRadioButton";
            this.stepByStepRadioButton.Size = new System.Drawing.Size(93, 24);
            this.stepByStepRadioButton.TabIndex = 24;
            this.stepByStepRadioButton.TabStop = true;
            this.stepByStepRadioButton.Tag = "1";
            this.stepByStepRadioButton.Text = "Krokowy";
            this.stepByStepRadioButton.UseVisualStyleBackColor = true;
            this.stepByStepRadioButton.CheckedChanged += new System.EventHandler(this.ChooseCommandsExecutingTypeViaRadioButton);
            // 
            // totalRadioButton
            // 
            this.totalRadioButton.AutoSize = true;
            this.totalRadioButton.Checked = true;
            this.totalRadioButton.Location = new System.Drawing.Point(3, 4);
            this.totalRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.totalRadioButton.Name = "totalRadioButton";
            this.totalRadioButton.Size = new System.Drawing.Size(112, 24);
            this.totalRadioButton.TabIndex = 23;
            this.totalRadioButton.TabStop = true;
            this.totalRadioButton.Tag = "0";
            this.totalRadioButton.Text = "Calosciowy";
            this.totalRadioButton.UseVisualStyleBackColor = true;
            this.totalRadioButton.CheckedChanged += new System.EventHandler(this.ChooseCommandsExecutingTypeViaRadioButton);
            // 
            // CommandExecutingOrderPanel
            // 
            this.CommandExecutingOrderPanel.Controls.Add(this.stepByStepRadioButton);
            this.CommandExecutingOrderPanel.Controls.Add(this.totalRadioButton);
            this.CommandExecutingOrderPanel.Location = new System.Drawing.Point(712, 728);
            this.CommandExecutingOrderPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CommandExecutingOrderPanel.Name = "CommandExecutingOrderPanel";
            this.CommandExecutingOrderPanel.Size = new System.Drawing.Size(227, 32);
            this.CommandExecutingOrderPanel.TabIndex = 39;
            // 
            // commandsRichTextBox
            // 
            this.commandsRichTextBox.BackColor = System.Drawing.Color.Black;
            this.commandsRichTextBox.Font = new System.Drawing.Font("MS PGothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandsRichTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.commandsRichTextBox.Location = new System.Drawing.Point(465, 11);
            this.commandsRichTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.commandsRichTextBox.Name = "commandsRichTextBox";
            this.commandsRichTextBox.ReadOnly = true;
            this.commandsRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.commandsRichTextBox.Size = new System.Drawing.Size(474, 635);
            this.commandsRichTextBox.TabIndex = 40;
            this.commandsRichTextBox.Text = "";
            // 
            // readFromFileButton
            // 
            this.readFromFileButton.Location = new System.Drawing.Point(705, 658);
            this.readFromFileButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.readFromFileButton.Name = "readFromFileButton";
            this.readFromFileButton.Size = new System.Drawing.Size(234, 38);
            this.readFromFileButton.TabIndex = 41;
            this.readFromFileButton.Text = "Wczytaj";
            this.readFromFileButton.UseVisualStyleBackColor = true;
            this.readFromFileButton.Click += new System.EventHandler(this.ReadFromFile);
            // 
            // saveToFileButton
            // 
            this.saveToFileButton.Location = new System.Drawing.Point(465, 658);
            this.saveToFileButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveToFileButton.Name = "saveToFileButton";
            this.saveToFileButton.Size = new System.Drawing.Size(234, 38);
            this.saveToFileButton.TabIndex = 42;
            this.saveToFileButton.Text = "Zapisz";
            this.saveToFileButton.UseVisualStyleBackColor = true;
            this.saveToFileButton.Click += new System.EventHandler(this.SaveToFile);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // setRegisterValueButton
            // 
            this.setRegisterValueButton.Location = new System.Drawing.Point(241, 212);
            this.setRegisterValueButton.Name = "setRegisterValueButton";
            this.setRegisterValueButton.Size = new System.Drawing.Size(213, 38);
            this.setRegisterValueButton.TabIndex = 43;
            this.setRegisterValueButton.Text = "Ustaw rejestry";
            this.setRegisterValueButton.UseVisualStyleBackColor = true;
            this.setRegisterValueButton.Click += new System.EventHandler(this.setRegisterValueButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(369, 53);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(85, 26);
            this.numericUpDown1.TabIndex = 44;
            this.numericUpDown1.Tag = "0";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(369, 87);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(85, 26);
            this.numericUpDown2.TabIndex = 45;
            this.numericUpDown2.Tag = "1";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(369, 125);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(85, 26);
            this.numericUpDown3.TabIndex = 46;
            this.numericUpDown3.Tag = "2";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(369, 160);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(85, 26);
            this.numericUpDown4.TabIndex = 47;
            this.numericUpDown4.Tag = "3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 859);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.setRegisterValueButton);
            this.Controls.Add(this.saveToFileButton);
            this.Controls.Add(this.readFromFileButton);
            this.Controls.Add(this.commandsRichTextBox);
            this.Controls.Add(this.CommandExecutingOrderPanel);
            this.Controls.Add(this.CommandsExecutingModeLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SourceLabel);
            this.Controls.Add(this.StartActionButton);
            this.Controls.Add(this.numericBox);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.DGroupBox);
            this.Controls.Add(this.DestinationLabel);
            this.Controls.Add(this.IntructionGroupBox);
            this.Controls.Add(this.AdressingTypeGroup);
            this.Controls.Add(this.CleanRegistersButton);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DLLabel);
            this.Controls.Add(this.CLLabel);
            this.Controls.Add(this.BLLabel);
            this.Controls.Add(this.ALLabel);
            this.Controls.Add(this.DHLabel);
            this.Controls.Add(this.CHLabel);
            this.Controls.Add(this.BHLabel);
            this.Controls.Add(this.AHLabel);
            this.Controls.Add(this.DXLabel);
            this.Controls.Add(this.CXLabel);
            this.Controls.Add(this.BXLabel);
            this.Controls.Add(this.AXLabel);
            this.Controls.Add(this.RegisterLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.AdressingTypeGroup.ResumeLayout(false);
            this.AdressingTypeGroup.PerformLayout();
            this.IntructionGroupBox.ResumeLayout(false);
            this.IntructionGroupBox.PerformLayout();
            this.DGroupBox.ResumeLayout(false);
            this.DGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.CommandExecutingOrderPanel.ResumeLayout(false);
            this.CommandExecutingOrderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.Label AXLabel;
        private System.Windows.Forms.Label BXLabel;
        private System.Windows.Forms.Label CXLabel;
        private System.Windows.Forms.Label DXLabel;
        private System.Windows.Forms.Label AHLabel;
        private System.Windows.Forms.Label BHLabel;
        private System.Windows.Forms.Label CHLabel;
        private System.Windows.Forms.Label DHLabel;
        private System.Windows.Forms.Label ALLabel;
        private System.Windows.Forms.Label BLLabel;
        private System.Windows.Forms.Label CLLabel;
        private System.Windows.Forms.Label DLLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button CleanRegistersButton;
        private System.Windows.Forms.RadioButton ADDRadioButton;
        private System.Windows.Forms.RadioButton RegisterRadioButton;
        private System.Windows.Forms.RadioButton ImmediateRadioButton;
        private System.Windows.Forms.GroupBox AdressingTypeGroup;
        private System.Windows.Forms.GroupBox IntructionGroupBox;
        private System.Windows.Forms.RadioButton MOVRadioButton;
        private System.Windows.Forms.RadioButton SUBRadioButton;
        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.GroupBox DGroupBox;
        private System.Windows.Forms.RadioButton DXRadioButton;
        private System.Windows.Forms.RadioButton CXRadioButton;
        private System.Windows.Forms.RadioButton BXRadioButton;
        private System.Windows.Forms.RadioButton AXRadioButton;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.NumericUpDown numericBox;
        private System.Windows.Forms.Button StartActionButton;
        private System.Windows.Forms.Label SourceLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label CommandsExecutingModeLabel;
        private System.Windows.Forms.RadioButton stepByStepRadioButton;
        private System.Windows.Forms.RadioButton totalRadioButton;
        private System.Windows.Forms.Panel CommandExecutingOrderPanel;
        private System.Windows.Forms.RichTextBox commandsRichTextBox;
        private System.Windows.Forms.Button readFromFileButton;
        private System.Windows.Forms.Button saveToFileButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button setRegisterValueButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
    }
}

