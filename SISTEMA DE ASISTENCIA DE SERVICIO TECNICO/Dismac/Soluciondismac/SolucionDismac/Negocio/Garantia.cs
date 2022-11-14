using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Negocio.Garantia
{
    public class Garantia : DAL.TDatosSql
    {
        #region"atributos"
        private Int64 idGarantia;
        private Int64 numeroGarantia;
        private String serieGarantia;
        private DateTime fechaCompra;
        private DateTime fechaValidezGarantia;
        private String obsGarantia;
        private Byte estadoGarantia;
        private Int32 iConcurrenciaGarantia;
        private Int64 idCliente;
        private Int64 idVendedor;
        private Int64 idProducto;
        #endregion
        #region"propiedades"
        public Int64 PidGarantia
        {
            set { idGarantia = value; }
            get { return idGarantia; }
        }

        public Int64 PnumeroGarantia
        {
            set { numeroGarantia = value; }
            get { return numeroGarantia; }
        }

        public String PserieGarantia
        {
            set { serieGarantia = value; }
            get { return serieGarantia; }
        }

        public DateTime PfechaCompra
        {
            set { fechaCompra = value; }
            get { return fechaCompra; }
        }

        public DateTime PfechaValidezGarantia
        {
            set { fechaValidezGarantia = value; }
            get { return fechaValidezGarantia; }
        }

        public String PobsGarantia
        {
            set { obsGarantia = value; }
            get { return obsGarantia; }
        }

        public Byte PestadoGarantia
        {
            set { estadoGarantia = value; }
            get { return estadoGarantia; }
        }

        public Int32 PiConcurrenciaGarantia
        {
            set { iConcurrenciaGarantia = value; }
            get { return iConcurrenciaGarantia; }
        }

        public Int64 PidCliente
        {
            set { idCliente = value; }
            get { return idCliente; }
        }

        public Int64 PidVendedor
        {
            set { idVendedor = value; }
            get { return idVendedor; }
        }

        public Int64 PidProducto
        {
            set { idProducto = value; }
            get { return idProducto; }
        }

        #endregion
        #region"Metodos"


        private int ABM(Utilitario.Utilitario._ABM tarea)
        {
            int resultado = 0;
            System.Object[] args = new System.Object[13];
            args[0] = tarea;
            args[1] = this.PidGarantia;
            args[2] = this.PnumeroGarantia;
            args[3] = this.PserieGarantia;
            args[4] = this.PfechaCompra;
            args[5] = this.PfechaValidezGarantia;
            args[6] = this.PobsGarantia;
            args[7] = this.PestadoGarantia;
            args[8] = this.PiConcurrenciaGarantia;
            args[9] = this.PidCliente;
            args[10] = this.PidVendedor;
            args[11] = this.PidProducto;
            args[12] = resultado;
            resultado = this.Ejecutar("Sp_abmGarantia", args);
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
        public DataTable Traer_Garantia()
        {
            System.Object[] args = new System.Object[1];
            args[0] = this.PidGarantia;
            return this.TraerDataTable("Sp_TraerGarantia", args);
        }//


        public DataTable Traer_Grtbl_garantias_x_numero()
        {
            System.Object[] args = new System.Object[2];
            args[0] = this.numeroGarantia;
            args[1] = this.serieGarantia;
            return this.TraerDataTable("Sp_TraerGarantia", args);
        }


        public DataTable Traer_Cliente()
        {
            System.Object[] args = new System.Object[0];
            return this.TraerDataTable("sp_Traer_Cliente", args);
        }//


        public DataTable Traer_Garantia_Cliente_Vendeodor()
        {
            System.Object[] args = new System.Object[2];
            args[0] = Utilitario.Utilitario.Inicial;
            args[1] = Utilitario.Utilitario.Final;
            return this.TraerDataTable("sp_Garantia_Generada", args);
        }

        public DataTable Traer_Garantia_porIDReporte()
        {
            System.Object[] args = new System.Object[2];
            args[0] = Utilitario.Utilitario.idGarantiaReporte;
            return this.TraerDataTable("sp_Traer_Garantia_porNumero", args);
        }

        public DataTable Validar_Garantia()
        {
            System.Object[] args = new System.Object[2];
            args[0] = Utilitario.Utilitario.Inicial;
            args[1] = Utilitario.Utilitario.Final;
            return this.TraerDataTable("sp_validar_Series", args);
        }


        public DataTable Traer_Garantias_comodin()
        {
            System.Object[] args = new System.Object[2];
            args[0] = this.PobsGarantia;
            return this.TraerDataTable("sp_Traer_Garantias_Lista", args);
        }


        public DataTable Traer_Garantias_porID()
        {
            System.Object[] args = new System.Object[2];
            args[0] = this.PidGarantia;
            return this.TraerDataTable("sp_Traer_Garantia_porID", args);
        }

        public DataTable Traer_Garantias_por_idGarantia()
        {
            System.Object[] args = new System.Object[2];
            args[0] = this.PidGarantia;
            return this.TraerDataTable("sp_Traer_Garantia_porNumero", args);
        }


        #endregion
    }
}
