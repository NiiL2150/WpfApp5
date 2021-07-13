using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    class User : INotifyPropertyChanged
    {
        private string name = "";
        private string password = "";

        public string Name
        {
            get => name;
            set
            {
                if (!this.name.Equals(value))
                {
                    this.name = value;
                    OnChange(new PropertyChangedEventArgs(nameof(this.name)));
                }
            }
        }

        public string Password
        {
            get => password;
            set
            {
                if (!this.password.Equals(value))
                {
                    this.password = value;
                    OnChange(new PropertyChangedEventArgs(nameof(this.password)));
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
