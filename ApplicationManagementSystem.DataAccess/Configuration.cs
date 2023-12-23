using Microsoft.Extensions.Configuration;

namespace ApplicationManagementSystem.DataAccess;

static class Configuration
{
    static public string ConnectionString
    {
        get
        {
            ConfigurationManager configurationManager = new();
            try
            {
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../ApplicationManagementSystem.API"));
                configurationManager.AddJsonFile("appsettings.json");
            }
            catch
            {
                configurationManager.AddJsonFile("appsettings.json");
            }

            return configurationManager.GetConnectionString("SqlServer");
        }
    }

}
