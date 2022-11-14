using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Negocio.Garantia{
public class Servicio:DAL.TDatosSql {
   #region"atributos"
       private Int64 idServicio;
       private String nombreServicio;
       private Int32 iConcurrenciaServicio;
   #endregion
   #region"propiedades"
       public Int64 PidServicio{
          set {idServicio=value;}
          get { return idServicio;}
       }

       public String PnombreServicio{
          set {nombreServicio=value;}
          get { return nombreServicio;}
       }

       public Int32 PiConcurrenciaServicio{
          set {iConcurrenciaServicio=value;}
          get { return iConcurrenciaServicio;}
       }

   #endregion
   #region"Metodos"
   private int ABM(Utilitario.Utilitario._ABM tarea) {
       int resultado=0;
       System.Object[] args = new System.Object[5];
       args[0] = tarea;
       args[1] = this.PidServicio;
       args[2] = this.PnombreServicio;
       args[3] = this.PiConcurrenciaServicio;
       args[4] = resultado;
       resultado = this.Ejecutar("Sp_abmServicio", args);
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
   public DataTable Traer_Servicio(){
       System.Object[] args = new System.Object[1];
       args[0] = this.PidServicio;
       return this.TraerDataTable("sp_traerServicio", args);
   }

   public DataTable Traer_Servicios()
   {
       System.Object[] args = new System.Object[0];
       return this.TraerDataTable("sp_Traer_Servicios", args);
   }
   #endregion
}
}
