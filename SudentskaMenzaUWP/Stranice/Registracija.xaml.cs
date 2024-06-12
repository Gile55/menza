using Microsoft.Extensions.DependencyInjection;
using Serilog;
using SudentskaMenzaUWP.ViewModel;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SudentskaMenzaUWP.Stranice
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Registracija : Page
    {

        private RegistracijaViewModel ViewModel { get { return (RegistracijaViewModel) DataContext; } }

        public Registracija()
        {
            this.InitializeComponent();
            var container = ((App)Application.Current).Container;
            DataContext = ActivatorUtilities.GetServiceOrCreateInstance(container, typeof(RegistracijaViewModel));
        }

        private void OdabirTipaKorisnikaPromjenjen(object sender, SelectionChangedEventArgs e)
        {
            ViewModel.OdabirTipaKorisnikaPromjenjen((sender as ListView).SelectedItem as TipKorisnika);
            ddbOdabirTipaKorisnika.Flyout.Hide();
            ddbOdabirTipaKorisnika.Content = ViewModel.OdabraniTipKorisnika.Naziv;
            lblIdentifikacijskoPolje.Text = ViewModel.IdentifikacijskoPolje; 
        }

        private void Registracija_Klik(object sender, RoutedEventArgs e)
        {
            ViewModel.Registracija(ViewModel.OdabraniTipKorisnika.Oznaka, tbIdentifikacijskoPolje.Text, tbPunoIme.Text, tbLozinka.Text);
        }
    }
}
