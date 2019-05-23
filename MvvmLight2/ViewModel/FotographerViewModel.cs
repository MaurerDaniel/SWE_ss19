using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using MvvmLight2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLight2.ViewModel
{
    public class FotographerViewModel : ViewModelBase
    {
        //private readonly IDataService _dataService;
        //private readonly INavigationService _navigationService;
        //private RelayCommand _incrementCommand;
        //private RelayCommand<string> _navigateCommand;
        //private RelayCommand _sendMessageCommand;
        //private RelayCommand _showDialogCommand;

        //private List<FotographerModel> _fotographerList;
        //private FotographerModel _selectedFotographer;


        //public FotographerModel SelectedFotographer
        //{
        //    get
        //    {
        //        return _selectedFotographer;
        //    }

        //    set
        //    {
        //        Set(ref _welcomeTitle, value);
        //    }
        //}

        public FotographerViewModel(IDataService dataService, INavigationService navigationService)
        {
            //_dataService = dataService;
            //_navigationService = navigationService;
            //Initialize();
        }

        //private async Task Initialize()
        //{
        //    try
        //    {
        //        var item = await _dataService.GetData();
        //        WelcomeTitle = item.Title;
        //    }
        //    catch (Exception ex)
        //    {
        //        // Report error here
        //        WelcomeTitle = ex.Message;
        //    }
        //}
    }
}
