using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Negocio.Garantia{
public class Desperfecto:DAL.TDatosSql {
   #region"atributos"
       private Int64 idDesperfecto;
       private String nombreDesperfecto;
       private Int32 iConcurrenciaDesperfecto;
   #endregion
   #region"propiedades"
       public Int64 PidDesperfecto{
          set {idDesperfecto=value;}
          get { return idDesperfecto;}
       }

       public String PnombreDesperfecto{
          set {nombreDesperfecto=value;}
          get { return nombreDesperfecto;}
       }

       public Int32 PiConcurrenciaDesperfecto{
          set {iConcurrenciaDesperfecto=value;}
          get { return iConcurrenciaDesperfecto;}
       }

   #endregion
   #region"Metodos"
   private int ABM(Utilitario.Utilitario._ABM tarea) {
       int resultado=0;
       System.Object[] args = new System.Object[5];
       args[0] = tarea;
       args[1] = this.PidDesperfecto;
       args[2] = this.PnombreDesperfecto;
       args[3] = this.PiConcurrenciaDesperfecto;
       args[4] = resultado;
       resultado = this.Ejecutar("Sp_abmDesperfecto", args);
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
   public DataTable Traer_Desperfecto(){
       System.Object[] args = new System.Object[1];
       args[0] = this.PidDesperfecto;
       return this.TraerDataTable("sp_traerDesperfecto", args);
   }

   public DataTable Traer_Desperfectos()
   {
       System.Object[] args = new System.Object[0];
       return this.TraerDataTable("sp_Traer_Desperfecto", args);
   }

   #endregion
}
}
