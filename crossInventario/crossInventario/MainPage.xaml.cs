using crossInventario.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace crossInventario
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void Guardar_Clicked(object sender, EventArgs e)
        {
            var listaw3 = await inventarioDatabase.GetItemsNotDoneAsync("4007817328941");
            Debug.WriteLine("<----------------********---------------->");
            foreach (var stock3 in listaw3)
            {
                Debug.WriteLine(stock3.CODIGO_PRODUCTO);
                Debug.WriteLine(stock3.CANTIDAD);
                Debug.WriteLine(stock3.CODIGO_BODEGA);
                Debug.WriteLine(stock3.CODIGO_UM);
            }
        }
    }
}
