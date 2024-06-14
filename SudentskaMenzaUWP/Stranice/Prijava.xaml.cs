using Microsoft.Extensions.DependencyInjection;
using SudentskaMenzaUWP.ViewModel;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SudentskaMenzaUWP.Stranice
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Prijava : Page
    {
        private PrijavaViewModel ViewModel { get { return (PrijavaViewModel)this.DataContext; } }

        public Prijava()
        {
            this.InitializeComponent();
            var container = ((App)Application.Current).Container;
            this.DataContext = ActivatorUtilities.GetServiceOrCreateInstance(container, typeof(PrijavaViewModel));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
        }

        private void OdabirTipaKorisnikaPromjenjen(object sender, SelectionChangedEventArgs e)
        {
            this.ViewModel.OdabirTipaKorisnikaPromjenjen((sender as ListView).SelectedItem as TipKorisnika);
            this.ddbOdabirTipaKorisnika.Flyout.Hide();
            this.ddbOdabirTipaKorisnika.Content = this.ViewModel.OdabraniTipKorisnika.Naziv;
            this.lblIdentifikacijskoPolje.Text = this.ViewModel.IdentifikacijskoPolje;
        }

        private void Prijava_Klik(object sender, RoutedEventArgs e)
        {
            this.ViewModel.Prijava(this.ViewModel.OdabraniTipKorisnika.Oznaka, this.tbIdentifikacijskoPolje.Text, this.tbLozinka.Text);
        }

        private void Registracija_Klik(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Registracija));
        }
    }
}
