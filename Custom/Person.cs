using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom
{
    public class Person : Generic.Person
    {
        public override string GetObjectName()
        {
            return "Custom Person";
        }
    }
}
