using iTimMobile.Modules.LoginModule.Login;
using iTimMobile.Services.Interfaces;
using iTimMobile.Shared.ViewModels;
using System.Threading.Tasks;

namespace iTimMobile.Modules
{
    public class LoadingViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;
        private readonly IUserService _userService;

        public LoadingViewModel(INavigationService navigationService, IUserService userService)
        {
            _navigationService = navigationService;
            _userService = userService;
        }

        public override Task InitializeAsync(object obj)
        {
            if(_userService.GetUserInfo() != null)
            {
                _navigationService.GoToMainFlow();
                return Task.CompletedTask;
            }

            _navigationService.GoToLoginFlow();
            return _navigationService.InsertAsRoot<LoginViewModel>();
        }
    }
}
