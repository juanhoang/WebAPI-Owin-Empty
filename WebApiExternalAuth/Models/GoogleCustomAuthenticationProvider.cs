﻿using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.Owin.Security.Google;

namespace WebApiExternalAuth.Models
{
    public class GoogleCustomAuthenticationProvider : GoogleOAuth2AuthenticationProvider
    {
        public override Task Authenticated(GoogleOAuth2AuthenticatedContext context)
        {
            context.Identity.AddClaim(new Claim(Claims.ExternalAccessToken, context.AccessToken));
            context.Identity.AddClaim(new Claim(Claims.ExternalEmail, context.Email));
            context.Identity.AddClaim(new Claim(Claims.ExternalUserName, context.Name));

            return base.Authenticated(context);
        }
    }
}