using Alaca.Core.Entities;
using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Service.Abstract
{
    public interface IAccountService : IManager
    {
        Task<bool> Login(string UserName, string Password);
        Task<HashSet<Menu>> GetAllMenu();
        Task<string> TryRefreshToken();

        Task<string> TryForceRefreshToken();
        void Logout();
    }
}
