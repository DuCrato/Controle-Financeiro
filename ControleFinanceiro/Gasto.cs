using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;


namespace ControleFinanceiro
{
    class Gasto : INotifyPropertyChanged
    {
        string title,
               amountSpent,
               description;

        DateTime date;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Title
        {
            get => title;
            set
            {
                if (title != value)
                {
                    title = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string AmountSpent
        {
            get => amountSpent;
            set
            {
                if (amountSpent != value)
                {
                    amountSpent = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Description
        {
            get => description;
            set
            {
                if (description != value)
                {
                    description = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public DateTime Date
        {
            get => date;
            set
            {
                if (date != value)
                {
                    date = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public void NotifyPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
