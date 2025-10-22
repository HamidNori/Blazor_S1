using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor_S1;

namespace Blazor_S1
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
    }

}