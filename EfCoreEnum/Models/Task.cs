﻿/*******************************************************************************************************************************
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

namespace EnumWithEfCoreDemo.Models
{
    public class Task
    {
        public Guid Id { get; set; }

        public PriorityType Priority { get; set; }

        public string Name { get; set; } = String.Empty;

        public string Description { get; set; } = String.Empty;

        public StatusType Status { get; set; }
    }
}
