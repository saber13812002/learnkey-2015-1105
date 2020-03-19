using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public Global gl = new Global();

        public string HeaderContent_meta_title="1موسسه آموزشی صابر";
        public string BodyContent_html_TopLinkkBar = "";
        public string BodyContent_html_NextCources = "";
        public string BodyContent_html_certified = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            //generate meta tag from meta table insert into title
            string storeprocedurename = "mysp_learnkey_meta_title_defult";
            DataTable DT_settings_meta = gl.runstoreprocedure(storeprocedurename, "");
            HeaderContent_meta_title = gl.datatable2string(DT_settings_meta, "meta_title");

            //toplinkbar
            //generate html tag from html table insert into toplinkbar
            storeprocedurename = "mysp_learnkey_html_toplinkbar";
            DataTable DT_html_toplinkbar = gl.runstoreprocedure(storeprocedurename, "");
            BodyContent_html_TopLinkkBar = gl.datatable2string(DT_html_toplinkbar, "html_toplinkbar");

            //nextcources
            //generate html tag from html table insert into next cources
            storeprocedurename = "mysp_learnkey_html_nextcources";
            DataTable DT_html_nextcources = gl.runstoreprocedure(storeprocedurename, "");
            BodyContent_html_NextCources = gl.datatable2string(DT_html_nextcources, "html_nextcources");

            //certified
            //generate html tag from html table insert into next certified
            storeprocedurename = "mysp_learnkey_html_certified";
            DataTable DT_html_certified = gl.runstoreprocedure(storeprocedurename, "");
            BodyContent_html_certified = gl.datatable2string(DT_html_certified, "html_certified");
        }


    }
}