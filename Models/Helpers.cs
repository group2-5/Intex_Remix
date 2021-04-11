using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;

namespace Intex_Remix.Models
{
    public class Helpers
    {
        public static string GetRDSConnectionString()
        {
            var appConfig = ConfigurationManager.AppSettings;



            string dbname = appConfig["MummyDB"];



            //if (string.IsNullOrEmpty(dbname)) return null;



            string username = appConfig["admin"];
            string password = appConfig["PokemonHangman"];
            string hostname = appConfig["intex2.chocwqhmp0h9.us-east-1.rds.amazonaws.com"];
            string port = appConfig["1433"];



            //return "Data Source=" + hostname + "," + port + ";Initial Catalog=" + dbname + ";User ID=" + username + ";Password=" + password + ";";
            return "Data Source=intex2.chocwqhmp0h9.us-east-1.rds.amazonaws.com,1433;Initial Catalog=MummyDB;User ID=admin;Password=PokemonHangman;";
        }
    }
}