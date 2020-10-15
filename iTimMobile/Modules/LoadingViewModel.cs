using System.Threading.Tasks;
using iTimMobile.Modules.LoginModule.Login;
using iTimMobile.Services.Interfaces;
using iTimMobile.Shared;
using iTimMobile.Shared.ViewModels;
using Xamarin.Essentials;

namespace iTimMobile.Modules
{
    public class LoadingViewModel : BaseViewModel
    {
        private INavigationService _navigationService;

        public LoadingViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override Task InitializeAsync(object obj)
        {
            if (Preferences.ContainsKey(Constants.IS_USER_LOGGED_IN) && Preferences.Get(Constants.IS_USER_LOGGED_IN, false) == true)
            {
                _navigationService.GoToMainFlow();
                return Task.CompletedTask;
            }

            _navigationService.GoToLoginFlow();
            return _navigationService.InsertAsRoot<LoginViewModel>();
        }
    }
}
