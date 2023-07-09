using Prism.Commands;
using Prism.Regions;
using Project_Prism_Modules.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project_Prism_Modules.ViewModels
{
    public class LoginViewModel : BaseClass 
    {
        public DelegateCommand LoginCommand { get; set; }

        public DelegateCommand SignupCommand { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new DelegateCommand(LoginMethod);
        }

        private string _username;

        public string Username
        {
            get { return _username; }
            set { _username = value;
                OnPropertyChanged("Username");
            }
                   
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value;
                OnPropertyChanged("Password");
                }
        }



        private void LoginMethod()
        {
           
        }
    }
}
