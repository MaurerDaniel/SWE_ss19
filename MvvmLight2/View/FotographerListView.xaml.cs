using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using MvvmLight2.ViewModel;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=234238 dokumentiert.

namespace MvvmLight2.View
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class FotographerListView : Page
    {
        public FotographerListViewModel Vm => (FotographerListViewModel)DataContext;


        public FotographerListView()
        {

            //DataContext = new FotographerListViewModel();
            InitializeComponent();
        }

        private void GoBackButtonClick(object sender, RoutedEventArgs e)
        {
            var nav = ServiceLocator.Current.GetInstance<INavigationService>();
            nav.GoBack();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
        }
    }
}