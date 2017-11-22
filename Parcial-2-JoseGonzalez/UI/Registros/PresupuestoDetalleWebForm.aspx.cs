using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSistemaGonzalez;
using Entidades;
using BLL;

namespace Parcial_2_JoseGonzalez.UI.Registros
{
    public partial class PresupuestoDetalleWebForm : System.Web.UI.Page
    {
        Presupuestos presupuestos = new Presupuestos();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            ScriptResourceDefinition myScriptResDef = new ScriptResourceDefinition();
            myScriptResDef.Path = "~/Scripts/jquery-1.4.2.min.js";
            myScriptResDef.DebugPath = "~/Scripts/jquery-1.4.2.js";
            myScriptResDef.CdnPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.min.js";
            myScriptResDef.CdnDebugPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.js";
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", null, myScriptResDef);

            if (!IsPostBack)
            {
                dt.Columns.AddRange(new DataColumn[3] { new DataColumn("Descripcion"), new DataColumn("Meta"), new DataColumn("Logrado")});
                ViewState["PresupuestoDetalle"] = dt;
            }
        }

        protected void AgregarButton_Click(object sender, EventArgs e)
        {
            AgregarDataGrid();
        }

        protected void BindGrid()
        {
            DataTable dt = new DataTable();
            PresupuestoDetalleGridView.DataSource = (DataTable)ViewState["PresupuestoDetalle"];
            PresupuestoDetalleGridView.DataBind();
        }

        private void AgregarDataGrid()
        {
            DataTable dt = (DataTable)ViewState["PresupuestoDetalle"];
            dt.Rows.Add(DescripcionTextBox.Text, MetaTextBox.Text, LogradoTextBox.Text);
            ViewState["PresupuestoDetalle"] = dt;
            this.BindGrid();
        }

        protected void IdTextBox_TextChanged(object sender, EventArgs e)
        {
            BuscarPresupuesto();
        }

        private void BuscarPresupuesto()
        {
            if (!string.IsNullOrEmpty(IdTextBox.Text))
            {
                int id = Utilidades.ToInt(IdTextBox.Text);
                presupuestos = PresupuestosBll.Buscar(p => p.PresupuestosId == id);
                if (presupuestos != null)
                {
                    DescripcionTextBox.Text = presupuestos.Descripcion;                   
                }
                else
                {
                    DescripcionTextBox.Text = "";                  
                }
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            BuscarPresupuesto();
        }
    }
}