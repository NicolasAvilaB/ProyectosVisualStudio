using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Negocio.Producto{
public class Producto:DAL.TDatosSql {
   #region"atributos"
       private Int64 idProducto;
       private String nombreProducto;
       private Int32 iConcurrenciaProducto;
       private Int64 idModelo;
   #endregion
   #region"propiedades"
       public Int64 PidProducto{
          set {idProducto=value;}
          get { return idProducto;}
       }

       public String PnombreProducto{
          set {nombreProducto=value;}
          get { return nombreProducto;}
       }

       public Int32 PiConcurrenciaProducto{
          set {iConcurrenciaProducto=value;}
          get { return iConcurrenciaProducto;}
       }

       public Int64 PidModelo{
          set {idModelo=value;}
          get { return idModelo;}
       }

   #endregion
   #region"Metodos"
   private int ABM(Utilitario.Utilitario._ABM tarea) {
       int resultado=0;
       System.Object[] args = new System.Object[6];
       args[0] = tarea;
       args[1] = this.PidProducto;
       args[2] = this.PnombreProducto;
       args[3] = this.PiConcurrenciaProducto;
       args[4] = this.PidModelo;
       args[5] = resultado;
       resultado = this.Ejecutar("Sp_abmProducto", args);
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

   public DataTable Traer_Producto(){
       System.Object[] args = new System.Object[1];
       args[0] = this.PidProducto;
       return this.TraerDataTable("sp_traerProducto", args);
   }

   public DataTable Traer_Productos()
   {
       System.Object[] args = new System.Object[1];
       args[0] = this.PidModelo;
       return this.TraerDataTable("sp_Traer_Producto", args);
   }




   public DataTable Traer_Productos_por_ID()
   {
       System.Object[] args = new System.Object[1];
       args[0] = this.PidProducto;
       return this.TraerDataTable("sp_Traer_Producto_por_Numero", args);
   }


   public DataTable Traer_Productos_Comodin()
   {
       System.Object[] args = new System.Object[1];
       args[0] = this.nombreProducto;
       return this.TraerDataTable("sp_Traer_Producto_Comodin", args);
   }
   #endregion
}
}
