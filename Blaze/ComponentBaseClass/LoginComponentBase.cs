using Blaze.Services.Interface;
using BlazeShared;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Blaze.ComponentBaseClass
{
    public class LoginComponentBase : ComponentBase
    {
        #region Services
        [Inject]
        public ILoginDataServices LoginDataServices { get; set; }
        #endregion

        #region Properties
        public UserModel userModel { get; set; } = new UserModel();

        #endregion

        #region Fields
        #endregion

        #region LifeCycleMethods
        protected async Task HandleValidSubmit()
        {
            var result = await LoginDataServices.ValidateLogin(userModel);
        }
        #endregion





    }
}
