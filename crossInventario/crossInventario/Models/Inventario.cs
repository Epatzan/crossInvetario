using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace crossInventario.Models
{
    public class IN_BODEGA
    {
        public string CODIGO_EMPRESA { get; set; }
        public string CODIGO_BODEGA { get; set; }
        public string CODIGO_BARRAS { get; set; }
    }

    public class IN_PRODUCTO
    {
        public string CODIGO_PRODUCTO { get; set; }
        public string DECRIPCION_PRODUCTO { get; set; }
        public string CODIGO_IDENTIFICADOR { get; set; }
        public string UNIDAD_SUGERIDA { get; set; }
        public int DECIMALES { get; set; }
        public int NUEVO_PRODUCTO { get; set; }
    }

    public class IN_PRODUCTOS_UM
    {
        public string CODIGO_PRODUCTO { get; set; }
        public string CODIGO_UM { get; set; }
    }

    public class IN_UBICACION
    {
        public string CODIGO_BODEGA { get; set; }
        public string CODIGO_UBICA { get; set; }
        public string CODIGO_BARRAS { get; set; }
    }
    public class LECTURA_PRODUCTO
    {
        public string CODIGO_BODEGA { get; set; }
        public string CODIGO_UBICACION { get; set; }
        public string CODIGO_PRODUCTO { get; set; }
        [PrimaryKey]
        public string CODIGO_IDENTIFICADOR { get; set; }
        public string CODIGO_UM { get; set; }
        public int CANTIDAD { get; set; }


    }
}
