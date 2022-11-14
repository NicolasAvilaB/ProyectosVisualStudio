using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Negocio.Producto{
public class Modelo:DAL.TDatosSql {
   #region"atributos"
       private Int64 idModelo;
       private String nombreModelo;
       private String descModelo;
       private Int32 iConcurrenciaModelo;
       private Int64 idLinea;
   #endregion
   #region"propiedades"
       public Int64 PidModelo{
          set {idModelo=value;}
          get { return idModelo;}
       }

       public String PnombreModelo{
          set {nombreModelo=value;}
          get { return nombreModelo;}
       }

       public String PdescModelo{
          set {descModelo=value;}
          get { return descModelo;}
       }

       public Int32 PiConcurrenciaModelo{
          set {iConcurrenciaModelo=value;}
          get { return iConcurrenciaModelo;}
       }

       public Int64 PidLinea{
          set {idLinea=value;}
          get { return idLinea;}
       }

   #endregion
   #region"Metodos"
   private int ABM(Utilitario.Utilitario._ABM tarea) {
       int resultado=0;
       System.Object[] args = new System.Object[7];
       args[0] = tarea;
       args[1] = this.PidModelo;
       args[2] = this.PnombreModelo;
       args[3] = this.PdescModelo;
       args[4] = this.PiConcurrenciaModelo;
       args[5] = this.PidLinea;
       args[6] = resultado;
       resultado = this.Ejecutar("Sp_abmModelo", args);
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
   public DataTable Traer_Modelo(){
       System.Object[] args = new System.Object[1];
       args[0] = this.PidLinea;
       return this.TraerDataTable("sp_Traer_Modelo", args);
   }


   public DataTable Traer_Modelo_porID()
   {
       System.Object[] args = new System.Object[1];
       args[0] = this.PidModelo;
       return this.TraerDataTable("sp_Traer_modelo_porID", args);
   }

   public DataTable Traer_Modelo_Comodin()
   {
       System.Object[] args = new System.Object[1];
       args[0] = this.descModelo;
       return this.TraerDataTable("sp_Traer_modelo_comodin", args);
   }
   #endregion
}
}
