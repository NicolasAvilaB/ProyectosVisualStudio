using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Negocio.Garantia
{
    public class Control : DAL.TDatosSql
    {
        #region"atributos"
        private Int64 idControl;
        private DateTime fechaControl;
        private Int32 numeroInicialGarantia;
        private Int32 numeroFinalGarantia;
        private String descControl;
        private Int32 iConcurrenciaControl;
        private Int64 idVendedor;
        private Int64 idCliente;
        #endregion
        #region"propiedades"
        public Int64 PidControl
        {
            set { idControl = value; }
            get { return idControl; }
        }

        public DateTime PfechaControl
        {
            set { fechaControl = value; }
            get { return fechaControl; }
        }

        public Int32 PnumeroInicialGarantia
        {
            set { numeroInicialGarantia = value; }
            get { return numeroInicialGarantia; }
        }

        public Int32 PnumeroFinalGarantia
        {
            set { numeroFinalGarantia = value; }
            get { return numeroFinalGarantia; }
        }

        public String PdescControl
        {
            set { descControl = value; }
            get { return descControl; }
        }

        public Int32 PiConcurrenciaControl
        {
            set { iConcurrenciaControl = value; }
            get { return iConcurrenciaControl; }
        }

        public Int64 PidVendedor
        {
            set { idVendedor = value; }
            get { return idVendedor; }
        }

        public Int64 PidCliente
        {
            set { idCliente = value; }
            get { return idCliente; }
        }

        #endregion
        #region"Metodos"
        private int ABM(Utilitario.Utilitario._ABM tarea)
        {
            int resultado = 0;
            System.Object[] args = new System.Object[10];
            args[0] = tarea;
            args[1] = this.PidControl;
            args[2] = this.PfechaControl;
            args[3] = this.PnumeroInicialGarantia;
            args[4] = this.PnumeroFinalGarantia;
            args[5] = this.PdescControl;
            args[6] = this.PiConcurrenciaControl;
            args[7] = this.PidVendedor;
            args[8] = this.PidCliente;
            args[9] = resultado;
            resultado = this.Ejecutar("Sp_abmControl", args);
            return resultado;
        }
        public int Guardar()
        {
            return ABM(Utilitario.Utilitario._ABM.Guardar);
        }
        public int Modificar()
        {
            return ABM(Utilitario.Utilitario._ABM.Modificar);
        }
        public int Eliminar()
        {
            return ABM(Utilitario.Utilitario._ABM.Eliminar);
        }
        public DataTable Traer_Control_porNumero()
        {
            System.Object[] args = new System.Object[1];
            args[0] = this.PidControl;
            return this.TraerDataTable("sp_TraerControl_porNumero", args);
        }


        public DataTable Traer_Controles()
        {
            System.Object[] args = new System.Object[1];
            args[0] = this.PdescControl;
            return this.TraerDataTable("sp_TraerControles", args);
        }
        #endregion
    }
}
