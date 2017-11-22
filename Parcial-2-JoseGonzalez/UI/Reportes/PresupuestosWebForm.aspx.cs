using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial_2_JoseGonzalez.UI.Reportes
{
    public partial class PresupuestosWebForm : System.Web.UI.Page
    {
        public object Ui { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.ReportViewerUsuario.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
            this.ReportViewerUsuario.Reset();


            this.ReportViewerUsuario.LocalReport.ReportPath = @"C:\Users\Jose Gonzalez\Desktop\Parcial2JoseGonzalez\Parcial-2-JoseGonzalez\Parcial-2-JoseGonzalez\UI\Reportes\UsuariosReport.rdlc";
            this.ReportViewerUsuario.LocalReport.DataSources.Clear();



            // this.ReportViewerUsuario.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("DataSetUsuario", UI.Consultas.ConsultaDetalleWebForm));

            this.ReportViewerUsuario.LocalReport.Refresh();
        }
    }
}