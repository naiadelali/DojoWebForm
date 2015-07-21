using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DojoWebForm.BLL;
using DojoWebForms.Model;

namespace DojoWebForm.UI
{
    public partial class UnitMeasure : System.Web.UI.Page
    {
        private UnitMeasureBLL Service = new UnitMeasureBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                GridUnitMeasure.DataSource = Service.SelectAll();
                GridUnitMeasure.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<b style='color:red;'>" + ex.Message + "</b");
                Response.End();
            }
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                Service.Inserir(new DojoWebForms.Model.UnitMeasure() { Id = 0, Description = "Litros", Abbreviation = "L" });
            }
            catch (Exception ex)
            {
                Response.Write("<b style='color:red;'>" + ex.Message + "</b");
                Response.End();
            }
        }
    }
}