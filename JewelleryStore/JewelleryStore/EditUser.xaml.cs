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
using System.Windows.Shapes;

namespace JewelleryStore
{
    /// <summary>
    /// Interaction logic for EditUser.xaml
    /// </summary>
    public partial class EditUser : Window
    {
        zaposleni user;
        StoreDb db = new StoreDb();

        public EditUser()
        {
            InitializeComponent();
            AddBtn.Visibility = Visibility.Visible;
            EditBtn.Visibility = Visibility.Collapsed;
            userLabel.Content = "";
        }

        public EditUser(zaposleni user)
        {
            InitializeComponent();
            this.user = user;
            userLabel.Content = user.Ime + " " + user.Prezime;
            adminCheckBox.IsChecked = user.isAdmin;

            nameField.Text = user.Ime;
            lastnameField.Text = user.Prezime;
            usernameField.Text = user.KorisnickoIme;
            passwordField.Text = user.Lozinka;
            salaryField.Text = user.Plata.ToString();

            adminCheckBox.IsChecked = user.isAdmin;
            dateSince.SelectedDate = user.ZaposlenOd;

            AddBtn.Visibility = Visibility.Collapsed;
            EditBtn.Visibility = Visibility.Visible;
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void EditUserInfo(object sender, RoutedEventArgs e)
        {
            var zap = db.zaposlenis.First(o => o.idZaposlenog == user.idZaposlenog);
            if (nameField.Text != "") zap.Ime = nameField.Text;
            if (lastnameField.Text != "") zap.Prezime = lastnameField.Text;
            if (usernameField.Text != "") zap.KorisnickoIme = usernameField.Text;
            if (passwordField.Text != "") zap.Lozinka = passwordField.Text;
            if (salaryField.Text != "") zap.Plata = Decimal.Parse(salaryField.Text);
            zap.isAdmin = (bool)adminCheckBox.IsChecked;

            if(dateSince.SelectedDate != null)
             zap.ZaposlenOd = (DateTime)dateSince.SelectedDate;

            db.SaveChanges();
            this.Close();
            //Console.WriteLine(zap.Ime + " " + zap.Prezime + " " + zap.KorisnickoIme +  " " + zap.Lozinka + " " + zap.Plata + " " + zap.isAdmin + " " +zap.ZaposlenOd );
        }

        private void AddUser(object sender, RoutedEventArgs e)
        {
            user = new zaposleni();

            if (nameField.Text != "") user.Ime = nameField.Text;
            if (lastnameField.Text != "") user.Prezime = lastnameField.Text;
            if (usernameField.Text != "") user.KorisnickoIme = usernameField.Text;
            if (passwordField.Text != "") user.Lozinka = passwordField.Text;
            if (salaryField.Text != "") user.Plata = Int32.Parse(salaryField.Text);
            user.isAdmin = (bool)adminCheckBox.IsChecked;

            if (dateSince.SelectedDate != null)
                user.ZaposlenOd = (DateTime)dateSince.SelectedDate;

            user.isActive = true;

            db.zaposlenis.Add(user);
            db.SaveChanges();
            this.Close();

        }
    }
}
