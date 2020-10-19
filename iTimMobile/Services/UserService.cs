using iTimMobile.Models;
using iTimMobile.Services.Interfaces;
using iTimMobile.Shared;
using System.Text.Json;
using Xamarin.Essentials;

namespace iTimMobile.Services
{
    public class UserService : IUserService
    {
        public void ClearUserInfo()
        {
            Preferences.Remove(Constants.LOGGED_IN_USER);
        }

        public UserInfo GetUserInfo()
        {
            if (!Preferences.ContainsKey(Constants.LOGGED_IN_USER))
            {
                return null;
            }

            var userInfoJson = Preferences.Get(Constants.LOGGED_IN_USER, string.Empty);
            return JsonSerializer.Deserialize<UserInfo>(userInfoJson);
        }

        public void StoreUserInfo(UserInfo userInfo)
        {
            Preferences.Set(Constants.LOGGED_IN_USER, JsonSerializer.Serialize(userInfo));
        }
    }
}
