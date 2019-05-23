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
    public class FotographerListViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;
        private readonly INavigationService _navigationService;
        //private RelayCommand _incrementCommand;
        //private RelayCommand<string> _navigateCommand;
        //private RelayCommand _sendMessageCommand;
        //private RelayCommand _showDialogCommand;
        //private RelayCommand _addFotographerCommand;

        private RelayCommand _createNewCommand;
        private RelayCommand<string> _editExistCommand;
        private RelayCommand<string> _navigateCommandBack;

        private List<FotographerModel> _fotographerList = new List<FotographerModel>()
        {
            new FotographerModel("Bob", "Bobster", DateTime.Today , "Notes 1"),
            new FotographerModel("Alice", "Alicster", DateTime.Today, "Notes 2"),
            new FotographerModel("Hans", "Hanster", DateTime.Today, "Note 3")
            };

        private FotographerModel _selectedFotographer;
        private string _welcomeTitle;

        public string WelcomeTitle
        {
            get
            {
                return _welcomeTitle;
            }

            set
            {
                Set(ref _welcomeTitle, value);
            }
        }

        public List<FotographerModel> FotographerModelList
        {
            get
            {
                return _fotographerList;
            }
            set
            {
                Set(ref _fotographerList, value);
            }
        }

        public FotographerModel SelectedFotographer
        {
            get
            {
                return _selectedFotographer;
            }

            set
            {
                Set(ref _selectedFotographer, value);
            }
        }

        //public FotographerListViewModel(IDataService dataService, INavigationService navigationService)
        //{
        //    _dataService = dataService;
        //    _navigationService = navigationService;
        //    Initialize();
        //}

        public RelayCommand<string> NavigateCommandBack
        {
            get
            {
                return _navigateCommandBack
                       ?? (_navigateCommandBack = new RelayCommand<string>(
                           p => _navigationService.NavigateTo(ViewModelLocator.MainPageKey, p),
                           p => !string.IsNullOrEmpty(p)));
            }
        }

        public RelayCommand CreateNewCommand
        {
            get
            {
                return _createNewCommand
                       ?? (_createNewCommand = new RelayCommand(
                    () =>
                    {
                        WelcomeTitle = string.Format("Counter clicked times");
                    }));
            }
        }

        //public FotographerListViewModel()
        //{
        //    Initialize();
        //}

        public FotographerListViewModel(IDataService dataService, INavigationService navigationService)
        {
            _dataService = dataService;
            _navigationService = navigationService;
            Initialize();
        }

        private async Task Initialize()
        {
            try
            {
                var item = await _dataService.GetData();
                WelcomeTitle = item.Title;
            }
            catch (Exception ex)
            {
                // Report error here
                WelcomeTitle = ex.Message;
            }
        }


        //public RelayCommand AddFotographerCommand
        //{
        //    get
        //    {
        //        return _addFotographerCommand
        //            ?? (_addFotographerCommand = new RelayCommand(
        //            () =>
        //            {
        //                //TODO take entries from FotographerListView
        //                _fotographerList.Add(new FotographerModel(
        //                    "Harrald",
        //                    "Wahl" + DateTime.Now.Second.ToString(),
        //                    DateTime.Today,
        //                    "I really don't care")
        //                    );
        //            }));
        //    }
        //}

    }
}
