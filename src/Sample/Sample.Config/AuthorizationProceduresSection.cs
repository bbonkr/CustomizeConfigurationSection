using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Config
{
    public class AuthorizationProceduresSection : ConfigurationSection
    {

        // Declare the UrlsCollection collection property.
        [ConfigurationProperty("authorizationProcedures", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(AuthorizationProceduresCollection),
            AddItemName = "add",
            ClearItemsName = "clear",
            RemoveItemName = "remove")]
        public AuthorizationProceduresCollection AuthorizationProcedures
        {
            get
            {
                AuthorizationProceduresCollection proceduresCollection =
                    (AuthorizationProceduresCollection)base["authorizationProcedures"];

                return proceduresCollection;
            }

            set
            {
                AuthorizationProceduresCollection proceduresCollection = value;
            }

        }

        // Create a new instance of the UrlsSection.
        // This constructor creates a configuration element
        // using the UrlConfigElement default values.
        // It assigns this element to the collection.
        public AuthorizationProceduresSection()
        {

        }
    }



}
