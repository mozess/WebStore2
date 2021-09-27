using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using WebStore.Domain.Entities.Identity;

namespace WebStore.Domain.DTO.Identity
{
    public abstract class UserDTO
    {
        public User User { get; init; }
    }

    public class AddLoginDTO : UserDTO
    { 
        public UserLoginInfo UserLoginInfo { get; init; }
    }

    public class PasswordHashDTO : UserDTO
    {
        public string Hash { get; init; }
    }

    public class SetLockoutDTO : UserDTO
    {
        public DateTimeOffset? LockoutEnd { get; init; }
    }
}
