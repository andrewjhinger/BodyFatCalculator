namespace BodyFatCalculator
{
    partial class BodyFatCalculator
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
            this.bodyFatTabControl = new System.Windows.Forms.TabControl();
            this.calculatorPage = new System.Windows.Forms.TabPage();
            this.forearmUnitLabel = new System.Windows.Forms.Label();
            this.hipsUnitLabel = new System.Windows.Forms.Label();
            this.wristUnitLabel = new System.Windows.Forms.Label();
            this.waistUnitLabel = new System.Windows.Forms.Label();
            this.weightUnitLabel = new System.Windows.Forms.Label();
            this.requiredForFemaleLabel = new System.Windows.Forms.Label();
            this.bodyFatLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.forearmTextBox = new System.Windows.Forms.TextBox();
            this.hipsTextBox = new System.Windows.Forms.TextBox();
            this.wristTextBox = new System.Windows.Forms.TextBox();
            this.waistTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.forearmLabel = new System.Windows.Forms.Label();
            this.hipsLabel = new System.Windows.Forms.Label();
            this.wristLabel = new System.Windows.Forms.Label();
            this.waistLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.chartPage = new System.Windows.Forms.TabPage();
            this.obeseLabel = new System.Windows.Forms.Label();
            this.acceptableLabel = new System.Windows.Forms.Label();
            this.fitnessLabel = new System.Windows.Forms.Label();
            this.athletesLabel = new System.Windows.Forms.Label();
            this.essentialLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.bodyFatTabControl.SuspendLayout();
            this.calculatorPage.SuspendLayout();
            this.chartPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // bodyFatTabControl
            // 
            this.bodyFatTabControl.Controls.Add(this.calculatorPage);
            this.bodyFatTabControl.Controls.Add(this.chartPage);
            this.bodyFatTabControl.Location = new System.Drawing.Point(12, 22);
            this.bodyFatTabControl.Name = "bodyFatTabControl";
            this.bodyFatTabControl.SelectedIndex = 0;
            this.bodyFatTabControl.Size = new System.Drawing.Size(305, 301);
            this.bodyFatTabControl.TabIndex = 0;
            // 
            // calculatorPage
            // 
            this.calculatorPage.Controls.Add(this.forearmUnitLabel);
            this.calculatorPage.Controls.Add(this.hipsUnitLabel);
            this.calculatorPage.Controls.Add(this.wristUnitLabel);
            this.calculatorPage.Controls.Add(this.waistUnitLabel);
            this.calculatorPage.Controls.Add(this.weightUnitLabel);
            this.calculatorPage.Controls.Add(this.requiredForFemaleLabel);
            this.calculatorPage.Controls.Add(this.bodyFatLabel);
            this.calculatorPage.Controls.Add(this.calculateButton);
            this.calculatorPage.Controls.Add(this.maleRadioButton);
            this.calculatorPage.Controls.Add(this.femaleRadioButton);
            this.calculatorPage.Controls.Add(this.forearmTextBox);
            this.calculatorPage.Controls.Add(this.hipsTextBox);
            this.calculatorPage.Controls.Add(this.wristTextBox);
            this.calculatorPage.Controls.Add(this.waistTextBox);
            this.calculatorPage.Controls.Add(this.weightTextBox);
            this.calculatorPage.Controls.Add(this.forearmLabel);
            this.calculatorPage.Controls.Add(this.hipsLabel);
            this.calculatorPage.Controls.Add(this.wristLabel);
            this.calculatorPage.Controls.Add(this.waistLabel);
            this.calculatorPage.Controls.Add(this.weightLabel);
            this.calculatorPage.Location = new System.Drawing.Point(4, 22);
            this.calculatorPage.Name = "calculatorPage";
            this.calculatorPage.Padding = new System.Windows.Forms.Padding(3);
            this.calculatorPage.Size = new System.Drawing.Size(297, 275);
            this.calculatorPage.TabIndex = 0;
            this.calculatorPage.Text = "Calculator";
            this.calculatorPage.UseVisualStyleBackColor = true;
            // 
            // forearmUnitLabel
            // 
            this.forearmUnitLabel.AutoSize = true;
            this.forearmUnitLabel.Location = new System.Drawing.Point(174, 132);
            this.forearmUnitLabel.Name = "forearmUnitLabel";
            this.forearmUnitLabel.Size = new System.Drawing.Size(116, 13);
            this.forearmUnitLabel.TabIndex = 21;
            this.forearmUnitLabel.Text = "inches (at fullest point)*";
            // 
            // hipsUnitLabel
            // 
            this.hipsUnitLabel.AutoSize = true;
            this.hipsUnitLabel.Location = new System.Drawing.Point(174, 101);
            this.hipsUnitLabel.Name = "hipsUnitLabel";
            this.hipsUnitLabel.Size = new System.Drawing.Size(116, 13);
            this.hipsUnitLabel.TabIndex = 20;
            this.hipsUnitLabel.Text = "inches (at fullest point)*";
            // 
            // wristUnitLabel
            // 
            this.wristUnitLabel.AutoSize = true;
            this.wristUnitLabel.Location = new System.Drawing.Point(174, 76);
            this.wristUnitLabel.Name = "wristUnitLabel";
            this.wristUnitLabel.Size = new System.Drawing.Size(116, 13);
            this.wristUnitLabel.TabIndex = 19;
            this.wristUnitLabel.Text = "inches (at fullest point)*";
            // 
            // waistUnitLabel
            // 
            this.waistUnitLabel.AutoSize = true;
            this.waistUnitLabel.Location = new System.Drawing.Point(174, 48);
            this.waistUnitLabel.Name = "waistUnitLabel";
            this.waistUnitLabel.Size = new System.Drawing.Size(85, 13);
            this.waistUnitLabel.TabIndex = 18;
            this.waistUnitLabel.Text = "inches (at naval)";
            // 
            // weightUnitLabel
            // 
            this.weightUnitLabel.AutoSize = true;
            this.weightUnitLabel.Location = new System.Drawing.Point(174, 20);
            this.weightUnitLabel.Name = "weightUnitLabel";
            this.weightUnitLabel.Size = new System.Drawing.Size(42, 13);
            this.weightUnitLabel.TabIndex = 17;
            this.weightUnitLabel.Text = "pounds";
            // 
            // requiredForFemaleLabel
            // 
            this.requiredForFemaleLabel.AutoSize = true;
            this.requiredForFemaleLabel.Location = new System.Drawing.Point(121, 152);
            this.requiredForFemaleLabel.Name = "requiredForFemaleLabel";
            this.requiredForFemaleLabel.Size = new System.Drawing.Size(125, 13);
            this.requiredForFemaleLabel.TabIndex = 16;
            this.requiredForFemaleLabel.Text = "*Only required for Female";
            // 
            // bodyFatLabel
            // 
            this.bodyFatLabel.AutoSize = true;
            this.bodyFatLabel.Location = new System.Drawing.Point(11, 238);
            this.bodyFatLabel.Name = "bodyFatLabel";
            this.bodyFatLabel.Size = new System.Drawing.Size(110, 13);
            this.bodyFatLabel.TabIndex = 15;
            this.bodyFatLabel.Text = "Body Fat Percentage:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(14, 191);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(133, 23);
            this.calculateButton.TabIndex = 14;
            this.calculateButton.Text = "Calculator Body Fat";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(73, 168);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(48, 17);
            this.maleRadioButton.TabIndex = 13;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(8, 168);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(59, 17);
            this.femaleRadioButton.TabIndex = 12;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // forearmTextBox
            // 
            this.forearmTextBox.Location = new System.Drawing.Point(68, 129);
            this.forearmTextBox.Name = "forearmTextBox";
            this.forearmTextBox.Size = new System.Drawing.Size(100, 20);
            this.forearmTextBox.TabIndex = 11;
            // 
            // hipsTextBox
            // 
            this.hipsTextBox.Location = new System.Drawing.Point(68, 101);
            this.hipsTextBox.Name = "hipsTextBox";
            this.hipsTextBox.Size = new System.Drawing.Size(100, 20);
            this.hipsTextBox.TabIndex = 10;
            // 
            // wristTextBox
            // 
            this.wristTextBox.Location = new System.Drawing.Point(68, 73);
            this.wristTextBox.Name = "wristTextBox";
            this.wristTextBox.Size = new System.Drawing.Size(100, 20);
            this.wristTextBox.TabIndex = 9;
            // 
            // waistTextBox
            // 
            this.waistTextBox.Location = new System.Drawing.Point(68, 45);
            this.waistTextBox.Name = "waistTextBox";
            this.waistTextBox.Size = new System.Drawing.Size(100, 20);
            this.waistTextBox.TabIndex = 8;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(68, 17);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 7;
            // 
            // forearmLabel
            // 
            this.forearmLabel.AutoSize = true;
            this.forearmLabel.Location = new System.Drawing.Point(17, 136);
            this.forearmLabel.Name = "forearmLabel";
            this.forearmLabel.Size = new System.Drawing.Size(45, 13);
            this.forearmLabel.TabIndex = 5;
            this.forearmLabel.Text = "Forearm";
            // 
            // hipsLabel
            // 
            this.hipsLabel.AutoSize = true;
            this.hipsLabel.Location = new System.Drawing.Point(17, 107);
            this.hipsLabel.Name = "hipsLabel";
            this.hipsLabel.Size = new System.Drawing.Size(28, 13);
            this.hipsLabel.TabIndex = 4;
            this.hipsLabel.Text = "Hips";
            // 
            // wristLabel
            // 
            this.wristLabel.AutoSize = true;
            this.wristLabel.Location = new System.Drawing.Point(17, 78);
            this.wristLabel.Name = "wristLabel";
            this.wristLabel.Size = new System.Drawing.Size(31, 13);
            this.wristLabel.TabIndex = 3;
            this.wristLabel.Text = "Wrist";
            // 
            // waistLabel
            // 
            this.waistLabel.AutoSize = true;
            this.waistLabel.Location = new System.Drawing.Point(17, 49);
            this.waistLabel.Name = "waistLabel";
            this.waistLabel.Size = new System.Drawing.Size(34, 13);
            this.waistLabel.TabIndex = 2;
            this.waistLabel.Text = "Waist";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(17, 20);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(41, 13);
            this.weightLabel.TabIndex = 1;
            this.weightLabel.Text = "Weight";
            // 
            // chartPage
            // 
            this.chartPage.Controls.Add(this.obeseLabel);
            this.chartPage.Controls.Add(this.acceptableLabel);
            this.chartPage.Controls.Add(this.fitnessLabel);
            this.chartPage.Controls.Add(this.athletesLabel);
            this.chartPage.Controls.Add(this.essentialLabel);
            this.chartPage.Location = new System.Drawing.Point(4, 22);
            this.chartPage.Name = "chartPage";
            this.chartPage.Padding = new System.Windows.Forms.Padding(3);
            this.chartPage.Size = new System.Drawing.Size(297, 275);
            this.chartPage.TabIndex = 1;
            this.chartPage.Text = "Chart";
            this.chartPage.UseVisualStyleBackColor = true;
            // 
            // obeseLabel
            // 
            this.obeseLabel.AutoSize = true;
            this.obeseLabel.Location = new System.Drawing.Point(26, 178);
            this.obeseLabel.Name = "obeseLabel";
            this.obeseLabel.Size = new System.Drawing.Size(166, 13);
            this.obeseLabel.TabIndex = 4;
            this.obeseLabel.Text = "Obese: Women 32%+, Men 25%+";
            // 
            // acceptableLabel
            // 
            this.acceptableLabel.AutoSize = true;
            this.acceptableLabel.Location = new System.Drawing.Point(26, 141);
            this.acceptableLabel.Name = "acceptableLabel";
            this.acceptableLabel.Size = new System.Drawing.Size(207, 13);
            this.acceptableLabel.TabIndex = 3;
            this.acceptableLabel.Text = "Acceptable: Women 25-31%, Men 18-25%";
            // 
            // fitnessLabel
            // 
            this.fitnessLabel.AutoSize = true;
            this.fitnessLabel.Location = new System.Drawing.Point(26, 104);
            this.fitnessLabel.Name = "fitnessLabel";
            this.fitnessLabel.Size = new System.Drawing.Size(186, 13);
            this.fitnessLabel.TabIndex = 2;
            this.fitnessLabel.Text = "Fitness: Women 21-24%, Men 14-17%";
            // 
            // athletesLabel
            // 
            this.athletesLabel.AutoSize = true;
            this.athletesLabel.Location = new System.Drawing.Point(26, 67);
            this.athletesLabel.Name = "athletesLabel";
            this.athletesLabel.Size = new System.Drawing.Size(185, 13);
            this.athletesLabel.TabIndex = 1;
            this.athletesLabel.Text = "Athletes: Women 14-20%, Men 6-13%";
            // 
            // essentialLabel
            // 
            this.essentialLabel.AutoSize = true;
            this.essentialLabel.Location = new System.Drawing.Point(26, 30);
            this.essentialLabel.Name = "essentialLabel";
            this.essentialLabel.Size = new System.Drawing.Size(201, 13);
            this.essentialLabel.TabIndex = 0;
            this.essentialLabel.Text = "Essential Fat: Women 10-12%, Men 2-4%";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(201, 346);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // BodyFatCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 381);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.bodyFatTabControl);
            this.Name = "BodyFatCalculator";
            this.Text = "Body Fat Calculator";
            this.bodyFatTabControl.ResumeLayout(false);
            this.calculatorPage.ResumeLayout(false);
            this.calculatorPage.PerformLayout();
            this.chartPage.ResumeLayout(false);
            this.chartPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl bodyFatTabControl;
        private System.Windows.Forms.TabPage calculatorPage;
        private System.Windows.Forms.Label requiredForFemaleLabel;
        private System.Windows.Forms.Label bodyFatLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.TextBox forearmTextBox;
        private System.Windows.Forms.TextBox hipsTextBox;
        private System.Windows.Forms.TextBox wristTextBox;
        private System.Windows.Forms.TextBox waistTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label forearmLabel;
        private System.Windows.Forms.Label hipsLabel;
        private System.Windows.Forms.Label wristLabel;
        private System.Windows.Forms.Label waistLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TabPage chartPage;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label forearmUnitLabel;
        private System.Windows.Forms.Label hipsUnitLabel;
        private System.Windows.Forms.Label wristUnitLabel;
        private System.Windows.Forms.Label waistUnitLabel;
        private System.Windows.Forms.Label weightUnitLabel;
        private System.Windows.Forms.Label obeseLabel;
        private System.Windows.Forms.Label acceptableLabel;
        private System.Windows.Forms.Label fitnessLabel;
        private System.Windows.Forms.Label athletesLabel;
        private System.Windows.Forms.Label essentialLabel;
    }
}

