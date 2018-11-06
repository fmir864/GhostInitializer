using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class GenericProxyAttribute : ProxyAttribute
    {
        public override MarshalByRefObject CreateInstance(Type serverType)
        {
            string typeName = serverType.Name;

            try
            {
                Assembly library = Assembly.LoadFrom("Custom.dll");
                Type type = library.GetType(string.Format("Custom.{0}", typeName), false, true);
                return base.CreateInstance(type);
            }
            catch (Exception)
            {
                return base.CreateInstance(serverType);
            }
        }
    }
}
