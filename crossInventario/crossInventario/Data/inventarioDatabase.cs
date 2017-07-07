using crossInventario.Models;
using crossInventario.Services;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace crossInventario.Data
{
    public partial class inventarioDatabase
    {
        static readonly SQLiteAsyncConnection database = DependencyService.Get<IDatabaseConnection>().DbConnection();
        public static Task<List<LECTURA_PRODUCTO>> GetItemsNotDoneAsync(string numero)
        {

            return database.QueryAsync<LECTURA_PRODUCTO>("SELECT * FROM [LECTURA_PRODUCTO] WHERE [CODIGO_IDENTIFICADOR] = '" + numero + "'");
        }

        public static Task<LECTURA_PRODUCTO> GetCode(string topic) {
            return database.Table<LECTURA_PRODUCTO>().Where(x => x.CODIGO_IDENTIFICADOR.Equals(topic)).FirstOrDefaultAsync();
        }
    }
}
