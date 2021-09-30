using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTExamaple.Requests
{
    public class AuthorizationRequest
    {
        public string User { get; set; }
        public string Password { get; set; }
    }
}
