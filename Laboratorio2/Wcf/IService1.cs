using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        List<Productos> GetProductos();

        [OperationContract]
        List<Productos> MostrarProductos();
        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Productos
    {
        int idFactura = 0;
        string fechaFactura = string.Empty;
        string fechaFacturaInicio = string.Empty;
        string fechaFacturaFin = string.Empty;
        double precioTotal = 0.00;
        string nombreProducto = string.Empty;

        [DataMember]
        public int IdFactura
        {
            get { return idFactura; }
            set { idFactura = value; }
        }
        [DataMember]
        public string FechaFactura
        {
            get { return fechaFactura; }
            set { fechaFactura = value; }
        }
        [DataMember]
        public string FechaFacturaInicio
        {
            get { return fechaFacturaInicio; }
            set { fechaFacturaInicio = value; }
        }
        [DataMember]
        public string FechaFacturaFin
        {
            get { return fechaFacturaFin; }
            set { fechaFacturaFin = value; }
        }
        [DataMember]
        public double PrecioTotal
        {
            get { return precioTotal; }
            set { precioTotal = value; }
        }
        [DataMember]
        public string NombreProducto
        {
            get { return nombreProducto; }
            set { nombreProducto = value; }
        }
    }

}
