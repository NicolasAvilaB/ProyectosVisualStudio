using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Negocio.Garantia{
public class Repuestoorden:DAL.TDatosSql {
   #region"atributos"
       private Int64 idRepuestoOrden;
       private Int32 cantidadRepuestoOrden;
       private Decimal precioRepuestoOrden;
       private DateTime fechaRepuesto;
       private Int32 iConcurrenciaRepuestoOrden;
       private Int64 idRepuesto;
       private Int64 idOrdenTrabajo;
   #endregion
   #region"propiedades"
       public Int64 PidRepuestoOrden{
          set {idRepuestoOrden=value;}
          get { return idRepuestoOrden;}
       }

       public Int32 PcantidadRepuestoOrden{
          set {cantidadRepuestoOrden=value;}
          get { return cantidadRepuestoOrden;}
       }

       public Decimal PprecioRepuestoOrden{
          set {precioRepuestoOrden=value;}
          get { return precioRepuestoOrden;}
       }

       public DateTime PfechaRepuesto{
          set {fechaRepuesto=value;}
          get { return fechaRepuesto;}
       }

       public Int32 PiConcurrenciaRepuestoOrden{
          set {iConcurrenciaRepuestoOrden=value;}
          get { return iConcurrenciaRepuestoOrden;}
       }

       public Int64 PidRepuesto{
          set {idRepuesto=value;}
          get { return idRepuesto;}
       }

       public Int64 PidOrdenTrabajo{
          set {idOrdenTrabajo=value;}
          get { return idOrdenTrabajo;}
       }

   #endregion
   #region"Metodos"
   private int ABM(Utilitario.Utilitario._ABM tarea) {
       int resultado=0;
       System.Object[] args = new System.Object[9];
       args[0] = tarea;
       args[1] = this.PidRepuestoOrden;
       args[2] = this.PcantidadRepuestoOrden;
       args[3] = this.PprecioRepuestoOrden;
       args[4] = this.PfechaRepuesto;
       args[5] = this.PiConcurrenciaRepuestoOrden;
       args[6] = this.PidRepuesto;
       args[7] = this.PidOrdenTrabajo;
       args[8] = resultado;
       resultado = this.Ejecutar("Sp_abmRepuestoorden", args);
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
   public DataTable Traer_Repuestoorden(){
       System.Object[] args = new System.Object[1];
       args[0] = this.PidOrdenTrabajo;
       return this.TraerDataTable("sp_traerRepuestoorden", args);
   }


   public DataTable Traer_Repuestoorden_porNumero()
   {
       System.Object[] args = new System.Object[1];
       args[0] = this.PidOrdenTrabajo;
       return this.TraerDataTable("sp_Traer_Respuesto_Orden", args);
   }



   #endregion
}
}
