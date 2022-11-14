using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Negocio.Usuario
{
    public class Usuario : DAL.TDatosSql
    {
        #region"atributos"
        private Int64 idUsuario;
        private String nombreUsuario;
        private String contraseñaUsuario;
        private Byte estadoUsuario;
        private Int32 iConcurrenciaUsuario;
        private Int64 idRol;
        private Int64 idPersona;
        #endregion
        #region"propiedades"
        public Int64 PidUsuario
        {
            set { idUsuario = value; }
            get { return idUsuario; }
        }

        public String PnombreUsuario
        {
            set { nombreUsuario = value; }
            get { return nombreUsuario; }
        }

        public String PcontraseñaUsuario
        {
            set { contraseñaUsuario = value; }
            get { return contraseñaUsuario; }
        }

        public Byte PestadoUsuario
        {
            set { estadoUsuario = value; }
            get { return estadoUsuario; }
        }

        public Int32 PiConcurrenciaUsuario
        {
            set { iConcurrenciaUsuario = value; }
            get { return iConcurrenciaUsuario; }
        }

        public Int64 PidRol
        {
            set { idRol = value; }
            get { return idRol; }
        }

        public Int64 PidPersona
        {
            set { idPersona = value; }
            get { return idPersona; }
        }

        #endregion
        #region"Metodos"

        private int ABM(Utilitario.Utilitario._ABM tarea)
        {
            int resultado = 0;
            System.Object[] args = new System.Object[9];
            args[0] = tarea;
            args[1] = this.PidUsuario;
            args[2] = this.PnombreUsuario;
            args[3] = this.PcontraseñaUsuario;
            args[4] = this.PestadoUsuario;
            args[5] = this.PiConcurrenciaUsuario;
            args[6] = this.PidRol;
            args[7] = this.PidPersona;
            args[8] = resultado;
            resultado = this.Ejecutar("Sp_abmUsuario", args);
            return resultado;
        }


        private int ABMContraseña(Utilitario.Utilitario._ABM tarea)
        {
            int resultado = 0;
            System.Object[] args = new System.Object[6];
            args[0] = tarea;
            args[1] = this.PidUsuario;
            args[2] = this.PnombreUsuario;
            args[3] = this.PcontraseñaUsuario;
            args[4] = Utilitario.Utilitario.nuevaContraseña;
            args[5] = resultado;
            resultado = this.Ejecutar("sp_cambiarProcedure", args);
            return resultado;
        }

        public int ModificarContraseña()
        {
            return ABMContraseña(Utilitario.Utilitario._ABM.Modificar);
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


        public DataTable Traer_Usuario()
        {
            System.Object[] args = new System.Object[1];
            args[0] = this.PidUsuario;
            return this.TraerDataTable("sp_traerUsuario", args);
        }


        public DataTable VerificarUsuario()
        {
            System.Object[] args = new System.Object[2];
            args[0] = this.PnombreUsuario;
            args[1] = this.PcontraseñaUsuario;
            return this.TraerDataTable("sp_Login", args);
        }

        public DataTable Traer_Rol()
        {
            System.Object[] args = new System.Object[0];
            return this.TraerDataTable("sp_Traer_Rol", args);
        }

        public DataTable Traer_ListaUsuarios()
        {
            System.Object[] args = new System.Object[1];
            args[0] = this.PidUsuario;
            return this.TraerDataTable("Traer_UsuarioLista", args);
        }


        #endregion
    }
}
