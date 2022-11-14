using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Negocio.Producto{
public class Marca:DAL.TDatosSql {
   #region"atributos"
       private Int64 idMarca;
       private String nombreMarca;
       private String descMarca;
       private Int32 iConcurrenciaMarca;
   #endregion
   #region"propiedades"
       public Int64 PidMarca{
          set {idMarca=value;}
          get { return idMarca;}
       }

       public String PnombreMarca{
          set {nombreMarca=value;}
          get { return nombreMarca;}
       }

       public String PdescMarca{
          set {descMarca=value;}
          get { return descMarca;}
       }

       public Int32 PiConcurrenciaMarca{
          set {iConcurrenciaMarca=value;}
          get { return iConcurrenciaMarca;}
       }

   #endregion
   #region"Metodos"
   private int ABM(Utilitario.Utilitario._ABM tarea) {
       int resultado=0;
       System.Object[] args = new System.Object[6];
       args[0] = tarea;
       args[1] = this.PidMarca;
       args[2] = this.PnombreMarca;
       args[3] = this.PdescMarca;
       args[4] = this.PiConcurrenciaMarca;
       args[5] = resultado;
       resultado = this.Ejecutar("Sp_abmMarca", args);
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
   public DataTable Traer_Marca(){
       System.Object[] args = new System.Object[0];
       return this.TraerDataTable("sp_Traer_Marca", args);
   }


   public DataTable Traer_Marca_porId()
   {
       System.Object[] args = new System.Object[1];
       args[0] = PidMarca;
       return this.TraerDataTable("sp_TraerMarca_porID", args);
   }

   public DataTable Traer_Marca_Comodin()
   {
       System.Object[] args = new System.Object[1];
       args[0] = PdescMarca;
       return this.TraerDataTable("sp_Traer_Marca_Comodin", args);
   }


   #endregion
}
}
