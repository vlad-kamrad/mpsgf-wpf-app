using MPSGF.wpf.ViewModel;
using System.Windows;

namespace MPSGF.wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var viewModel = new MainViewModel();
            var view = new MainWindow { DataContext = viewModel };

            view.Show();
        }
    }
}
