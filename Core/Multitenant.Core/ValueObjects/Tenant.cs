﻿namespace Multitenant.Core.ValueObjects
{
    using System.Collections.Generic;

    public class Tenant
    {
        public Tenant()
        {
            Environments = new List<Environment>();
            GlobalSettings = new Dictionary<string, string>();
        }

        public string Name { get; set; }
        public List<Environment> Environments { get; set; }
        public Dictionary<string, string> GlobalSettings { get; set; }

        public void Add(Environment environment)
        {
            Environments.Add(environment);
        }
    }
}
