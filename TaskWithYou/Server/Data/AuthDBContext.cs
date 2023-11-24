using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Client;
using TaskWithYou.Server.Models;

namespace TaskWithYou.Server.Data
{
    public class AuthDBContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public AuthDBContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
    }
}