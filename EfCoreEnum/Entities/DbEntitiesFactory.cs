/*******************************************************************************************************************************
*  COPYRIGHT BY ZIGGY RAFIQ (ZAHEER RAFIQ)
*  LinkedIn Profile URL Address: https://www.linkedin.com/in/ziggyrafiq/ 
*
*  System   :  	Demo for Blog Post: https://blog.ziggyrafiq.com/2022/04/how-to-use-enum-data-values-with-net-60.html
*  Date     :  	16/04/2022
*  Author   :  	Ziggy Rafiq (https://www.ziggyrafiq.com)
*  License  :	MIT
*  Notes    :  	This code project is for Blog Post: How to use Enum data values with .Net 6 Framework
*
*******************************************************************************************************************************/

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace EnumWithEfCoreDemo.Entities
{
    public class DbEntitiesFactory : IDesignTimeDbContextFactory<DbEntities>
    {
        public DbEntities CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile(@Directory.GetCurrentDirectory() + "/appsettings.json")
                .Build();


            var builder = new DbContextOptionsBuilder<DbEntities>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseSqlServer(connectionString);

            return new DbEntities(builder.Options);


        }
    }
}
