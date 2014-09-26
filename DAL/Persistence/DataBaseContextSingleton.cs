using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Persistence
{
    internal class DataBaseContextSingleton
    {
        private DataBaseContextSingleton() { }

        private static RepositorioContainer dataBaseContext;

        public static RepositorioContainer DataBaseContext
        {
            get
            {
                if (dataBaseContext == null)
                {
                    dataBaseContext = new RepositorioContainer();
                }
                return dataBaseContext;
            }
        }
    }
}
