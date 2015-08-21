using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {


        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Lab2DB;Integrated Security=True");


        public List<Productos> GetProductos()
        {

            Productos prod = new Productos();
            con.Open();
            SqlCommand cmd = new SqlCommand();

            //cmd.CommandText = "SELECT top 10 Factura.idFactura, Factura.FechaFactura, Factura.PrecioTotal, Producto.nombreProducto " +
            //    "FROM Factura " +
            //    "INNER JOIN FacturaDetail ON Factura.idFactura = FacturaDetail.Factura_idFactura " +
            //    "INNER JOIN Producto ON FacturaDetail.Producto_idProducto = Producto.idProducto ";

            //cmd.CommandText = "WHERE FechaFactura >= '@fechaFacturaInicio' AND ";
            //cmd.Parameters.AddWithValue("fechaFacturaInicio", prod.FechaFacturaInicio);

            //cmd.CommandText = "FechaFactura <= '@fechaFacturaFin' AND ";
            //cmd.Parameters.AddWithValue("fechaFacturaFin", prod.FechaFacturaFin);

            //cmd.CommandText = "nombreProducto LIKE '@nombreProducto' ";
            //cmd.Parameters.AddWithValue("nombreProducto", prod.NombreProducto);

            cmd.Connection = con; // IMPORTANE |EEEEEEEEEE

            //----------------------PRUEBAA====================

            cmd.CommandText = "SELECT top 10 Factura.idFactura, Factura.FechaFactura, Factura.PrecioTotal, Producto.nombreProducto FROM Factura INNER JOIN FacturaDetail ON Factura.idFactura = FacturaDetail.Factura_idFactura INNER JOIN Producto ON FacturaDetail.Producto_idProducto = Producto.idProducto WHERE FechaFactura >= '1990-01-01'AND FechaFactura <= '2016-12-31' and nombreProducto LIKE '%mountain%'";

            //--------------------------------------------======


            List<Productos> ProdL = new List<Productos>();

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

        public List<Productos> MostrarProductos() 
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            List<Productos> ProdL2 = new List<Productos>();

            cmd.CommandText = "SELECT top 10 Factura.idFactura, Factura.FechaFactura, Factura.PrecioTotal, Producto.nombreProducto FROM Factura INNER JOIN FacturaDetail ON Factura.idFactura = FacturaDetail.Factura_idFactura INNER JOIN Producto ON FacturaDetail.Producto_idProducto = Producto.idProducto";

            cmd.Connection = con; // IMPORTANE |EEEEEEEEEE

            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {

                Productos prod2 = new Productos();
                prod2.IdFactura = Convert.ToInt32(reader[0]);
                prod2.FechaFactura = reader[1].ToString();
                prod2.PrecioTotal = Convert.ToDouble(reader[2]);
                prod2.NombreProducto = reader[3].ToString();

                ProdL2.Add(prod2);
            
            }

            con.Close();

            return ProdL2;
        }

    }
}
