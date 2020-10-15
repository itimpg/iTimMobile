using System.Threading.Tasks;
using iTimMobile.Shared.ViewModels;

namespace iTimMobile.Services.Interfaces
{
    public interface INavigationService
    {
        Task PushAsymc<TViewModel>(string parameters = null) where TViewModel : BaseViewModel;
        Task PopAsync();
        Task InsertAsRoot<TViewModel>(string parameters = null) where TViewModel : BaseViewModel;
        Task GoBackAsync();
        void GoToMainFlow();
        void GoToLoginFlow();
    }
}
