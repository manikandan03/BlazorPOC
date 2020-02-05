using BlazeAPI.Context;
using BlazeAPI.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlazeAPI.Repository
{

    public class UserRepository : Repository<Users>, IUserRepository
    {
        public new HRMS_TestingContext Context { get; }

        /// <summary>
        /// user repo
        /// </summary>
        /// <param name="context"></param>
        public UserRepository(HRMS_TestingContext context) : base(context)
        {
            Context = context;
        }
        public Users ValidateLogin(string username, string password)
        {
            string cryptpassword = Create_SHA256(password);
            return Context.Users.Where(x => x.UserName == username && x.Password == cryptpassword && x.IsActive==true).FirstOrDefault();
        }

        public static string Create_SHA256(String Password)
        {
            SHA256Managed crypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(Password), 0, Encoding.UTF8.GetByteCount(Password));

            foreach (byte bit in crypto)
            {
                hash += bit.ToString("x2");
            }
            return hash;
        }
    }
}
