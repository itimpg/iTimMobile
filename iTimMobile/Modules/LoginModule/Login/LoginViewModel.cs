using iTimMobile.Modules.MainModule.Main;
using iTimMobile.Services.Interfaces;
using iTimMobile.Shared.ViewModels;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace iTimMobile.Modules.LoginModule.Login
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;
        private readonly IUserService _userService;

        public ICommand LoginCommand { get => new Command(async () => await LoginAsync()); }

        public LoginViewModel(INavigationService navigationService, IUserService userService)
        {
            _navigationService = navigationService;
            _userService = userService;
        }

        private async Task LoginAsync()
        {
            _userService.StoreUserInfo(new Models.UserInfo { Name = "iTim" });
            _navigationService.GoToMainFlow();
            await _navigationService.InsertAsRoot<MainViewModel>();
        }
    }
}
