using Template10.Mvvm;
using ImageSortLibrary.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Template10.Services.NavigationService;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Navigation;

namespace ImageSortLibrary.UWP.ViewModels
{
    class SearchPageViewModel : ViewModelBase
    {
        public SearchPageViewModel()
        {

        }


        ObservableCollection<Picture> pictures; 
        public ObservableCollection<Picture> Pictures { get { return pictures; } set { Set(ref pictures, value); } }

        public override async Task OnNavigatedToAsync(Object parameter, NavigationMode mode, IDictionary<string, object> suspensionState)
        {
            if (Pictures == null)
            {
                Pictures = new ObservableCollection<Picture>(await DataSource.Pictures.Instance.GetPictures());
            }

            //TODO: Errorhandling?
            if(suspensionState.Any())
            {

            }
            await Task.CompletedTask;
        }
        
        public override async Task OnNavigatedFromAsync(IDictionary<string, object> suspensionState, bool suspending)
        {
            //TODO: Errorhandling?
            if(suspending)
            {

            }
            await Task.CompletedTask;
        }


        public override async Task OnNavigatingFromAsync(NavigatingEventArgs args)
        {
            args.Cancel = false;
            await Task.CompletedTask;
        }

        //TODO: Not yet made
        //public ICommand DeletePictureCommad
    }
}
