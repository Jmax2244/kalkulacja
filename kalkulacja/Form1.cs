using System;
using System.Windows.Forms;

namespace Kalkulacja
{
    public partial class Form1 : Form
    {
        private const decimal PLNtoUSD = 0.24m;
        private const decimal PLNtoEUR = 0.22m;
        private const decimal PLNtoRUB = 24.30m;
        private const decimal PLNtoTHB = 8.34m;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                decimal amount = Convert.ToDecimal(txtAmount.Text);
                string fromCurrency = GetSelectedFromCurrency();
                string toCurrency = GetSelectedToCurrency();

                decimal result = ConvertCurrency(amount, fromCurrency, toCurrency);
                lblResult.Text = $"{amount} {fromCurrency} = {result} {toCurrency}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"B³¹d: {ex.Message}");
            }
        }

        private string GetSelectedFromCurrency()
        {
            if (rbtnFromPLN.Checked) return "PLN";
            if (rbtnFromUSD.Checked) return "USD";
            if (rbtnFromEUR.Checked) return "EUR";
            if (rbtnFromRUB.Checked) return "RUB";
            if (rbtnFromTHB.Checked) return "THB";
            return "PLN";
        }

        private string GetSelectedToCurrency()
        {
            if (rbtnToPLN.Checked) return "PLN";
            if (rbtnToUSD.Checked) return "USD";
            if (rbtnToEUR.Checked) return "EUR";
            if (rbtnToRUB.Checked) return "RUB";
            if (rbtnToTHB.Checked) return "THB";
            return "PLN";
        }

        private decimal ConvertCurrency(decimal amount, string fromCurrency, string toCurrency)
        {
            if (fromCurrency != "PLN")
            {
                amount = ConvertToPLN(amount, fromCurrency);
            }

            if (toCurrency != "PLN")
            {
                amount = ConvertFromPLN(amount, toCurrency);
            }

            return amount;
        }

        private decimal ConvertToPLN(decimal amount, string fromCurrency)
        {
            switch (fromCurrency)
            {
                case "USD":
                    return amount / PLNtoUSD;
                case "EUR":
                    return amount / PLNtoEUR;
                case "RUB":
                    return amount / PLNtoRUB;
                case "THB":
                    return amount / PLNtoTHB;
                default:
                    return amount;
            }
        }

        private decimal ConvertFromPLN(decimal amount, string toCurrency)
        {
            switch (toCurrency)
            {
                case "USD":
                    return amount * PLNtoUSD;
                case "EUR":
                    return amount * PLNtoEUR;
                case "RUB":
                    return amount * PLNtoRUB;
                case "THB":
                    return amount * PLNtoTHB;
                default:
                    return amount;
            }
        }
    }
}
