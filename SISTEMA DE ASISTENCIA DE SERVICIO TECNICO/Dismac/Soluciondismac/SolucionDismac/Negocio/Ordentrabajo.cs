using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Negocio.Garantia{
public class Ordentrabajo:DAL.TDatosSql {
   #region"atributos"
       private Int64 idOrdenTrabajo;
       private DateTime fechaOrdenTrabajo;
       private Byte estadoOrdenTrabajo;
       private String descOrdenTrabajo;
       private Int32 iConcurrenciaOrdenTrabajo;
       private Int64 idUsuario;
       private Int64 idGarantia;
   #endregion
   #region"propiedades"
       public Int64 PidOrdenTrabajo{
          set {idOrdenTrabajo=value;}
          get { return idOrdenTrabajo;}
       }

       public DateTime PfechaOrdenTrabajo{
          set {fechaOrdenTrabajo=value;}
          get { return fechaOrdenTrabajo;}
       }

       public Byte PestadoOrdenTrabajo{
          set {estadoOrdenTrabajo=value;}
          get { return estadoOrdenTrabajo;}
       }

       public String PdescOrdenTrabajo{
          set {descOrdenTrabajo=value;}
          get { return descOrdenTrabajo;}
       }

       public Int32 PiConcurrenciaOrdenTrabajo{
          set {iConcurrenciaOrdenTrabajo=value;}
          get { return iConcurrenciaOrdenTrabajo;}
       }

       public Int64 PidUsuario{
          set {idUsuario=value;}
          get { return idUsuario;}
       }

       public Int64 PidGarantia{
          set {idGarantia=value;}
          get { return idGarantia;}
       }

   #endregion
   #region"Metodos"
   private int ABM(Utilitario.Utilitario._ABM tarea) {
       int resultado=0;
       System.Object[] args = new System.Object[9];
       args[0] = tarea;
       args[1] = this.PidOrdenTrabajo;
       args[2] = this.PfechaOrdenTrabajo;
       args[3] = this.PestadoOrdenTrabajo;
       args[4] = this.PdescOrdenTrabajo;
       args[5] = this.PiConcurrenciaOrdenTrabajo;
       args[6] = this.PidUsuario;
       args[7] = this.PidGarantia;
       args[8] = resultado;
       resultado = this.Ejecutar("Sp_abmOrdentrabajo", args);
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
    public DataTable Traer_Ordtbl_trabajos_con_Nombre()
    {
       System.Object[] args = new System.Object[0];
       return this.TraerDataTable("sp_Traer_Orden_Nombre", args);
   }

    //
    public DataTable Traer_Ordtbl_trabajos_Completo()
    {
        System.Object[] args = new System.Object[1];
        args[0] = this.PidOrdenTrabajo;
        return this.TraerDataTable("sp_Traer_Orden_Completo", args);
    }

    public DataTable Traer_Ordtbl_trabajos_Comodin()
    {
        System.Object[] args = new System.Object[1];
        args[0] = Utilitario.Utilitario.comodin;
        return this.TraerDataTable("sp_Traer_comodin", args);
    }

    public DataTable Traer_OrdenTrabajo_por_Numero()
    {
        System.Object[] args = new System.Object[1];
        args[0] = Utilitario.Utilitario.nroOrdenTrabajo;
        return this.TraerDataTable("sp_Traer_Orden_porNumero", args);
    }

   #endregion
}
}
