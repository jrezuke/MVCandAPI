using IdentityServer4.Models;
using System.Collections.Generic;

namespace Host.Configuration
{
    public class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new List<Client>
            {
                new Client
                {
                    Enabled = true,
                    ClientId = "ifar.extranetVS",
                    ClientName = "IFAR.Extranet",
                    AllowAccessTokensViaBrowser = true,
                    AllowedGrantTypes = GrantTypes.Implicit,

                    RedirectUris = new List<string>
                    {
                        "http://localhost:21308",
                    },
                    PostLogoutRedirectUris = new List<string>
                    {
                        "http://localhost:21308",
                    },
                    AllowedCorsOrigins = new List<string>
                    {
                        "http://localhost:21308",
                        "http://localhost:1773"
                    },

                    AllowedScopes = new List<string>
                    {
                        StandardScopes.OpenId.Name,
                        StandardScopes.Profile.Name,
                        "api1"
                    }
                },
                new Client
                {
                    Enabled = true,
                    ClientId = "ifar.extranet",
                    ClientName = "IFAR.Extranet",
                    AllowAccessTokensViaBrowser = true,
                    AllowedGrantTypes = GrantTypes.Implicit,

                    RedirectUris = new List<string>
                    {
                        "http://localhost:8010",
                    },
                    PostLogoutRedirectUris = new List<string>
                    {
                        "http://localhost:8010",
                    },
                    //AllowedCorsOrigins = new List<string>
                    //{
                    //    "http://localhost:8010",
                    //    "http://localhost:1773"
                    //},

                    AllowedScopes = new List<string>
                    {
                        StandardScopes.OpenId.Name,
                        StandardScopes.Profile.Name,
                        "api1"
                    }
                },
                new Client
                {
                    ClientId = "mvc",
                    ClientName = "MVC Hybrid Client",
                    AllowedGrantTypes = GrantTypes.Hybrid,

                    RedirectUris = new List<string>
                    {
                        "http://localhost:3308/signin-oidc"
                    },

                    PostLogoutRedirectUris = new List<string>
                    {
                        "http://localhost:3308/"
                    },

                    ClientSecrets = new List<Secret>
                    {
                        new Secret("secret".Sha256())
                    },

                    AllowedScopes = new List<string>
                    {
                        StandardScopes.OpenId.Name,
                        StandardScopes.Profile.Name,
                        "api1"
                    }
                }
            };
        }
    }
}