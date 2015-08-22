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
using Wcf.Model;

namespace Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public List<Productos> GetProductos(Productos prod)
        {

            MetodosQuerry MQ = new MetodosQuerry();

            List<Productos> ProdL = new List<Productos>();

            return MQ.filtraProductos(prod, ProdL);

        }

        public List<Productos> MostrarProductos() 
        {

            MetodosQuerry MQ = new MetodosQuerry();

            List<Productos> ProdL = new List<Productos>();

            return MQ.cargaProductos(ProdL);
            
            
        }

    }
}
