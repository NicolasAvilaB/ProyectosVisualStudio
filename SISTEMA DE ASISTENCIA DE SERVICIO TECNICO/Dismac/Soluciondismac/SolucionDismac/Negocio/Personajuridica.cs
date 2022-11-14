using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Negocio.Usuario{
public class Personajuridica:DAL.TDatosSql {
   #region"atributos"
       private Int64 idPersonaJuridica;
       private String razonSocial;
       private Int32 iConcurrenciaJuridica;
       private Int64 idRubro;
       private Int64 idPersona;
   #endregion
   #region"propiedades"
       public Int64 PidPersonaJuridica{
          set {idPersonaJuridica=value;}
          get { return idPersonaJuridica;}
       }

       public String PrazonSocial{
          set {razonSocial=value;}
          get { return razonSocial;}
       }

       public Int32 PiConcurrenciaJuridica{
          set {iConcurrenciaJuridica=value;}
          get { return iConcurrenciaJuridica;}
       }

       public Int64 PidRubro{
          set {idRubro=value;}
          get { return idRubro;}
       }

       public Int64 PidPersona{
          set {idPersona=value;}
          get { return idPersona;}
       }

   #endregion
   #region"Metodos"
   private int ABM(Utilitario.Utilitario._ABM tarea) {
       int resultado=0;
       System.Object[] args = new System.Object[7];
       args[0] = tarea;
       args[1] = this.PidPersonaJuridica;
       args[2] = this.PrazonSocial;
       args[3] = this.PiConcurrenciaJuridica;
       args[4] = this.PidRubro;
       args[5] = this.PidPersona;
       args[6] = resultado;
       resultado = this.Ejecutar("Sp_abmPersonajuridica", args);
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
   public DataTable Traer_Personajuridica(){
       System.Object[] args = new System.Object[1];
       args[0] = this.PidPersona;
       return this.TraerDataTable("sp_traerPersonajuridica", args);
   }
   #endregion
}
}
