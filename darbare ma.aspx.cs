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
    public partial class darbare_ma : System.Web.UI.Page
    {
        public Global gl = new Global();
        public string HeaderContent_meta_title = "1موسسه آموزشی صابر";
        public string BodyContent_html_TopLinkkBar = "";
        public string BodyContent_html_darbarema = "";
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=learnkey_arjang;Integrated Security=True");
        SqlCommand com = new SqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {
            string storeprocedurename;
            //generate meta tag from meta table insert into title
            storeprocedurename = "mysp_learnkey_meta_title_darbarema";
            DataTable DT_settings_meta = gl.runstoreprocedure(storeprocedurename, "");
            HeaderContent_meta_title = gl.datatable2string(DT_settings_meta, "meta_title");

            //toplinkbar
            //generate html tag from html table insert into toplinkbar
            storeprocedurename = "mysp_learnkey_html_toplinkbar";
            DataTable DT_html_toplinkbar = gl.runstoreprocedure(storeprocedurename, "");
            BodyContent_html_TopLinkkBar = gl.datatable2string(DT_html_toplinkbar, "html_toplinkbar");

            //generate html tag from html table insert into darbarema
            //storeprocedurename = "mysp_learnkey_html_darbarema";
            //DataTable DT_html_darbarema = gl.runstoreprocedure(storeprocedurename, "");
            //BodyContent_html_darbarema = gl.datatable2string(DT_html_darbarema, "html_darbarema");

            com.CommandText = "SELECT * FROM lk_arj_aboutus$ where id_darbarema=N'1'";
            com.Connection = con;
            SqlDataReader dr = null;
            con.Open();
            dr = com.ExecuteReader();
            dr.Read();
            string matn = dr["matn"].ToString();
            string img = dr["img"].ToString();
            con.Close();
            dr.Close();

             string str_html_darbarema = "";
                str_html_darbarema += "<div class=\"about-us-page\"><div class=\"post hentry single\" id=\"post-73\"><div class=\"postContent\"><h2 class=\"entry-title\">درباره ما</h2><div class=\"entry-content\"><div class=\"simplesocialbuttons\">";
                str_html_darbarema += "<div class=\"simplesocialbutton ssb-button-googleplus\"><!-- Google Plus One--><div class=\"g-plusone\" data-size=\"medium\" data-href=\"http://arjang.ac.ir/remis/\"></div></div><div class=\"simplesocialbutton ssb-button-fblike\"><!-- Facebook like--><div id=\"fb-root\"></div><div class=\"fb-like\" data-href=\"http://arjang.ac.ir/remis/\" data-send=\"false\" data-layout=\"button_count\" data-width=\"100\" data-show-faces=\"false\"></div></div><div class=\"simplesocialbutton ssb-buttom-twitter\"><!-- Twitter--><a href=\"https://twitter.com/share\" class=\"twitter-share-button\" data-text=\"درباره ما\" data-url=\"http://arjang.ac.ir/remis/\" data-via=\"arjangins\" rel=\"nofollow\"></a></div></div><ul class=\"nav nav-tabs\"><li class=\"active\"><a href=\"#about_arjang\" data-toggle=\"tab\">درباره آموزشگاه</a></li><li><a href=\"#our_team\" data-toggle=\"tab\">تیم ما</a></li></ul><div class=\"tab-content\"><div class=\"tab-pane active\" id=\"about_arjang\"><div><p><strong>موسسه آموزشی مجازی مصباح سافت</strong>\"";
                str_html_darbarema += matn;
                str_html_darbarema += "</p>";

                com.CommandText = "SELECT * FROM lk_arj_nextcourses$ ";
            com.Connection = con;
            SqlDataReader dr1 = null;
            con.Open();
            dr1 = com.ExecuteReader();
           while( dr1.Read())
           {
                    string name = dr1["name"].ToString();
                    str_html_darbarema += "<li><strong>";
                    str_html_darbarema += name;
                    str_html_darbarema += "</strong></li>";
           }
          con.Close();
            dr1.Close();


                     str_html_darbarema +="</ul><div class=\"clearfix\"><div><p style=\"text-align: center;\">&nbsp;</p><p>&nbsp;</p><p>اساتید موسسه آموزشی مجازی مصباح سافت:<p><a href=\"";
                     str_html_darbarema += img;
                    str_html_darbarema += "><img class=\"aligncenter size-full wp-image-3812\" alt=\"\" src=\"";
                    str_html_darbarema += img;
                    str_html_darbarema += "\" width=\"650\" height=\"389\" /></a></p></div></div></div></div>";

                    str_html_darbarema +="<div class=\"tab-pane\" id=\"our_team\"><div><div style=\"width: 600px; height: 340px;\">";
                        str_html_darbarema +="<div style=\"width: 320px; height: 320px; margin-right: 178px; background: url('http://arjang.ac.ir/wp-content/themes/remis/images/ourteam/manager-bg-team.png') no-repeat;\">";
                       str_html_darbarema +="<div><img style=\"border-radius: 10px; margin-right: 35px; margin-top: 30px;\" alt=\"\" src=\"";
              com.CommandText = "SELECT * FROM lk_arj_taem$ where modiriat=N'1'";
            com.Connection = con;
            SqlDataReader dr2 = null;
            con.Open();
            dr2 = com.ExecuteReader();
              dr2.Read();
             string image_modir = dr2["img"].ToString();
             string name_modir = dr2["name"].ToString();
             string semate_modir = dr2["semat"].ToString();
             str_html_darbarema += image_modir;
          con.Close();
          dr2.Close(); 
                    
            str_html_darbarema += "\" /></div><div style=\"margin-top: 10px; color: #fff;\"><p style=\"font-family: 'BNazanin', tahoma; font-size: 24px; margin-right: 95px;\"><strong>";
            str_html_darbarema +=name_modir;
         str_html_darbarema +="</strong></p><p style=\"margin-right: 95px;\">";
              str_html_darbarema +=semate_modir;
                  str_html_darbarema +="</p></div></div></div><div style=\"color: #fff; margin-right: 37px; width: 600px; height: 290px; background: url('http://arjang.ac.ir/wp-content/themes/remis/images/ourteam/training-girls-bg.png') no-repeat;\">";
           str_html_darbarema +="<div style=\"width: 150px; min-height: 100px; float: right; margin: 10px; margin-top: 30px; margin-right: 30px;\"><div><img style=\"border-radius: 10px;\" alt=\"\" src=\"";
             
            com.CommandText = "SELECT * FROM lk_arj_taem$ where karshenas_amozesh=N'1' and shomare=N'1'";
            com.Connection = con;
            SqlDataReader dr3 = null;
            con.Open();
            dr3 = com.ExecuteReader();
            string name_amozesh1="";
             string semat_amozesh1="";
          dr3.Read();
           {
                    string image_amozesh1= dr3["img"].ToString();
                 name_amozesh1= dr3["name"].ToString();
               semat_amozesh1= dr3["semat"].ToString();
              str_html_darbarema +=image_amozesh1;
                   
           }
          con.Close();
            dr3.Close(); 
            
             str_html_darbarema += " \" /></div><div style=\"margin-top: 10px;\"><p style=\"text-align: center;\"><strong>";
            str_html_darbarema += name_amozesh1;
             str_html_darbarema +="</strong></p><p style=\"text-align: center;\">";
              str_html_darbarema +=semat_amozesh1;
            str_html_darbarema +="</p></div></div><div style=\"width: 150px; min-height: 100px; float: right; margin: 10px; margin-top: 30px;\"><div><div><img alt=\"\" src=\"";
         
            com.CommandText = "SELECT * FROM lk_arj_taem$ where karshenas_amozesh=N'1' and shomare=N'2'";
            com.Connection = con;
            SqlDataReader dr4 = null;
            con.Open();
            dr4= com.ExecuteReader();
            string name_amozesh2="";
             string semat_amozesh2="";
          dr4.Read();
           {
                    string image_amozesh2= dr4["img"].ToString();
                 name_amozesh2= dr4["name"].ToString();
               semat_amozesh2= dr4["semat"].ToString();
              str_html_darbarema +=image_amozesh2;
                   
           }
          con.Close();
            dr4.Close(); 
            
            
            str_html_darbarema +="\" /></div></div><div style=\"margin-top: 10px;\"><p style=\"text-align: center;\"><strong>";
           str_html_darbarema +=name_amozesh2;
           str_html_darbarema +="<br /></strong></p><p style=\"text-align: center;\">";
           str_html_darbarema +=semat_amozesh2;
             str_html_darbarema +="</p></div><div style=\"width: 150px; min-height: 100px; float: right; margin: 10px; margin-top: 30px;\"><div><img style=\"border-radius: 10px;\" alt=\"\" src=\"";
            
            com.CommandText = "SELECT * FROM lk_arj_taem$ where karshenas_amozesh=N'1' and shomare=N'3'";
            com.Connection = con;
            SqlDataReader dr5 = null;
            con.Open();
            dr5= com.ExecuteReader();
            string name_amozesh3="";
             string semat_amozesh3="";
          dr5.Read();
           {
                    string image_amozesh3= dr5["img"].ToString();
                 name_amozesh3= dr5["name"].ToString();
               semat_amozesh3= dr5["semat"].ToString();
              str_html_darbarema +=image_amozesh3;
                   
           }
          con.Close();
            dr5.Close();  
            str_html_darbarema +="\" /></div><div style=\"margin-top: 10px;\"><p style=\"text-align: center;\"><strong>";
             str_html_darbarema +=name_amozesh3;
             str_html_darbarema +="</strong></p><p style=\"text-align: center;\">";
             str_html_darbarema += semat_amozesh3;
             str_html_darbarema += "</p></div></div></div><p><br style=\"color: #fff; margin-right: 37px; width: 600px; height: 320px; background: url('http://arjang.ac.ir/wp-content/themes/remis/images/ourteam/technical-boys-bg.png') no-repeat;\" /></p><div style=\"color: #fff; margin-right: 37px; width: 600px; height: 320px; background: url('http://arjang.ac.ir/wp-content/themes/remis/images/ourteam/technical-boys-bg.png') no-repeat;\">";
          str_html_darbarema += "<div style=\"width: 150px; min-height: 100px; float: right; margin: 10px; margin-top: 30px;\"><div><img style=\"border-radius: 10px;\" alt=\"\" src=\"";

 com.CommandText = "SELECT * FROM lk_arj_taem$ where karshenase_fani=N'1' ";
            com.Connection = con;
            SqlDataReader dr6 = null;
            con.Open();
            dr6= com.ExecuteReader();
            string name_fani="";
             string semat_fani="";
          dr6.Read();
           {
                    string image_fani= dr6["img"].ToString();
                 name_fani= dr6["name"].ToString();
               semat_fani= dr6["semat"].ToString();
              str_html_darbarema += image_fani;
                   
           }
          con.Close();
            dr6.Close();  
           str_html_darbarema +="\" /></div><div style=\"margin-top: 10px;\"><p style=\"text-align: center;\"><strong>";
             str_html_darbarema +=name_fani;
           str_html_darbarema +="</strong></p><p style=\"text-align: center;\">";
            str_html_darbarema +=semat_fani;
            str_html_darbarema += "</p></div></div><div style=\"width: 150px; min-height: 100px; float: right; margin: 10px; margin-top: 30px;\"></div></div></div></div></div><p><!-- tab content --></p></div></div></div></div>";

            BodyContent_html_darbarema = str_html_darbarema;
        }
    }
}