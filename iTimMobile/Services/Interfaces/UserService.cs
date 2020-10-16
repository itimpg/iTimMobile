using iTimMobile.Models;
using iTimMobile.Shared;
using System.Text.Json;
using Xamarin.Essentials;

namespace iTimMobile.Services.Interfaces
{
    public class UserService : IUserService
    {
        public void ClearUserInfo()
        {
            Preferences.Clear(Constants.LOGGED_IN_USER);
        }

        public UserInfo GetUserInfo()
        {
            var userInfoJson = Preferences.Get(Constants.LOGGED_IN_USER, string.Empty);
            return JsonSerializer.Deserialize<UserInfo>(userInfoJson);
        }

        public void StoreUserInfo(UserInfo userInfo)
        {
            Preferences.Set(Constants.LOGGED_IN_USER, JsonSerializer.Serialize(userInfo));
        }
    }
}
