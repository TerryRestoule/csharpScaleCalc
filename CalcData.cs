using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScaleCalc
{
    class CalcData
    {
        public struct FractionConvert
        {
            public string Fraction;
            public Double FractionDecValue;
        }

        public struct FretWireLength
        {
            public Double WireInches;
            public Double WireCentimeters;
        }
        
        public static FretWireLength WireLengths = new FretWireLength();

        public static FractionConvert[] arrFractions = new FractionConvert[65];
        public static Double[] FretPercents = null, DulcimerFretNumbers = null;

        public static Double[] CutLocations = null, FretLengths = null;
        public static bool[] FretIsAssigned = null;

        public static string sInstrumentDesc = "";

        public static Double dbScaleLen, dbNutWidth = 0, dbBaseWidth = 0, dbBoardLength = 0, dbFretOversize = 0, dbTotalActualFret, dbTotalOversizeFret;
        public static bool blDulcimer = false, blDulcOneHalf = false, blDulcFourHalf = false, blDulcSixHalf = false, blDulcChrome = false;
        public static bool bInches = true;

        private const Double db128th = 0.0078125;

        private static StreamWriter mobjWriter;


        public static void LoadFractions()
        {
            arrFractions[1].Fraction = "1/64";   arrFractions[1].FractionDecValue = 0.015625;
            arrFractions[2].Fraction = "1/32";   arrFractions[2].FractionDecValue = 0.03125;
            arrFractions[3].Fraction = "3/64";   arrFractions[3].FractionDecValue = 0.046875;
            arrFractions[4].Fraction = "1/16";   arrFractions[4].FractionDecValue = 0.0625;
            arrFractions[5].Fraction = "5/64";   arrFractions[5].FractionDecValue = 0.078125;
            arrFractions[6].Fraction = "3/32";   arrFractions[6].FractionDecValue = 0.09375;
            arrFractions[7].Fraction = "7/64";   arrFractions[7].FractionDecValue = 0.109375;
            arrFractions[8].Fraction = "1/8";    arrFractions[8].FractionDecValue = 0.125;
            arrFractions[9].Fraction = "9/64";   arrFractions[9].FractionDecValue = 0.140625;
            arrFractions[10].Fraction = "5/32";  arrFractions[10].FractionDecValue = 0.15625;
            arrFractions[11].Fraction = "11/64"; arrFractions[11].FractionDecValue = 0.171875;
            arrFractions[12].Fraction = "3/16";  arrFractions[12].FractionDecValue = 0.1875;
            arrFractions[13].Fraction = "13/64"; arrFractions[13].FractionDecValue = 0.203125;
            arrFractions[14].Fraction = "7/32";  arrFractions[14].FractionDecValue = 0.21875;
            arrFractions[15].Fraction = "15/64"; arrFractions[15].FractionDecValue = 0.234375;
            arrFractions[16].Fraction = "1/4";   arrFractions[16].FractionDecValue = 0.25;
            arrFractions[17].Fraction = "17/64"; arrFractions[17].FractionDecValue = 0.265625;
            arrFractions[18].Fraction = "9/32";  arrFractions[18].FractionDecValue = 0.28125;
            arrFractions[19].Fraction = "19/64"; arrFractions[19].FractionDecValue = 0.296875;
            arrFractions[20].Fraction = "5/16";  arrFractions[20].FractionDecValue = 0.3125;
            arrFractions[21].Fraction = "21/64"; arrFractions[21].FractionDecValue = 0.328125;
            arrFractions[22].Fraction = "11/32"; arrFractions[22].FractionDecValue = 0.34375;
            arrFractions[23].Fraction = "23/64"; arrFractions[23].FractionDecValue = 0.359375;
            arrFractions[24].Fraction = "3/8";   arrFractions[24].FractionDecValue = 0.375;
            arrFractions[25].Fraction = "25/64"; arrFractions[25].FractionDecValue = 0.390625;
            arrFractions[26].Fraction = "13/32"; arrFractions[26].FractionDecValue = 0.40625;
            arrFractions[27].Fraction = "27/64"; arrFractions[27].FractionDecValue = 0.421875;
            arrFractions[28].Fraction = "7/16";  arrFractions[28].FractionDecValue = 0.4375;
            arrFractions[29].Fraction = "29/64"; arrFractions[29].FractionDecValue = 0.453125;
            arrFractions[30].Fraction = "15/32"; arrFractions[30].FractionDecValue = 0.46875;
            arrFractions[31].Fraction = "31/64"; arrFractions[31].FractionDecValue = 0.484375;
            arrFractions[32].Fraction = "1/2";   arrFractions[32].FractionDecValue = 0.5;
            arrFractions[33].Fraction = "33/64"; arrFractions[33].FractionDecValue = 0.515625;
            arrFractions[34].Fraction = "17/32"; arrFractions[34].FractionDecValue = 0.53125;
            arrFractions[35].Fraction = "35/64"; arrFractions[35].FractionDecValue = 0.546875;
            arrFractions[36].Fraction = "9/16";  arrFractions[36].FractionDecValue = 0.5625;
            arrFractions[37].Fraction = "37/64"; arrFractions[37].FractionDecValue = 0.578125;
            arrFractions[38].Fraction = "19/32"; arrFractions[38].FractionDecValue = 0.59375;
            arrFractions[39].Fraction = "39/64"; arrFractions[39].FractionDecValue = 0.609375;
            arrFractions[40].Fraction = "5/8";   arrFractions[40].FractionDecValue = 0.625;
            arrFractions[41].Fraction = "41/64"; arrFractions[41].FractionDecValue = 0.640625;
            arrFractions[42].Fraction = "21/32"; arrFractions[42].FractionDecValue = 0.65625;
            arrFractions[43].Fraction = "43/64"; arrFractions[43].FractionDecValue = 0.671875;
            arrFractions[44].Fraction = "11/16"; arrFractions[44].FractionDecValue = 0.6875;
            arrFractions[45].Fraction = "45/64"; arrFractions[45].FractionDecValue = 0.703125;
            arrFractions[46].Fraction = "23/32"; arrFractions[46].FractionDecValue = 0.71875;
            arrFractions[47].Fraction = "47/64"; arrFractions[47].FractionDecValue = 0.734375;
            arrFractions[48].Fraction = "3/4";   arrFractions[48].FractionDecValue = 0.75;
            arrFractions[49].Fraction = "49/64"; arrFractions[49].FractionDecValue = 0.765625;
            arrFractions[50].Fraction = "25/32"; arrFractions[50].FractionDecValue = 0.78125;
            arrFractions[51].Fraction = "51/64"; arrFractions[51].FractionDecValue = 0.796875;
            arrFractions[52].Fraction = "13/16"; arrFractions[52].FractionDecValue = 0.8125;
            arrFractions[53].Fraction = "53/64"; arrFractions[53].FractionDecValue = 0.828125;
            arrFractions[54].Fraction = "27/32"; arrFractions[54].FractionDecValue = 0.84375;
            arrFractions[55].Fraction = "55/64"; arrFractions[55].FractionDecValue = 0.859375;
            arrFractions[56].Fraction = "7/8";   arrFractions[56].FractionDecValue = 0.875;
            arrFractions[57].Fraction = "57/64"; arrFractions[57].FractionDecValue = 0.890625;
            arrFractions[58].Fraction = "29/32"; arrFractions[58].FractionDecValue = 0.90625;
            arrFractions[59].Fraction = "59/64"; arrFractions[59].FractionDecValue = 0.921875;
            arrFractions[60].Fraction = "15/16"; arrFractions[60].FractionDecValue = 0.9375;
            arrFractions[61].Fraction = "61/64"; arrFractions[61].FractionDecValue = 0.953125;
            arrFractions[62].Fraction = "31/32"; arrFractions[62].FractionDecValue = 0.96875;
            arrFractions[63].Fraction = "63/64"; arrFractions[63].FractionDecValue = 0.984375;
            arrFractions[64].Fraction = "1"; arrFractions[63].FractionDecValue = 1;
        }

        public static void LoadWireLengths()
        {
            WireLengths.WireInches = 24;
            WireLengths.WireCentimeters = 60.96;
        }

        public static void LoadFretPercents()
        {
            FretPercents = new Double[13];
                                                /* Fret Position Constants */
                                                /* ----------------------- */
                                                /*
                                                 * Mine             Stewart MacDonald
                                                 * ----------       -----------------
                                                 *                                      */
            FretPercents[1] = 0.1112132F;       /* 0.1112132F       0.1122335F          */
            FretPercents[2] = 0.2179775F;       /* 0.2179775F       0.2182189F          */
            FretPercents[3] = 0.3170956F;       /* 0.3170956F       0.3181897F          */
            FretPercents[4] = 0.4112359F;       /* 0.4112359F       0.4126131F          */
            FretPercents[5] = 0.5011235F;       /* 0.5011235F       0.5016642F          */
            FretPercents[6] = 0.5836397F;       /* 0.5836397F       0.5858102F          */
            FretPercents[7] = 0.6636029F;       /* 0.6636029F       0.6651678F          */
            FretPercents[8] = 0.7393294F;       /* 0.7393294F       0.7400875F          */
            FretPercents[9] = 0.8089887F;       /* 0.8089887F       0.8108029F          */
            FretPercents[10] = 0.8775474F;      /* 0.8775474F       0.8775474F          */
            FretPercents[11] = 0.9402574F;      /* 0.9402574F       0.9405547F          */
            FretPercents[12] = 1;
        }

        public static void LoadDulcimerNumbers()
        {
            DulcimerFretNumbers = new Double[13];

            DulcimerFretNumbers[1] = 0.5;
            DulcimerFretNumbers[2] = 1;
            DulcimerFretNumbers[3] = 1.5;
            DulcimerFretNumbers[4] = 2;
            DulcimerFretNumbers[5] = 3;
            DulcimerFretNumbers[6] = 4;
            DulcimerFretNumbers[7] = 4.5;
            DulcimerFretNumbers[8] = 5;
            DulcimerFretNumbers[9] = 6;
            DulcimerFretNumbers[10] = 6.5;
            DulcimerFretNumbers[11] = 7;
            DulcimerFretNumbers[12] = 8;
        }

        public static string SetColumnLabels(bool CutLabel, bool ImperialChecked, int HeadingLine)
        {
            string sOutLabel = "";

            if (CutLabel)
            {
                if (HeadingLine == 1)
                {
                    sOutLabel = "Fret #        Cut Position from";
                    if (ImperialChecked)
                        sOutLabel = sOutLabel + "        Tape";
                }
                else
                {
                    sOutLabel = "                Front of Nut";
                    if (ImperialChecked)
                        sOutLabel = sOutLabel + "        Measure";
                }
            }
            else
            {
                if (HeadingLine == 1)
                {
                    sOutLabel = "Fret #        Fret Length";
                    if (ImperialChecked)
                        sOutLabel = sOutLabel + "        Tape";
                    sOutLabel = sOutLabel + "        with Oversize";
                    if (ImperialChecked)
                        sOutLabel = sOutLabel + "        Tape";
                }
                else
                {
                    if (ImperialChecked)
                        sOutLabel = sOutLabel + "                                Measure                Measure";
                    else
                        sOutLabel = "";
                }
            }

            return sOutLabel;
        }

        public static bool TestScaleLength(string InScaleLength)
        {
            bool OutIsNumber = false;

            OutIsNumber = Double.TryParse(InScaleLength, out dbScaleLen);

            return OutIsNumber;
        }

        public static bool TestBoardLength(string InBoardLength)
        {
            bool OutIsNumber = false;

            OutIsNumber = Double.TryParse(InBoardLength, out dbBoardLength);

            return OutIsNumber;
        }

        public static bool TestNutWidth(string InNutWidth)
        {
            bool OutIsNumber = false;

            OutIsNumber = Double.TryParse(InNutWidth, out dbNutWidth);

            return OutIsNumber;
        }

        public static bool TestFingerboardBaseWidth(string InBaseWidth)
        {
            bool OutIsNumber = false;

            OutIsNumber = Double.TryParse(InBaseWidth, out dbBaseWidth);

            return OutIsNumber;
        }

        public static bool TestFretOversize(string InOversize)
        {
            bool OutIsNumber = false;

            OutIsNumber = Double.TryParse(InOversize, out dbFretOversize);

            return OutIsNumber;
        }

        public static void ClearDulcimerFrets(int iFrets)
        {
            int i;

            CutLocations[1] = 0;

            if (!blDulcOneHalf)
                CutLocations[3] = 0;

            CutLocations[6] = 0;
            CutLocations[8] = 0;

            if (!blDulcSixHalf)
                CutLocations[10] = 0;

            for (i = 13; i <= iFrets; i++)
            {
                if (i % 12 == 1 || i % 12 == 3 || i % 12 == 6 || i % 12 == 8 || i % 12 == 10)
                    CutLocations[i] = 0;
            }
        }

        public static void InitializeScaleCalculationsOutputFile(string InPath)
        {
            if (File.Exists(InPath + "\\ScaleCalculations.txt"))
                File.Delete(InPath + "\\ScaleCalculations.txt");

            mobjWriter = new StreamWriter(InPath + "\\ScaleCalculations.txt");
            mobjWriter.Close();
        }

        public static Double CalculateLastFretCut(int iLastFretNumber)
        {
            Double dbOutFretCutPosition = 0, dbFullOctaveCount = iLastFretNumber / 12;
            Double dbPrevOctave = dbScaleLen;

            int i, iOctaveCount = Convert.ToInt16(Math.Truncate(dbFullOctaveCount));

            for (i = 1; i <= iOctaveCount; i++)
            {
                dbPrevOctave = dbPrevOctave / 2;
                dbOutFretCutPosition = dbOutFretCutPosition + dbPrevOctave;
            }

            if (iLastFretNumber % 12 > 0)
            {
                dbPrevOctave = dbPrevOctave / 2;
                dbOutFretCutPosition = dbOutFretCutPosition + (dbPrevOctave * FretPercents[iLastFretNumber % 12]);
            }

            return dbOutFretCutPosition;
        }

        public static void CalculateCutPositions(float ScaleLen, int iFrets)
        {
            int i, CurrentOctaveFret = 12, OctaveCount = (iFrets / 12) + 1;
            Double BaseOctaveDistance = 0, CurrentOctaveLength = ScaleLen / 2;

            CutLocations = new Double[(OctaveCount * 12) + 1];
            FretLengths = new Double[(OctaveCount * 12) + 1];

            CutLocations[CurrentOctaveFret] = CurrentOctaveLength;

            for (i = 1; i <= iFrets; i++)
            {
                if (i % 12 == 0)
                {
                    CutLocations[i] = BaseOctaveDistance + CutLocations[CurrentOctaveFret] * FretPercents[12];
                    CurrentOctaveFret = CurrentOctaveFret + 12;
                    CurrentOctaveLength = CurrentOctaveLength / 2;
                    CutLocations[CurrentOctaveFret] = CurrentOctaveLength;
                    BaseOctaveDistance = CutLocations[i];
                }
                else
                    CutLocations[i] = BaseOctaveDistance + CutLocations[CurrentOctaveFret] * FretPercents[i % 12];

                FretLengths[i] = CalculateFretLength(i);
            }

            if (blDulcimer && !blDulcChrome)
                ClearDulcimerFrets(iFrets);
        }

        public static Double CalculateFretLength(int iFret)
        {
            Double dbLengthOut = 0;
            Double dbBaseDiff = 0, dbDiffPercent = 0;

            if (dbNutWidth == dbBaseWidth)
                dbLengthOut = dbNutWidth;
            else
            {
                dbBaseDiff = dbBaseWidth - dbNutWidth;

                if (CutLocations[iFret] != 0)
                {
                    dbDiffPercent = CutLocations[iFret] / dbBoardLength;
                    dbLengthOut = dbNutWidth + (dbBaseDiff * dbDiffPercent);
                }
            }

            return dbLengthOut;
        }

        public static void ConvertToMetric(ref string InScaleLen, ref string InFretCount, ref string InNutWidth, ref string InBoardLength, ref string InBaseWidth, ref string InFretOversize)
        {
            int i, iFrets;

            bInches = false;

            if (InScaleLen != "")
            {
                dbScaleLen = Convert.ToDouble(InScaleLen);
                dbScaleLen = dbScaleLen * 2.54;
                InScaleLen = Convert.ToString(dbScaleLen);
            }

            if (InNutWidth != "")
            {
                dbNutWidth = Convert.ToDouble(InNutWidth);
                dbNutWidth = dbNutWidth * 2.54;
                InNutWidth = Convert.ToString(dbNutWidth);
            }

            if (InBoardLength != "")
            {
                dbBoardLength = Convert.ToDouble(InBoardLength);
                dbBoardLength = dbBoardLength * 2.54;
                InBoardLength = Convert.ToString(dbBoardLength);
            }

            if (InBaseWidth != "")
            {
                dbBaseWidth = Convert.ToDouble(InBaseWidth);
                dbBaseWidth = dbBaseWidth * 2.54;
                InBaseWidth = Convert.ToString(dbBaseWidth);
            }

            if (InFretOversize != "")
            {
                dbFretOversize = Convert.ToDouble(InFretOversize);
                dbFretOversize = dbFretOversize * 2.54;
                InFretOversize = Convert.ToString(dbFretOversize);
            }

            if (InFretCount != "")
            {
                iFrets = Convert.ToInt32(InFretCount);

                if (CutLocations != null)
                    for (i = 1; i <= iFrets; i++)
                        CutLocations[i] = CutLocations[i] * 2.54;

                if (FretLengths != null)
                    for (i = 1; i <= iFrets; i++)
                        FretLengths[i] = FretLengths[i] * 2.54;
            }
        }

        public static void ConvertToImperial(ref string InScaleLen, ref string InFretCount, ref string InNutWidth, ref string InBoardLength, ref string InBaseWidth, ref string InFretOversize)
        {
            int i, iFrets;

            bInches = true;

            if (InScaleLen != "")
            {
                dbScaleLen = Convert.ToDouble(InScaleLen);
                dbScaleLen = dbScaleLen / 2.54;
                InScaleLen = Convert.ToString(dbScaleLen);
            }

            if (InNutWidth != "")
            {
                dbNutWidth = Convert.ToDouble(InNutWidth);
                dbNutWidth = dbNutWidth / 2.54;
                InNutWidth = Convert.ToString(dbNutWidth);
            }

            if (InBoardLength != "")
            {
                dbBoardLength = Convert.ToDouble(InBoardLength);
                dbBoardLength = dbBoardLength / 2.54;
                InBoardLength = Convert.ToString(dbBoardLength);
            }

            if (InBaseWidth != "")
            {
                dbBaseWidth = Convert.ToDouble(InBaseWidth);
                dbBaseWidth = dbBaseWidth / 2.54;
                InBaseWidth = Convert.ToString(dbBaseWidth);
            }

            if (InFretOversize != "")
            {
                dbFretOversize = Convert.ToDouble(InFretOversize);
                dbFretOversize = dbFretOversize / 2.54;
                InFretOversize = Convert.ToString(dbFretOversize);
            }

            if (InFretCount != "")
            {
                iFrets = Convert.ToInt32(InFretCount);

                if (CutLocations != null)
                    for (i = 1; i <= iFrets; i++)
                        CutLocations[i] = CutLocations[i] / 2.54;

                if (FretLengths != null)
                    for (i = 1; i <= iFrets; i++)
                        FretLengths[i] = FretLengths[i] / 2.54;
            }
        }

        public static string FormatCutLocationDescription(int InFret)
        {
            string OutListEntry = "";

            if (CutLocations[InFret] != 0)
            {
                OutListEntry = InFret + "        " + CutLocations[InFret].ToString("F6");

                if (bInches)
                    OutListEntry = OutListEntry + "        " + FormatFractionalLength(CutLocations[InFret]);
            }

            return OutListEntry;
        }

        public static string FormatFretLengthDescription(int InFret)
        {
            string OutListEntry = "";
            Double dbFullFretWidth = FretLengths[InFret];

            if (FretLengths[InFret] != 0)
            {
                OutListEntry = InFret + "        " + FretLengths[InFret].ToString("F6");

                if (bInches)
                    OutListEntry = OutListEntry + "        " + FormatFractionalLength(FretLengths[InFret]);

                if (dbFretOversize > 0)
                {
                    dbFullFretWidth = FretLengths[InFret] + dbFretOversize;
                    OutListEntry = OutListEntry + "        " + dbFullFretWidth.ToString("F6");
                }

                if (bInches)
                    OutListEntry = OutListEntry + "        " + FormatFractionalLength(dbFullFretWidth);
            }

            return OutListEntry;
        }

        public static string FormatFractionalLength(Double InLength)
        {
            string OutFractionalString = "";

            int i, iLower = 0, iUpper = 0;
            int iInInches = Convert.ToInt16(Math.Truncate(InLength));

            Double dbFraction = InLength - iInInches;
            Double dbTestPoint;

            if (dbFraction > 0)
            {
                for (i = 1; i <= arrFractions.GetUpperBound(0); i++)
                {
                    if (arrFractions[i].FractionDecValue > dbFraction)
                    {
                        iUpper = i;
                        iLower = i - 1;
                        break;
                    }
                }

                dbTestPoint = arrFractions[iLower].FractionDecValue + db128th;

                if (dbFraction >= dbTestPoint)
                {
                    if (arrFractions[iUpper].FractionDecValue == 1)
                    {
                        iInInches = iInInches + 1;
                        OutFractionalString = Convert.ToString(iInInches);
                    }
                    else
                        OutFractionalString = Convert.ToString(iInInches) + " " + arrFractions[iUpper].Fraction;
                }
                else
                {
                    if (arrFractions[iLower].FractionDecValue == 0)
                        OutFractionalString = Convert.ToString(iInInches);
                    else
                        OutFractionalString = Convert.ToString(iInInches) + " " + arrFractions[iLower].Fraction;
                }
            }

            return OutFractionalString;
        }

        private static string FormatWireLayoutLine(int InWireCount, ref int iFretsAssigned)
        {
            string sOutWireLine = "", sFretList = "";
            int i, iAssignedCount = 0;
            Double dbWireRemaining;

            if (bInches)
                dbWireRemaining = WireLengths.WireInches;
            else
                dbWireRemaining = WireLengths.WireCentimeters;

            for (i = FretLengths.GetUpperBound(0); i > 0; i--)
            {
                if (!FretIsAssigned[i] && FretLengths[i] <= dbWireRemaining)
                {
                    iAssignedCount++;
                    iFretsAssigned++;
                    FretIsAssigned[i] = true;
                    dbWireRemaining = dbWireRemaining - FretLengths[i];
                    if (iAssignedCount > 1)
                        sFretList = sFretList + ", " + i;
                    else
                        sFretList = sFretList + i;
                }

                if (dbWireRemaining < FretLengths[1])
                    break;
            }

            sOutWireLine = "Wire " + InWireCount + ": \t Contains frets: " + sFretList + "\t Waste: " + dbWireRemaining;

            return sOutWireLine;
        }

        public static void InstrumentXML(float ScaleLen, int iFrets, string InPath, string InDisplayUnits)
        {
            Double dbOverFretLength = 0;

            StreamWriter XMLFile = File.AppendText(InPath + "\\" + sInstrumentDesc + InDisplayUnits + ".xml");
            int i, iWireCount = 0;

            XMLFile.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>");
            XMLFile.WriteLine("<?xml-stylesheet type=\"text/xsl\" href=\"" + "Scale" + InDisplayUnits + ".xsl\"?>");
            XMLFile.WriteLine("<ScaleOutput>");

            XMLFile.WriteLine("\t<Parameters>");

            XMLFile.WriteLine("\t\t<Description>" + sInstrumentDesc + "</Description>");
            XMLFile.WriteLine("\t\t<Units>" + InDisplayUnits + "</Units>");

            if (InDisplayUnits == "Fraction")
                XMLFile.WriteLine("\t\t<ScaleLength>" + FormatFractionalLength(ScaleLen) + "</ScaleLength>");
            else
                XMLFile.WriteLine("\t\t<ScaleLength>" + ScaleLen.ToString("F6") + "</ScaleLength>");

            XMLFile.WriteLine("\t\t<FretCount>" + iFrets + "</FretCount>");

            if (InDisplayUnits == "Fraction")
                XMLFile.WriteLine("\t\t<FretOversize>" + FormatFractionalLength(dbFretOversize) + "</FretOversize>");
            else
                XMLFile.WriteLine("\t\t<FretOversize>" + dbFretOversize.ToString("F6") + "</FretOversize>");

            XMLFile.WriteLine("\t\t<Fingerboard>");

            if (InDisplayUnits == "Fraction")
            {
                XMLFile.WriteLine("\t\t\t<NutWidth>" + FormatFractionalLength(dbNutWidth) + "</NutWidth>");
                XMLFile.WriteLine("\t\t\t<BaseWidth>" + FormatFractionalLength(dbBaseWidth) + "</BaseWidth>");
                XMLFile.WriteLine("\t\t\t<BoardLength>" + FormatFractionalLength(dbBoardLength) + "</BoardLength>");
            }
            else
            {
                XMLFile.WriteLine("\t\t\t<NutWidth>" + dbNutWidth.ToString("F6") + "</NutWidth>");
                XMLFile.WriteLine("\t\t\t<BaseWidth>" + dbBaseWidth.ToString("F6") + "</BaseWidth>");
                XMLFile.WriteLine("\t\t\t<BoardLength>" + dbBoardLength.ToString("F6") + "</BoardLength>");
            }

            XMLFile.WriteLine("\t\t</Fingerboard>");

            XMLFile.WriteLine("\t\t<FretWireLength>" + "" + "</FretWireLength>");

            XMLFile.WriteLine("\t</Parameters>");

            XMLFile.WriteLine("\t<FretCuts>");

            for (i = 1; i <= iFrets; i++)
            {
                XMLFile.WriteLine("\t\t<Cut>");
                XMLFile.WriteLine("\t\t\t<CutNumber>" + i + "</CutNumber>");

                if (InDisplayUnits == "Fraction")
                    XMLFile.WriteLine("\t\t\t<CutLocation>" + FormatFractionalLength(CutLocations[i]) + "</CutLocation>");
                else
                    XMLFile.WriteLine("\t\t\t<CutLocation>" + CutLocations[i].ToString("F6") + "</CutLocation>");

                XMLFile.WriteLine("\t\t</Cut>");
            }

            XMLFile.WriteLine("\t</FretCuts>");

            XMLFile.WriteLine("\t<FretLengths>");

            for (i = 1; i <= iFrets; i++)
            {
                dbOverFretLength = FretLengths[i] + dbFretOversize;

                XMLFile.WriteLine("\t\t<Fret>");
                XMLFile.WriteLine("\t\t\t<FretNumber>" + i + "</FretNumber>");

                if (InDisplayUnits == "Fraction")
                {
                    XMLFile.WriteLine("\t\t\t<Length>" + FormatFractionalLength(FretLengths[i]) + "</Length>");
                    XMLFile.WriteLine("\t\t\t<OversizeLength>" + FormatFractionalLength(dbOverFretLength) + "</OversizeLength>");
                }
                else
                {
                    XMLFile.WriteLine("\t\t\t<Length>" + FretLengths[i].ToString("F6") + "</Length>");
                    XMLFile.WriteLine("\t\t\t<OversizeLength>" + dbOverFretLength.ToString("F6") + "</OversizeLength>");
                }

                XMLFile.WriteLine("\t\t</Fret>");
            }

            XMLFile.WriteLine("\t</FretLengths>");

            XMLFile.WriteLine("\t<WireMap>");

            for (i = 1; i <= iWireCount; i++)
            {
                XMLFile.WriteLine("\t\t<Wire>");
                XMLFile.WriteLine("\t\t\t<WireNumber>" + i + "</WireNumber>");
                XMLFile.WriteLine("\t\t\t<FretList>" + "" + "</FretList>");
                XMLFile.WriteLine("\t\t</Wire>");
            }

            XMLFile.WriteLine("\t</WireMap>");

            XMLFile.WriteLine("</ScaleOutput>");

            XMLFile.Close();
        }

        public static void OutputCalculations(float ScaleLen, int iFrets, string InPath)
        {
            StreamWriter dataFile = File.AppendText(InPath + "\\ScaleCalculations.txt");
            int i, iWireCount = 0, iFretsAssigned = 0, iDulcimerNumberOffSet = 0;
            Double dbFullFretLength = 0, dbDulcimerFretNo;
            string sFraction = "";

            FretIsAssigned = new bool[iFrets];

            for (i = 1; i <= iFrets; i++)
                FretIsAssigned[i] = false;

            dbTotalActualFret = 0;
            dbTotalOversizeFret = 0;

            dataFile.WriteLine("Instrument Description: " + sInstrumentDesc);

            if (blDulcimer)
                dataFile.WriteLine("Dulcimer");

            dataFile.WriteLine();

            dataFile.Write("Scale Length: " + ScaleLen);

            if (bInches)
                dataFile.Write(" inches");
            else
                dataFile.Write(" centimetres");

            dataFile.WriteLine();

            dataFile.WriteLine("Number of Frets: " + iFrets);
            dataFile.WriteLine();
            dataFile.WriteLine("Fret Cut Distances From the Nut");
            dataFile.WriteLine("-------------------------------");
            dataFile.WriteLine();
            dataFile.WriteLine("Fret #" + "\t Distance from \t  Tape");
            dataFile.WriteLine("\t Front of Nut \t Measure");

            for (i = 1; i <= iFrets; i++)
            {
                if (blDulcimer)
                    if (CutLocations[i] > 0)
                    {
                        if (i % 12 == 0)
                            iDulcimerNumberOffSet = iDulcimerNumberOffSet + 8;

                        dbDulcimerFretNo = DulcimerFretNumbers[(i % 12) + iDulcimerNumberOffSet];

                        dataFile.Write(FormatFractionalLength(dbDulcimerFretNo) + "\t " + CutLocations[i].ToString("F6"));

                        if (bInches)
                            dataFile.WriteLine("\t " + FormatFractionalLength(CutLocations[i]));
                        else
                            dataFile.WriteLine();
                    }
                else
                {
                    dataFile.Write(i + "\t " + CutLocations[i].ToString("F6"));

                    if (bInches)
                        dataFile.WriteLine("\t " + FormatFractionalLength(CutLocations[i]));
                    else
                        dataFile.WriteLine();
                }
            }

            dataFile.WriteLine();
            dataFile.WriteLine();

            if (dbNutWidth > 0 && dbBoardLength > 0 && dbBaseWidth > 0)
            {
                dataFile.WriteLine("Fret Length Calculations");
                dataFile.WriteLine("------------------------");
                dataFile.WriteLine();
                dataFile.WriteLine("Nut Width: " + dbNutWidth);
                dataFile.WriteLine("Width at Base: " + dbBaseWidth);
                dataFile.WriteLine("Fingerboard Length: " + dbBoardLength);
                dataFile.WriteLine("Oversize Amount:" + dbFretOversize);

                dataFile.WriteLine();
                dataFile.WriteLine("Fret #" + "\t Fret Length" + "\t  Tape \t\t Oversize \t   Tape");
                dataFile.WriteLine("\t\t\t Measure\t\t\t Measure");

                for (i = 1; i <= iFrets; i++)
                {
                    dataFile.Write(i + "\t " + FretLengths[i].ToString("F6"));

                    if (bInches)
                    {
                        sFraction = FormatFractionalLength(FretLengths[i]);

                        dataFile.Write("\t " + sFraction);

                        if (sFraction.Length < 7)
                            dataFile.Write("\t");
                    }

                    dbTotalActualFret = dbTotalActualFret + FretLengths[i];

                    if (dbFretOversize > 0)
                    {
                        dbFullFretLength = FretLengths[i] + dbFretOversize;
                        dataFile.Write("\t " + dbFullFretLength.ToString("F6"));

                        if (bInches)
                            dataFile.Write("\t " + FormatFractionalLength(dbFullFretLength));

                        dbTotalOversizeFret = dbTotalOversizeFret + dbFullFretLength;
                    }

                    dataFile.WriteLine();
                }

                dataFile.WriteLine();
                dataFile.WriteLine();

                if (bInches)
                {
                    dataFile.Write("Total Actual Fret Length:\t" + FormatFractionalLength(dbTotalActualFret));
                    dataFile.Write(" inches");
                }
                else
                {
                    dataFile.Write("Total Actual Fret Length:\t" + dbTotalActualFret.ToString("F6"));
                    dataFile.Write(" centimetres");
                }

                dataFile.WriteLine();
                dataFile.WriteLine();

                if (bInches)
                {
                    dataFile.Write("Total Oversize Fret Length:\t" + FormatFractionalLength(dbTotalOversizeFret));
                    dataFile.Write(" inches");
                }
                else
                {
                    dataFile.Write("Total Oversize Fret Length:\t" + dbTotalOversizeFret.ToString("F6"));
                    dataFile.Write(" centimetres");
                }

                dataFile.WriteLine();
                dataFile.WriteLine();
                dataFile.WriteLine("FretWire Layout Information");
                dataFile.WriteLine();

                while (iFretsAssigned <= CutLocations.GetUpperBound(0))
                {
                    iWireCount++;
                    dataFile.WriteLine(FormatWireLayoutLine(iWireCount, ref iFretsAssigned));
                }
            }

            dataFile.Close();
        }

        public static string GetXMLElementValue(string XMLIn, string ElementTag)
        {
            string sWorkStr, sEleValue = "", sClosingTag = "</" + ElementTag;
            int TagPos, ValueStart, ValueLength;

            sWorkStr = XMLIn;

            if (sWorkStr.Contains(ElementTag))
            {
                TagPos = sWorkStr.IndexOf(ElementTag);
                ValueStart = TagPos + ElementTag.Length + 1;
                TagPos = sWorkStr.IndexOf(sClosingTag);
                ValueLength = TagPos - ValueStart;
                sEleValue = sWorkStr.Substring(ValueStart, ValueLength);
            }

            return sEleValue;
        }

    }
}
