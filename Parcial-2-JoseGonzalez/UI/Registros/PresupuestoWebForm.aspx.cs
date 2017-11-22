using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using BLL;
using WebSistemaGonzalez;

namespace Parcial_2_JoseGonzalez.UI.Registros
{
    public partial class PresupuestoWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.FechaTextBox.Text = string.Format("{0:G}", DateTime.Now);
            ScriptResourceDefinition myScriptResDef = new ScriptResourceDefinition();
            myScriptResDef.Path = "~/Scripts/jquery-1.4.2.min.js";
            myScriptResDef.DebugPath = "~/Scripts/jquery-1.4.2.js";
            myScriptResDef.CdnPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.min.js";
            myScriptResDef.CdnDebugPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.js";
            myScriptResDef.CdnDebugPath = "~/Content/toastr.css";
            myScriptResDef.CdnDebugPath = "~/Content/toastr.min.css";
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", null, myScriptResDef);
            FechaTextBox.Enabled = false;
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            idPresupuestosTextbox.Text = " ";
            DescripcionTextBox.Text = " ";
            MontoTextBox.Text = " ";
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            Presupuestos presupuestos = new Presupuestos();
            if (IsValid)
            {
                if (presupuestos.PresupuestosId != 0)
                {
                    PresupuestosBll.Modificar(presupuestos);
                    Utilidades.ShowToastr(this, "El Presupuesto", " Se Modifico Correctamente", "Success");
                }
                else
                {
                    presupuestos = Llenar();
                    PresupuestosBll.Guardar(presupuestos);
                    Utilidades.ShowToastr(this, "El presupuesto", " Se Guardo Correctamente", "Success");
                    Limpiar();
                }
            }
        }

        private Presupuestos Llenar()
        {
            Presupuestos presupuestos = new Presupuestos();
            presupuestos.Fecha = Convert.ToDateTime(FechaTextBox.Text);
            presupuestos.Descripcion = DescripcionTextBox.Text;
            presupuestos.Monto = Convert.ToInt32(MontoTextBox.Text);   
            return presupuestos;
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.ToInt(idPresupuestosTextbox.Text);
            Presupuestos presupuestos = PresupuestosBll.Buscar(u => u.PresupuestosId == id);
            if (presupuestos != null)
            {
                if (presupuestos.PresupuestosId != 1)
                {
                    PresupuestosBll.Eliminar(presupuestos);
                    Utilidades.ShowToastr(this, "El Presupuesto", " Se Elimino Correctamente", "Success");
                    Limpiar();
                }
                else
                {
                    Utilidades.ShowToastr(this, "El Presupuesto", "No Se Elimino", "warning");
                }
            }
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.ToInt(idPresupuestosTextbox.Text);
            Presupuestos presupuestos = PresupuestosBll.Buscar(u => u.PresupuestosId == id);
            if (presupuestos != null)
            {
                DescripcionTextBox.Text = presupuestos.Descripcion;
                MontoTextBox.Text = presupuestos.Monto.ToString();
                FechaTextBox.Text = presupuestos.Fecha.ToString();
            }
            else
            {
                Utilidades.ShowToastr(this, "No Existe", "Ingresar Presupuesto Existente", "warning");
            }
        }
    }
}