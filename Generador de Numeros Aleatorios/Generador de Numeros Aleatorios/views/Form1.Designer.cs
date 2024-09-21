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
            SuspendLayout();
            // 
            // cmbAlgorithm
            // 
            cmbAlgorithm.FormattingEnabled = true;
            cmbAlgorithm.Items.AddRange(new object[] { "Cuadrados medios", "Productos medios", "Multiplicador constante" });
            cmbAlgorithm.Location = new Point(461, 47);
            cmbAlgorithm.Name = "cmbAlgorithm";
            cmbAlgorithm.Size = new Size(207, 28);
            cmbAlgorithm.TabIndex = 0;
            cmbAlgorithm.Text = "Seleccione un algoritmo";
            cmbAlgorithm.SelectedIndexChanged += cmbAlgorithm_SelectedIndexChanged;
            // 
            // lblSeed1
            // 
            lblSeed1.AutoSize = true;
            lblSeed1.Location = new Point(55, 28);
            lblSeed1.Name = "lblSeed1";
            lblSeed1.Size = new Size(58, 20);
            lblSeed1.TabIndex = 1;
            lblSeed1.Text = "Semilla";
            // 
            // txtSeed
            // 
            txtSeed.Location = new Point(55, 51);
            txtSeed.Name = "txtSeed";
            txtSeed.Size = new Size(160, 27);
            txtSeed.TabIndex = 2;
            // 
            // txtNumOfNumbers
            // 
            txtNumOfNumbers.Location = new Point(255, 51);
            txtNumOfNumbers.Name = "txtNumOfNumbers";
            txtNumOfNumbers.Size = new Size(160, 27);
            txtNumOfNumbers.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 28);
            label2.Name = "label2";
            label2.Size = new Size(151, 20);
            label2.TabIndex = 3;
            label2.Text = "Cantidad de números";
            // 
            // listRandomNumbers
            // 
            listRandomNumbers.FormattingEnabled = true;
            listRandomNumbers.Location = new Point(65, 261);
            listRandomNumbers.Name = "listRandomNumbers";
            listRandomNumbers.Size = new Size(160, 364);
            listRandomNumbers.TabIndex = 5;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(461, 117);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(207, 27);
            btnGenerate.TabIndex = 6;
            btnGenerate.Text = "Generar números";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnAverageTest
            // 
            btnAverageTest.Location = new Point(267, 268);
            btnAverageTest.Name = "btnAverageTest";
            btnAverageTest.Size = new Size(207, 27);
            btnAverageTest.TabIndex = 7;
            btnAverageTest.Text = "Prueba de medias";
            btnAverageTest.UseVisualStyleBackColor = true;
            // 
            // btnVariabilityTest
            // 
            btnVariabilityTest.Location = new Point(267, 329);
            btnVariabilityTest.Name = "btnVariabilityTest";
            btnVariabilityTest.Size = new Size(207, 27);
            btnVariabilityTest.TabIndex = 8;
            btnVariabilityTest.Text = "Prueba de varianza";
            btnVariabilityTest.UseVisualStyleBackColor = true;
            // 
            // btnUniformentTest
            // 
            btnUniformentTest.Location = new Point(267, 384);
            btnUniformentTest.Name = "btnUniformentTest";
            btnUniformentTest.Size = new Size(207, 27);
            btnUniformentTest.TabIndex = 9;
            btnUniformentTest.Text = "Prueba de uniformidad";
            btnUniformentTest.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 228);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 10;
            label3.Text = "Números generados";
            // 
            // txtPivot
            // 
            txtPivot.Enabled = false;
            txtPivot.Location = new Point(55, 117);
            txtPivot.Name = "txtPivot";
            txtPivot.Size = new Size(160, 27);
            txtPivot.TabIndex = 12;
            txtPivot.Visible = false;
            // 
            // lblPivot
            // 
            lblPivot.AutoSize = true;
            lblPivot.Enabled = false;
            lblPivot.Location = new Point(55, 94);
            lblPivot.Name = "lblPivot";
            lblPivot.Size = new Size(70, 20);
            lblPivot.TabIndex = 11;
            lblPivot.Text = "Semilla 2";
            lblPivot.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 675);
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
    }
}
