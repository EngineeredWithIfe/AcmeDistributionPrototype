using Microsoft.Maui.Controls;
using System;

namespace MyApp
{
    public partial class MainWindow : ContentPage
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DecreaseButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(QuantityTextBox.Text, out int quantity) && quantity > 0)
            {
                QuantityTextBox.Text = (quantity - 1).ToString();
            }
        }

        private void IncreaseButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(QuantityTextBox.Text, out int quantity))
            {
                QuantityTextBox.Text = (quantity + 1).ToString();
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string address = AddressTextBox.Text;
            string searchItem = SearchTextBox.Text;

            if (!int.TryParse(QuantityTextBox.Text, out int quantity) || 
                string.IsNullOrEmpty(address) || 
                string.IsNullOrEmpty(searchItem) || 
                quantity <= 0)
            {
                DisplayAlert("Error", "Please fill in all fields and ensure quantity is greater than 0.", "OK");
                return;
            }

            DisplayAlert("Order Submitted", $"Order submitted!\nAddress: {address}\nItem: {searchItem}\nQuantity: {quantity}", "OK");
        }
    }
}
