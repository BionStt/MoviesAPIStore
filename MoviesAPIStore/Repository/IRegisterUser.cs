using MoviesAPIStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPIStore.Repository
{
    public interface IRegisterUser
    {
        void Add(RegisterUser registeruser);
        bool ValidateRegisteredUser(RegisterUser registeruser);
        bool ValidateUsername(RegisterUser registeruser);
        long GetLoggedUserID(RegisterUser registeruser);
    }
}
