using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Config
{
    public class AuthorizationConfigHelper
    {
        public static AuthorizationProceduresSection ReadSection()
        {
            AuthorizationProceduresSection authorizationProceduresSection = null;
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None) as Configuration;

                authorizationProceduresSection = config.GetSection("sample.config.authorization") as AuthorizationProceduresSection;
            }
            catch (ConfigurationErrorsException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return authorizationProceduresSection;
        }
    }
}
