namespace ScaleCalc
{
    partial class ScaleCalculator
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabInstruments = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstInstruments = new System.Windows.Forms.ListBox();
            this.tabParms = new System.Windows.Forms.TabPage();
            this.bxDisplay = new System.Windows.Forms.GroupBox();
            this.rbFraction = new System.Windows.Forms.RadioButton();
            this.rbDecimal = new System.Windows.Forms.RadioButton();
            this.txtOversize = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBaseWidth = new System.Windows.Forms.TextBox();
            this.txtBoardLength = new System.Windows.Forms.TextBox();
            this.txtNutWidth = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bxDulcimer = new System.Windows.Forms.GroupBox();
            this.chkFourHalf = new System.Windows.Forms.CheckBox();
            this.chkDulcChromatic = new System.Windows.Forms.CheckBox();
            this.chkSixHalf = new System.Windows.Forms.CheckBox();
            this.chkOneHalf = new System.Windows.Forms.CheckBox();
            this.chkDulcimer = new System.Windows.Forms.CheckBox();
            this.txtFretCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bxUnits = new System.Windows.Forms.GroupBox();
            this.rbCentimeters = new System.Windows.Forms.RadioButton();
            this.rbInches = new System.Windows.Forms.RadioButton();
            this.txtScaleLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCuts = new System.Windows.Forms.TabPage();
            this.lblCut2 = new System.Windows.Forms.Label();
            this.lblCut1 = new System.Windows.Forms.Label();
            this.lstCuts = new System.Windows.Forms.ListBox();
            this.tabFrets = new System.Windows.Forms.TabPage();
            this.lblFret2 = new System.Windows.Forms.Label();
            this.lblFret1 = new System.Windows.Forms.Label();
            this.lstFretLengths = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInstrumentDesc = new System.Windows.Forms.TextBox();
            this.tabMain.SuspendLayout();
            this.tabInstruments.SuspendLayout();
            this.tabParms.SuspendLayout();
            this.bxDisplay.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.bxDulcimer.SuspendLayout();
            this.bxUnits.SuspendLayout();
            this.tabCuts.SuspendLayout();
            this.tabFrets.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabInstruments);
            this.tabMain.Controls.Add(this.tabParms);
            this.tabMain.Controls.Add(this.tabCuts);
            this.tabMain.Controls.Add(this.tabFrets);
            this.tabMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(3, 34);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(473, 415);
            this.tabMain.TabIndex = 0;
            // 
            // tabInstruments
            // 
            this.tabInstruments.Controls.Add(this.btnAdd);
            this.tabInstruments.Controls.Add(this.lstInstruments);
            this.tabInstruments.Location = new System.Drawing.Point(4, 22);
            this.tabInstruments.Name = "tabInstruments";
            this.tabInstruments.Padding = new System.Windows.Forms.Padding(3);
            this.tabInstruments.Size = new System.Drawing.Size(465, 389);
            this.tabInstruments.TabIndex = 3;
            this.tabInstruments.Text = "Instruments";
            this.tabInstruments.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(359, 340);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 26);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstInstruments
            // 
            this.lstInstruments.FormattingEnabled = true;
            this.lstInstruments.Location = new System.Drawing.Point(13, 15);
            this.lstInstruments.Name = "lstInstruments";
            this.lstInstruments.Size = new System.Drawing.Size(432, 303);
            this.lstInstruments.TabIndex = 0;
            this.lstInstruments.DoubleClick += new System.EventHandler(this.lstInstruments_DoubleClick);
            // 
            // tabParms
            // 
            this.tabParms.Controls.Add(this.bxDisplay);
            this.tabParms.Controls.Add(this.txtOversize);
            this.tabParms.Controls.Add(this.label10);
            this.tabParms.Controls.Add(this.groupBox1);
            this.tabParms.Controls.Add(this.bxDulcimer);
            this.tabParms.Controls.Add(this.chkDulcimer);
            this.tabParms.Controls.Add(this.txtFretCount);
            this.tabParms.Controls.Add(this.label2);
            this.tabParms.Controls.Add(this.btnCalc);
            this.tabParms.Controls.Add(this.btnCancel);
            this.tabParms.Controls.Add(this.bxUnits);
            this.tabParms.Controls.Add(this.txtScaleLength);
            this.tabParms.Controls.Add(this.label1);
            this.tabParms.Location = new System.Drawing.Point(4, 22);
            this.tabParms.Name = "tabParms";
            this.tabParms.Padding = new System.Windows.Forms.Padding(3);
            this.tabParms.Size = new System.Drawing.Size(465, 389);
            this.tabParms.TabIndex = 0;
            this.tabParms.Text = "Parameters";
            this.tabParms.UseVisualStyleBackColor = true;
            // 
            // bxDisplay
            // 
            this.bxDisplay.Controls.Add(this.rbFraction);
            this.bxDisplay.Controls.Add(this.rbDecimal);
            this.bxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxDisplay.Location = new System.Drawing.Point(11, 61);
            this.bxDisplay.Name = "bxDisplay";
            this.bxDisplay.Size = new System.Drawing.Size(175, 41);
            this.bxDisplay.TabIndex = 20;
            this.bxDisplay.TabStop = false;
            this.bxDisplay.Text = "Output Display";
            // 
            // rbFraction
            // 
            this.rbFraction.AutoSize = true;
            this.rbFraction.Location = new System.Drawing.Point(87, 18);
            this.rbFraction.Name = "rbFraction";
            this.rbFraction.Size = new System.Drawing.Size(77, 17);
            this.rbFraction.TabIndex = 3;
            this.rbFraction.Text = "Fractions";
            this.rbFraction.UseVisualStyleBackColor = true;
            // 
            // rbDecimal
            // 
            this.rbDecimal.AutoSize = true;
            this.rbDecimal.Checked = true;
            this.rbDecimal.Location = new System.Drawing.Point(7, 18);
            this.rbDecimal.Name = "rbDecimal";
            this.rbDecimal.Size = new System.Drawing.Size(76, 17);
            this.rbDecimal.TabIndex = 2;
            this.rbDecimal.TabStop = true;
            this.rbDecimal.Text = "Decimals";
            this.rbDecimal.UseVisualStyleBackColor = true;
            // 
            // txtOversize
            // 
            this.txtOversize.Location = new System.Drawing.Point(117, 182);
            this.txtOversize.Name = "txtOversize";
            this.txtOversize.Size = new System.Drawing.Size(89, 20);
            this.txtOversize.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Fret Oversize:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBaseWidth);
            this.groupBox1.Controls.Add(this.txtBoardLength);
            this.groupBox1.Controls.Add(this.txtNutWidth);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(224, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 109);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fingerboard";
            // 
            // txtBaseWidth
            // 
            this.txtBaseWidth.Location = new System.Drawing.Point(115, 76);
            this.txtBaseWidth.Name = "txtBaseWidth";
            this.txtBaseWidth.Size = new System.Drawing.Size(90, 20);
            this.txtBaseWidth.TabIndex = 8;
            this.txtBaseWidth.Leave += new System.EventHandler(this.txtBaseWidth_Leave);
            // 
            // txtBoardLength
            // 
            this.txtBoardLength.Location = new System.Drawing.Point(115, 48);
            this.txtBoardLength.Name = "txtBoardLength";
            this.txtBoardLength.Size = new System.Drawing.Size(90, 20);
            this.txtBoardLength.TabIndex = 7;
            this.txtBoardLength.Leave += new System.EventHandler(this.txtBoardLength_Leave);
            // 
            // txtNutWidth
            // 
            this.txtNutWidth.Location = new System.Drawing.Point(115, 20);
            this.txtNutWidth.Name = "txtNutWidth";
            this.txtNutWidth.Size = new System.Drawing.Size(90, 20);
            this.txtNutWidth.TabIndex = 6;
            this.txtNutWidth.Leave += new System.EventHandler(this.txtNutWidth_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Width at Base:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Length:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Width at Nut:";
            // 
            // bxDulcimer
            // 
            this.bxDulcimer.Controls.Add(this.chkFourHalf);
            this.bxDulcimer.Controls.Add(this.chkDulcChromatic);
            this.bxDulcimer.Controls.Add(this.chkSixHalf);
            this.bxDulcimer.Controls.Add(this.chkOneHalf);
            this.bxDulcimer.Enabled = false;
            this.bxDulcimer.Location = new System.Drawing.Point(98, 217);
            this.bxDulcimer.Name = "bxDulcimer";
            this.bxDulcimer.Size = new System.Drawing.Size(153, 113);
            this.bxDulcimer.TabIndex = 17;
            this.bxDulcimer.TabStop = false;
            this.bxDulcimer.Text = "Dulcimer Options";
            this.bxDulcimer.Visible = false;
            // 
            // chkFourHalf
            // 
            this.chkFourHalf.AutoSize = true;
            this.chkFourHalf.Location = new System.Drawing.Point(7, 42);
            this.chkFourHalf.Name = "chkFourHalf";
            this.chkFourHalf.Size = new System.Drawing.Size(135, 17);
            this.chkFourHalf.TabIndex = 12;
            this.chkFourHalf.Text = "Four and a half fret";
            this.chkFourHalf.UseVisualStyleBackColor = true;
            this.chkFourHalf.CheckedChanged += new System.EventHandler(this.chkFourHalf_CheckedChanged);
            // 
            // chkDulcChromatic
            // 
            this.chkDulcChromatic.AutoSize = true;
            this.chkDulcChromatic.Location = new System.Drawing.Point(6, 86);
            this.chkDulcChromatic.Name = "chkDulcChromatic";
            this.chkDulcChromatic.Size = new System.Drawing.Size(82, 17);
            this.chkDulcChromatic.TabIndex = 14;
            this.chkDulcChromatic.Text = "Chromatic";
            this.chkDulcChromatic.UseVisualStyleBackColor = true;
            this.chkDulcChromatic.CheckedChanged += new System.EventHandler(this.chkDulcChromatic_CheckedChanged);
            // 
            // chkSixHalf
            // 
            this.chkSixHalf.AutoSize = true;
            this.chkSixHalf.Location = new System.Drawing.Point(7, 64);
            this.chkSixHalf.Name = "chkSixHalf";
            this.chkSixHalf.Size = new System.Drawing.Size(127, 17);
            this.chkSixHalf.TabIndex = 13;
            this.chkSixHalf.Text = "Six and a half fret";
            this.chkSixHalf.UseVisualStyleBackColor = true;
            this.chkSixHalf.CheckedChanged += new System.EventHandler(this.chkSixHalf_CheckedChanged);
            // 
            // chkOneHalf
            // 
            this.chkOneHalf.AutoSize = true;
            this.chkOneHalf.Location = new System.Drawing.Point(7, 20);
            this.chkOneHalf.Name = "chkOneHalf";
            this.chkOneHalf.Size = new System.Drawing.Size(133, 17);
            this.chkOneHalf.TabIndex = 11;
            this.chkOneHalf.Text = "One and a half fret";
            this.chkOneHalf.UseVisualStyleBackColor = true;
            this.chkOneHalf.CheckedChanged += new System.EventHandler(this.chkOneHalf_CheckedChanged);
            // 
            // chkDulcimer
            // 
            this.chkDulcimer.AutoSize = true;
            this.chkDulcimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDulcimer.Location = new System.Drawing.Point(9, 217);
            this.chkDulcimer.Name = "chkDulcimer";
            this.chkDulcimer.Size = new System.Drawing.Size(75, 17);
            this.chkDulcimer.TabIndex = 10;
            this.chkDulcimer.Text = "Dulcimer";
            this.chkDulcimer.UseVisualStyleBackColor = true;
            this.chkDulcimer.CheckedChanged += new System.EventHandler(this.chkDulcimer_CheckedChanged_1);
            // 
            // txtFretCount
            // 
            this.txtFretCount.Location = new System.Drawing.Point(117, 148);
            this.txtFretCount.Name = "txtFretCount";
            this.txtFretCount.Size = new System.Drawing.Size(89, 20);
            this.txtFretCount.TabIndex = 5;
            this.txtFretCount.Leave += new System.EventHandler(this.txtFretCount_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Number of Frets:";
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(298, 346);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(72, 28);
            this.btnCalc.TabIndex = 15;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(376, 346);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 28);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bxUnits
            // 
            this.bxUnits.Controls.Add(this.rbCentimeters);
            this.bxUnits.Controls.Add(this.rbInches);
            this.bxUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxUnits.Location = new System.Drawing.Point(11, 14);
            this.bxUnits.Name = "bxUnits";
            this.bxUnits.Size = new System.Drawing.Size(143, 41);
            this.bxUnits.TabIndex = 11;
            this.bxUnits.TabStop = false;
            this.bxUnits.Text = "Units";
            // 
            // rbCentimeters
            // 
            this.rbCentimeters.AutoSize = true;
            this.rbCentimeters.Location = new System.Drawing.Point(87, 18);
            this.rbCentimeters.Name = "rbCentimeters";
            this.rbCentimeters.Size = new System.Drawing.Size(42, 17);
            this.rbCentimeters.TabIndex = 3;
            this.rbCentimeters.Text = "Cm";
            this.rbCentimeters.UseVisualStyleBackColor = true;
            this.rbCentimeters.CheckedChanged += new System.EventHandler(this.rbCentimeters_CheckedChanged);
            // 
            // rbInches
            // 
            this.rbInches.AutoSize = true;
            this.rbInches.Checked = true;
            this.rbInches.Location = new System.Drawing.Point(7, 18);
            this.rbInches.Name = "rbInches";
            this.rbInches.Size = new System.Drawing.Size(63, 17);
            this.rbInches.TabIndex = 2;
            this.rbInches.TabStop = true;
            this.rbInches.Text = "Inches";
            this.rbInches.UseVisualStyleBackColor = true;
            this.rbInches.CheckedChanged += new System.EventHandler(this.rbInches_CheckedChanged);
            // 
            // txtScaleLength
            // 
            this.txtScaleLength.Location = new System.Drawing.Point(117, 108);
            this.txtScaleLength.Name = "txtScaleLength";
            this.txtScaleLength.Size = new System.Drawing.Size(89, 20);
            this.txtScaleLength.TabIndex = 4;
            this.txtScaleLength.Leave += new System.EventHandler(this.txtScaleLength_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Scale Length:";
            // 
            // tabCuts
            // 
            this.tabCuts.Controls.Add(this.lblCut2);
            this.tabCuts.Controls.Add(this.lblCut1);
            this.tabCuts.Controls.Add(this.lstCuts);
            this.tabCuts.Location = new System.Drawing.Point(4, 22);
            this.tabCuts.Name = "tabCuts";
            this.tabCuts.Padding = new System.Windows.Forms.Padding(3);
            this.tabCuts.Size = new System.Drawing.Size(465, 389);
            this.tabCuts.TabIndex = 1;
            this.tabCuts.Text = "Cut Locations";
            this.tabCuts.UseVisualStyleBackColor = true;
            // 
            // lblCut2
            // 
            this.lblCut2.AutoSize = true;
            this.lblCut2.Location = new System.Drawing.Point(6, 20);
            this.lblCut2.Name = "lblCut2";
            this.lblCut2.Size = new System.Drawing.Size(131, 13);
            this.lblCut2.TabIndex = 2;
            this.lblCut2.Text = "              Front of Nut";
            // 
            // lblCut1
            // 
            this.lblCut1.AutoSize = true;
            this.lblCut1.Location = new System.Drawing.Point(6, 3);
            this.lblCut1.Name = "lblCut1";
            this.lblCut1.Size = new System.Drawing.Size(161, 13);
            this.lblCut1.TabIndex = 1;
            this.lblCut1.Text = "Fret #      Cut Position from";
            // 
            // lstCuts
            // 
            this.lstCuts.FormattingEnabled = true;
            this.lstCuts.Location = new System.Drawing.Point(8, 41);
            this.lstCuts.Name = "lstCuts";
            this.lstCuts.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstCuts.Size = new System.Drawing.Size(440, 355);
            this.lstCuts.TabIndex = 0;
            // 
            // tabFrets
            // 
            this.tabFrets.Controls.Add(this.lblFret2);
            this.tabFrets.Controls.Add(this.lblFret1);
            this.tabFrets.Controls.Add(this.lstFretLengths);
            this.tabFrets.Location = new System.Drawing.Point(4, 22);
            this.tabFrets.Name = "tabFrets";
            this.tabFrets.Size = new System.Drawing.Size(465, 389);
            this.tabFrets.TabIndex = 2;
            this.tabFrets.Text = "Fret Lengths";
            this.tabFrets.UseVisualStyleBackColor = true;
            // 
            // lblFret2
            // 
            this.lblFret2.AutoSize = true;
            this.lblFret2.Location = new System.Drawing.Point(6, 20);
            this.lblFret2.Name = "lblFret2";
            this.lblFret2.Size = new System.Drawing.Size(103, 13);
            this.lblFret2.TabIndex = 5;
            this.lblFret2.Text = "            Measure";
            // 
            // lblFret1
            // 
            this.lblFret1.AutoSize = true;
            this.lblFret1.Location = new System.Drawing.Point(6, 3);
            this.lblFret1.Name = "lblFret1";
            this.lblFret1.Size = new System.Drawing.Size(130, 13);
            this.lblFret1.TabIndex = 4;
            this.lblFret1.Text = "Fret #      Fret Length";
            // 
            // lstFretLengths
            // 
            this.lstFretLengths.FormattingEnabled = true;
            this.lstFretLengths.Location = new System.Drawing.Point(8, 41);
            this.lstFretLengths.Name = "lstFretLengths";
            this.lstFretLengths.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstFretLengths.Size = new System.Drawing.Size(438, 355);
            this.lstFretLengths.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Instrument Description:";
            // 
            // txtInstrumentDesc
            // 
            this.txtInstrumentDesc.Location = new System.Drawing.Point(161, 8);
            this.txtInstrumentDesc.Name = "txtInstrumentDesc";
            this.txtInstrumentDesc.Size = new System.Drawing.Size(292, 20);
            this.txtInstrumentDesc.TabIndex = 1;
            this.txtInstrumentDesc.Leave += new System.EventHandler(this.txtInstrumentDesc_Leave);
            // 
            // ScaleCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 458);
            this.Controls.Add(this.txtInstrumentDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabMain);
            this.Name = "ScaleCalculator";
            this.Text = "Scale Calculator";
            this.Load += new System.EventHandler(this.ScaleCalculator_Load);
            this.tabMain.ResumeLayout(false);
            this.tabInstruments.ResumeLayout(false);
            this.tabParms.ResumeLayout(false);
            this.tabParms.PerformLayout();
            this.bxDisplay.ResumeLayout(false);
            this.bxDisplay.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.bxDulcimer.ResumeLayout(false);
            this.bxDulcimer.PerformLayout();
            this.bxUnits.ResumeLayout(false);
            this.bxUnits.PerformLayout();
            this.tabCuts.ResumeLayout(false);
            this.tabCuts.PerformLayout();
            this.tabFrets.ResumeLayout(false);
            this.tabFrets.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabParms;
        private System.Windows.Forms.GroupBox bxDulcimer;
        private System.Windows.Forms.CheckBox chkDulcChromatic;
        private System.Windows.Forms.CheckBox chkSixHalf;
        private System.Windows.Forms.CheckBox chkOneHalf;
        private System.Windows.Forms.CheckBox chkDulcimer;
        private System.Windows.Forms.TextBox txtFretCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox bxUnits;
        private System.Windows.Forms.RadioButton rbCentimeters;
        private System.Windows.Forms.RadioButton rbInches;
        private System.Windows.Forms.TextBox txtScaleLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabCuts;
        private System.Windows.Forms.Label lblCut1;
        private System.Windows.Forms.ListBox lstCuts;
        private System.Windows.Forms.TabPage tabFrets;
        private System.Windows.Forms.Label lblFret1;
        private System.Windows.Forms.ListBox lstFretLengths;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBaseWidth;
        private System.Windows.Forms.TextBox txtBoardLength;
        private System.Windows.Forms.TextBox txtNutWidth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCut2;
        private System.Windows.Forms.TextBox txtOversize;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblFret2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInstrumentDesc;
        private System.Windows.Forms.CheckBox chkFourHalf;
        private System.Windows.Forms.GroupBox bxDisplay;
        private System.Windows.Forms.RadioButton rbFraction;
        private System.Windows.Forms.RadioButton rbDecimal;
        private System.Windows.Forms.TabPage tabInstruments;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstInstruments;

    }
}

