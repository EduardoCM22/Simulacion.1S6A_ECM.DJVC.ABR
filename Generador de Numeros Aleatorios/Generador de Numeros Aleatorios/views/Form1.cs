using System.Collections.ObjectModel;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Xml.Serialization;
using MathNet.Numerics.Statistics;
using MathNet.Numerics.Distributions;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System;

namespace Generador_de_Numeros_Aleatorios
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            sldMTrustLevel.Value = 95;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Lime600, Primary.Lime800, Primary.Lime800, Accent.Lime700, TextShade.BLACK);



            cmbMAlgorithm.SelectedIndex = 0;
        }

        MaterialSkinManager TManager = MaterialSkinManager.Instance;

        private bool inputValidation()
        {
            bool errSeed;
            bool errNumOfNumbers;
            bool errPivot;

            if (txtMSeed.Text.Length < 4)
            {
                lblMErrSeed.Visible = true;
                lblMErrSeed.Text = "La semilla debe contener al menos 4 dígitos.";
                errSeed = true;
            }
            else
            {
                if (!int.TryParse(txtMSeed.Text, out _))
                {
                    lblMErrSeed.Visible = true;
                    lblMErrSeed.Text = "Semilla inválida.";
                    errSeed = true;
                }
                else
                {
                    lblMErrSeed.Visible = false;
                    errSeed = false;
                }
            }

            if (txtMNumOfNumbers.Text.Length == 0)
            {
                lblMErrNum.Visible = true;
                lblMErrNum.Text = "Ingrese la cantidad de números.";
                errNumOfNumbers = true;
            }
            else
            {
                int amount;
                if (!int.TryParse(txtMNumOfNumbers.Text, out amount))
                {
                    lblMErrNum.Visible = true;
                    lblMErrNum.Text = "Cantidad inválida.";
                    errNumOfNumbers = true;
                }
                else
                {
                    if (amount == 0)
                    {
                        lblMErrNum.Visible = true;
                        lblMErrNum.Text = "Cantidad inválida.";
                        errNumOfNumbers = true;
                    }
                    else
                    {
                        lblMErrNum.Visible = false;
                        errNumOfNumbers = false;
                    }
                }
            }

            if (txtMPivot.Visible == true)
            {
                if (lblMPivot.Text == "Semilla 2")
                {
                    if (txtMPivot.Text.Length != txtMSeed.Text.Length || txtMPivot.Text.Length == 0)
                    {
                        lblMErrPivot.Visible = true;
                        lblMErrPivot.Text = "Las semillas deben contener la misma cantidad de dígitos.";
                        errPivot = true;
                    }
                    else
                    {
                        if (!int.TryParse(txtMPivot.Text, out _))
                        {
                            lblMErrPivot.Visible = true;
                            lblMErrPivot.Text = "Semilla 2 inválida.";
                            errPivot = true;
                        }
                        else
                        {
                            lblMErrPivot.Visible = false;
                            errPivot = false;
                        }
                    }
                }
                else
                {
                    if (txtMPivot.Text.Length < 4)
                    {
                        lblMErrPivot.Visible = true;
                        lblMErrPivot.Text = "El multiplicador debe contener al menos 4 dígitos.";
                        errPivot = true;
                    }
                    else
                    {
                        if (!int.TryParse(txtMPivot.Text, out _))
                        {
                            lblMErrPivot.Visible = true;
                            lblMErrPivot.Text = "Multiplicador inválido.";
                            errPivot = true;
                        }
                        else
                        {
                            lblMErrPivot.Visible = false;
                            errPivot = false;
                        }
                    }
                }
            }
            else
            {
                errPivot = false;
            }

            if (errSeed == false && errNumOfNumbers == false && errPivot == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool testValidation()
        {
            if (!genNum)
            {
                lblMErrGen.Visible = true;
                lblMErrGen.Text = "Genera primero los números.";
                return false;
            }
            else
            {
                lblMErrGen.Visible = false;
                return true;
            }
        }
        private void txt_TextChanged(object sender, EventArgs e)
        {
            MaterialTextBox txtActual = sender as MaterialTextBox;
            if (txtActual.Equals(txtMSeed))
            {
                lblMErrSeed.Visible = false;
            }
            else if (txtActual.Equals(txtMNumOfNumbers))
            {
                lblMErrNum.Visible = false;
            }
            else
            {
                lblMErrPivot.Visible = false;
            }
        }


        private Collection<String> MeanSqueres()
        {
            string seed = txtMSeed.Text;
            int amount = Convert.ToInt32(txtMNumOfNumbers.Text);
            int seedLength = seed.Length;
            Collection<String> list = new Collection<String>();

            for (int i = 0; i < amount; i++)
            {
                seed = GetMeanNumbers(seedLength, Math.Pow(long.Parse(seed), 2).ToString());
                if (int.Parse(seed) == 0)
                {
                    MessageBox.Show("Solo se pueden generar " + i + " números con la semilla ingresada.",
                        "Límite de generación", MessageBoxButtons.OK);
                    return list;
                }
                list.Add("0." + seed);
            }
            return list;
        }

        private Collection<String> MeanProducts()
        {
            string seed1 = txtMSeed.Text;
            string seed2 = txtMPivot.Text;
            int amount = Convert.ToInt32(txtMNumOfNumbers.Text);
            int seedLength = seed1.Length;

            Collection<String> list = new Collection<String>();
            for (int i = 0; i < amount; i++)
            {
                string aux = seed2;
                seed2 = GetMeanNumbers(seedLength, (int.Parse(seed1) * int.Parse(seed2)).ToString());
                if (int.Parse(seed2) == 0)
                {
                    MessageBox.Show("Solo se pueden generar " + i + " números con la semilla ingresada.",
                        "Límite de generación", MessageBoxButtons.OK);
                    return list;
                }
                seed1 = aux;
                list.Add("0." + seed2);
            }
            return list;
        }

        private Collection<String> ConstantMultiplier()
        {
            string seed = txtMSeed.Text;
            string multiplier = txtMPivot.Text;
            int amount = Convert.ToInt32(txtMNumOfNumbers.Text);
            int seedLength = seed.Length;

            Collection<String> list = new Collection<String>();
            for (int i = 0; i < amount; i++)
            {
                seed = GetMeanNumbers(seedLength, (int.Parse(multiplier) * int.Parse(seed)).ToString());
                if (int.Parse(seed) == 0)
                {
                    MessageBox.Show("Solo se pueden generar " + i + " números con la semilla ingresada.",
                        "Límite de generación", MessageBoxButtons.OK);
                    return list;
                }
                list.Add("0." + seed);
            }
            return list;
        }

        private string GetMeanNumbers(int seedLength, string seed)
        {
            string nextSeed = ""; // la siguiente semilla en ser generada
            int currentSeedLength = seed.Length; // Longitud de la semilla actual
            int dif = currentSeedLength - seedLength; // Diferencia entre las longitudes

            nextSeed = seed.Substring(dif / 2, seedLength);
            return nextSeed;
        }


        private void swMLight_CheckedChanged(object sender, EventArgs e)
        {
            if (!swMLight.Checked)
            {
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;
                swMLight.Text = "Light";
            }
            else
            {
                TManager.Theme = MaterialSkinManager.Themes.DARK;
                swMLight.Text = "Dark";
            }
            inputValidation();
        }

        static bool genNum = false;
        static int genAmount = 0;
        private void btnMGenerate_Click(object sender, EventArgs e)
        {
            if (inputValidation() == false) return;
            genNum = true;

            Collection<String> randomNumbersList = new Collection<String>();
            listMRandomNumbers.Items.Clear();

            int algoritmo = cmbMAlgorithm.SelectedIndex;

            switch (algoritmo)
            {
                case 0:
                    randomNumbersList = MeanSqueres();
                    genAmount = randomNumbersList.Count;
                    break;
                case 1:
                    randomNumbersList = MeanProducts();
                    genAmount = randomNumbersList.Count;
                    break;
                case 2:
                    randomNumbersList = ConstantMultiplier();
                    genAmount = randomNumbersList.Count;
                    break;
                default:
                    break;
            }


            foreach (var number in randomNumbersList)
            {
                listMRandomNumbers.Items.Add(new MaterialListBoxItem(number));
            }

            gpbTestResultsMV.Visible = false;
            lblMTestTitle.Text = "";
            lsvMTestResults.Clear();
            lsvMTestResultsU.Clear();
            lblMValueM.Visible = false;
            lblMValueN.Visible = false;
            lblMTestTitle.Visible = false;
            lsvMTestResults.Visible = false;
        }

        private void cmbMAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMErrPivot.Visible = false;
            lblMErrNum.Visible = false;
            lblMErrSeed.Visible = false;

            int index = cmbMAlgorithm.SelectedIndex;
            switch (index)
            {
                case 0:
                    lblMPivot.Visible = false;
                    txtMPivot.Visible = false;
                    txtMPivot.Enabled = false;
                    txtMPivot.Text = string.Empty;
                    break;
                case 1:
                    lblMPivot.Text = "Semilla 2";
                    lblMPivot.Visible = true;
                    lblMPivot.Enabled = true;
                    txtMPivot.Visible = true;
                    txtMPivot.Enabled = true;
                    break;
                case 2:
                    lblMPivot.Text = "Multiplicador";
                    lblMPivot.Enabled = true;
                    lblMPivot.Visible = true;
                    txtMPivot.Visible = true;
                    txtMPivot.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void testResultsMV(String method, String li, String mOrV, String ls)
        {
            String methodColumn = method == "Varianza" ? "Varianza" : "Media";
            lsvMTestResults.Clear();
            int totalWidth = lsvMTestResults.ClientSize.Width;
            lsvMTestResults.Columns.Add("Límite Inferior", (int)(totalWidth * (1.0 / 3.0)));
            lsvMTestResults.Columns.Add(methodColumn, (int)(totalWidth * (1.0 / 3.0)));
            lsvMTestResults.Columns.Add("Límite Superior", (int)(totalWidth * (1.0 / 3.0)));

            ListViewItem filaValores = new ListViewItem(new[] { li.ToString(), mOrV.ToString(), ls.ToString() });
            lsvMTestResults.Items.Add(filaValores);
            lblMTestTitle.Text = "Prueba de " + method;
            gpbTestResultsMV.Visible = true;
            lblMTestTitle.Visible = true;
            lsvMTestResults.Visible = true;
        }

        private void btnMAverageTest_Click(object sender, EventArgs e)
        {
            if (!testValidation()) return;
            if (genAmount < 1)
            {
                lblMErrGen.Visible = true;
                lblMErrGen.Text = "Prueba de medias requiere al menos 1 número generado.";
                return;
            }

            List<double> numbers = new List<double>();
            foreach (var number in listMRandomNumbers.Items)
            {

                if (double.TryParse(number.Text, out double value))
                {
                    numbers.Add(value);
                }
            }

            double probability = Convert.ToDouble(sldMTrustLevel.Value) / 100;
            probability = (1 - probability) / 2 + probability;

            double mean = numbers.Average();
            double li = 0.5 - Normal.InvCDF(0, 1, probability) * (1 / Math.Sqrt(12 * numbers.Count));
            double ls = 0.5 + Normal.InvCDF(0, 1, probability) * (1 / Math.Sqrt(12 * numbers.Count));

            testResultsMV("Medias", li.ToString(), mean.ToString(), ls.ToString());
        }

        private void btnMVariabilityTest_Click(object sender, EventArgs e)
        {
            if (!testValidation()) return;
            if (genAmount < 2)
            {
                lblMErrGen.Visible = true;
                lblMErrGen.Text = "Prueba de varianza requiere al menos 2 números generados.";
                return;
            }

            List<double> numbers = new List<double>();
            foreach (var number in listMRandomNumbers.Items)
            {
                if (double.TryParse(number.Text, out double value))
                {
                    numbers.Add(value);
                }
            }

            double probability = Convert.ToDouble(sldMTrustLevel.Value) / 100;
            probability = (1 - probability) / 2 + probability;

            double variance = numbers.Variance();
            double li = ChiSquared.InvCDF(numbers.Count - 1, 1 - probability) / (12 * (numbers.Count - 1));
            double ls = ChiSquared.InvCDF(numbers.Count - 1, probability) / (12 * (numbers.Count - 1));

            //resultado.Text = variance.ToString() + " " + li.ToString() + " " + ls.ToString();

            testResultsMV("Varianza", li.ToString(), variance.ToString(), ls.ToString());
        }

        private void btnMUniformentTest_Click(object sender, EventArgs e)
        {
            if (!testValidation()) return;
            if (genAmount < 2)
            {
                lblMErrGen.Visible = true;
                lblMErrGen.Text = "Prueba de uniformidad requiere al menos 2 números generados.";
                return;
            }

            List<double> numbers = new List<double>();
            foreach (var number in listMRandomNumbers.Items)
            {
                if (double.TryParse(number.Text, out double value))
                {
                    numbers.Add(value);
                }
            }

            double probability = Convert.ToDouble(sldMTrustLevel.Value) / 100;
            probability = (1 - probability) / 2 + probability;

            int n = numbers.Count;
            double m = Math.Ceiling(Math.Sqrt(n));



            List<double> inferiorInterval = new List<double>();
            List<double> superiorInterval = new List<double>();
            //inferiorInterval.Add(0);
            //superiorInterval.Add(1.0/m);
            double intervalSize = 1.0 / m;
            for (int i = 0; i < m; i++)
            {
                //inferiorInterval.Add(inferiorInterval[i] + intervalSize);
                //superiorInterval.Add(superiorInterval[i] + intervalSize);
                inferiorInterval.Add(Math.Round(i * intervalSize, 10));
                superiorInterval.Add(Math.Round((i + 1) * intervalSize, 10));
            }

            int[] frecuencias = new int[(int)m];

            foreach (var number in numbers)
            {
                int indiceIntervalo = (int)(number / intervalSize);
                if (indiceIntervalo >= m)
                {
                    indiceIntervalo = (int)m - 1;
                }
                frecuencias[indiceIntervalo]++;
            }
            Console.WriteLine(inferiorInterval.ToArray().ToString());
            Console.WriteLine(superiorInterval.ToArray().ToString());


            lsvMTestResultsU.Clear();
            int totalWidth = lsvMTestResultsU.ClientSize.Width;
            lsvMTestResultsU.Columns.Add("Intervalo Inferior \"(\"", (int)(totalWidth * 0.2));
            lsvMTestResultsU.Columns.Add("Intervalo Superior \"]\"", (int)(totalWidth * 0.2));
            lsvMTestResultsU.Columns.Add("O", (int)(totalWidth * 0.2));
            lsvMTestResultsU.Columns.Add("E = n/m", (int)(totalWidth * 0.2));
            lsvMTestResultsU.Columns.Add("((E-O)^2)/E", (int)(totalWidth * 0.2));

            ListViewItem filaValores;
            double result = 0;
            double ChiSqrContrubution = 0.0;
            for (int i = 0; i < m; i++)
            {
                ChiSqrContrubution = (Math.Pow(((n / m) - frecuencias[i]), 2) / (n / m));
                result += ChiSqrContrubution;
                filaValores = new ListViewItem(new[] { inferiorInterval[i].ToString(),
                    superiorInterval[i].ToString(),frecuencias[i].ToString(),(n/m).ToString(),ChiSqrContrubution.ToString() });
                lsvMTestResultsU.Items.Add(filaValores);
            }
            double chiQuad = ChiSquared.InvCDF(m - 1, probability);

            lblMValueN.Text = "N = " + n.ToString();
            lblMValueM.Text = "M = " + ((int)m).ToString();
            lblMChiCompareToResult.Text = "Chi cuadrada: " + chiQuad +
                (result < chiQuad ? " > " : " < ") + result;

            lblMValueN.Visible = true;
            lblMValueM.Visible = true;
            lblMChiCompareToResult.Visible = true;
            lsvMTestResultsU.Visible = true;

        }
    }
}
