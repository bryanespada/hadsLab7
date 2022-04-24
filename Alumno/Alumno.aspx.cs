    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab2
{
    public partial class Alumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelUsuarios.Text = "USUARIOS LOGUEADOS: " + Application.Contents["numeroAlumnos"] + " Alumno/s y " +
                Application.Contents["numeroProfesores"] + " Profe/s";
            ListBox1.DataSource = Application["listaAlumnos"];
            ListBox1.DataBind();
            ListBox2.DataSource = Application["listaProfesores"];
            ListBox2.DataBind();
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {


        }

       

      

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Alumno/VerTareasEstudiante.aspx"); 
        }

        protected void botonCerrarSesion_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/inicio.aspx");
        }
    }
}