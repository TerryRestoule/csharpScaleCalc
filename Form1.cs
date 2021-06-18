using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace ScaleCalc
{
    public partial class ScaleCalculator : Form
    {
        private static bool bLoading = false;

        string msAppPath = Path.GetDirectoryName(Application.ExecutablePath);

        public ScaleCalculator()
        {
            InitializeComponent();
        }

        private void LoadFileList()
        {
            string sFilename = "", sInstDesc, sDisplayOutType, sFileListItem;
            int iStartExt;

            DirectoryInfo dInfo = new DirectoryInfo(msAppPath);
            FileInfo[] fInfo = dInfo.GetFiles(".xml");

            lstInstruments.Items.Clear();

            foreach (FileInfo fileinf in fInfo)
            {
                sFilename = fileinf.Name;

                if (sFilename.Length > 6)
                {
                    iStartExt = sFilename.IndexOf(".xml");
                    sDisplayOutType = sFilename.Substring(iStartExt - 2, 2);

                    if (sDisplayOutType.ToUpper() == "IN" || sDisplayOutType.ToUpper() == "FR" || sDisplayOutType.ToUpper() == "CM")
                    {
                        sInstDesc = sFilename.Substring(0, iStartExt - 3);

                        switch (sDisplayOutType.ToUpper())
                        {
                            case "IN":
                                sFileListItem = sInstDesc + " - " + "Inches";
                                lstInstruments.Items.Add(sFileListItem);
                                break;
                            case "FR":
                                sFileListItem = sInstDesc + " - " + "Fractions";
                                lstInstruments.Items.Add(sFileListItem);
                                break;
                            case "CM":
                                sFileListItem = sInstDesc + " - " + "Metric";
                                lstInstruments.Items.Add(sFileListItem);
                                break;
                        }
                    }

                }
            }
        }

        private void ScaleCalculator_Load(object sender, EventArgs e)
        {
            bLoading = true;

            CalcData.InitializeScaleCalculationsOutputFile(msAppPath);

            CalcData.LoadFretPercents();
            CalcData.LoadDulcimerNumbers();
            CalcData.LoadFractions();

            LoadFileList();

            CalcData.bInches = true;
            
            lblCut1.Text = CalcData.SetColumnLabels(true, rbInches.Checked, 1);
            lblCut2.Text = CalcData.SetColumnLabels(true, rbInches.Checked, 2);
            lblFret1.Text = CalcData.SetColumnLabels(false, rbInches.Checked, 1);
            lblFret2.Text = CalcData.SetColumnLabels(false, rbInches.Checked, 2);

            txtOversize.Text = "0.25";
            CalcData.dbFretOversize = 0.25;

            bLoading = false;
        }

        private void ClearParametersAndResults()
        {
            rbInches.Checked = true;

            txtScaleLength.Text = "";
            txtFretCount.Text = "";
            txtNutWidth.Text = "";
            txtBoardLength.Text = "";
            txtBaseWidth.Text = "";

            chkDulcimer.Checked = false;
            chkOneHalf.Checked = false;
            chkSixHalf.Checked = false;
            chkDulcChromatic.Checked = false;

            lstCuts.Items.Clear();
            lstFretLengths.Items.Clear();

            txtOversize.Text = "0.25";
        }

        private void chkDulcimer_CheckedChanged(object sender, EventArgs e)
        {
            if (!bLoading)
            {
                CalcData.blDulcimer = chkDulcimer.Checked;

                if (chkDulcimer.Checked)
                    bxDulcimer.Visible = true;
                else
                    bxDulcimer.Visible = false;
            }
        }

        private void rbCentimeters_CheckedChanged(object sender, EventArgs e)
        {
            string sScaleLength, sFretCount, sNutWidth, sBoardLength, sBaseWidth, sOversize;

            if (rbCentimeters.Checked)
                if (bxDisplay.Visible)
                    bxDisplay.Visible = false;

            sScaleLength = txtScaleLength.Text;
            sFretCount = txtFretCount.Text;
            sNutWidth = txtNutWidth.Text;
            sBoardLength = txtBoardLength.Text;
            sBaseWidth = txtBaseWidth.Text;
            sOversize = txtOversize.Text;

            if (rbCentimeters.Checked)
                CalcData.ConvertToMetric(ref sScaleLength, ref sFretCount, ref sNutWidth, ref sBoardLength, ref sBaseWidth, ref sOversize);
            else
                CalcData.ConvertToImperial(ref sScaleLength, ref sFretCount, ref sNutWidth, ref sBoardLength, ref sBaseWidth, ref sOversize);

            txtScaleLength.Text = sScaleLength;
            txtFretCount.Text = sFretCount;
            txtNutWidth.Text = sNutWidth;
            txtBoardLength.Text = sBoardLength;
            txtBaseWidth.Text = sBaseWidth;
            txtOversize.Text = sOversize;

            SetOutputListHeadings();

            ReloadOutputLists();
        }

        private void rbInches_CheckedChanged(object sender, EventArgs e)
        {
            string sScaleLength, sFretCount, sNutWidth, sBoardLength, sBaseWidth, sOversize;

            if (rbInches.Checked)
                if (!bxDisplay.Visible)
                    bxDisplay.Visible = true;

            sScaleLength = txtScaleLength.Text;
            sFretCount = txtFretCount.Text;
            sNutWidth = txtNutWidth.Text;
            sBoardLength = txtBoardLength.Text;
            sBaseWidth = txtBaseWidth.Text;
            sOversize = txtOversize.Text;

            if (rbInches.Checked)
                CalcData.ConvertToImperial(ref sScaleLength, ref sFretCount, ref sNutWidth, ref sBoardLength, ref sBaseWidth, ref sOversize);
            else
                CalcData.ConvertToMetric(ref sScaleLength, ref sFretCount, ref sNutWidth, ref sBoardLength, ref sBaseWidth, ref sOversize);

            txtScaleLength.Text = sScaleLength;
            txtFretCount.Text = sFretCount;
            txtNutWidth.Text = sNutWidth;
            txtBoardLength.Text = sBoardLength;
            txtBaseWidth.Text = sBaseWidth;
            txtOversize.Text = sOversize;

            SetOutputListHeadings();

            ReloadOutputLists();
        }

        private void SetOutputListHeadings()
        {
            lblCut1.Text = CalcData.SetColumnLabels(true, rbInches.Checked, 1);
            lblCut2.Text = CalcData.SetColumnLabels(true, rbInches.Checked, 2);
            lblFret1.Text = CalcData.SetColumnLabels(false, rbInches.Checked, 1);
            lblFret2.Text = CalcData.SetColumnLabels(false, rbInches.Checked, 2);
        }

        private void ReloadOutputLists()
        {
            int i;

            if (CalcData.CutLocations != null)
            {
                lstCuts.Items.Clear();

                for (i = 1; i <= CalcData.CutLocations.GetUpperBound(0); i++)
                    lstCuts.Items.Add(CalcData.FormatCutLocationDescription(i));
            }

            if (CalcData.FretLengths != null)
            {
                lstFretLengths.Items.Clear();

                for (i = 1; i <= CalcData.FretLengths.GetUpperBound(0); i++)
                    lstFretLengths.Items.Add(CalcData.FormatFretLengthDescription(i));
            }
        }

        private void chkOneHalf_CheckedChanged(object sender, EventArgs e)
        {
            if (!bLoading)
                CalcData.blDulcOneHalf = chkOneHalf.Checked;
        }

        private void chkFourHalf_CheckedChanged(object sender, EventArgs e)
        {
            if (!bLoading)
                CalcData.blDulcFourHalf = chkFourHalf.Checked;
        }

        private void chkSixHalf_CheckedChanged(object sender, EventArgs e)
        {
            if (!bLoading)
                CalcData.blDulcSixHalf = chkSixHalf.Checked;
        }

        private void chkDulcChromatic_CheckedChanged(object sender, EventArgs e)
        {
            if (!bLoading)
                CalcData.blDulcChrome = chkDulcChromatic.Checked;
        }

        private void chkDulcimer_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!bLoading)
            {
                if (chkDulcimer.Checked)
                {
                    bxDulcimer.Visible = true;
                    bxDulcimer.Enabled = true;
                }
                else
                {
                    bxDulcimer.Visible = false;
                    bxDulcimer.Enabled = false;
                }
            }
        }

        private void txtFretCount_Leave(object sender, EventArgs e)
        {
            if (!bLoading)
            {
                if (txtFretCount.Text != "")
                {
                    int iFretCount = 0;
                    Double dbBoardLength = 0, dbLastCut = 0;
                    bool bIsNumber = false;

                    bIsNumber = int.TryParse(txtFretCount.Text, out iFretCount);

                    if (bIsNumber)
                    {
                        if (txtBoardLength.Text != "")
                        {
                            bIsNumber = Double.TryParse(txtBoardLength.Text, out dbBoardLength);

                            if (bIsNumber)
                            {
                                dbLastCut = CalcData.CalculateLastFretCut(iFretCount);

                                if (dbLastCut > dbBoardLength)
                                {
                                    MessageBox.Show("Fingerboard is not long enough for that many frets", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    txtFretCount.Focus();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Fret Count must be numeric", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtFretCount.Focus();
                    }
                }
            }
        }

        private void txtBoardLength_Leave(object sender, EventArgs e)
        {
            if (!bLoading)
            {
                if (txtBoardLength.Text != "")
                {
                    bool bIsNumber = false;

                    bIsNumber = CalcData.TestBoardLength(txtBoardLength.Text);

                    if (!bIsNumber)
                    {
                        MessageBox.Show("Board Length must be numeric", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtBoardLength.Focus();
                    }
                }
            }
        }

        private void txtNutWidth_Leave(object sender, EventArgs e)
        {
            if (!bLoading)
            {
                if (txtNutWidth.Text != "")
                {
                    bool bIsNumber = false;

                    bIsNumber = CalcData.TestNutWidth(txtNutWidth.Text);

                    if (!bIsNumber)
                    {
                        MessageBox.Show("Nut Width must be numeric", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNutWidth.Focus();
                    }
                }
            }
        }

        private void txtBaseWidth_Leave(object sender, EventArgs e)
        {
            if (!bLoading)
            {
                if (txtBaseWidth.Text != "")
                {
                    bool bIsNumber = false;

                    bIsNumber = CalcData.TestFingerboardBaseWidth(txtBaseWidth.Text);

                    if (!bIsNumber)
                    {
                        MessageBox.Show("Fingerboard Base Width must be numeric", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtBaseWidth.Focus();
                    }
                }
            }
        }

        private void txtScaleLength_Leave(object sender, EventArgs e)
        {
            if (!bLoading)
            {
                if (txtScaleLength.Text != "")
                {
                    bool bIsNumber = false;

                    bIsNumber = CalcData.TestScaleLength(txtScaleLength.Text);

                    if (!bIsNumber)
                    {
                        MessageBox.Show("Scale Length must be numeric", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtScaleLength.Focus();
                    }
                }
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            float ScaleLen = 0;
            int i, iFrets = 0;

            if (!bLoading)
                if (btnCalc.Text == "Calculate")
                {
                    if (txtNutWidth.Text == "" || txtBoardLength.Text == "" || txtBaseWidth.Text == "")
                    {
                        MessageBox.Show("Fingerboard Measurements Must Be Entered", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNutWidth.Focus();
                    }
                    else
                    {
                        if (float.TryParse(txtScaleLength.Text, out ScaleLen))
                            if (int.TryParse(txtFretCount.Text, out iFrets))
                            {
                                CalcData.CalculateCutPositions(ScaleLen, iFrets);

                                lstCuts.Items.Clear();
                                lstFretLengths.Items.Clear();

                                for (i = 1; i <= iFrets; i++)
                                {
                                    if (CalcData.CutLocations[i] > 0)
                                    {
                                        lstCuts.Items.Add(i + "     " + Convert.ToString(CalcData.CutLocations[i]));
                                        lstFretLengths.Items.Add(i + "     " + Convert.ToString(CalcData.FretLengths[i]));
                                    }
                                }

                                CalcData.OutputCalculations(ScaleLen, iFrets, msAppPath);
                            }
                            else
                            {
                                MessageBox.Show("Number of Frets must be specified", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                txtFretCount.Focus();
                            }
                        else
                        {
                            MessageBox.Show("Scale Length must be specified", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtScaleLength.Focus();
                        }
                    }

                    btnCalc.Text = "Clear";

                    tabMain.SelectTab("tabCuts");
                }
                else
                    if (btnCalc.Text == "Clear")
                    {
                        ClearParametersAndResults();
                        btnCalc.Text = "Calculate";
                    }
        }

        private void txtOversize_Leave(object sender, EventArgs e)
        {
            if (!bLoading)
            {
                if (txtOversize.Text != "")
                {
                    bool bIsNumber = false;

                    bIsNumber = CalcData.TestFretOversize(txtOversize.Text);
                    if (!bIsNumber)
                    {
                        MessageBox.Show("Amount Oversize must be numeric", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtOversize.Focus();
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtInstrumentDesc_Leave(object sender, EventArgs e)
        {
            if (!bLoading)
                if (txtInstrumentDesc.Text != "")
                    CalcData.sInstrumentDesc = txtInstrumentDesc.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!bLoading)
            {
                ClearParametersAndResults();
                tabMain.SelectTab("tabParms");
            }
        }

        private string GetSelectedInstrumentFile(string InSelectedInstrument)
        {
            string sOutFileName = "";
            int iDashPos = 0;

            if (InSelectedInstrument.IndexOf(" - ") > 0)
            {
                iDashPos = InSelectedInstrument.IndexOf(" - ");
                sOutFileName = InSelectedInstrument.Substring(0, iDashPos - 1);

                if (InSelectedInstrument.EndsWith("Inches"))
                    sOutFileName = sOutFileName + "IN";
                else
                    if (InSelectedInstrument.EndsWith("Fractions"))
                        sOutFileName = sOutFileName + "FR";
                    else
                        if (InSelectedInstrument.EndsWith("Metric"))
                            sOutFileName = sOutFileName + "CM";

                sOutFileName = sOutFileName + ".xml";
            }

            return sOutFileName;
        }

        private void LoadInstrumentParmsFromFile(string InstrumentFileName)
        {
            StreamReader datafile = new StreamReader(msAppPath + "\\" + InstrumentFileName);
            string sInstrumentData = "", sUnits = "";

            sInstrumentData = datafile.ReadToEnd();

            txtInstrumentDesc.Text = CalcData.GetXMLElementValue(sInstrumentData, "Description");
            sUnits = CalcData.GetXMLElementValue(sInstrumentData, "Units");

            switch (sUnits)
            {
                case "Inches":
                    {
                        rbInches.Checked = true;
                        rbDecimal.Checked = true;

                        break;
                    }
                case "Fractions":
                    {
                        rbInches.Checked = true;
                        rbFraction.Checked = true;
                        break;
                    }
                case "Metric":
                    {
                        rbCentimeters.Checked = true;
                        break;
                    }
            }

            txtScaleLength.Text = CalcData.GetXMLElementValue(sInstrumentData, "ScaleLength");
            txtFretCount.Text = CalcData.GetXMLElementValue(sInstrumentData, "FretCount");
            txtOversize.Text = CalcData.GetXMLElementValue(sInstrumentData, "FretOversize");
            txtNutWidth.Text = CalcData.GetXMLElementValue(sInstrumentData, "NutWidth");
            txtBoardLength.Text = CalcData.GetXMLElementValue(sInstrumentData, "BoardLength");
            txtBaseWidth.Text = CalcData.GetXMLElementValue(sInstrumentData, "BaseWidth");

            datafile.Close();
        }

        private void lstInstruments_DoubleClick(object sender, EventArgs e)
        {
            string sIFileName = "";

            ClearParametersAndResults();

            sIFileName = GetSelectedInstrumentFile(lstInstruments.SelectedValue.ToString());

            if (sIFileName != "")
            {
                LoadInstrumentParmsFromFile(sIFileName);
                tabMain.SelectTab("tabParms");
            }
        }

    }
}
