using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Negocio.Garantia{
public class Tecnico:DAL.TDatosSql {
   #region"atributos"
       private Int64 idTecnico;
       private Byte tipoTecnico;
       private Int32 iConcurrenciaTecnico;
       private Int64 idPersona;
   #endregion
   #region"propiedades"
       public Int64 PidTecnico{
          set {idTecnico=value;}
          get { return idTecnico;}
       }

       public Byte PtipoTecnico{
          set {tipoTecnico=value;}
          get { return tipoTecnico;}
       }

       public Int32 PiConcurrenciaTecnico{
          set {iConcurrenciaTecnico=value;}
          get { return iConcurrenciaTecnico;}
       }

       public Int64 PidPersona{
          set {idPersona=value;}
          get { return idPersona;}
       }

   #endregion
   #region"Metodos"
   private int ABM(Utilitario.Utilitario._ABM tarea) {
       int resultado=0;
       System.Object[] args = new System.Object[6];
       args[0] = tarea;
       args[1] = this.PidTecnico;
       args[2] = this.PtipoTecnico;
       args[3] = this.PiConcurrenciaTecnico;
       args[4] = this.PidPersona;
       args[5] = resultado;
       resultado = this.Ejecutar("Sp_abmTecnico", args);
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
   public DataTable Traer_Tecnico(){
       System.Object[] args = new System.Object[1];
       args[0] = this.PidTecnico;
       return this.TraerDataTable("sp_traerTecnico", args);
   }

   public DataTable Traer_Tecnicos()
   {
       System.Object[] args = new System.Object[0];
       return this.TraerDataTable("sp_Traer_Tecnico", args);
   }

   #endregion
}
}
