using System.Collections.ObjectModel;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Xml.Serialization;
using MathNet.Numerics.Statistics;
using MathNet.Numerics.Distributions;
using System.Windows.Forms;

namespace Generador_de_Numeros_Aleatorios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbAlgorithm.SelectedIndex = 0;
        }

        private bool inputValidation()
        {
            bool errSeed;
            bool errNumOfNumbers;
            bool errPivot;

            if (txtSeed.Text.Length < 4)
            {
                lblErrSeed.Visible = true;
                lblErrSeed.Text = "La semilla debe contener al menos 4 dígitos.";
                errSeed = true;
            }
            else
            {
                if (!int.TryParse(txtSeed.Text, out _))
                {
                    lblErrSeed.Visible = true;
                    lblErrSeed.Text = "Semilla inválida.";
                    errSeed = true;
                }
                else
                {
                    lblErrSeed.Visible = false;
                    errSeed = false;
                }
            }

            if (txtNumOfNumbers.Text.Length == 0)
            {
                lblErrNum.Visible = true;
                lblErrNum.Text = "Ingrese la cantidad de números.";
                errNumOfNumbers = true;
            }
            else
            {
                if (!int.TryParse(txtNumOfNumbers.Text, out _))
                {
                    lblErrNum.Visible = true;
                    lblErrNum.Text = "Cantidad inválida.";
                    errNumOfNumbers = true;
                }
                else
                {
                    lblErrNum.Visible = false;
                    errNumOfNumbers = false;
                }
            }

            if (txtPivot.Visible == true)
            {
                if (lblPivot.Text == "Semilla 2")
                {
                    if (txtPivot.Text.Length != txtSeed.Text.Length || txtPivot.Text.Length == 0)
                    {
                        lblErrPivot.Visible = true;
                        lblErrPivot.Text = "Las semillas deben contener la misma cantidad de dígitos.";
                        errPivot = true;
                    }
                    else
                    {
                        if (!int.TryParse(txtPivot.Text, out _))
                        {
                            lblErrPivot.Visible = true;
                            lblErrPivot.Text = "Semilla 2 inválida.";
                            errPivot = true;
                        }
                        else
                        {
                            lblErrPivot.Visible = false;
                            errPivot = false;
                        }
                    }
                }
                else
                {
                    if (txtPivot.Text.Length < 4)
                    {
                        lblErrPivot.Visible = true;
                        lblErrPivot.Text = "El multiplicador debe contener al menos 4 dígitos.";
                        errPivot = true;
                    }
                    else
                    {
                        if (!int.TryParse(txtPivot.Text, out _))
                        {
                            lblErrPivot.Visible = true;
                            lblErrPivot.Text = "Multiplicador inválido.";
                            errPivot = true;
                        }
                        else
                        {
                            lblErrPivot.Visible = false;
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
        private void txt_TextChanged(object sender, EventArgs e)
        {
            TextBox txtActual = sender as TextBox;
            if (txtActual == txtSeed)
            {
                lblErrSeed.Visible = false;
            }
            else if (txtActual == txtNumOfNumbers)
            {
                lblErrNum.Visible = false;
            }
            else
            {
                lblErrPivot.Visible = false;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (inputValidation() == false) return;

            Collection<String> randomNumbersList = new Collection<String>();
            listRandomNumbers.Items.Clear();

            int algoritmo = cmbAlgorithm.SelectedIndex;

            switch (algoritmo)
            {
                case 0:
                    listRandomNumbers.Items.AddRange(
                        MeanSqueres().ToArray());
                    break;
                case 1:
                    listRandomNumbers.Items.AddRange(
                        MeanProducts().ToArray());
                    break;
                case 2:
                    listRandomNumbers.Items.AddRange(
                        ConstantMultiplier().ToArray());
                    break;
                default:
                    break;
            }


        }

        private Collection<String> MeanSqueres()
        {
            string seed = txtSeed.Text;
            int amount = Convert.ToInt32(txtNumOfNumbers.Text);
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
            string seed1 = txtSeed.Text;
            string seed2 = txtPivot.Text;
            int amount = Convert.ToInt32(txtNumOfNumbers.Text);
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
            string seed = txtSeed.Text;
            string multiplier = txtPivot.Text;
            int amount = Convert.ToInt32(txtNumOfNumbers.Text);
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

        private void cmbAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblErrPivot.Visible = false;
            lblErrNum.Visible = false;
            lblErrSeed.Visible = false;

            int index = cmbAlgorithm.SelectedIndex;
            switch (index)
            {
                case 0:
                    lblPivot.Visible = false;
                    txtPivot.Visible = false;
                    txtPivot.Enabled = false;
                    txtPivot.Text = string.Empty;
                    break;
                case 1:
                    lblPivot.Text = "Semilla 2";
                    lblPivot.Visible = true;
                    lblPivot.Enabled = true;
                    txtPivot.Visible = true;
                    txtPivot.Enabled = true;
                    break;
                case 2:
                    lblPivot.Text = "Multiplicador";
                    lblPivot.Enabled = true;
                    lblPivot.Visible = true;
                    txtPivot.Visible = true;
                    txtPivot.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void btnAverageTest_Click(object sender, EventArgs e)
        {
            List<double> numbers = new List<double>();
            foreach (var number in listRandomNumbers.Items)
            {
                if (double.TryParse(number.ToString(), out double value))
                {
                    numbers.Add(value);
                }
            }

            double probability = Convert.ToDouble(numUpDwNC.Value) / 100;
            probability = (1 - probability) / 2 + probability;

            double mean = numbers.Average();
            double li = 0.5 - Normal.InvCDF(0, 1, probability) * (1 / Math.Sqrt(12 * numbers.Count));
            double ls = 0.5 + Normal.InvCDF(0, 1, probability) * (1 / Math.Sqrt(12 * numbers.Count));

            resultado.Text = mean.ToString() + " " + li.ToString() + " " + ls.ToString();

        }

        private void btnVariabilityTest_Click(object sender, EventArgs e)
        {
            List<double> numbers = new List<double>();
            foreach (var number in listRandomNumbers.Items)
            {
                if (double.TryParse(number.ToString(), out double value))
                {
                    numbers.Add(value);
                }
            }

            double probability = Convert.ToDouble(numUpDwNC.Value) / 100;
            probability = (1 - probability) / 2 + probability;

            double variance = numbers.Variance();
            double li = ChiSquared.InvCDF(numbers.Count - 1, 1 - probability) / (12 * (numbers.Count - 1));
            double ls = ChiSquared.InvCDF(numbers.Count - 1, probability) / (12 * (numbers.Count - 1));

            resultado.Text = variance.ToString() + " " + li.ToString() + " " + ls.ToString();
        }

        private void btnUniformentTest_Click(object sender, EventArgs e)
        {
            List<double> numbers = new List<double>();
            foreach (var number in listRandomNumbers.Items)
            {
                if (double.TryParse(number.ToString(), out double value))
                {
                    numbers.Add(value);
                }
            }

            double probability = Convert.ToDouble(numUpDwNC.Value) / 100;
            probability = (1 - probability) / 2 + probability;

            int n = numbers.Count;
            double m = Math.Ceiling(Math.Sqrt(n));

            List<double> inferiorInterval = new List<double>();
            List<double> superiorInterval = new List<double>();
            inferiorInterval.Add(0);
            superiorInterval.Add(0.1);
            for (int i = 0; i < m-1; i++)
            {
                inferiorInterval.Add(inferiorInterval[i] + m/100);
                superiorInterval.Add(superiorInterval[i] + m/100);
            }
            Console.WriteLine(inferiorInterval.ToArray().ToString());
            Console.WriteLine(superiorInterval.ToArray().ToString());

        }

    }
}
