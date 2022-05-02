using LMS.Pages;
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

namespace LMS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SignIn signInPage;
        public SignUp signUpPage;
        public HomePage homePage;
        public ProfilePage profile;
        public BookRentPage bookRentPage;   
        public MainWindow()
        {
            InitializeComponent();
            signInPage=new SignIn();
            signUpPage=new SignUp();
            homePage=new HomePage();
            profile = new ProfilePage();
            bookRentPage=new BookRentPage();

        }

        private void SignInPage_Btt_Click(object sender, RoutedEventArgs e)
        {
            MainwindowFrame.Content = signInPage;
        }

        private void SignUpPage_Btt_Click(object sender, RoutedEventArgs e)
        {
            MainwindowFrame.Content = signUpPage;
        }

        private void Back_Bttn(object sender, RoutedEventArgs e)
        {
            if (MainwindowFrame.NavigationService.CanGoBack)
            {
                MainwindowFrame.NavigationService.GoBack();
            }
        }

        private void Forward_Bttn(object sender, RoutedEventArgs e)
        {
            if (MainwindowFrame.NavigationService.CanGoForward)
            {
                MainwindowFrame.NavigationService.GoForward();
            }
        }

        private void HomePage_Btt_Click(object sender, RoutedEventArgs e)
        {
            MainwindowFrame.Content= homePage;
        }

        private void Book_Btt_Click(object sender, RoutedEventArgs e)
        {
            MainwindowFrame.Content = profile;
        }

        private void BookRent_Btt_Click(object sender, RoutedEventArgs e)
        {
            MainwindowFrame.Content = bookRentPage;
        }
    }
}
