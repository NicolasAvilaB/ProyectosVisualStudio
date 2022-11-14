using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace Resportes
{
   public  class CtrlReporte
    {
       public DataSet ListadoReporte2()
       {
           DataSet ds = new DataSet();

           Negocio.Garantia.Ordentrabajo obj = new Negocio.Garantia.Ordentrabajo();
           obj.PidOrdenTrabajo = Utilitario.Utilitario.nroOrdenTrabajo;
           ds.Tables.Add(obj.Traer_OrdenTrabajo_por_Numero());
           ds.Tables[0].TableName = "vista_reporte";
           return ds;

       }

       public DataSet ListadoReporte()
       {
           DataSet ds = new DataSet();

           Negocio.Garantia.Garantia obj = new Negocio.Garantia.Garantia();
           ds.Tables.Add(obj.Traer_Garantia_Cliente_Vendeodor());
           ds.Tables[0].TableName = "Vista_Garantias_Vendedor_Cliente";
           return ds;

       }

       public DataSet ListadoReporte3()
       {
           DataSet ds = new DataSet();

           Negocio.Garantia.Garantia obj = new Negocio.Garantia.Garantia();
           ds.Tables.Add(obj.Traer_Garantia_porIDReporte());
           ds.Tables[0].TableName = "Vista_Garantias_Vendedor_Cliente";
           return ds;

       }

     
    }
}
