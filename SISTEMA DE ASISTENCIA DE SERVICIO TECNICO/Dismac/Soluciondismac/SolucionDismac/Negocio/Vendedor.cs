using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Negocio.Garantia{
public class Vendedor:DAL.TDatosSql {
   #region"atributos"
       private Int64 idVendedor;
       private Int32 iConcurrenciaVendedor;
       private Byte tipoVendedor;
       private Int64 idPersona;
       private Int64 idLocalidad;
   #endregion
   #region"propiedades"
       public Int64 PidVendedor{
          set {idVendedor=value;}
          get { return idVendedor;}
       }

       public Int32 PiConcurrenciaVendedor{
          set {iConcurrenciaVendedor=value;}
          get { return iConcurrenciaVendedor;}
       }

       public Byte PtipoVendedor{
          set {tipoVendedor=value;}
          get { return tipoVendedor;}
       }

       public Int64 PidPersona{
          set {idPersona=value;}
          get { return idPersona;}
       }

       public Int64 PidLocalidad{
          set {idLocalidad=value;}
          get { return idLocalidad;}
       }

   #endregion
   #region"Metodos"
   private int ABM(Utilitario.Utilitario._ABM tarea) {
       int resultado=0;
       System.Object[] args = new System.Object[7];
       args[0] = tarea;
       args[1] = this.PidVendedor;
       args[2] = this.PiConcurrenciaVendedor;
       args[3] = this.PtipoVendedor;
       args[4] = this.PidPersona;
       args[5] = this.PidLocalidad;
       args[6] = resultado;
       resultado = this.Ejecutar("Sp_abmVendedor", args);
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
   public DataTable Traer_Vendedor(){
       System.Object[] args = new System.Object[1];
       args[0] = this.PidVendedor;
       return this.TraerDataTable("sp_Traer_Vendedor", args);
   }
   #endregion
}
}
