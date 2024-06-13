using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTest
{
    internal class Functions
    {
        public DemoTestEntities2 db = new DemoTestEntities2();
        public int CountEmployees()
        {
            return db.Beholder_Employee.ToList().Count;
        }
    }
}
