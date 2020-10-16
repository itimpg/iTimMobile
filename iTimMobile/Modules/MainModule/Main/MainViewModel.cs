using iTimMobile.Services.Interfaces;
using iTimMobile.Shared.ViewModels;
using System.Threading.Tasks;

namespace iTimMobile.Modules.MainModule.Main
{
    public class MainViewModel : BaseViewModel
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        private readonly IUserService _userService;

        public MainViewModel(IUserService userService)
        {
            _userService = userService;
        }

        public override Task InitializeAsync(object obj)
        {
            Name = _userService.GetUserInfo().Name;
            return Task.CompletedTask;
        }
    }
}
