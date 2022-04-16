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
using MyTask = EnumWithEfCoreDemo.Models.Task;

namespace EnumWithEfCoreDemo.Entities
{
    public class DbEntities : DbContext
    {
        public DbEntities() { }
        public DbEntities(DbContextOptions<DbEntities> options) : base(options) { }


        //Entites 
        public DbSet<MyTask>? Tasks { get; set; } = null;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            DataSeeding.SeedData(modelBuilder);
        }
    }
}
