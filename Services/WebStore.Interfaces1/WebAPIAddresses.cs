﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStore.Interfaces
{
    public static class WebAPIAddresses
    {
        public const string Values = "api/values";
        public const string Employees = "api/employees";
        public const string Products = "api/products";
        public const string Orders = "api/orders";

        public static class Identity
        {
            public const string Users = "api/user";
            public const string Roles = "api/roles";
        }

    }
}
