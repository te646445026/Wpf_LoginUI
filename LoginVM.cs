using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_LoginUI
{
    internal class LoginVM : INotifyPropertyChanged
    {
		private LoginUIModel _LoginM;

        

        public LoginUIModel LoginM
		{
			get { return _LoginM; }
            set
            {
                _LoginM = value;
                RaisePropertyChanged("LoginM");
            }
		}

        public LoginVM()
        {
            _LoginM = new LoginUIModel();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
