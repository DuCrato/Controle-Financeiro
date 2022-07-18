using System.Windows;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace ControleFinanceiro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            string titleSpending = txt_title.Text.ToString();
            double valueSpending = double.Parse(txt_value.Text.ToString());
            string valueFormat   = valueSpending.ToString("C");
            string description   = txt_description.Text.ToString();
            var dateUser = Convert.ToDateTime(date_day_buy.Text).ToString("dd/MM/yyyy");

            List<Gasto> gasto = new List<Gasto>();

            gasto.Add(new Gasto()
            {
                Title       = titleSpending,
                AmountSpent = valueFormat,
                Description = description,
                Date        = dateUser
            });

            try
            {
                listGastos.Items.Add(gasto);
            }
            catch
            {
                MessageBox.Show("Informe os dados");
            }

        }

        private void txt_value_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
        }
    }
}
