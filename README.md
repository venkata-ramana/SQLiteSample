# SQLiteSample

This sample helps you to understand sqlite with NPoco.

Nuget available here <https://www.nuget.org/packages/NPoco/> 

Step 1:
    
   install <https://www.nuget.org/packages/NPoco/> 

Step 2: 

      <system.data>
      <DbProviderFactories>
      <remove invariant="System.Data.SQLite.EF6" />
      <add name="SQLite Data Provider (Entity Framework 6)" invariant="System.Data.SQLite.EF6" description=".NET Framework Data Provider for SQLite (Entity Framework 6)" type="System.Data.SQLite.EF6.SQLiteProviderFactory, System.Data.SQLite.EF6" />
      <remove invariant="System.Data.SQLite" /><add name="SQLite Data Provider" invariant="System.Data.SQLite" description=".NET Framework Data Provider for SQLite" type="System.Data.SQLite.SQLiteFactory, System.Data.SQLite" />
      </DbProviderFactories>
      </system.data>


Step 3: 

    <connectionStrings>
    <add name="DefaultConnection" connectionString="Data Source = C:\db\test.db;" providerName="System.Data.SQLite" />
    </connectionStrings>

Step 4:

     public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
    }

    static void Main(string[] args)
    {
       var config = ConfigurationManager.ConnectionStrings["DefaultConnection"];
       var db = new MyDb(config.ConnectionString, config.ProviderName);
       List<User> users = db.Fetch<User>(string.Empty);
       Console.WriteLine(users.Count);
    }

    public class MyDb : NPoco.Database
    {
        public MyDb()
            : base("DefaultConnection")
        {
        }

        public MyDb(string connectionString, string providerName)
            : base(connectionString, providerName)
        {
        }
    }
.
