using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Wcf.Controller;

namespace Wcf.Model
{
    public class MetodosQuerry
    {

         static SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Lab2DB;Integrated Security=True");

        public SqlCommand conexion()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();

            return cmd;
        }

        public List<Productos> filtraProductos(Productos prod, List<Productos> ProdL){

            SqlCommand cmd =  conexion();

            cmd = new SqlCommand();

            cmd.CommandText = "SELECT top 10 Factura.idFactura, Factura.FechaFactura, Factura.PrecioTotal, Producto.nombreProducto "+ 
            "FROM Factura INNER JOIN FacturaDetail ON Factura.idFactura = FacturaDetail.Factura_idFactura INNER JOIN Producto "+
            "ON FacturaDetail.Producto_idProducto = Producto.idProducto "+
            "WHERE FechaFactura >= '" +prod.FechaFacturaInicio+ "' AND FechaFactura <= '" +prod.FechaFacturaFin+ "' AND nombreProducto LIKE '%" +prod.NombreProducto+ "%'";

            cmd.Connection = con; // IMPORTANE |EEEEEEEEEE

            ProdL = new List<Productos>();

            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                prod.IdFactura = Convert.ToInt32(reader[0]);
                prod.FechaFactura = reader[1].ToString();
                prod.PrecioTotal = Convert.ToDouble(reader[2]);
                prod.NombreProducto = reader[3].ToString(); ;

                ProdL.Add(prod);
            }

            con.Close();

            return ProdL;
        }

        public List<Productos> cargaProductos(List<Productos> ProdL) {

            SqlCommand cmd = conexion();

            cmd = new SqlCommand();

            cmd.CommandText = "SELECT top 10 Factura.idFactura, Factura.FechaFactura, Factura.PrecioTotal, Producto.nombreProducto FROM Factura INNER JOIN FacturaDetail ON Factura.idFactura = FacturaDetail.Factura_idFactura INNER JOIN Producto ON FacturaDetail.Producto_idProducto = Producto.idProducto";

            cmd.Connection = con; // IMPORTANE |EEEEEEEEEE

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                Productos prod = new Productos();
                prod.IdFactura = Convert.ToInt32(reader[0]);
                prod.FechaFactura = reader[1].ToString();
                prod.PrecioTotal = Convert.ToDouble(reader[2]);
                prod.NombreProducto = reader[3].ToString();

                ProdL.Add(prod);

            }

            con.Close();

            return ProdL;
        
            


        }

    }
}