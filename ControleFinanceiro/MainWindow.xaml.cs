using System.Collections.ObjectModel;
using System.Windows;
using System;

namespace ControleFinanceiro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Gasto> Gastos;

        public MainWindow()
        {
            InitializeComponent();

            Gastos = new ObservableCollection<Gasto>()
            {
                new Gasto(){Title = "arroz",   AmountSpent = "4.85",  Date = DateTime.Now},
                new Gasto(){Title = "feijão",  AmountSpent = "12,75", Date = DateTime.Now},
                new Gasto(){Title = "farinha", AmountSpent = "2,50",  Date = DateTime.Now}

            };
            listGastos.ItemsSource = Gastos;
        }
    }
}
