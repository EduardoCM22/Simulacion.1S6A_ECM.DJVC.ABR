using System.Collections.ObjectModel;
using System.Runtime.Intrinsics.X86;

namespace Generador_de_Numeros_Aleatorios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (txtSeed.Text.Length < 4) return;
            if (txtNumOfNumbers.Text.Length == 0) return;
            if (cmbAlgorithm.SelectedIndex < 0) return;

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
            int index = cmbAlgorithm.SelectedIndex;
            switch (index)
            {
                case 0:
                    lblPivot.Visible = false;
                    txtPivot.Visible = false;
                    txtPivot.Enabled = false;
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
    }
}
