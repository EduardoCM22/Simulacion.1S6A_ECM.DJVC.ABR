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
            comboBox1 = new ComboBox();
            label1 = new Label();
            txtSeed = new TextBox();
            txtNumOfNumbers = new TextBox();
            label2 = new Label();
            listRandomNumbers = new ListBox();
            btnGenerate = new Button();
            btnAverageTest = new Button();
            btnVariabilityTest = new Button();
            btnUniformentTest = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Seleccione un algoritmo", "Cuadrados medios", "Productos medios", "Multiplicador constante" });
            comboBox1.Location = new Point(247, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(207, 28);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 28);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 1;
            label1.Text = "Semilla";
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
            txtNumOfNumbers.Location = new Point(55, 121);
            txtNumOfNumbers.Name = "txtNumOfNumbers";
            txtNumOfNumbers.Size = new Size(160, 27);
            txtNumOfNumbers.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 98);
            label2.Name = "label2";
            label2.Size = new Size(151, 20);
            label2.TabIndex = 3;
            label2.Text = "Cantidad de números";
            // 
            // listRandomNumbers
            // 
            listRandomNumbers.FormattingEnabled = true;
            listRandomNumbers.Location = new Point(55, 173);
            listRandomNumbers.Name = "listRandomNumbers";
            listRandomNumbers.Size = new Size(160, 364);
            listRandomNumbers.TabIndex = 5;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(247, 121);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(207, 27);
            btnGenerate.TabIndex = 6;
            btnGenerate.Text = "Generar";
            btnGenerate.UseVisualStyleBackColor = true;
            // 
            // btnAverageTest
            // 
            btnAverageTest.Location = new Point(247, 188);
            btnAverageTest.Name = "btnAverageTest";
            btnAverageTest.Size = new Size(207, 27);
            btnAverageTest.TabIndex = 7;
            btnAverageTest.Text = "Prueba de medias";
            btnAverageTest.UseVisualStyleBackColor = true;
            // 
            // btnVariabilityTest
            // 
            btnVariabilityTest.Location = new Point(247, 249);
            btnVariabilityTest.Name = "btnVariabilityTest";
            btnVariabilityTest.Size = new Size(207, 27);
            btnVariabilityTest.TabIndex = 8;
            btnVariabilityTest.Text = "Prueba de varianza";
            btnVariabilityTest.UseVisualStyleBackColor = true;
            // 
            // btnUniformentTest
            // 
            btnUniformentTest.Location = new Point(247, 304);
            btnUniformentTest.Name = "btnUniformentTest";
            btnUniformentTest.Size = new Size(207, 27);
            btnUniformentTest.TabIndex = 9;
            btnUniformentTest.Text = "Prueba de uniformidad";
            btnUniformentTest.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 549);
            Controls.Add(btnUniformentTest);
            Controls.Add(btnVariabilityTest);
            Controls.Add(btnAverageTest);
            Controls.Add(btnGenerate);
            Controls.Add(listRandomNumbers);
            Controls.Add(txtNumOfNumbers);
            Controls.Add(label2);
            Controls.Add(txtSeed);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Generador de números aleatorios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private TextBox txtSeed;
        private TextBox txtNumOfNumbers;
        private Label label2;
        private ListBox listRandomNumbers;
        private Button btnGenerate;
        private Button btnAverageTest;
        private Button btnVariabilityTest;
        private Button btnUniformentTest;
    }
}
