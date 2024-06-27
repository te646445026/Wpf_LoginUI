using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_LoginUI
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        //LoginModel loginModel;

        LoginVM loginVm;
        public MainWindow()
        {
            InitializeComponent();

            //loginModel = new LoginModel();

            //this.DataContext = loginModel;

            loginVm = new LoginVM();
            this.DataContext = loginVm;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string userName = loginVm.LoginM.UserName;
            string password = loginVm.LoginM.Password;

            if (userName == "wpf" && password == "666")
            {
                Index index = new Index();
                index.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("输入的用户名或密码不正确");

                loginVm.LoginM.UserName = "";
                loginVm.LoginM.Password = "";
                loginVm.LoginM = loginVm.LoginM;
            }
        }
    }
}
