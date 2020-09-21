using bumShopSolution.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace bumShopSolution.Application.Common.System
{
    public interface IUserService
    {
        Task<string> Authencate(LoginRequest request);
        Task<string> Register(RegisterRequest request);
    }
}
