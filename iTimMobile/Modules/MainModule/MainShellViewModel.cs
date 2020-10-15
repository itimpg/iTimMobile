using System;
using System.Threading.Tasks;
using System.Windows.Input;
using iTimMobile.Modules.LoginModule.Login;
using iTimMobile.Services.Interfaces;
using iTimMobile.Shared;
using iTimMobile.Shared.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace iTimMobile.Modules.MainModule
{
    public class MainShellViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;

        public ICommand SignOutCommand { get => new Command(async () => await SignOutAsync()); }

        public MainShellViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
          
        private async Task SignOutAsync()
        {
            Preferences.Remove(Constants.IS_USER_LOGGED_IN);
            _navigationService.GoToLoginFlow();
            await _navigationService.InsertAsRoot<LoginViewModel>();
        }
    }
}
