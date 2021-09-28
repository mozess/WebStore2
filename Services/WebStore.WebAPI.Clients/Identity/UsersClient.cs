using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebStore.Interfaces;
using WebStore.WebAPI.Clients.Base;

namespace WebStore.WebAPI.Clients.Identity
{
    class UsersClient:BaseClient
    {
        public UsersClient(HttpClient Client) : base(Client, WebAPIAddresses.Identity.Users) { }
    }
}
