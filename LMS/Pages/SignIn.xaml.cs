using System;
using System.Collections.Generic;
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

namespace LMS.Pages
{
    /// <summary>
    /// Interaction logic for SignIn.xaml
    /// </summary>
    public partial class SignIn : Page
    {
        public SignIn()
        {
            InitializeComponent();
        }
        private void go_to_singUp_Page(object sender, RoutedEventArgs e)
        {
            SignUp signUp = new SignUp();
            
           
        }
        private void go_to_home_page(object sender, RoutedEventArgs e)
        {
            HomePage homePage = new HomePage();
           

        }
    }
}
