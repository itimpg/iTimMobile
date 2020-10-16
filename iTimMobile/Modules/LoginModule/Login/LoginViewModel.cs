using iTimMobile.Modules.MainModule.Main;
using iTimMobile.Services.Interfaces;
using iTimMobile.Shared;
using iTimMobile.Shared.ViewModels;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace iTimMobile.Modules.LoginModule.Login
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;

        public ICommand LoginCommand { get => new Command(async () => await LoginAsync()); }

        public LoginViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        private async Task LoginAsync()
        {
            // TODO: do login

            Preferences.Set(Constants.IS_USER_LOGGED_IN, true);
            _navigationService.GoToMainFlow();
            await _navigationService.InsertAsRoot<MainViewModel>();
        }
    }
}
