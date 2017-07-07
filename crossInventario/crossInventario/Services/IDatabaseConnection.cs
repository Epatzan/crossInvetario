using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace crossInventario.Services
{
   public  interface IDatabaseConnection
    {
        SQLiteAsyncConnection DbConnection();
    }
}
