using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class DB
    {
        static DB()
        {
            EmployeeRegist = new EmployeeRegistData();
        }

        public static EmployeeRegistData EmployeeRegist { get; }
    }
}
