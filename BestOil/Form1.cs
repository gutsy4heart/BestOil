namespace BestOil
{
    public partial class BestOil : Form
    {
        public double GasAI92Price = 0.70;
        public double GasAI95Price = 1.50;
        public double BurgerPrice = 3.20;
        public double HotDogPrice = 1.80;
        public double CocaColaPrice = 1.20;
        public double AmericanoPrice = 1.50;
        public double totalRevenue = 0;
        public BestOil()
        {
            InitializeComponent();
            GasolineComboBox.SelectedItem = "AI-92";
            GasBox.TextChanged += GasBox_TextChanged;
            SumBox.TextChanged += SumBox_TextChanged;
            CalculateTotalPrice();

        }

        private void GasolineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GasolineComboBox.Text == "AI-92")
            {
                priceGas.Text = GasAI92Price.ToString();
            }
            else if (GasolineComboBox.Text == "AI-95")
            {
                priceGas.Text = GasAI95Price.ToString();
            }
            CalculateTotalPrice();
        }

        private void LitresRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (LitresRadioButton1.Checked)
            {

                label5.Text = "$";
                GasBox.Enabled = true ;
                SumBox.Enabled = false;
                SumBox.Clear();
                CalculateGas.Text = "0";
            }
        }

        private void SumRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (SumRadioButton1.Checked)
            {
                label5.Text = "L";
                SumBox.Enabled = true;
                GasBox.Enabled = false;
                GasBox.Clear();
                CalculateGas.Text = "0";
            }
        }

        private void CalculateTotalPrice()
        {
            double pricePerLiter;
            double quantity, amount;

            double? totalQuantity;
            double? totalPriceGas;
            double? BurgerTotalPrice = 0, HotDogTotalPrice = 0, CocaColaTotalPrice = 0, AmericanoTotalPrice = 0;

            if (GasolineComboBox.Text == "AI-92")
            {
                pricePerLiter = GasAI92Price;
            }
            else if (GasolineComboBox.Text == "AI-95")
            {
                pricePerLiter = GasAI95Price;
            }
            else
            {
                return;
            }

            if (LitresRadioButton1.Checked && double.TryParse(GasBox.Text, out quantity))
            {
                totalPriceGas = pricePerLiter * quantity;
                CalculateGas.Text = totalPriceGas.ToString();
            }
            else if (SumRadioButton1.Checked && double.TryParse(SumBox.Text, out amount))
            {
                totalQuantity = amount / pricePerLiter;
                CalculateGas.Text = totalQuantity.ToString();
            }

            if (checkBoxBurger.Checked)
            {
                BurgerTotalPrice = BurgerPrice * (double)numericUpDownBurger.Value;
            }
            if (checkBoxHotDog.Checked)
            {
                HotDogTotalPrice = HotDogPrice * (double)numericUpDownHotDog.Value;
            }
            if (checkBoxCocaCola.Checked)
            {
                CocaColaTotalPrice = CocaColaPrice * (double)numericUpDownCocaCola.Value;
            }
            if (checkBoxAmericano.Checked)
            {
                AmericanoTotalPrice = AmericanoPrice * (double)numericUpDownAmericano.Value;
            }

            double OverAllAmountCafe = BurgerTotalPrice.Value + HotDogTotalPrice.Value + CocaColaTotalPrice.Value + AmericanoTotalPrice.Value;
            CalculateCafe.Text = OverAllAmountCafe.ToString();


        }

        private void GasBox_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }
        private void SumBox_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void checkBoxBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBurger.Checked)
            {
                numericUpDownBurger.Enabled = true;
                if (numericUpDownBurger.Value == 0)
                {
                    numericUpDownBurger.Value = 1;
                }
            }
            else
            {
                numericUpDownBurger.Value = 0;
            }
            if (checkBoxHotDog.Checked)
            {
                numericUpDownHotDog.Enabled = true;
                if (numericUpDownHotDog.Value == 0)
                {
                    numericUpDownHotDog.Value = 1;
                }
            }
            else
            {
                numericUpDownHotDog.Value = 0;
            }
            if (checkBoxCocaCola.Checked)
            {
                numericUpDownCocaCola.Enabled = true;
                if (numericUpDownCocaCola.Value == 0)
                {
                    numericUpDownCocaCola.Value = 1;
                }
            }
            else
            {
                numericUpDownCocaCola.Value = 0;
            }
            if (checkBoxAmericano.Checked)
            {
                numericUpDownAmericano.Enabled = true;
                if (numericUpDownAmericano.Value == 0)
                {
                    numericUpDownAmericano.Value = 1;
                }
            }
            else
            {
                numericUpDownAmericano.Value = 0;
            }



        }

        private void numericUpDownBurger_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void numericUpDownHotDog_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void numericUpDownCocaCola_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void numericUpDownAmericano_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();

        }

        private void CalculateCafe_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }
        private void CalculateGas_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            CalculateTotalPrice();
            double totalPriceGas = Convert.ToDouble(CalculateGas.Text);
            double OverAllAmountCafe = Convert.ToDouble(CalculateCafe.Text);

            totalRevenue = OverAllAmountCafe + totalPriceGas;
            CalculateGasCafe.Text = totalRevenue.ToString();

            StartResetTimer();
        }

        private async void StartResetTimer()
        {
            await Task.Delay(10000);
            DialogResult result = MessageBox.Show("Хотите очистить форму?", "Очистка формы", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ClearForm();
            }
        }

        private void ClearForm()
        {
            GasolineComboBox.SelectedItem = "AI-92";
            GasBox.Clear();
            SumBox.Clear();
            LitresRadioButton1.Checked = true;
            SumRadioButton1.Checked = false;
            checkBoxBurger.Checked = false;
            checkBoxHotDog.Checked = false;
            checkBoxCocaCola.Checked = false;
            checkBoxAmericano.Checked = false;
            numericUpDownBurger.Value = 0;
            numericUpDownHotDog.Value = 0;
            numericUpDownCocaCola.Value = 0;
            numericUpDownAmericano.Value = 0;
            CalculateGas.Text = "0";
            CalculateCafe.Text = "0";
            CalculateGasCafe.Text = "0";
        }



        private void CloseProgram(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show($"Общая сумма выручки за день: {totalRevenue}", "Выручка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
