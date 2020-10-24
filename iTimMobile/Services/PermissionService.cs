﻿using iTimMobile.Services.Interfaces;
using System.Threading.Tasks;
using Xamarin.Essentials;
using static Xamarin.Essentials.Permissions;

namespace iTimMobile.Services
{
    public class PermissionService : IPermissionService
    {
        public async Task<PermissionStatus> CheckAndRequestPermissionAsync<T>(T permission)
               where T : BasePermission
        {
            var status = await permission.CheckStatusAsync();
            if (status != PermissionStatus.Granted)
            {
                status = await permission.RequestAsync();
            }

            return status;
        }
    }
}
