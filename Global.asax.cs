using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;

namespace lab2
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery",

                 new ScriptResourceDefinition


                 {

                     Path = "~/scripts/jquery-3.6.0.min.js",

                     DebugPath = "~/scripts/jquery-3.6.0.js",

                     CdnPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.8.3.min.js",

                     CdnDebugPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.8.3.js"

                 });

            Application["version"] = "v8.7.3";

            List<String> listaProfesores = new List<String>();
            List<String> listaAlumnos = new List<String>();

            Application.Contents["listaProfesores"]= listaProfesores;
            Application.Contents["listaAlumnos"] = listaAlumnos;
            Application.Contents["numeroAlumnos"] = 0;
            Application.Contents["numeroProfesores"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();
            if ((String)Session["tipo"] == "Alumno")
            {
                List<String> la = (List<String>)Application.Contents["listaAlumnos"];
                la.Add((String)Session["email"]);
                Application.Contents["listaAlumnos"] = la;
                int na = la.Count();
                Application.Contents["numeroAlumnos"] = na;
            } else if((String)Session["tipo"] == "Profesor"){
                List<String> lp = (List<String>)Application.Contents["listaProfesores"];
                lp.Add((String)Session["email"]);
                Application.Contents["listaProfesores"] = lp;
                int np = lp.Count();
                Application.Contents["numeroProfesores"] = np;
            }
            Application.UnLock();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application.Lock();
            if ((string)Session["tipo"] == "Alumno")
            {
                List<String> la = (List<String>)Application["listaAlumnos"];
                la.Remove((string)Session["email"]);
                Application["listaAlumnos"] = la;
                Application["numeroAlumnos"] = la.Count();
            }
            else if ((string)Session["tipo"] == "Profesor")
            {
                List<String> lp = (List<String>)Application["listaProfesores"];
                lp.Remove((string)Session["email"]);
                Application["listaProfesores"] = lp;
                Application["numeroProfesores"] = lp.Count();
            }
            Application.UnLock();
        }

        protected void Application_End(object sender, EventArgs e)
        {
            List<String> listaProfesores = new List<String>();
            List<String> listaAlumnos = new List<String>();
            Application.Contents["listaProfesores"] = listaProfesores;
            Application.Contents["listaAlumnos"] = listaAlumnos;
            Application.Contents["numeroAlumnos"] = 0;
            Application.Contents["numeroProfesores"] = 0;
        }
    }
}