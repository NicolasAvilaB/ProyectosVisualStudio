using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Xml.Linq;
using System.Web.Routing;
using System.Web.DynamicData;

namespace WebApplication1
{
    public class Global : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            MetaModel model = new MetaModel();

            //                    IMPORTANTE: REGISTRO DEL MODELO DE DATOS 
            // Quitar la marca de comentario de esta línea para registrar un Entity Data Model de ADO.NET
            // para datos dinámicos de ASP.NET. Establezca ScaffoldAllTables = true solo si está seguro 
            // de que desea que todas las tablas del modelo de datos admitan una vista con scaffold (es decir, plantillas). 
            // Para controlar la técnica scaffolding para tablas individuales, cree una clase parcial para 
            // la tabla y aplique el atributo [Scaffold(true)] a dicha clase.
            // Nota: asegúrese de que cambia "YourDataContextType" al nombre de la clase del contexto de datos
            // en la aplicación.
            model.RegisterContext(typeof(SATEntities1), new ContextConfiguration() { ScaffoldAllTables = true });

            // La siguiente declaración admite el modo de páginas independientes, donde las tareas List, Detail, Insert y 
            // Update se realizan usando páginas independientes. Para habilitar este modo, quite las marcas de comentario de la siguiente 
            // definición del objeto route y marque como comentario las definiciones de route en la sección del modo de páginas independientes siguiente.
            routes.Add(new DynamicDataRoute("{table}/{action}.aspx")
            {
                Constraints = new RouteValueDictionary(new { action = "List|Details|Edit|Insert" }),
                Model = model
            });

            // Las siguientes declaraciones admiten el modo de páginas combinadas, donde las tareas List, Detail, Insert y 
            // Update se realizan usando la misma página. Para habilitar este modo, quite las marcas de comentario de los siguientes objetos
            // routes y marque como comentario la definición del objeto route en la sección del modo de páginas independientes anterior.
            //routes.Add(new DynamicDataRoute("{table}/ListDetails.aspx") {
            //    Action = PageAction.List,
            //    ViewName = "ListDetails",
            //    Modelo = modelo
            //});

            //routes.Add(new DynamicDataRoute("{table}/ListDetails.aspx") {
            //    Action = PageAction.Details,
            //    ViewName = "ListDetails",
            //    Model = model
            //});
        }

        void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);
        }

    }
}
