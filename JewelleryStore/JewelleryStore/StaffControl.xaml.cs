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

namespace JewelleryStore
{
    /// <summary>
    /// Interaction logic for StaffControl.xaml
    /// </summary>
    public partial class StaffControl : UserControl
    {
        zaposleni user;
        StoreDb db = new StoreDb();

        public StaffControl()
        {
            InitializeComponent();
        }

        public StaffControl(zaposleni user)
        {
            this.user = user;
            InitializeComponent();

            nameLabel.Text = user.Ime + " " + user.Prezime;
            usernameLabel.Content = user.KorisnickoIme;
            sinceLabel.Content = user.ZaposlenOd;
            salaryLabel.Content = user.Plata;
        
       }

        private void DeleteUser(object sender, RoutedEventArgs e)
        {
            zaposleni zap = db.zaposlenis.First( o => o.idZaposlenog == user.idZaposlenog);
            zap.isActive = false;
            db.SaveChanges();
            ((StackPanel)this.Parent).Children.Remove(this);
        }
    }
}
