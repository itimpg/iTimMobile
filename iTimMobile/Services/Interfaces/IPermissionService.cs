using System.Threading.Tasks;
using Xamarin.Essentials;
using static Xamarin.Essentials.Permissions;

namespace iTimMobile.Services.Interfaces
{
    public interface IPermissionService
    {
        Task<PermissionStatus> CheckAndRequestPermissionAsync<T>(T permission) where T : BasePermission;
    }
}
