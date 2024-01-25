using Microsoft.AspNetCore.Identity;

namespace MyFirstWebShop.Helpers
{
    public static class MyFirstWebShopConfiguration
    {
        private static readonly string[] Roles = { "Admin", "Manager", "Retail", "Kunde", "User" };

        public static IServiceCollection ConfigureWebShopIdentity(this IServiceCollection services)
        {
            return services.Configure<IdentityOptions>(options =>
            {
                //Password settings
                options.Password.RequiredLength = 20;

                //Lockout settings
                options.Lockout.AllowedForNewUsers = true;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;

                // User settings.
                options.User.AllowedUserNameCharacters =
               "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = false;
            });

            //services.ConfigureApplicationCookie(options =>
            //{
            //    //Cookie Settings
                

            //    ;
            //});
        }

        /// <summary>
        /// Uses the <see cref="RoleManager{TRole}"/> to add the roles to the database
        /// </summary>
        /// <param name="container"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public static async void EnsureMockRolesCreatedAsync(this IServiceProvider provider)
        {
            using (var scope = provider.CreateAsyncScope())
            {
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>() ?? throw new ArgumentNullException();

                foreach (var role in Roles)
                {
                    if (!await roleManager.RoleExistsAsync(role))
                        await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }

        /// <summary>
        /// Adds the WebShop RolePolicies programmatically
        /// </summary>
        /// <param name="services"></param>
        public static void AddWebShopRolePolicies(this IServiceCollection services)
        {
            services.AddAuthorization(options =>
            {
                foreach (var role in Roles)
                {
                    options.AddPolicy(role, policy => policy.RequireRole(role));
                }
            });
        }
    }
}
