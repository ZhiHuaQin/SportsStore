using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using Vic.SportsStore.Domain.Concrete;
using Vic.SportsStore.WebApp.Infrastrature.Abstract;

namespace Vic.SportsStore.WebApp.Infrastrature.Concrete
{
    public class FormsAuthProvider : IAuthProvider
    {
        private EFDbContext context = new EFDbContext();
        public bool Authenticate(string username, string password)
        {
            bool result = false;
            var user = context.AdminUsers.FirstOrDefault(x => x.UserName == username);

            if(user!=null && user.Password == password)
            {
                result = true;
            }
            if (result)
            {
                FormsAuthentication.SetAuthCookie(username, false);
            }
            return result;
        }
    }
}