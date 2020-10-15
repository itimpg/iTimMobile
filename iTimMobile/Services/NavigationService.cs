using System.Threading.Tasks;
using iTimMobile.Modules.LoginModule;
using iTimMobile.Modules.MainModule;
using iTimMobile.Services.Interfaces;
using iTimMobile.Shared.ViewModels;
using Xamarin.Forms;

namespace iTimMobile.Services
{
    public class NavigationService : INavigationService
    {
        public Task PopAsync()
        {
            return Shell.Current.Navigation.PopAsync();
        }

        public Task GoBackAsync()
        {
            return Shell.Current.GoToAsync("..");
        }

        public Task InsertAsRoot<TViewModel>(string parameters = null) where TViewModel : BaseViewModel
        {
            return GoToAsync<TViewModel>("//", parameters);
        }

        public Task PushAsymc<TViewModel>(string parameters = null) where TViewModel : BaseViewModel
        {
            return GoToAsync<TViewModel>(string.Empty, parameters);
        }

        private Task GoToAsync<TViewModel>(string routePrefix, string parameters) where TViewModel : BaseViewModel
        {
            var route = routePrefix + typeof(TViewModel).Name;
            if (!string.IsNullOrWhiteSpace(parameters))
            {
                route += $"?{parameters}";
            }
            return Shell.Current.GoToAsync(route);
        }

        public void GoToMainFlow()
        {
            Application.Current.MainPage = new MainShell();
        }

        public void GoToLoginFlow()
        {
            Application.Current.MainPage = new LoginShell();
        }
    }
}
