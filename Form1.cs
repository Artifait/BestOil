namespace BestOil
{
    public enum TypeOil
    {
        Oil92,
        Oil95
    }

    public partial class Form1 : Form
    {
        UserInput Input;
        int CountOrders = 0;
        double dayGain;

        public bool SumSmenaNado = true;
        public bool VolumeSmenaNado = true;

        public Form1()
        {
            Input = new UserInput();
            InitializeComponent();
            
            Settings.ReadSettings();
            UpdateCofePriceView();
        }
        private void InputTypeOil_SelectedIndexChanged(object sender, EventArgs e)
        {
            Input.OilType = (TypeOil)InputTypeOil.SelectedIndex;
            ViewPriceOil.Text = Settings.GetOilPrice(Input.OilType).ToString();

            SumSmenaNado = false;
            InputVolume.Text = GetPrice(Input.BuySumOfOil / Settings.GetOilPrice(Input.OilType));
            SumSmenaNado = true;

            UpdateOilView();
        }

        private void VolumeType_CheckedChanged(object sender, EventArgs e)
        {
            InputVolume.ReadOnly = false;
            InputSum.ReadOnly = true;
        }

        private void SumType_CheckedChanged(object sender, EventArgs e)
        {
            InputVolume.ReadOnly = true;
            InputSum.ReadOnly = false;
        }

        private void InputVolume_TextChanged(object sender, EventArgs e)
        {
            if (InputVolume.Text.Length == 0)
                InputVolume.Text = "0";

            double Litrs = double.Parse(InputVolume.Text);
            Input.BuySumOfOil = Litrs * Settings.GetOilPrice(Input.OilType);

            if (SumSmenaNado)
            {
                VolumeSmenaNado = false;
                InputSum.Text = GetPrice(Input.BuySumOfOil);
                VolumeSmenaNado = true;
            }

            UpdateOilView();
        }

        private void InputSum_TextChanged(object sender, EventArgs e)
        {
            if (InputSum.Text.Length == 0)
                InputSum.Text = "0";

            double Sum = double.Parse(InputSum.Text);
            Input.BuySumOfOil = Sum;


            if (VolumeSmenaNado)
            {
                SumSmenaNado = false;
                InputVolume.Text = GetPrice(Sum / Settings.GetOilPrice(Input.OilType));
                SumSmenaNado = true;
            }
            UpdateOilView();
        }


        public string GetPrice(double price)
        {
            string StrPrice = price.ToString("#.##");

            if (string.IsNullOrWhiteSpace(StrPrice)) StrPrice = "0";
            if (StrPrice[0] == ',') StrPrice = '0' + StrPrice;

            return StrPrice;
        }

        public void UpdateCofePriceView()
        {
            ViewBurgerPrice.Text = Settings.hamburgerPrice.ToString("#.##");
            ViewCocaColaPrice.Text = Settings.cocaColaPrice.ToString("#.##");
            ViewFrenchFryPrice.Text = Settings.frenchFriesPrice.ToString("#.##");
            ViewHotDogPrice.Text = Settings.hotDogPrice.ToString("#.##");
        }
        public void UpdateOilView()
        {
            string StrSumOfOil = GetPrice(Input.BuySumOfOil);
            string StrTotalSum = GetPrice(Input.TotalBuySum);


            ViewTotalOilPrice.Text = StrSumOfOil;
            ViewTotalPrice.Text = StrTotalSum;
        }
        public void UpdateCofeView()
        {
            string StrSumOfCofe = GetPrice(Input.BuySumOfCofe);
            string StrTotalSum = GetPrice(Input.TotalBuySum);

            ViewTotalCofePrice.Text = StrSumOfCofe;
            ViewTotalPrice.Text = StrTotalSum;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormClosing += new FormClosingEventHandler(Main_FormClosing);
        }

        private void InputHotDogCount_ValueChanged(object sender, EventArgs e)
        {
            Input.CountHotDog = Convert.ToInt32(InputHotDogCount.Value);

            if (Input.CountHotDog == 0) checkBoxHotDog.CheckState = CheckState.Unchecked;
            else checkBoxHotDog.CheckState = CheckState.Checked;

            UpdateCofeView();
        }

        private void InputBurgerCount_ValueChanged(object sender, EventArgs e)
        {
            Input.CountBurger = Convert.ToInt32(InputBurgerCount.Value);

            if (Input.CountBurger == 0) checkBoxBurger.CheckState = CheckState.Unchecked;
            else checkBoxBurger.CheckState = CheckState.Checked;

            UpdateCofeView();
        }

        private void InputFrenchFryCount_ValueChanged(object sender, EventArgs e)
        {
            Input.CountFrenchFry = Convert.ToInt32(InputFrenchFryCount.Value);

            if (Input.CountFrenchFry == 0) checkBoxFrenchFry.CheckState = CheckState.Unchecked;
            else checkBoxFrenchFry.CheckState = CheckState.Checked;

            UpdateCofeView();
        }

        private void InputCocaColaCount_ValueChanged(object sender, EventArgs e)
        {
            Input.CountCocaCola = Convert.ToInt32(InputCocaColaCount.Value);

            if (Input.CountCocaCola == 0) checkBoxCocaCola.CheckState = CheckState.Unchecked;
            else checkBoxCocaCola.CheckState = CheckState.Checked;

            UpdateCofeView();
        }
        private void checkBoxHotDog_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxHotDog.Checked)
            {
                Input.CountHotDog = 0;
                InputHotDogCount.Value = 0;
            }

            UpdateCofeView();
        }
        private void checkBoxBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxBurger.Checked)
            {
                Input.CountBurger = 0;
                InputBurgerCount.Value = 0;
            }

            UpdateCofeView();
        }

        private void checkBoxFrenchFry_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxFrenchFry.Checked)
            {
                Input.CountFrenchFry = 0;
                InputFrenchFryCount.Value = 0;
            }

            UpdateCofeView();
        }

        private void checkBoxCocaCola_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxCocaCola.Checked)
            {
                Input.CountCocaCola = 0;
                InputCocaColaCount.Value = 0;
            }

            UpdateCofeView();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            CountOrders++;
            //isPause = true;
            fCheck c = new fCheck(CountOrders, BuildCheckString());
            Settings.gain += Input.TotalBuySum;
            Settings.WriteSettings();
            dayGain += Input.TotalBuySum;
            c.ShowDialog();
        }

        public string BuildCheckString()
        {
            string TotalString = string.Empty;

            TotalString += $"Всего: {Input.TotalBuySum} RUB\n===========================\n\n";

            if (Input.BuySumOfOil != 0)
            {
                TotalString += $"Заправка: {Input.BuySumOfOil} RUB\n===========================\n";

                TotalString += $"Бензин: {Enum.GetName(Input.OilType)}, {Settings.GetOilPrice(Input.OilType)} RUB/L\n";
                TotalString += $"Кол-во: {Input.BuySumOfOil / Settings.GetOilPrice(Input.OilType)} L\n\n";

            }


            if (Input.BuySumOfCofe != 0)
            {
                TotalString += $"Кафе: {Input.BuySumOfCofe} RUB\n===========================\n";

                if(Input.CountHotDog != 0)
                    TotalString += $"Хот-Дог: {Input.CountHotDog} шт. - {Input.CountHotDog * Settings.hotDogPrice} RUB\n";
                if (Input.CountCocaCola != 0)
                    TotalString += $"Кока-Кола: {Input.CountCocaCola} шт. - {Input.CountCocaCola * Settings.cocaColaPrice} RUB\n";
                if (Input.CountBurger != 0)
                    TotalString += $"Бургер: {Input.CountBurger} шт. - {Input.CountBurger * Settings.hamburgerPrice} RUB\n";
                if (Input.CountFrenchFry != 0)
                    TotalString += $"Картошка-Фри: {Input.CountFrenchFry} шт. - {Input.CountFrenchFry * Settings.frenchFriesPrice} RUB\n";
            }

            return TotalString;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show($"Day gain: {dayGain} {Settings.currency}\nTotal gain: {Settings.gain} {Settings.currency}", "Gain Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
