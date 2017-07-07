using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using crossInventario.Droid.Services;
using crossInventario.Services;
using crossInventario.ConecctionClass;
using SQLite;

[assembly: Dependency (typeof(DatabaseConnection_Android))]

namespace crossInventario.Droid.Services
{
   public class DatabaseConnection_Android : IDatabaseConnection
    {
        conectionDatabase nuevo = new conectionDatabase();
        public SQLiteAsyncConnection DbConnection() {
            return new SQLiteAsyncConnection(nuevo.databasePath, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache);
        }
    }
}