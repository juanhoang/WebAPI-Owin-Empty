using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Google;
using Owin;

namespace WebApiExternalAuth.Configuration
{
    public static class SecurityConfig
    {
        public static void Configure(this IAppBuilder app)
        {
            // Enable the application to use a cookie to store information for the signed in user
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ExternalCookie
            });

            // Use a cookie to temporarily store information about a user logging in with a third party login provider
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            // Configure google authentication
            var options = new GoogleOAuth2AuthenticationOptions()
            {
                ClientId = "592811454485-irj0ateep1jp0fukkg9obn1rm6015qrt.apps.googleusercontent.com",
                ClientSecret = "i7AMD7wIipImrOpL7bX7IyQ7"
            };

            app.UseGoogleAuthentication(options);
        }
    }
}