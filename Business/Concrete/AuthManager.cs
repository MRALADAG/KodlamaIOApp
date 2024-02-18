using Business.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        public bool checkIfRealUser(IUser user)
        {
            Console.WriteLine(user.UserName + " isimli kullanıcı doğrulanmıştır.");
            return true;
        }
    }
}
