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
    public partial class matnemaghale : System.Web.UI.Page
    {

        public Global gl = new Global();
        public string HeaderContent_meta_title = "1موسسه آموزشی صابر";
        public string BodyContent_html_TopLinkkBar = "";
        public string BodyContent_html_matnemaghalat = "";
        SqlCommand com = new SqlCommand();
        //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=learnkey_arjang;Integrated Security=True");

        SqlConnection con = new SqlConnection("Data Source=185.55.225.11;Initial Catalog=asanhost_learnkey;User Id=sabertabatabaei;password=fDsd047$");
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id_magahle"];
            string storeprocedurename;
            //generate meta tag from meta table insert into title
            ////storeprocedurename = "mysp_learnkey_meta_title";
            ////DataTable DT_settings_meta = gl.runstoreprocedure(storeprocedurename, "");
            ////HeaderContent_meta_title = gl.datatable2string(DT_settings_meta, "meta_title");

            //toplinkbar
            //generate html tag from html table insert into toplinkbar
            storeprocedurename = "mysp_learnkey_html_toplinkbar";
            DataTable DT_html_toplinkbar = gl.runstoreprocedure(storeprocedurename, "");
            BodyContent_html_TopLinkkBar = gl.datatable2string(DT_html_toplinkbar, "html_toplinkbar");

            //generate html tag from html table insert into maghalat
            //storeprocedurename = "mysp_learnkey_html_matnemaghale";
            //DataTable DT_html_matnemaghale = gl.runstoreprocedure(storeprocedurename, "");
            //BodyContent_html_matnemaghalat = gl.datatable2string(DT_html_matnemaghale, "html_matnemaghalat");
            com.CommandText = "SELECT * FROM lk_arj_maghalat$ where id_magahle=N'" + id + "'";
            com.Connection = con;
            SqlDataReader dr = null;
            con.Open();
            dr = com.ExecuteReader();
            dr.Read();
            string title = dr["title"].ToString();
            string body = dr["body"].ToString();
            string date = dr["date"].ToString();
            string manba = dr["manba"].ToString();
            con.Close();
            dr.Close();
            HeaderContent_meta_title = title;
           BodyContent_html_matnemaghalat += " <h3>";
           BodyContent_html_matnemaghalat += title;
           BodyContent_html_matnemaghalat += "</h3>";
           BodyContent_html_matnemaghalat += " <div class=\"postDate\"><span>تاريخ انتشار : </span>";
           BodyContent_html_matnemaghalat += date;
           BodyContent_html_matnemaghalat += "</div>";
           BodyContent_html_matnemaghalat += "<div style=\"width: 100%; text-align: center; margin-top: 20px; margin-bottom: 20px;\"></div> <div class=\"entry-content\"><div class=\"simplesocialbuttons\">";
           BodyContent_html_matnemaghalat += "<div class=\"simplesocialbutton ssb-button-googleplus\"><!-- Google Plus One--><div class=\"g-plusone\" data-size=\"medium\" data-href=\"http://arjang.ac.ir/%d8%b3%db%8c%d8%b3%da%a9%d9%88-%d8%b1%d9%88%db%8c-%d9%be%d8%b1%d9%88%da%98%d9%87-80-%d9%85%db%8c%d9%84%db%8c%d9%88%d9%86-%d8%af%d9%84%d8%a7%d8%b1%db%8c-%d9%81%d8%b6%d8%a7%db%8c-%d8%a7%d8%a8%d8%b1-clo/\"></div></div>";
           BodyContent_html_matnemaghalat += "<div class=\"simplesocialbutton ssb-button-fblike\"><!-- Facebook like--><div id=\"fb-root\"></div><div class=\"fb-like\" data-href=\"http://arjang.ac.ir/%d8%b3%db%8c%d8%b3%da%a9%d9%88-%d8%b1%d9%88%db%8c-%d9%be%d8%b1%d9%88%da%98%d9%87-80-%d9%85%db%8c%d9%84%db%8c%d9%88%d9%86-%d8%af%d9%84%d8%a7%d8%b1%db%8c-%d9%81%d8%b6%d8%a7%db%8c-%d8%a7%d8%a8%d8%b1-clo/\" data-send=\"false\" data-layout=\"button_count\" data-width=\"100\" data-show-faces=\"false\"></div></div>";
           BodyContent_html_matnemaghalat += "<div class=\"simplesocialbutton ssb-buttom-twitter\"><!-- Twitter--><a href=\"https://twitter.com/share\" class=\"twitter-share-button\" data-text=\"";
           BodyContent_html_matnemaghalat += title;
           BodyContent_html_matnemaghalat += " \" data-url=\"http://arjang.ac.ir/%d8%b3%db%8c%d8%b3%da%a9%d9%88-%d8%b1%d9%88%db%8c-%d9%be%d8%b1%d9%88%da%98%d9%87-80-%d9%85%db%8c%d9%84%db%8c%d9%88%d9%86-%d8%af%d9%84%d8%a7%d8%b1%db%8c-%d9%81%d8%b6%d8%a7%db%8c-%d8%a7%d8%a8%d8%b1-clo/\" data-via=\"arjangins\" rel=\"nofollow\"></a></div>";
           BodyContent_html_matnemaghalat += "</div><p dir=\"RTL\">";
           BodyContent_html_matnemaghalat += body;
           BodyContent_html_matnemaghalat += "</p><p dir=\"RTL\"><a href=\"";
           BodyContent_html_matnemaghalat += manba;
           BodyContent_html_matnemaghalat += "\" target=\"_blank\">لینک خبر</a></p></div>";
        }
    }
}