using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Config
{
    public class AuthorizationProcedureElement : ConfigurationElement
    {
        [ConfigurationProperty("name", DefaultValue = "", IsRequired = true, IsKey = true)]
        public string Name
        {
            get
            {
                return (string)this["name"];
            }
            set
            {
                this["name"] = value;
            }
        }

        [ConfigurationProperty("procedureName", DefaultValue = "", IsRequired = true)]
        public string ProcedureName
        {
            get
            {
                return (string)this["procedureName"];
            }
            set
            {
                this["procedureName"] = value;
            }
        }
    }
}
