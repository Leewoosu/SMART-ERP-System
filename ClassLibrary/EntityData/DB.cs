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
            사원등록 = new 사원등록Data();
            상각방법 = new 상각방법Data();
        }

        public static 사원등록Data 사원등록 { get; }
        public static 상각방법Data 상각방법 { get; }
    }
}
