using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace crossInventario.ConecctionClass
{
    public class conectionDatabase
    {
        public string databasePath
        {
            get
            {
                var dbName = "basesAusar.db";


#if __IOS__
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                folder = Path.Combine(folder, "..", "Library");
                var databasePath = Path.Combine(folder, dbName);
                

#else
#if __ANDROID__
                string documenthPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                var databasePath = Path.Combine(documenthPath, dbName);


#else

                //var databasePath = Path.Combine(ApplicationData.Current.LocalFolder.Path, dbName);
                //var databasePath = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, dbName);
               

#endif
#endif
                return databasePath;


            }
        }
    }
}
