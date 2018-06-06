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



namespace MyXpenses
{
    /// <summary>
    /// Interação lógica para MyXpensesHome.xam
    /// </summary>
    public partial class MyXpensesHome : Page
    {
        
        public MyXpensesHome()
        {
            InitializeComponent();

            this._appFrame.Navigate(new MyXpensesDashboard());
            
        }
                
        private void menuBtnDashboard_Click(object sender, RoutedEventArgs e)
        {
            this._appFrame.Navigate(new MyXpensesDashboard());
        }

        private void menuBtnDespesas_Click(object sender, RoutedEventArgs e)
        {
            this._appFrame.Navigate(new MyXpensesDespesas());
        }
    }
}
