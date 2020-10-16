using iTimMobile.Models;

namespace iTimMobile.Services.Interfaces
{
    public interface IUserService
    {
        void StoreUserInfo(UserInfo userInfo);
        UserInfo GetUserInfo();
        void ClearUserInfo();
    }
}
