using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Negocio.Garantia{
public class Asignacion:DAL.TDatosSql {
   #region"atributos"
       private Int64 idAsignacion;
       private DateTime fechaAsignacion;
       private String obsAsignacion;
       private Int32 iConcurrenciaAsignacion;
       private Int64 idOrdenTrabajo;
       private Int64 idTecnico;
   #endregion
   #region"propiedades"
       public Int64 PidAsignacion{
          set {idAsignacion=value;}
          get { return idAsignacion;}
       }

       public DateTime PfechaAsignacion{
          set {fechaAsignacion=value;}
          get { return fechaAsignacion;}
       }

       public String PobsAsignacion{
          set {obsAsignacion=value;}
          get { return obsAsignacion;}
       }

       public Int32 PiConcurrenciaAsignacion{
          set {iConcurrenciaAsignacion=value;}
          get { return iConcurrenciaAsignacion;}
       }

       public Int64 PidOrdenTrabajo{
          set {idOrdenTrabajo=value;}
          get { return idOrdenTrabajo;}
       }

       public Int64 PidTecnico{
          set {idTecnico=value;}
          get { return idTecnico;}
       }

   #endregion
   #region"Metodos"
   private int ABM(Utilitario.Utilitario._ABM tarea) {
       int resultado=0;
       System.Object[] args = new System.Object[8];
       args[0] = tarea;
       args[1] = this.PidAsignacion;
       args[2] = this.PfechaAsignacion;
       args[3] = this.PobsAsignacion;
       args[4] = this.PiConcurrenciaAsignacion;
       args[5] = this.PidOrdenTrabajo;
       args[6] = this.PidTecnico;
       args[7] = resultado;
       resultado = this.Ejecutar("Sp_abmAsignacion", args);
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
   public DataTable Traer_Asignacion(){
       System.Object[] args = new System.Object[1];
       args[0] = this.PidAsignacion;
       return this.TraerDataTable("sp_traerAsignacion", args);
   }

   public DataTable Traer_Asignacion_porNumero()
   {
       System.Object[] args = new System.Object[1];
       args[0] = this.PidOrdenTrabajo;
       return this.TraerDataTable("sp_Traer_Asignacion_porNumero", args);
   }
   #endregion
}
}
