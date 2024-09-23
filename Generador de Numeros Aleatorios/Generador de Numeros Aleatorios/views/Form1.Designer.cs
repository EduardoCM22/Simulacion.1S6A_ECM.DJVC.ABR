namespace Generador_de_Numeros_Aleatorios
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMSeed = new MaterialSkin.Controls.MaterialTextBox();
            lblMSeed1 = new MaterialSkin.Controls.MaterialLabel();
            lblMErrSeed = new MaterialSkin.Controls.MaterialLabel();
            swMLight = new MaterialSkin.Controls.MaterialSwitch();
            lblMTheme = new MaterialSkin.Controls.MaterialLabel();
            grpTheme = new GroupBox();
            lblMAmOfNum = new MaterialSkin.Controls.MaterialLabel();
            lblMErrNum = new MaterialSkin.Controls.MaterialLabel();
            txtMNumOfNumbers = new MaterialSkin.Controls.MaterialTextBox();
            lblMPivot = new MaterialSkin.Controls.MaterialLabel();
            lblMErrPivot = new MaterialSkin.Controls.MaterialLabel();
            txtMPivot = new MaterialSkin.Controls.MaterialTextBox();
            cmbMAlgorithm = new MaterialSkin.Controls.MaterialComboBox();
            lblMAlgorithm = new MaterialSkin.Controls.MaterialLabel();
            btnMGenerate = new MaterialSkin.Controls.MaterialButton();
            listMRandomNumbers = new MaterialSkin.Controls.MaterialListBox();
            lblMGeneratedNums = new MaterialSkin.Controls.MaterialLabel();
            sldMTrustLevel = new MaterialSkin.Controls.MaterialSlider();
            lblMTrustLevel = new MaterialSkin.Controls.MaterialLabel();
            btnMAverageTest = new MaterialSkin.Controls.MaterialButton();
            btnMVariabilityTest = new MaterialSkin.Controls.MaterialButton();
            btnMUniformentTest = new MaterialSkin.Controls.MaterialButton();
            lsvMTestResults = new MaterialSkin.Controls.MaterialListView();
            lblMTestTitle = new MaterialSkin.Controls.MaterialLabel();
            gpbTestResultsMV = new GroupBox();
            lsvMTestResultsU = new MaterialSkin.Controls.MaterialListView();
            lblMValueN = new MaterialSkin.Controls.MaterialLabel();
            lblMValueM = new MaterialSkin.Controls.MaterialLabel();
            lblMChiCompareToResult = new MaterialSkin.Controls.MaterialLabel();
            lblMErrGen = new MaterialSkin.Controls.MaterialLabel();
            btnMNumsToFile = new MaterialSkin.Controls.MaterialButton();
            gpbTestResultsU = new GroupBox();
            lblMTesUTitle = new MaterialSkin.Controls.MaterialLabel();
            grpTheme.SuspendLayout();
            gpbTestResultsMV.SuspendLayout();
            gpbTestResultsU.SuspendLayout();
            SuspendLayout();
            // 
            // txtMSeed
            // 
            txtMSeed.AnimateReadOnly = false;
            txtMSeed.BorderStyle = BorderStyle.None;
            txtMSeed.Depth = 0;
            txtMSeed.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMSeed.LeadingIcon = null;
            txtMSeed.Location = new Point(40, 152);
            txtMSeed.MaxLength = 50;
            txtMSeed.MouseState = MaterialSkin.MouseState.OUT;
            txtMSeed.Multiline = false;
            txtMSeed.Name = "txtMSeed";
            txtMSeed.Size = new Size(245, 50);
            txtMSeed.TabIndex = 21;
            txtMSeed.Text = "";
            txtMSeed.TrailingIcon = null;
            txtMSeed.TextChanged += txt_TextChanged;
            // 
            // lblMSeed1
            // 
            lblMSeed1.AutoSize = true;
            lblMSeed1.Depth = 0;
            lblMSeed1.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblMSeed1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblMSeed1.Location = new Point(39, 123);
            lblMSeed1.MouseState = MaterialSkin.MouseState.HOVER;
            lblMSeed1.Name = "lblMSeed1";
            lblMSeed1.Size = new Size(67, 24);
            lblMSeed1.TabIndex = 22;
            lblMSeed1.Text = "Semilla";
            // 
            // lblMErrSeed
            // 
            lblMErrSeed.Depth = 0;
            lblMErrSeed.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblMErrSeed.ForeColor = Color.Red;
            lblMErrSeed.HighEmphasis = true;
            lblMErrSeed.Location = new Point(39, 205);
            lblMErrSeed.MouseState = MaterialSkin.MouseState.HOVER;
            lblMErrSeed.Name = "lblMErrSeed";
            lblMErrSeed.Size = new Size(246, 49);
            lblMErrSeed.TabIndex = 23;
            lblMErrSeed.Text = "Error Semilla";
            lblMErrSeed.UseAccent = true;
            lblMErrSeed.UseWaitCursor = true;
            lblMErrSeed.Visible = false;
            // 
            // swMLight
            // 
            swMLight.AutoSize = true;
            swMLight.Depth = 0;
            swMLight.Location = new Point(110, 25);
            swMLight.Margin = new Padding(0);
            swMLight.MouseLocation = new Point(-1, -1);
            swMLight.MouseState = MaterialSkin.MouseState.HOVER;
            swMLight.Name = "swMLight";
            swMLight.Ripple = true;
            swMLight.Size = new Size(94, 37);
            swMLight.TabIndex = 24;
            swMLight.Text = "Light";
            swMLight.UseVisualStyleBackColor = true;
            swMLight.CheckedChanged += swMLight_CheckedChanged;
            // 
            // lblMTheme
            // 
            lblMTheme.AutoSize = true;
            lblMTheme.Depth = 0;
            lblMTheme.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblMTheme.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblMTheme.Location = new Point(22, 28);
            lblMTheme.MouseState = MaterialSkin.MouseState.HOVER;
            lblMTheme.Name = "lblMTheme";
            lblMTheme.Size = new Size(52, 24);
            lblMTheme.TabIndex = 25;
            lblMTheme.Text = "Tema";
            // 
            // grpTheme
            // 
            grpTheme.Controls.Add(lblMTheme);
            grpTheme.Controls.Add(swMLight);
            grpTheme.Location = new Point(1170, 123);
            grpTheme.Name = "grpTheme";
            grpTheme.Size = new Size(223, 75);
            grpTheme.TabIndex = 26;
            grpTheme.TabStop = false;
            // 
            // lblMAmOfNum
            // 
            lblMAmOfNum.AutoSize = true;
            lblMAmOfNum.Depth = 0;
            lblMAmOfNum.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblMAmOfNum.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblMAmOfNum.Location = new Point(40, 263);
            lblMAmOfNum.MouseState = MaterialSkin.MouseState.HOVER;
            lblMAmOfNum.Name = "lblMAmOfNum";
            lblMAmOfNum.Size = new Size(191, 24);
            lblMAmOfNum.TabIndex = 27;
            lblMAmOfNum.Text = "Cantidad de números";
            // 
            // lblMErrNum
            // 
            lblMErrNum.Depth = 0;
            lblMErrNum.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblMErrNum.HighEmphasis = true;
            lblMErrNum.Location = new Point(40, 343);
            lblMErrNum.MouseState = MaterialSkin.MouseState.HOVER;
            lblMErrNum.Name = "lblMErrNum";
            lblMErrNum.Size = new Size(245, 56);
            lblMErrNum.TabIndex = 28;
            lblMErrNum.Text = "Error numeros";
            lblMErrNum.UseAccent = true;
            lblMErrNum.Visible = false;
            // 
            // txtMNumOfNumbers
            // 
            txtMNumOfNumbers.AnimateReadOnly = false;
            txtMNumOfNumbers.BorderStyle = BorderStyle.None;
            txtMNumOfNumbers.Depth = 0;
            txtMNumOfNumbers.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMNumOfNumbers.LeadingIcon = null;
            txtMNumOfNumbers.Location = new Point(40, 290);
            txtMNumOfNumbers.MaxLength = 50;
            txtMNumOfNumbers.MouseState = MaterialSkin.MouseState.OUT;
            txtMNumOfNumbers.Multiline = false;
            txtMNumOfNumbers.Name = "txtMNumOfNumbers";
            txtMNumOfNumbers.Size = new Size(245, 50);
            txtMNumOfNumbers.TabIndex = 29;
            txtMNumOfNumbers.Text = "";
            txtMNumOfNumbers.TrailingIcon = null;
            txtMNumOfNumbers.TextChanged += txt_TextChanged;
            // 
            // lblMPivot
            // 
            lblMPivot.AutoSize = true;
            lblMPivot.Depth = 0;
            lblMPivot.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblMPivot.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblMPivot.Location = new Point(325, 123);
            lblMPivot.MouseState = MaterialSkin.MouseState.HOVER;
            lblMPivot.Name = "lblMPivot";
            lblMPivot.Size = new Size(83, 24);
            lblMPivot.TabIndex = 30;
            lblMPivot.Text = "Semilla 2";
            lblMPivot.Visible = false;
            // 
            // lblMErrPivot
            // 
            lblMErrPivot.Depth = 0;
            lblMErrPivot.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblMErrPivot.HighEmphasis = true;
            lblMErrPivot.Location = new Point(325, 203);
            lblMErrPivot.MouseState = MaterialSkin.MouseState.HOVER;
            lblMErrPivot.Name = "lblMErrPivot";
            lblMErrPivot.Size = new Size(245, 49);
            lblMErrPivot.TabIndex = 31;
            lblMErrPivot.Text = "Error Semilla";
            lblMErrPivot.UseAccent = true;
            lblMErrPivot.Visible = false;
            // 
            // txtMPivot
            // 
            txtMPivot.AnimateReadOnly = false;
            txtMPivot.BorderStyle = BorderStyle.None;
            txtMPivot.Depth = 0;
            txtMPivot.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMPivot.LeadingIcon = null;
            txtMPivot.Location = new Point(325, 153);
            txtMPivot.MaxLength = 50;
            txtMPivot.MouseState = MaterialSkin.MouseState.OUT;
            txtMPivot.Multiline = false;
            txtMPivot.Name = "txtMPivot";
            txtMPivot.Size = new Size(245, 50);
            txtMPivot.TabIndex = 32;
            txtMPivot.Text = "";
            txtMPivot.TrailingIcon = null;
            txtMPivot.Visible = false;
            txtMPivot.TextChanged += txt_TextChanged;
            // 
            // cmbMAlgorithm
            // 
            cmbMAlgorithm.AutoResize = false;
            cmbMAlgorithm.BackColor = Color.FromArgb(255, 255, 255);
            cmbMAlgorithm.Depth = 0;
            cmbMAlgorithm.DrawMode = DrawMode.OwnerDrawVariable;
            cmbMAlgorithm.DropDownHeight = 174;
            cmbMAlgorithm.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMAlgorithm.DropDownWidth = 121;
            cmbMAlgorithm.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbMAlgorithm.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbMAlgorithm.FormattingEnabled = true;
            cmbMAlgorithm.IntegralHeight = false;
            cmbMAlgorithm.ItemHeight = 43;
            cmbMAlgorithm.Items.AddRange(new object[] { "Cuadrados medios", "Productos medios", "Multiplicador constante" });
            cmbMAlgorithm.Location = new Point(608, 155);
            cmbMAlgorithm.MaxDropDownItems = 4;
            cmbMAlgorithm.MouseState = MaterialSkin.MouseState.OUT;
            cmbMAlgorithm.Name = "cmbMAlgorithm";
            cmbMAlgorithm.Size = new Size(245, 49);
            cmbMAlgorithm.StartIndex = 0;
            cmbMAlgorithm.TabIndex = 33;
            cmbMAlgorithm.SelectedIndexChanged += cmbMAlgorithm_SelectedIndexChanged;
            // 
            // lblMAlgorithm
            // 
            lblMAlgorithm.AutoSize = true;
            lblMAlgorithm.Depth = 0;
            lblMAlgorithm.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblMAlgorithm.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblMAlgorithm.Location = new Point(608, 123);
            lblMAlgorithm.MouseState = MaterialSkin.MouseState.HOVER;
            lblMAlgorithm.Name = "lblMAlgorithm";
            lblMAlgorithm.Size = new Size(88, 24);
            lblMAlgorithm.TabIndex = 34;
            lblMAlgorithm.Text = "Algoritmo";
            // 
            // btnMGenerate
            // 
            btnMGenerate.AutoSize = false;
            btnMGenerate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMGenerate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnMGenerate.Depth = 0;
            btnMGenerate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMGenerate.HighEmphasis = true;
            btnMGenerate.Icon = Properties.Resources.dice_three_solid;
            btnMGenerate.Location = new Point(608, 232);
            btnMGenerate.Margin = new Padding(4, 6, 4, 6);
            btnMGenerate.MouseState = MaterialSkin.MouseState.HOVER;
            btnMGenerate.Name = "btnMGenerate";
            btnMGenerate.NoAccentTextColor = Color.Empty;
            btnMGenerate.Size = new Size(245, 69);
            btnMGenerate.TabIndex = 35;
            btnMGenerate.Text = "Generar números";
            btnMGenerate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnMGenerate.UseAccentColor = false;
            btnMGenerate.UseVisualStyleBackColor = true;
            btnMGenerate.Click += btnMGenerate_Click;
            // 
            // listMRandomNumbers
            // 
            listMRandomNumbers.BackColor = Color.WhiteSmoke;
            listMRandomNumbers.BorderColor = Color.LightGray;
            listMRandomNumbers.Density = MaterialSkin.Controls.MaterialListBox.MaterialItemDensity.Default;
            listMRandomNumbers.Depth = 0;
            listMRandomNumbers.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listMRandomNumbers.Location = new Point(39, 443);
            listMRandomNumbers.MouseState = MaterialSkin.MouseState.HOVER;
            listMRandomNumbers.Name = "listMRandomNumbers";
            listMRandomNumbers.RightToLeft = RightToLeft.No;
            listMRandomNumbers.SelectedIndex = -1;
            listMRandomNumbers.SelectedItem = null;
            listMRandomNumbers.Size = new Size(246, 475);
            listMRandomNumbers.TabIndex = 36;
            // 
            // lblMGeneratedNums
            // 
            lblMGeneratedNums.AutoSize = true;
            lblMGeneratedNums.Depth = 0;
            lblMGeneratedNums.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblMGeneratedNums.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblMGeneratedNums.Location = new Point(67, 411);
            lblMGeneratedNums.MouseState = MaterialSkin.MouseState.HOVER;
            lblMGeneratedNums.Name = "lblMGeneratedNums";
            lblMGeneratedNums.Size = new Size(181, 24);
            lblMGeneratedNums.TabIndex = 37;
            lblMGeneratedNums.Text = "Números generados";
            // 
            // sldMTrustLevel
            // 
            sldMTrustLevel.Depth = 0;
            sldMTrustLevel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            sldMTrustLevel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            sldMTrustLevel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sldMTrustLevel.Location = new Point(307, 443);
            sldMTrustLevel.MouseState = MaterialSkin.MouseState.HOVER;
            sldMTrustLevel.Name = "sldMTrustLevel";
            sldMTrustLevel.Size = new Size(263, 40);
            sldMTrustLevel.TabIndex = 38;
            sldMTrustLevel.Text = "";
            // 
            // lblMTrustLevel
            // 
            lblMTrustLevel.AutoSize = true;
            lblMTrustLevel.Depth = 0;
            lblMTrustLevel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblMTrustLevel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblMTrustLevel.Location = new Point(325, 416);
            lblMTrustLevel.MouseState = MaterialSkin.MouseState.HOVER;
            lblMTrustLevel.Name = "lblMTrustLevel";
            lblMTrustLevel.Size = new Size(165, 24);
            lblMTrustLevel.TabIndex = 39;
            lblMTrustLevel.Text = "Nivel de confianza";
            // 
            // btnMAverageTest
            // 
            btnMAverageTest.AutoSize = false;
            btnMAverageTest.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMAverageTest.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnMAverageTest.Depth = 0;
            btnMAverageTest.HighEmphasis = true;
            btnMAverageTest.Icon = Properties.Resources.chart_simple_solid;
            btnMAverageTest.Location = new Point(325, 567);
            btnMAverageTest.Margin = new Padding(4, 6, 4, 6);
            btnMAverageTest.MouseState = MaterialSkin.MouseState.HOVER;
            btnMAverageTest.Name = "btnMAverageTest";
            btnMAverageTest.NoAccentTextColor = Color.Empty;
            btnMAverageTest.Size = new Size(245, 69);
            btnMAverageTest.TabIndex = 40;
            btnMAverageTest.Text = "Prueba de medias";
            btnMAverageTest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnMAverageTest.UseAccentColor = false;
            btnMAverageTest.UseVisualStyleBackColor = true;
            btnMAverageTest.Click += btnMAverageTest_Click;
            // 
            // btnMVariabilityTest
            // 
            btnMVariabilityTest.AutoSize = false;
            btnMVariabilityTest.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMVariabilityTest.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnMVariabilityTest.Depth = 0;
            btnMVariabilityTest.HighEmphasis = true;
            btnMVariabilityTest.Icon = Properties.Resources.chart_line_solid;
            btnMVariabilityTest.Location = new Point(325, 648);
            btnMVariabilityTest.Margin = new Padding(4, 6, 4, 6);
            btnMVariabilityTest.MouseState = MaterialSkin.MouseState.HOVER;
            btnMVariabilityTest.Name = "btnMVariabilityTest";
            btnMVariabilityTest.NoAccentTextColor = Color.Empty;
            btnMVariabilityTest.Size = new Size(245, 69);
            btnMVariabilityTest.TabIndex = 41;
            btnMVariabilityTest.Text = "Prueba de varianza";
            btnMVariabilityTest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnMVariabilityTest.UseAccentColor = false;
            btnMVariabilityTest.UseVisualStyleBackColor = true;
            btnMVariabilityTest.Click += btnMVariabilityTest_Click;
            // 
            // btnMUniformentTest
            // 
            btnMUniformentTest.AutoSize = false;
            btnMUniformentTest.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMUniformentTest.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnMUniformentTest.Depth = 0;
            btnMUniformentTest.HighEmphasis = true;
            btnMUniformentTest.Icon = Properties.Resources.scale_balanced_solid;
            btnMUniformentTest.Location = new Point(325, 729);
            btnMUniformentTest.Margin = new Padding(4, 6, 4, 6);
            btnMUniformentTest.MouseState = MaterialSkin.MouseState.HOVER;
            btnMUniformentTest.Name = "btnMUniformentTest";
            btnMUniformentTest.NoAccentTextColor = Color.Empty;
            btnMUniformentTest.Size = new Size(245, 69);
            btnMUniformentTest.TabIndex = 42;
            btnMUniformentTest.Text = "Prueba de uniformidad";
            btnMUniformentTest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnMUniformentTest.UseAccentColor = false;
            btnMUniformentTest.UseVisualStyleBackColor = true;
            btnMUniformentTest.Click += btnMUniformentTest_Click;
            // 
            // lsvMTestResults
            // 
            lsvMTestResults.AutoSizeTable = false;
            lsvMTestResults.BackColor = Color.FromArgb(255, 255, 255);
            lsvMTestResults.BorderStyle = BorderStyle.None;
            lsvMTestResults.CausesValidation = false;
            lsvMTestResults.Depth = 0;
            lsvMTestResults.FullRowSelect = true;
            lsvMTestResults.Location = new Point(14, 44);
            lsvMTestResults.MaximumSize = new Size(581, 50);
            lsvMTestResults.MinimumSize = new Size(763, 65);
            lsvMTestResults.MouseLocation = new Point(-1, -1);
            lsvMTestResults.MouseState = MaterialSkin.MouseState.OUT;
            lsvMTestResults.Name = "lsvMTestResults";
            lsvMTestResults.OwnerDraw = true;
            lsvMTestResults.Size = new Size(763, 65);
            lsvMTestResults.TabIndex = 43;
            lsvMTestResults.UseCompatibleStateImageBehavior = false;
            lsvMTestResults.View = View.Details;
            lsvMTestResults.Visible = false;
            // 
            // lblMTestTitle
            // 
            lblMTestTitle.Depth = 0;
            lblMTestTitle.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblMTestTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblMTestTitle.HighEmphasis = true;
            lblMTestTitle.Location = new Point(14, 17);
            lblMTestTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblMTestTitle.Name = "lblMTestTitle";
            lblMTestTitle.Size = new Size(763, 19);
            lblMTestTitle.TabIndex = 44;
            lblMTestTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblMTestTitle.Visible = false;
            // 
            // gpbTestResultsMV
            // 
            gpbTestResultsMV.Controls.Add(lblMTestTitle);
            gpbTestResultsMV.Controls.Add(lsvMTestResults);
            gpbTestResultsMV.Location = new Point(608, 399);
            gpbTestResultsMV.Name = "gpbTestResultsMV";
            gpbTestResultsMV.Size = new Size(792, 124);
            gpbTestResultsMV.TabIndex = 45;
            gpbTestResultsMV.TabStop = false;
            // 
            // lsvMTestResultsU
            // 
            lsvMTestResultsU.AutoSizeTable = false;
            lsvMTestResultsU.BackColor = Color.FromArgb(255, 255, 255);
            lsvMTestResultsU.BorderStyle = BorderStyle.None;
            lsvMTestResultsU.Depth = 0;
            lsvMTestResultsU.FullRowSelect = true;
            lsvMTestResultsU.Location = new Point(14, 75);
            lsvMTestResultsU.MinimumSize = new Size(200, 100);
            lsvMTestResultsU.MouseLocation = new Point(-1, -1);
            lsvMTestResultsU.MouseState = MaterialSkin.MouseState.OUT;
            lsvMTestResultsU.Name = "lsvMTestResultsU";
            lsvMTestResultsU.OwnerDraw = true;
            lsvMTestResultsU.Size = new Size(763, 273);
            lsvMTestResultsU.TabIndex = 46;
            lsvMTestResultsU.UseCompatibleStateImageBehavior = false;
            lsvMTestResultsU.View = View.Details;
            lsvMTestResultsU.Visible = false;
            // 
            // lblMValueN
            // 
            lblMValueN.Depth = 0;
            lblMValueN.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblMValueN.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblMValueN.HighEmphasis = true;
            lblMValueN.Location = new Point(14, 42);
            lblMValueN.MouseState = MaterialSkin.MouseState.HOVER;
            lblMValueN.Name = "lblMValueN";
            lblMValueN.Size = new Size(145, 30);
            lblMValueN.TabIndex = 47;
            lblMValueN.Text = "N";
            lblMValueN.Visible = false;
            // 
            // lblMValueM
            // 
            lblMValueM.Depth = 0;
            lblMValueM.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblMValueM.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblMValueM.HighEmphasis = true;
            lblMValueM.Location = new Point(175, 42);
            lblMValueM.MouseState = MaterialSkin.MouseState.HOVER;
            lblMValueM.Name = "lblMValueM";
            lblMValueM.Size = new Size(153, 30);
            lblMValueM.TabIndex = 48;
            lblMValueM.Text = "M";
            lblMValueM.Visible = false;
            // 
            // lblMChiCompareToResult
            // 
            lblMChiCompareToResult.Depth = 0;
            lblMChiCompareToResult.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblMChiCompareToResult.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblMChiCompareToResult.HighEmphasis = true;
            lblMChiCompareToResult.Location = new Point(14, 351);
            lblMChiCompareToResult.MouseState = MaterialSkin.MouseState.HOVER;
            lblMChiCompareToResult.Name = "lblMChiCompareToResult";
            lblMChiCompareToResult.Size = new Size(763, 26);
            lblMChiCompareToResult.TabIndex = 49;
            lblMChiCompareToResult.Text = "Chi cuadrada: ";
            lblMChiCompareToResult.Visible = false;
            // 
            // lblMErrGen
            // 
            lblMErrGen.Depth = 0;
            lblMErrGen.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblMErrGen.HighEmphasis = true;
            lblMErrGen.Location = new Point(325, 486);
            lblMErrGen.MouseState = MaterialSkin.MouseState.HOVER;
            lblMErrGen.Name = "lblMErrGen";
            lblMErrGen.Size = new Size(245, 57);
            lblMErrGen.TabIndex = 50;
            lblMErrGen.Text = "Error Gen";
            lblMErrGen.UseAccent = true;
            lblMErrGen.Visible = false;
            // 
            // btnMNumsToFile
            // 
            btnMNumsToFile.AutoSize = false;
            btnMNumsToFile.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMNumsToFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnMNumsToFile.Depth = 0;
            btnMNumsToFile.HighEmphasis = true;
            btnMNumsToFile.Icon = Properties.Resources.file_arrow_down_solid;
            btnMNumsToFile.Location = new Point(608, 313);
            btnMNumsToFile.Margin = new Padding(4, 6, 4, 6);
            btnMNumsToFile.MouseState = MaterialSkin.MouseState.HOVER;
            btnMNumsToFile.Name = "btnMNumsToFile";
            btnMNumsToFile.NoAccentTextColor = Color.Empty;
            btnMNumsToFile.Size = new Size(245, 69);
            btnMNumsToFile.TabIndex = 51;
            btnMNumsToFile.Text = "GUARDAR EN .TXT";
            btnMNumsToFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnMNumsToFile.UseAccentColor = false;
            btnMNumsToFile.UseVisualStyleBackColor = true;
            btnMNumsToFile.Click += btnMNumsToFile_Click;
            // 
            // gpbTestResultsU
            // 
            gpbTestResultsU.Controls.Add(lblMTesUTitle);
            gpbTestResultsU.Controls.Add(lblMChiCompareToResult);
            gpbTestResultsU.Controls.Add(lblMValueM);
            gpbTestResultsU.Controls.Add(lblMValueN);
            gpbTestResultsU.Controls.Add(lsvMTestResultsU);
            gpbTestResultsU.Location = new Point(608, 529);
            gpbTestResultsU.Name = "gpbTestResultsU";
            gpbTestResultsU.Size = new Size(792, 389);
            gpbTestResultsU.TabIndex = 52;
            gpbTestResultsU.TabStop = false;
            // 
            // lblMTesUTitle
            // 
            lblMTesUTitle.Depth = 0;
            lblMTesUTitle.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblMTesUTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblMTesUTitle.HighEmphasis = true;
            lblMTesUTitle.Location = new Point(14, 10);
            lblMTesUTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblMTesUTitle.Name = "lblMTesUTitle";
            lblMTesUTitle.Size = new Size(763, 23);
            lblMTesUTitle.TabIndex = 50;
            lblMTesUTitle.Text = "PRUEBA DE UNIFORMIDAD";
            lblMTesUTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblMTesUTitle.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1429, 956);
            Controls.Add(gpbTestResultsU);
            Controls.Add(btnMNumsToFile);
            Controls.Add(lblMErrGen);
            Controls.Add(gpbTestResultsMV);
            Controls.Add(btnMGenerate);
            Controls.Add(btnMUniformentTest);
            Controls.Add(btnMVariabilityTest);
            Controls.Add(btnMAverageTest);
            Controls.Add(lblMTrustLevel);
            Controls.Add(sldMTrustLevel);
            Controls.Add(lblMGeneratedNums);
            Controls.Add(listMRandomNumbers);
            Controls.Add(lblMAlgorithm);
            Controls.Add(cmbMAlgorithm);
            Controls.Add(txtMPivot);
            Controls.Add(lblMErrPivot);
            Controls.Add(lblMPivot);
            Controls.Add(txtMNumOfNumbers);
            Controls.Add(lblMErrNum);
            Controls.Add(lblMAmOfNum);
            Controls.Add(grpTheme);
            Controls.Add(lblMErrSeed);
            Controls.Add(lblMSeed1);
            Controls.Add(txtMSeed);
            FormStyle = FormStyles.ActionBar_64;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Padding = new Padding(3, 88, 3, 2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "🎲 GENERADOR DE NÚMEROS ALEATORIOS";
            grpTheme.ResumeLayout(false);
            grpTheme.PerformLayout();
            gpbTestResultsMV.ResumeLayout(false);
            gpbTestResultsU.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txtMSeed;
        private MaterialSkin.Controls.MaterialLabel lblMSeed1;
        private MaterialSkin.Controls.MaterialLabel lblMErrSeed;
        private MaterialSkin.Controls.MaterialSwitch swMLight;
        private MaterialSkin.Controls.MaterialLabel lblMTheme;
        private GroupBox grpTheme;
        private MaterialSkin.Controls.MaterialLabel lblMAmOfNum;
        private MaterialSkin.Controls.MaterialLabel lblMErrNum;
        private MaterialSkin.Controls.MaterialTextBox txtMNumOfNumbers;
        private MaterialSkin.Controls.MaterialLabel lblMPivot;
        private MaterialSkin.Controls.MaterialLabel lblMErrPivot;
        private MaterialSkin.Controls.MaterialTextBox txtMPivot;
        private MaterialSkin.Controls.MaterialComboBox cmbMAlgorithm;
        private MaterialSkin.Controls.MaterialLabel lblMAlgorithm;
        private MaterialSkin.Controls.MaterialButton btnMGenerate;
        private MaterialSkin.Controls.MaterialListBox listMRandomNumbers;
        private MaterialSkin.Controls.MaterialLabel lblMGeneratedNums;
        private MaterialSkin.Controls.MaterialSlider materialSlider1;
        private MaterialSkin.Controls.MaterialSlider sldMTrustLevel;
        private MaterialSkin.Controls.MaterialLabel lblMTrustLevel;
        private MaterialSkin.Controls.MaterialButton btnMAverageTest;
        private MaterialSkin.Controls.MaterialButton btnMVariabilityTest;
        private MaterialSkin.Controls.MaterialButton btnMUniformentTest;
        private MaterialSkin.Controls.MaterialListView lsvMTestResults;
        private MaterialSkin.Controls.MaterialLabel lblMTestTitle;
        private GroupBox gpbTestResultsMV;
        private MaterialSkin.Controls.MaterialListView lsvMTestResultsU;
        private MaterialSkin.Controls.MaterialLabel lblMValueN;
        private MaterialSkin.Controls.MaterialLabel lblMValueM;
        private MaterialSkin.Controls.MaterialLabel lblMChiCompareToResult;
        private MaterialSkin.Controls.MaterialLabel lblMErrGen;
        private MaterialSkin.Controls.MaterialButton btnMNumsToFile;
        private GroupBox gpbTestResultsU;
        private MaterialSkin.Controls.MaterialLabel lblMTesUTitle;
    }
}
