using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Config
{
    public class AuthorizationProceduresCollection : ConfigurationElementCollection
    {
        public AuthorizationProceduresCollection()
        {

        }

        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.AddRemoveClearMap;
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new AuthorizationProcedureElement();
        }

        protected override Object GetElementKey(ConfigurationElement element)
        {
            return ((AuthorizationProcedureElement)element).Name;
        }

        public AuthorizationProcedureElement this[int index]
        {
            get
            {
                return (AuthorizationProcedureElement)BaseGet(index);
            }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }

        new public AuthorizationProcedureElement this[string Name]
        {
            get
            {
                return (AuthorizationProcedureElement)BaseGet(Name);
            }
        }


        public int IndexOf(AuthorizationProcedureElement procedure)
        {
            return BaseIndexOf(procedure);
        }

        public void Add(AuthorizationProcedureElement procedure)
        {
            BaseAdd(procedure);

            // Your custom code goes here.

        }

        protected override void BaseAdd(ConfigurationElement element)
        {
            BaseAdd(element, false);

            // Your custom code goes here.

        }

        public void Remove(AuthorizationProcedureElement procedure)
        {
            if (BaseIndexOf(procedure) >= 0)
            {
                BaseRemove(procedure.Name);
                // Your custom code goes here.
                Console.WriteLine("AuthorizationProceduresCollectionElement: {0}", "Removed collection element!");
            }
        }

        public void RemoveAt(int index)
        {
            BaseRemoveAt(index);

            // Your custom code goes here.

        }

        public void Remove(string name)
        {
            BaseRemove(name);

            // Your custom code goes here.

        }

        public void Clear()
        {
            BaseClear();

            // Your custom code goes here.
            Console.WriteLine("AuthorizationProceduresCollectionElement: {0}", "Removed entire collection!");
        }
    }
}
