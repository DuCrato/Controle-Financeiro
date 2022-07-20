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
            if (txt_title.Text == "")
            {
                MessageBox.Show("Campo título em branco!!!","ERROR");
            }else if (txt_value.Text == "")
            {
                MessageBox.Show("Campo valor em branco!!!");
            }else if (date_day_buy.Text == "")
            {
                MessageBox.Show("Campo data em branco!!!");
            }
            else
            {
                string titleSpending = txt_title.Text.ToString();
                double valueSpending = double.Parse(txt_value.Text.ToString());
                string valueFormat = valueSpending.ToString("C");
                string description = txt_description.Text.ToString();
                var dateUser = Convert.ToDateTime(date_day_buy.Text).ToString("dd/MM/yyyy");

                List<Gasto> gasto = new List<Gasto>();

                gasto.Add(new Gasto()
                {
                    Title = titleSpending,
                    AmountSpent = valueFormat,
                    Description = description,
                    Date = dateUser
                });

                listGastos.Items.Add(gasto);

                ClearTextBox();
            }
        }

        private void ClearTextBox()
        {
            txt_title.Text       = "";
            txt_value.Text       = "";
            txt_description.Text = "";
            date_day_buy.Text    = "";
        }

        private void txt_value_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9,]+");
        }
    }
}
