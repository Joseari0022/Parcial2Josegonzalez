using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;

namespace WebSistemaGonzalez
{
    public static class Utilidades
    {
        public static int ToInt(string num)
        {
            int numero = 0;
            int.TryParse(num, out numero);
            return numero;
        }

        public static string reporte { get; set; }
        public static DataTable data { get; set; }
        public static string dataset { get; set; }

        public static void ShowToastr(this Page page, string message, string title, string type = "info")
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "toastr_message",
            String.Format("toastr.{0}('{1}', '{2}');", type.ToLower(), message, title), addScriptTags: true);
        }
    }
}