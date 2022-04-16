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

using EnumWithEfCoreDemo.Models.Enums;
using Microsoft.EntityFrameworkCore;
using MyTask = EnumWithEfCoreDemo.Models.Task;

namespace EnumWithEfCoreDemo.Entities
{
    public class DataSeeding
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MyTask>().HasData(
                new MyTask
                {
                    Id = Guid.NewGuid(),
                    Priority = PriorityType.Low,
                    Name = "My 1st Task",
                    Description = "This is my 1st Task Description",
                    Status = StatusType.NotStarted


                },
                new MyTask
                {
                    Id = Guid.NewGuid(),
                    Priority = PriorityType.Highest,
                    Name = "My 2nd Task",
                    Description = "This is my 2nd Task Description",
                    Status = StatusType.OnHold


                },
                new MyTask
                {
                    Id = Guid.NewGuid(),
                    Priority = PriorityType.Normal,
                    Name = "My 3rd Task",
                    Description = "This is my 3rd Task Description",
                    Status = StatusType.Started


                }


               );
        }
    }
}
