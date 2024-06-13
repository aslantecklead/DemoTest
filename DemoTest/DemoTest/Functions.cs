using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTest
{
    internal class Functions
    {
        public DemoTestEntities4 db = new DemoTestEntities4();
        public int CountEmployees()
        {
            return db.Beholder_Employee.ToList().Count;
        }
    }
}
