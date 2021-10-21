using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTExamaple.Filter
{
    public class AuthorizationActionFilter:ActionFilterAttribute
    {
        public string[] Roles { set; get; }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Request.Headers.ContainsKey("Authorization"))
            {
                var token = context.HttpContext.Request.Headers["Authorization"].ToString();
                token = token.Remove(0, 7);
                var tokenBody = token.Split('.')[1];
                tokenBody = tokenBody.PadRight(tokenBody.Length + (tokenBody.Length * 3) % 4, '=');  // add padding
                var bytesTokenBody = Convert.FromBase64String(tokenBody);
                tokenBody = System.Text.Encoding.UTF8.GetString(bytesTokenBody);
                var tokenData = JsonConvert.DeserializeObject<dynamic>(tokenBody);
                if (!Roles.Contains((string)tokenData.role))
                {
                    context.Result = new UnauthorizedResult();
                }
            }
            base.OnActionExecuting(context);
        }
    }
}
