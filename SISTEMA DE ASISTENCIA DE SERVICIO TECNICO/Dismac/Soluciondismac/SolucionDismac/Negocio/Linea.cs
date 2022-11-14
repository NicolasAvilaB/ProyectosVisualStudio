using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Negocio.Producto{
public class Linea:DAL.TDatosSql {
   #region"atributos"
       private Int64 idLinea;
       private String nombreLinea;
       private String descLinea;
       private Int32 idConcurrencialinea;
       private Int64 idMarca;
   #endregion
   #region"propiedades"
       public Int64 PidLinea{
          set {idLinea=value;}
          get { return idLinea;}
       }

       public String PnombreLinea{
          set {nombreLinea=value;}
          get { return nombreLinea;}
       }

       public String PdescLinea{
          set {descLinea=value;}
          get { return descLinea;}
       }

       public Int32 PidConcurrencialinea{
          set {idConcurrencialinea=value;}
          get { return idConcurrencialinea;}
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
       args[1] = this.PidLinea;
       args[2] = this.PnombreLinea;
       args[3] = this.PdescLinea;
       args[4] = this.PidConcurrencialinea;
       args[5] = this.PidMarca;
       args[6] = resultado;
       resultado = this.Ejecutar("Sp_abmLinea", args);
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

   public DataTable Traer_Linea(){
       System.Object[] args = new System.Object[1];
       args[0] = this.PidMarca;
       return this.TraerDataTable("sp_Traer_Linea", args);
   }

   public DataTable Traer_Linea_Comodin()
   {
       System.Object[] args = new System.Object[1];
       args[0] = this.PdescLinea;
       return this.TraerDataTable("sp_Traer_LineaComodin", args);
   }

   public DataTable Traer_Linea_porID()
   {
       System.Object[] args = new System.Object[1];
       args[0] = this.PidLinea;
       return this.TraerDataTable("sp_Traer_Linea_porId", args);
   }

   public DataTable Traer_Linea_porMarca()
   {
       System.Object[] args = new System.Object[1];
       args[0] = this.PidMarca;
       return this.TraerDataTable("sp_Traer_linea_por_marca", args);
   }



   #endregion
}
}
