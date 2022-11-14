using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Negocio.Garantia{
public class Informe:DAL.TDatosSql {
   #region"atributos"
       private Int64 idInforme;
       private DateTime fechaInforme;
       private String obsInforme;
       private Int32 iConcurrenciaInforme;
       private Int64 idOrdenTrabajo;
       private Int64 idDesperfecto;
   #endregion
   #region"propiedades"
       public Int64 PidInforme{
          set {idInforme=value;}
          get { return idInforme;}
       }

       public DateTime PfechaInforme{
          set {fechaInforme=value;}
          get { return fechaInforme;}
       }

       public String PobsInforme{
          set {obsInforme=value;}
          get { return obsInforme;}
       }

       public Int32 PiConcurrenciaInforme{
          set {iConcurrenciaInforme=value;}
          get { return iConcurrenciaInforme;}
       }

       public Int64 PidOrdenTrabajo{
          set {idOrdenTrabajo=value;}
          get { return idOrdenTrabajo;}
       }

       public Int64 PidDesperfecto{
          set {idDesperfecto=value;}
          get { return idDesperfecto;}
       }

   #endregion
   #region"Metodos"
   private int ABM(Utilitario.Utilitario._ABM tarea) {
       int resultado=0;
       System.Object[] args = new System.Object[8];
       args[0] = tarea;
       args[1] = this.PidInforme;
       args[2] = this.PfechaInforme;
       args[3] = this.PobsInforme;
       args[4] = this.PiConcurrenciaInforme;
       args[5] = this.PidOrdenTrabajo;
       args[6] = this.PidDesperfecto;
       args[7] = resultado;
       resultado = this.Ejecutar("Sp_abmInforme", args);
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
   public DataTable Traer_Informe()
   {
       System.Object[] args = new System.Object[1];
       args[0] = this.PidInforme;
       return this.TraerDataTable("sp_traerInforme", args);
   }

   public DataTable Traer_Informe_porNumero()
   {
       System.Object[] args = new System.Object[1];
       args[0] = this.PidOrdenTrabajo;
       return this.TraerDataTable("sp_Traer_informe_porNumero", args);
   }
   #endregion
}
}
