using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPoco;

namespace SQLiteTester
{
    /// <summary>
    /// Class User
    /// </summary>
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    /// <summary>
    /// Class Program
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var config = ConfigurationManager.ConnectionStrings["DefaultConnection"];
            var db = new MyDb(config.ConnectionString, config.ProviderName);
            List<User> users = db.Fetch<User>(string.Empty);
            Console.WriteLine(users.Count);
        }
    }
}