using IdentityServer4.Models;
using System.Collections.Generic;

namespace Host.Configuration
{
    public class Scopes
    {
        public static IEnumerable<Scope> Get()
        {
            return new List<Scope>
            {
                StandardScopes.OpenId,
                StandardScopes.Profile,

                new Scope
                {
                    Name = "api1",
                    DisplayName = "API 1",
                    Description = "API 1 features and data",
                    Type = ScopeType.Resource,
                    Claims = new List<ScopeClaim>
                    {
                        new ScopeClaim("name", alwaysInclude: true),
                        new ScopeClaim("given_name", alwaysInclude: true),
                        new ScopeClaim("family_name", alwaysInclude: true),
                        new ScopeClaim("email", alwaysInclude: true),
                        new ScopeClaim("role", alwaysInclude: true),
                        new ScopeClaim("website", alwaysInclude: true),
                    }
                }
            };
        }
    }
}