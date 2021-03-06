﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using MvvmLight2.Model;
using MvvmLight2.View;

namespace MvvmLight2.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class ViewModelLocator
    {
        public const string MainPageKey = "MainPage";
        //public const string SecondPageKey = "SecondPage";
        public const string ThirdPageKey = "ThirdPage";
        public const string FotographerListViewKey = "FotographerListView";


        /// <summary>
        /// This property can be used to force the application to run with design time data.
        /// </summary>
        public static bool UseDesignTimeData
        {
            get
            {
                return false;
            }
        }

        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            var nav = new NavigationService();
            nav.Configure(MainPageKey, typeof(MainPage));
            //nav.Configure(SecondPageKey, typeof(SecondPage));
            nav.Configure(ThirdPageKey, typeof(ThirdPage));
            nav.Configure(FotographerListViewKey, typeof(FotographerListView));

            SimpleIoc.Default.Register<INavigationService>(() => nav);

            SimpleIoc.Default.Register<IDialogService, DialogService>();

            if (ViewModelBase.IsInDesignModeStatic
                    || UseDesignTimeData)
            {
                SimpleIoc.Default.Register<IDataService, Design.DesignDataService>();
            }
            else
            {
                SimpleIoc.Default.Register<IDataService, DataService>();
            }

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register <FotographerListViewModel>();
            SimpleIoc.Default.Register<PictureListViewModel>();

        }

        /// <summary>
        /// Gets the Main property.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();
        public PictureListViewModel Third => ServiceLocator.Current.GetInstance <PictureListViewModel>();
        public FotographerListViewModel FotographerList => ServiceLocator.Current.GetInstance<FotographerListViewModel>();
        //public FotographerListViewModel ListView => ServiceLocator.Current.GetInstance<FotographerListViewModel>();

    }
}
