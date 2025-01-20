using Iesi.Collections.Generic;
using System.Collections.Generic;

namespace NHibernate.JetDriver.Tests.Entities
{
    public class Category
    {
        public Category()
        {
            Catalogs = new LinkedHashSet<Catalog>();
        }

        public virtual int Id
        {
            get;
            set;
        }

        public virtual ISet<Catalog> Catalogs
        {
            get; 
            private set;
        }

        public virtual string Name
        {
            get;
            set;
        }

        public virtual Product Product
        {
            get;
            set;
        }
    }
}