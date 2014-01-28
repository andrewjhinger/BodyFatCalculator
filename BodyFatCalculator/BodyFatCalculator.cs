using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BodyFatCalculator
{


    public partial class BodyFatCalculator : Form
    {
        bool _enableDebugging = true;


        public BodyFatCalculator()
        {
            InitializeComponent();
            // Default to female.
            femaleRadioButton.Checked = true;



        }

        private double calculateBodyFat(bool isFemale, double weightFactor, double wristFactor,
                    double waistFactor, double hipsFactor, double forearmFactor)
        {
            double leanBodyMass = 0;
            double bodyFatWeight = 0;
            double bodyWeight = weightFactor;

            if (isFemale)
            {
                // Calculate for female.
                weightFactor = weightFactor * 0.732 + 8.987;
                wristFactor /= 3.140;
                waistFactor *= 0.157;
                hipsFactor *= 0.249;
                forearmFactor *= 0.434;
                leanBodyMass = weightFactor + wristFactor - waistFactor - hipsFactor + forearmFactor;
                bodyFatWeight = bodyWeight - leanBodyMass;
            }
            else
            {
                // Calculate for male.
                weightFactor = weightFactor * 1.082 + 94.42;
                waistFactor *= 4.15;
                leanBodyMass = weightFactor - waistFactor;
                bodyFatWeight = bodyWeight - leanBodyMass;
            }

            return bodyFatWeight;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double weightFactor = 0;
            double waistFactor = 0;
            double wristFactor = 0;
            double hipsFactor = 0;
            double forearmFactor = 0;
            double bodyFatPercentage = 0;
            bool isFemale = false;

            // See if female.
            if (femaleRadioButton.Checked)
                isFemale = true;


            // Set all unit labels to black.
            weightUnitLabel.ForeColor = Color.Black;
            waistUnitLabel.ForeColor = Color.Black;
            wristUnitLabel.ForeColor = Color.Black;
            hipsUnitLabel.ForeColor = Color.Black;
            forearmUnitLabel.ForeColor = Color.Black;

            // Attempt to convert TextBox values to doubles, marking unit labels red for failures.
            if (!double.TryParse(weightTextBox.Text, out weightFactor))
                weightUnitLabel.ForeColor = Color.Red;
            if (!double.TryParse(waistTextBox.Text, out waistFactor))
                waistUnitLabel.ForeColor = Color.Red;
            if (isFemale)
            {
                if (!double.TryParse(wristTextBox.Text, out wristFactor))
                    wristUnitLabel.ForeColor = Color.Red;
                if (!double.TryParse(hipsTextBox.Text, out hipsFactor))
                    hipsUnitLabel.ForeColor = Color.Red;
                if (!double.TryParse(forearmTextBox.Text, out forearmFactor))
                    forearmUnitLabel.ForeColor = Color.Red;
            }

            // Make sure all values are above zero.
            if (weightFactor <= 0)
                weightUnitLabel.ForeColor = Color.Red;
            if (waistFactor <= 0)
                waistUnitLabel.ForeColor = Color.Red;
            if (isFemale)
            {
                if (wristFactor <= 0)
                    wristUnitLabel.ForeColor = Color.Red;
                if (hipsFactor <= 0)
                    hipsUnitLabel.ForeColor = Color.Red;
                if (forearmFactor <= 0)
                    forearmUnitLabel.ForeColor = Color.Red;
            }

            // See if there were any errors by checking Unit label Forecolor.
            // Weight
            setToolTip(weightLabel, weightTextBox, weightUnitLabel, weightUnitLabel.ForeColor == Color.Red ? "Weight (pounds) must be numeric and above 0." : "");
            // Waist
            writeToLogDebug(Convert.ToString(weightLabel.Text));
            setToolTip(waistLabel, waistTextBox, waistUnitLabel, waistUnitLabel.ForeColor == Color.Red ? "Waist (inches) must be numeric and above 0." : "");
            writeToLogDebug(Convert.ToString(waistLabel.Text));
            if (isFemale)
            {
                // Wrist
                setToolTip(wristLabel, wristTextBox, wristUnitLabel, wristUnitLabel.ForeColor == Color.Red ? "Wrist (inches) must be numeric and above 0." : "");
                writeToLogDebug(Convert.ToString(wristLabel.Text));
                // Hips
                setToolTip(hipsLabel, hipsTextBox, hipsUnitLabel, hipsUnitLabel.ForeColor == Color.Red ? "Hips (inches) must be numeric and above 0." : "");
                writeToLogDebug(Convert.ToString(hipsLabel.Text));
                // Forearm
                setToolTip(forearmLabel, forearmTextBox, forearmUnitLabel, forearmUnitLabel.ForeColor == Color.Red ? "Forearm (inches) must be numeric and above 0." : "");
                writeToLogDebug(Convert.ToString(forearmLabel.Text));
            }

            // Check for error.                       
            bool isError = false;
            if (isFemale)
                isError = (weightUnitLabel.ForeColor == Color.Red || waistUnitLabel.ForeColor == Color.Red || wristUnitLabel.ForeColor == Color.Red
                            || hipsUnitLabel.ForeColor == Color.Red || forearmUnitLabel.ForeColor == Color.Red);
            else
                isError = (weightUnitLabel.ForeColor == Color.Red || waistUnitLabel.ForeColor == Color.Red);

            if (!isError)
            {
                // Display the body fat Label.
                bodyFatLabel.Visible = true;
                bodyFatLabel.ForeColor = Color.Red;

                // No errors, so calculate and display body fat percentage, formatting to two decimal places.
                bodyFatPercentage = (calculateBodyFat(isFemale, weightFactor, wristFactor, waistFactor, hipsFactor, forearmFactor) * 100) / weightFactor;
                bodyFatLabel.Text = "Body Fat Percentage: " + bodyFatPercentage.ToString("#0.00") + "%";
                writeToLogDebug(Convert.ToString(DateTime.Now));
                writeToLogDebug(Convert.ToString(bodyFatLabel.Text));
                writeToLogDebug("-------------");

            }

            else
            {
                // There were errors.
                bodyFatLabel.Visible = true;
                bodyFatLabel.ForeColor = Color.Red;
                bodyFatLabel.Text = "Hover mouse over error to see error message";
            }
        }

        private void setToolTip(Control labelControl, Control textBoxControl, Control labelUnitControl, string toolText)
        {
            // Create a tooltip object.
            ToolTip tp = new ToolTip();

            // Set tooltip for each control.
            tp.SetToolTip(labelControl, toolText);
            tp.SetToolTip(textBoxControl, toolText);
            tp.SetToolTip(labelUnitControl, toolText);
        }

        static string strLogText = "Default string to log";
        static StreamWriter LogWriter;

        public static void writeToLog(string message)
        {
            try
            {
                if (!File.Exists("LogFile.txt"))
                { LogWriter = new StreamWriter("LogFile.txt"); }
                else
                { LogWriter = File.AppendText("LogFile.txt"); }
                LogWriter.WriteLine(string.IsNullOrEmpty(message) ? strLogText : message);
                LogWriter.Flush();
            }
            catch (Exception) { }
            finally { if (LogWriter != null) { LogWriter.Close(); } }
        }

        public void writeToLogDebug(string debug)
        {

            if (_enableDebugging)
            {

                debug = "Debug: " + debug;
                writeToLog(debug);
            }
        }

    }
}
