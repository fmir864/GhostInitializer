using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    [GenericProxy]
    public class Person : ContextBoundObject
    {
        public virtual string GetObjectName()
        {
            return "Generic Person";
        }
    }
}
