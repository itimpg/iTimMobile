using iTimMobile.Modules.LoginModule.Login;
using iTimMobile.Services.Interfaces;
using iTimMobile.Shared.ViewModels;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace iTimMobile.Modules.MainModule
{
    public class MainShellViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;
        private readonly IUserService _userService;

        public ICommand SignOutCommand { get => new Command(async () => await SignOutAsync()); }

        public MainShellViewModel(INavigationService navigationService, IUserService userService)
        {
            _navigationService = navigationService;
            _userService = userService;
        }

        private async Task SignOutAsync()
        {
            _userService.ClearUserInfo();
            _navigationService.GoToLoginFlow();
            await _navigationService.InsertAsRoot<LoginViewModel>();
        }
    }
}
