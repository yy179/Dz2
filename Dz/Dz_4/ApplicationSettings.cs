using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_4
{
    internal class ApplicationSettings
    {
        private string name;
        private double version;
        public ApplicationSettings() { this.name = "DefaultName"; this.version = 1.0; }
        public ApplicationSettings(string name, double version) 
        {
            this.name = name;
            this.version = version;
        }
        public class DatabaseSettings
        {
            private string СonnectionString;
            private int ConnectionTimeout;
            
            public DatabaseSettings(string СonnectionString, int ConnectionTimeout) 
            {
                this.СonnectionString = СonnectionString;
                this.ConnectionTimeout = ConnectionTimeout;
            }
            public string Settings(ApplicationSettings apps) 
            {
                return $"Name: {apps.name}\nVersion: {apps.version}\nСonnection String: {СonnectionString}\nConnection Timeout: {ConnectionTimeout}";
            }
        }

    }
}
