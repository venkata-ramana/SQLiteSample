using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteTester
{
    /// <summary>
    /// Class MyDb
    /// </summary>
    /// <seealso cref="NPoco.Database" />
    public class MyDb : NPoco.Database
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MyDb"/> class.
        /// </summary>
        public MyDb()
            : base("DefaultConnection")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MyDb"/> class.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <param name="providerName">Name of the provider.</param>
        public MyDb(string connectionString, string providerName)
            : base(connectionString, providerName)
        {
        }
    }
}