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
using LiveCharts.Defaults;
using LiveCharts.Wpf;



namespace JewelleryStore
{
    /// <summary>
    /// Interaction logic for StatisticsPage.xaml
    /// </summary>
    public partial class StatisticsPage : Page
    {
        StoreDb db = new StoreDb();


        public StatisticsPage()
        {
            InitializeComponent();
            PointLabel = chartPoint =>
               string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            int necklaces = count(1);
            int rings = count(2);
            int earrings = count(3);
            int wristwear = count(4);

            SeriesCollection = new SeriesCollection {
                new PieSeries
                {
                    Title = (string) App.Current.Resources["Necklaces"],
                    Values = new ChartValues<ObservableValue> { new ObservableValue(necklaces)},
                    DataLabels = true

                },
                new PieSeries
                {
                    Title = (string) App.Current.Resources["Rings"],
                    Values = new ChartValues<ObservableValue> { new ObservableValue(rings)},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = (string) App.Current.Resources["Earrings"],
                    Values = new ChartValues<ObservableValue> { new ObservableValue(earrings)},
                    DataLabels = true

                },
                new PieSeries
                {
                    Title = (string) App.Current.Resources["Wristwear"],
                    Values = new ChartValues<ObservableValue> { new ObservableValue(wristwear)},
                    DataLabels = true

                }
            };
            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public Func<ChartPoint, string> PointLabel { get; set; }

        private void Chart_OnDataClick(object sender, ChartPoint chartpoint)
        {
            var chart = (LiveCharts.Wpf.PieChart)chartpoint.ChartView;

            //clear selected slice.
            foreach (PieSeries series in chart.Series)
                series.PushOut = 0;

            var selectedSeries = (PieSeries)chartpoint.SeriesView;
            selectedSeries.PushOut = 0;
        }

        private int count(int id)
        {
            int sum = 0;
           // Console.WriteLine(id);
           foreach (var rac in db.racuns.ToList())
           {
                //Console.WriteLine("racun : " + rac.idRacuna + " " + db.racuns.ToList().Count());
                foreach (var st in rac.racun_stavka.ToList())
                {
                       var proizvod = db.proizvods.First(o => o.SifraProizvoda == st.SifraProizvoda);
                       Console.WriteLine(proizvod.Naziv + " " + st.SifraProizvoda + "  " + st.Kolicina + "  " + st.Cijena);
                       if (proizvod.tipProizvoda == id)
                       {
                           sum+=st.Kolicina;
                       }
                   
                }
            }
            return sum;
        }
    }
}
