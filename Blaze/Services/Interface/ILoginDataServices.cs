using BlazeShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blaze.Services.Interface
{
    public interface ILoginDataServices
    {
        Task<string> ValidateLogin(UserModel userModel);
    }
}
