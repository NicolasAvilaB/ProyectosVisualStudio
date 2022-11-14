using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Negocio.Usuario{
public class Persona:DAL.TDatosSql {
   #region"atributos"
       private Int64 idPersona;
       private String estadoPersona;
       private String telf;
   #endregion
   #region"propiedades"
       public Int64 PidPersona{
          set {idPersona=value;}
          get { return idPersona;}
       }

       public String PestadoPersona{
          set {estadoPersona=value;}
          get { return estadoPersona;}
       }

       public String Ptelf{
          set {telf=value;}
          get { return telf;}
       }

   #endregion
   #region"Metodos"
   private int ABM(Utilitario.Utilitario._ABM tarea) {
       int resultado=0;
       System.Object[] args = new System.Object[5];
       args[0] = tarea;
       args[1] = this.PidPersona;
       args[2] = this.PestadoPersona;
       args[3] = this.Ptelf;
       args[4] = resultado;
       resultado = this.Ejecutar("Sp_abmPersona", args);
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
   public DataTable Traer_Persona(){
       System.Object[] args = new System.Object[1];
       args[0] = this.PidPersona;
       return this.TraerDataTable("sp_traerPersona", args);
   }
   #endregion
}
}
