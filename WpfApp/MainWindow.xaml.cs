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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public enum State
        {
            admin,  //0
            user,   //1
        }

        //state를 1(일반 사용자)로 초기화 -> 전역 변수 사용
        private State state = State.user;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void adminCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if(state == State.admin)
            {
                logTextBox.Text += Environment.NewLine + "you are admin :)";
                adminCheckBox.IsChecked = true;
                adminCheckBox.IsEnabled = false;
            }
            else
            {
                logTextBox.Text += Environment.NewLine + "you are not admin!! only admin is allowed." ;
                adminCheckBox.IsChecked = false;
                adminCheckBox.IsEnabled = false;
            }
        }

        private void getFlagButton_Click(object sender, RoutedEventArgs e)
        {
            if(state == State.admin && adminCheckBox.IsChecked == true)
            {
                logTextBox.Text += Environment.NewLine + "Success!";
            }
            else
            {
                logTextBox.Text += Environment.NewLine + "only admin is allowed :p" ;
            }
        }
    }
}
