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

namespace Wcf.Controller
{
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