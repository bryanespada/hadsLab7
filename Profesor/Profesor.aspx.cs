using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab2
{
    public partial class Profesor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Application["numeroProfesores"] = (int)Application["numeroProfesores"] + 1;
            LabelUsuarios.Text = "USUARIOS LOGUEADOS: " + Application.Contents["numeroAlumnos"] + " Alumno/s y " +
                Application.Contents["numeroProfesores"] + " Profe/s";
            ListBox1.DataSource = Application["listaAlumnos"];
            ListBox1.DataBind();
            ListBox2.DataSource = Application["listaProfesores"];
            ListBox2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Profesor/VerTareasProfesor.aspx");
        }

        protected void botonCerrarSesion_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/inicio.aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/Profesor/Estadisticas.aspx");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Profesor/XML/ImportarTareasXMLDocument.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Profesor/XML/ExportarTareas.aspx");

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}