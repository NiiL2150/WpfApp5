using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace WpfApp5
{
    class DataSource : INotifyPropertyChanged
    {
        private int value = 0;
        public int Value
        {
            get => value;
            set
            {
                if (!this.value.Equals(value))
                {
                    this.value = value;
                    OnChange(new PropertyChangedEventArgs(nameof(this.value)));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnChange(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}
