using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class akhbar : System.Web.UI.Page
    {
        public Global gl = new Global();
        public string HeaderContent_meta_title = "1موسسه آموزشی صابر";
        public string BodyContent_html_TopLinkkBar = "";
     public string BodyContent_html_akhbar = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            string storeprocedurename;
            //generate meta tag from meta table insert into title
            storeprocedurename = "mysp_learnkey_meta_title_akhbar";
            DataTable DT_settings_meta = gl.runstoreprocedure(storeprocedurename, "");
            HeaderContent_meta_title = gl.datatable2string(DT_settings_meta, "meta_title");

            //toplinkbar
            //generate html tag from html table insert into toplinkbar
            storeprocedurename = "mysp_learnkey_html_toplinkbar";
            DataTable DT_html_toplinkbar = gl.runstoreprocedure(storeprocedurename, "");
            BodyContent_html_TopLinkkBar = gl.datatable2string(DT_html_toplinkbar, "html_toplinkbar");

            //generate html tag from html table insert into akhbar
            storeprocedurename = "mysp_learnkey_html_news";
            DataTable DT_html_akhbar = gl.runstoreprocedure(storeprocedurename, "");
            BodyContent_html_akhbar= gl.datatable2string(DT_html_akhbar, "html_akhbar");

        }

       
    }
}