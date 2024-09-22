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
            cmbAlgorithm = new ComboBox();
            lblSeed1 = new Label();
            txtSeed = new TextBox();
            txtNumOfNumbers = new TextBox();
            label2 = new Label();
            listRandomNumbers = new ListBox();
            btnGenerate = new Button();
            btnAverageTest = new Button();
            btnVariabilityTest = new Button();
            btnUniformentTest = new Button();
            label3 = new Label();
            txtPivot = new TextBox();
            lblPivot = new Label();
            lblErrSeed = new Label();
            lblErrNum = new Label();
            lblErrPivot = new Label();
            label1 = new Label();
            label4 = new Label();
            numUpDwNC = new NumericUpDown();
            resultado = new Label();
            ((System.ComponentModel.ISupportInitialize)numUpDwNC).BeginInit();
            SuspendLayout();
            // 
            // cmbAlgorithm
            // 
            cmbAlgorithm.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAlgorithm.FormattingEnabled = true;
            cmbAlgorithm.Items.AddRange(new object[] { "Cuadrados medios", "Productos medios", "Multiplicador constante" });
            cmbAlgorithm.Location = new Point(881, 50);
            cmbAlgorithm.Name = "cmbAlgorithm";
            cmbAlgorithm.Size = new Size(207, 28);
            cmbAlgorithm.TabIndex = 0;
            cmbAlgorithm.SelectedIndexChanged += cmbAlgorithm_SelectedIndexChanged;
            // 
            // lblSeed1
            // 
            lblSeed1.AutoSize = true;
            lblSeed1.Location = new Point(29, 28);
            lblSeed1.Name = "lblSeed1";
            lblSeed1.Size = new Size(58, 20);
            lblSeed1.TabIndex = 1;
            lblSeed1.Text = "Semilla";
            // 
            // txtSeed
            // 
            txtSeed.Location = new Point(29, 51);
            txtSeed.Name = "txtSeed";
            txtSeed.Size = new Size(160, 27);
            txtSeed.TabIndex = 2;
            txtSeed.TextChanged += txt_TextChanged;
            // 
            // txtNumOfNumbers
            // 
            txtNumOfNumbers.Location = new Point(29, 139);
            txtNumOfNumbers.Name = "txtNumOfNumbers";
            txtNumOfNumbers.Size = new Size(160, 27);
            txtNumOfNumbers.TabIndex = 4;
            txtNumOfNumbers.TextChanged += txt_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 116);
            label2.Name = "label2";
            label2.Size = new Size(151, 20);
            label2.TabIndex = 3;
            label2.Text = "Cantidad de números";
            // 
            // listRandomNumbers
            // 
            listRandomNumbers.FormattingEnabled = true;
            listRandomNumbers.Location = new Point(29, 259);
            listRandomNumbers.Name = "listRandomNumbers";
            listRandomNumbers.Size = new Size(160, 264);
            listRandomNumbers.TabIndex = 5;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(881, 109);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(207, 27);
            btnGenerate.TabIndex = 6;
            btnGenerate.Text = "Generar números";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnAverageTest
            // 
            btnAverageTest.Location = new Point(233, 405);
            btnAverageTest.Name = "btnAverageTest";
            btnAverageTest.Size = new Size(207, 27);
            btnAverageTest.TabIndex = 7;
            btnAverageTest.Text = "Prueba de medias";
            btnAverageTest.UseVisualStyleBackColor = true;
            btnAverageTest.Click += btnAverageTest_Click;
            // 
            // btnVariabilityTest
            // 
            btnVariabilityTest.Location = new Point(233, 453);
            btnVariabilityTest.Name = "btnVariabilityTest";
            btnVariabilityTest.Size = new Size(207, 27);
            btnVariabilityTest.TabIndex = 8;
            btnVariabilityTest.Text = "Prueba de varianza";
            btnVariabilityTest.UseVisualStyleBackColor = true;
            btnVariabilityTest.Click += btnVariabilityTest_Click;
            // 
            // btnUniformentTest
            // 
            btnUniformentTest.Location = new Point(233, 499);
            btnUniformentTest.Name = "btnUniformentTest";
            btnUniformentTest.Size = new Size(207, 27);
            btnUniformentTest.TabIndex = 9;
            btnUniformentTest.Text = "Prueba de uniformidad";
            btnUniformentTest.UseVisualStyleBackColor = true;
            btnUniformentTest.Click += btnUniformentTest_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 234);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 10;
            label3.Text = "Números generados";
            // 
            // txtPivot
            // 
            txtPivot.Enabled = false;
            txtPivot.Location = new Point(478, 50);
            txtPivot.Name = "txtPivot";
            txtPivot.Size = new Size(160, 27);
            txtPivot.TabIndex = 12;
            txtPivot.Visible = false;
            txtPivot.TextChanged += txt_TextChanged;
            // 
            // lblPivot
            // 
            lblPivot.AutoSize = true;
            lblPivot.Enabled = false;
            lblPivot.Location = new Point(478, 27);
            lblPivot.Name = "lblPivot";
            lblPivot.Size = new Size(70, 20);
            lblPivot.TabIndex = 11;
            lblPivot.Text = "Semilla 2";
            lblPivot.Visible = false;
            // 
            // lblErrSeed
            // 
            lblErrSeed.AutoSize = true;
            lblErrSeed.ForeColor = Color.Red;
            lblErrSeed.Location = new Point(29, 81);
            lblErrSeed.Name = "lblErrSeed";
            lblErrSeed.Size = new Size(94, 20);
            lblErrSeed.TabIndex = 13;
            lblErrSeed.Text = "Error Semilla";
            lblErrSeed.Visible = false;
            // 
            // lblErrNum
            // 
            lblErrNum.AutoSize = true;
            lblErrNum.ForeColor = Color.Red;
            lblErrNum.Location = new Point(29, 169);
            lblErrNum.Name = "lblErrNum";
            lblErrNum.Size = new Size(102, 20);
            lblErrNum.TabIndex = 14;
            lblErrNum.Text = "Error numeros";
            lblErrNum.Visible = false;
            // 
            // lblErrPivot
            // 
            lblErrPivot.AutoSize = true;
            lblErrPivot.ForeColor = Color.Red;
            lblErrPivot.Location = new Point(478, 80);
            lblErrPivot.Name = "lblErrPivot";
            lblErrPivot.Size = new Size(94, 20);
            lblErrPivot.TabIndex = 16;
            lblErrPivot.Text = "Error Semilla";
            lblErrPivot.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(881, 27);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 17;
            label1.Text = "Algoritmo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(233, 338);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 18;
            label4.Text = "Nivel de confianza";
            // 
            // numUpDwNC
            // 
            numUpDwNC.Location = new Point(233, 361);
            numUpDwNC.Name = "numUpDwNC";
            numUpDwNC.Size = new Size(132, 27);
            numUpDwNC.TabIndex = 19;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(497, 318);
            resultado.Name = "resultado";
            resultado.Size = new Size(75, 20);
            resultado.TabIndex = 20;
            resultado.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 539);
            Controls.Add(resultado);
            Controls.Add(numUpDwNC);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(lblErrPivot);
            Controls.Add(lblErrNum);
            Controls.Add(lblErrSeed);
            Controls.Add(txtPivot);
            Controls.Add(lblPivot);
            Controls.Add(label3);
            Controls.Add(btnUniformentTest);
            Controls.Add(btnVariabilityTest);
            Controls.Add(btnAverageTest);
            Controls.Add(btnGenerate);
            Controls.Add(listRandomNumbers);
            Controls.Add(txtNumOfNumbers);
            Controls.Add(label2);
            Controls.Add(txtSeed);
            Controls.Add(lblSeed1);
            Controls.Add(cmbAlgorithm);
            Name = "Form1";
            Text = "Generador de números aleatorios";
            ((System.ComponentModel.ISupportInitialize)numUpDwNC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbAlgorithm;
        private Label lblSeed1;
        private TextBox txtSeed;
        private TextBox txtNumOfNumbers;
        private Label label2;
        private ListBox listRandomNumbers;
        private Button btnGenerate;
        private Button btnAverageTest;
        private Button btnVariabilityTest;
        private Button btnUniformentTest;
        private Label label3;
        private TextBox txtPivot;
        private Label lblPivot;
        private Label lblErrSeed;
        private Label lblErrNum;
        private Label lblErrPivot;
        private Label label1;
        private Label label4;
        private NumericUpDown numUpDwNC;
        private Label resultado;
    }
}
