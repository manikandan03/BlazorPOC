using BlazeAPI.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazeAPI.IRepository
{
    public interface IUserRepository : IRepository<Users>
    {
        Users ValidateLogin(string username, string password);
    }
}
