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
    /// Interação lógica para MyXpensesDespesas.xam
    /// </summary>
    public partial class MyXpensesDespesas : Page
    {
        public MyXpensesDespesas()
        {
            InitializeComponent();

            List<Despesa> despesas = new List<Despesa>
            {
                new Despesa("Desp1", "R$ 65,48", "2018-06-21"),
                new Despesa("Desp2", "R$ 152,17", "2018-06-15"),
                new Despesa("Desp3", "R$ 101,66", "2018-06-05"),
                new Despesa("Desp4", "R$ 302,00", "2018-06-05"),
                new Despesa("Desp5", "R$ 47,00", "2018-05-30"),
                new Despesa("Desp6", "R$ 676,02", "2018-06-05"),
                new Despesa("Desp7", "R$ 662,79", "2018-06-15"),
                new Despesa("Desp8", "R$ 296,00", "2018-06-15")
            };

            this.lstDespesas.ItemsSource = despesas;
        }
    }
}
