using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Negocio.Usuario{
public class Personanatural:DAL.TDatosSql {
   #region"atributos"
       private Int64 idPersonaNatural;
       private String nombrePersona;
       private String ciPersona;
       private Int32 iConcurrenciaNatural;
       private Int64 idTrato;
       private Int64 idPersona;
   #endregion
   #region"propiedades"
       public Int64 PidPersonaNatural{
          set {idPersonaNatural=value;}
          get { return idPersonaNatural;}
       }

       public String PnombrePersona{
          set {nombrePersona=value;}
          get { return nombrePersona;}
       }

       public String PciPersona{
          set {ciPersona=value;}
          get { return ciPersona;}
       }

       public Int32 PiConcurrenciaNatural{
          set {iConcurrenciaNatural=value;}
          get { return iConcurrenciaNatural;}
       }

       public Int64 PidTrato{
          set {idTrato=value;}
          get { return idTrato;}
       }

       public Int64 PidPersona{
          set {idPersona=value;}
          get { return idPersona;}
       }

   #endregion
   #region"Metodos"
   private int ABM(Utilitario.Utilitario._ABM tarea) {
       int resultado=0;
       System.Object[] args = new System.Object[8];
       args[0] = tarea;
       args[1] = this.PidPersonaNatural;
       args[2] = this.PnombrePersona;
       args[3] = this.PciPersona;
       args[4] = this.PiConcurrenciaNatural;
       args[5] = this.PidTrato;
       args[6] = this.PidPersona;
       args[7] = resultado;
       resultado = this.Ejecutar("Sp_abmPersonanatural", args);
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
   public DataTable Traer_Personanatural(){
       System.Object[] args = new System.Object[1];
       args[0] = this.PidPersona;
       return this.TraerDataTable("sp_traerPersonanatural", args);
   }

   public DataTable Traer_Empleado()
   {
       System.Object[] args = new System.Object[0];
       return this.TraerDataTable("Traer_Empleado", args);
   }
   #endregion
}
}
