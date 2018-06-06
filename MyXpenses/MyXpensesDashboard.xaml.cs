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

using LiveCharts;
using LiveCharts.Wpf;

namespace MyXpenses
{
    /// <summary>
    /// Interação lógica para MyXpensesDashboard.xam
    /// </summary>
    public partial class MyXpensesDashboard : Page
    {
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public MyXpensesDashboard()
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
                new Despesa("Desp8", "R$ 296,00", "2018-06-15"),
                new Despesa("Desp1", "R$ 65,48", "2018-06-21"),
                new Despesa("Desp2", "R$ 152,17", "2018-06-15"),
                new Despesa("Desp3", "R$ 101,66", "2018-06-05"),
                new Despesa("Desp4", "R$ 302,00", "2018-06-05"),
                new Despesa("Desp5", "R$ 47,00", "2018-05-30"),
                new Despesa("Desp6", "R$ 676,02", "2018-06-05"),
                new Despesa("Desp7", "R$ 662,79", "2018-06-15"),
                new Despesa("Desp8", "R$ 296,00", "2018-06-15"),
            };

            this.DespesasListView.ItemsSource = despesas;

            // The Chart
            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Series 1",
                    Values = new ChartValues<double> { 4, 6, 5, 2 ,4 }
                }/*,
                new LineSeries
                {
                    Title = "Series 2",
                    Values = new ChartValues<double> { 6, 7, 3, 4 ,6 },
                    PointGeometry = null
                },
                new LineSeries
                {
                    Title = "Series 3",
                    Values = new ChartValues<double> { 4,2,7,2,7 },
                    PointGeometry = DefaultGeometries.Square,
                    PointGeometrySize = 15
                }*/
            };

            Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May" };
            YFormatter = value => value.ToString("C");

            //modifying the series collection will animate and update the chart
            /*
            SeriesCollection.Add(new LineSeries
            {
                Title = "Series 4",
                Values = new ChartValues<double> { 5, 3, 2, 4 },
                LineSmoothness = 0, //0: straight lines, 1: really smooth lines
                PointGeometry = Geometry.Parse("m 25 70.36218 20 -28 -20 22 -8 -6 z"),
                PointGeometrySize = 50,
                PointForeground = Brushes.Gray
            });
            */

            //modifying any series values will also animate and update the chart
            //SeriesCollection[3].Values.Add(5d);

            DataContext = this;
        }

        private class Despesa
        {
            public String Descricao { get; set; }
            public String Valor { get; set; }
            public String DataPago { get; set; }

            public Despesa(String Descricao, String Valor, String DataPago)
            {
                this.DataPago = DataPago;
                this.Descricao = Descricao;
                this.Valor = Valor;
            }
        }
    }
}
