using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Negocio.Garantia{
public class Serviciosorden:DAL.TDatosSql {
   #region"atributos"
       private Int64 idServiciosOrden;
       private Int32 cantidadServicio;
       private Decimal precioSevicio;
       private DateTime fechaServicio;
       private String objServicio;
       private Int32 iConcurrenciaServicioOrden;
       private Int64 idOrdenTrabajo;
       private Int64 idServicio;
   #endregion
   #region"propiedades"
       public Int64 PidServiciosOrden{
          set {idServiciosOrden=value;}
          get { return idServiciosOrden;}
       }

       public Int32 PcantidadServicio{
          set {cantidadServicio=value;}
          get { return cantidadServicio;}
       }

       public Decimal PprecioSevicio{
          set {precioSevicio=value;}
          get { return precioSevicio;}
       }

       public DateTime PfechaServicio{
          set {fechaServicio=value;}
          get { return fechaServicio;}
       }

       public String PobjServicio{
          set {objServicio=value;}
          get { return objServicio;}
       }

       public Int32 PiConcurrenciaServicioOrden{
          set {iConcurrenciaServicioOrden=value;}
          get { return iConcurrenciaServicioOrden;}
       }

       public Int64 PidOrdenTrabajo{
          set {idOrdenTrabajo=value;}
          get { return idOrdenTrabajo;}
       }

       public Int64 PidServicio{
          set {idServicio=value;}
          get { return idServicio;}
       }

   #endregion
   #region"Metodos"
   private int ABM(Utilitario.Utilitario._ABM tarea) {
       int resultado=0;
       System.Object[] args = new System.Object[10];
       args[0] = tarea;
       args[1] = this.PidServiciosOrden;
       args[2] = this.PcantidadServicio;
       args[3] = this.PprecioSevicio;
       args[4] = this.PfechaServicio;
       args[5] = this.PobjServicio;
       args[6] = this.PiConcurrenciaServicioOrden;
       args[7] = this.PidOrdenTrabajo;
       args[8] = this.PidServicio;
       args[9] = resultado;
       resultado = this.Ejecutar("Sp_abmServiciosorden", args);
       return resultado;
   }
   public int Guardar(){
       return ABM(Utilitario.Utilitario._ABM.Guardar);
   }
   public int Modificar(){
       return ABM(Utilitario.Utilitario._ABM.Modificar);
   }
    public int Eliminar(){
       return ABM(Utilitario.Utilitario._ABM.Eliminar);
   }
   public DataTable Traer_Serviciosorden(){
       System.Object[] args = new System.Object[1];
       args[0] = this.PidOrdenTrabajo;
       return this.TraerDataTable("sp_traerServiciosorden", args);
   }


   public DataTable Traer_Serviciosorden_porID()
   {
       System.Object[] args = new System.Object[1];
       args[0] = this.PidOrdenTrabajo;
       return this.TraerDataTable("sp_Traer_ServiciosOrden_porId", args);
   }
   #endregion
}
}
