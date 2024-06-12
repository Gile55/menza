using System.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using StudentskaMenza.Repozitoriji;
using SudentskaMenzaUWP.Repozitoriji;
using SudentskaMenzaUWP.Servisi;
using SudentskaMenzaUWP.ViewModel;
using System;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using System.Diagnostics;

namespace SudentskaMenzaUWP
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : Application
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;
            Container = ConfigureDependencyInjection();
        }

        public IServiceProvider Container { get; }

        IServiceProvider ConfigureDependencyInjection()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddSingleton<StudentRepozitorij, StudentRepozitorij>();
            serviceCollection.AddSingleton<VoditeljMenzeRepozitorij, VoditeljMenzeRepozitorij>();
            serviceCollection.AddSingleton<KorisnickiServis, KorisnickiServis>();
            serviceCollection.AddTransient<PrijavaViewModel, PrijavaViewModel>();
            serviceCollection.AddTransient<RegistracijaViewModel, RegistracijaViewModel>();
            
            var builder = new SqlConnectionStringBuilder();
            builder.ApplicationName = "StudentskaMenzaUWP";
            builder.ConnectTimeout = 30;
            builder.DataSource = "localhost\\SQLEXPRESS";
            builder.InitialCatalog = "menza_1";
            builder.IntegratedSecurity = true;
            builder.ApplicationIntent = ApplicationIntent.ReadWrite;
            builder.Encrypt = false;
            builder.TrustServerCertificate = true;
            Debug.WriteLine(builder.ConnectionString);
            
            serviceCollection.AddTransient<SqlConnection, SqlConnection>(
                (sp) => new SqlConnection("Server=.\\SQLEXPRESS;Database=menza_1;Trusted_Connection=True;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=True;Application Name=StudentskaMenzaUWP;ApplicationIntent=ReadWrite")
            );
            return serviceCollection.BuildServiceProvider();
        }
        

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;

            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            if (rootFrame == null)
            {
                // Create a Frame to act as the navigation context and navigate to the first page
                rootFrame = new Frame();

                rootFrame.NavigationFailed += OnNavigationFailed;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    //TODO: Load state from previously suspended application
                }

                // Place the frame in the current Window
                Window.Current.Content = rootFrame;
            }

            if (e.PrelaunchActivated == false)
            {
                if (rootFrame.Content == null)
                {
                    // When the navigation stack isn't restored navigate to the first page,
                    // configuring the new page by passing required information as a navigation
                    // parameter
                    rootFrame.Navigate(typeof(MainPage), e.Arguments);
                }
                // Ensure the current window is active
                Window.Current.Activate();
            }
        }

        /// <summary>
        /// Invoked when Navigation to a certain page fails
        /// </summary>
        /// <param name="sender">The Frame which failed navigation</param>
        /// <param name="e">Details about the navigation failure</param>
        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            deferral.Complete();
        }
    }
}
