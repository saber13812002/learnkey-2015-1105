using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        public Global gl = new Global();

        public string HeaderContent_meta_title = "1موسسه آموزشی صابر";
        public string BodyContent_html_TopLinkkBar = "";
        public string BodyContent_html_tooltip = "";
        public string BodyContent_html_instructors = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            string storeprocedurename;
            //generate meta tag from meta table insert into title
            storeprocedurename = "mysp_learnkey_meta_title_asatid";
            DataTable DT_settings_meta = gl.runstoreprocedure(storeprocedurename, "");
            HeaderContent_meta_title = gl.datatable2string(DT_settings_meta, "meta_title");

            //toplinkbar
            //generate html tag from html table insert into toplinkbar
            storeprocedurename = "mysp_learnkey_html_toplinkbar";
            DataTable DT_html_toplinkbar = gl.runstoreprocedure(storeprocedurename, "");
            BodyContent_html_TopLinkkBar = gl.datatable2string(DT_html_toplinkbar, "html_toplinkbar");

            //generate html tag from html table insert into instructor
            storeprocedurename = "mysp_learnkey_html_asatid";
            DataTable DT_html_instructor = gl.runstoreprocedure(storeprocedurename, "");
            BodyContent_html_instructors = gl.datatable2string(DT_html_instructor, "html_instructor");

           
        }

    }
}