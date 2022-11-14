using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Negocio.Garantia{
public class Repuesto:DAL.TDatosSql {
   #region"atributos"
       private Int64 idRepuesto;
       private String descRepuesto;
       private Int32 cantidadRepuesto;
       private Int32 iConcurrenciaRepuesto;
       private Int64 idMarca;
   #endregion
   #region"propiedades"
       public Int64 PidRepuesto{
          set {idRepuesto=value;}
          get { return idRepuesto;}
       }

       public String PdescRepuesto{
          set {descRepuesto=value;}
          get { return descRepuesto;}
       }

       public Int32 PcantidadRepuesto{
          set {cantidadRepuesto=value;}
          get { return cantidadRepuesto;}
       }

       public Int32 PiConcurrenciaRepuesto{
          set {iConcurrenciaRepuesto=value;}
          get { return iConcurrenciaRepuesto;}
       }

       public Int64 PidMarca{
          set {idMarca=value;}
          get { return idMarca;}
       }

   #endregion
   #region"Metodos"
   private int ABM(Utilitario.Utilitario._ABM tarea) {
       int resultado=0;
       System.Object[] args = new System.Object[7];
       args[0] = tarea;
       args[1] = this.PidRepuesto;
       args[2] = this.PdescRepuesto;
       args[3] = this.PcantidadRepuesto;
       args[4] = this.PiConcurrenciaRepuesto;
       args[5] = this.PidMarca;
       args[6] = resultado;
       resultado = this.Ejecutar("Sp_abmRepuesto", args);
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
   public DataTable Traer_Repuesto(){
       System.Object[] args = new System.Object[1];
       args[0] = this.PidRepuesto;
       return this.TraerDataTable("sp_traerRepuesto", args);
   }

   public DataTable Traer_Repuestos()
   {
       System.Object[] args = new System.Object[0];
       return this.TraerDataTable("sp_Traer_Respuesto", args);
   }
   #endregion
}
}
