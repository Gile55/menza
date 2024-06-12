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
        private PrijavaViewModel ViewModel { get { return (PrijavaViewModel)DataContext; } }

        public Prijava()
        {
            this.InitializeComponent();
            var container = ((App)Application.Current).Container;
            DataContext = ActivatorUtilities.GetServiceOrCreateInstance(container, typeof(PrijavaViewModel));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
        }

        private void OdabirTipaKorisnikaPromjenjen(object sender, SelectionChangedEventArgs e)
        {
            ViewModel.OdabirTipaKorisnikaPromjenjen((sender as ListView).SelectedItem as TipKorisnika);
            ddbOdabirTipaKorisnika.Flyout.Hide();
            ddbOdabirTipaKorisnika.Content = ViewModel.OdabraniTipKorisnika.Naziv;
            lblIdentifikacijskoPolje.Text = ViewModel.IdentifikacijskoPolje;
        }

        private void Prijava_Klik(object sender, RoutedEventArgs e)
        {
            ViewModel.Prijava(ViewModel.OdabraniTipKorisnika.Oznaka, tbIdentifikacijskoPolje.Text, tbLozinka.Text);
        }

        private void Registracija_Klik(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Registracija));
        }
    }
}
