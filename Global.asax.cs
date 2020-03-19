using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public class Global : System.Web.HttpApplication
    {

        public DataTable runstoreprocedure(string storeprocedurename, string type)
        {
            Table t = new Table();
            try
            {

                //System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
                ////class sp
                //// در زمانی که در لوکال روی سرور مرکز اجرا می کنم
                ////SqlConnection con = new SqlConnection("Data Source=learnkey.ir;Initial Catalog=asanhost_learnkey;User Id=sabertabatabaei;password=bGd$4p20");
                //ConnectionStringSettings ConStrSetting = rootWebConfig.ConnectionStrings.ConnectionStrings["remoteSqlServer"];
                //SqlConnection con = new SqlConnection(ConStrSetting.ConnectionString);
                string connStr = ConfigurationManager.ConnectionStrings["remoteSqlServer"].ConnectionString;
                SqlConnection con = new SqlConnection(connStr);
                // در زمانی که در سرور شرکت اجرا می کنم
                //string connStr = ConfigurationManager.ConnectionStrings["remoteSqlServer"].ToString();
                // در زمانی که در سرور شرکت اجرا می کنم
                //SqlConnection con = new SqlConnection(connStr);
                //SqlConnection con = new SqlConnection("Data Source=server;Initial Catalog=learnkey_arjang;Integrated Security=True");
                //SqlConnection con = new SqlConnection("Data Source=server;Initial Catalog=learnkey_arjang;User Id=learnkey_arjang_user;password=123;");
                //stored procedure name
                SqlCommand command = new SqlCommand(storeprocedurename, con);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                if (type == "button")
                    da.SelectCommand.Parameters.Add("@type", SqlDbType.Int).Value = 2;
                else if (type == "link")
                    da.SelectCommand.Parameters.Add("@type", SqlDbType.Int).Value = 3;
                da.Fill(ds);

                //DataTable dt = 
                return ds.Tables[0]; 

            }
            catch (Exception)
            {
                throw;
            }
        }

        public string datatable2string(DataTable DT, string type)
        {
            if (type == "html_darbarema")
            {
//<div class="about-us-page">	
//    <div class="post hentry single" id="post-73">
//      <div class="postContent">
//        <h2 class="entry-title">درباره ما</h2>
//        <div class="entry-content">
//                <div class="simplesocialbuttons">
//<div class="simplesocialbutton ssb-button-googleplus"><!-- Google Plus One--><div class="g-plusone" data-size="medium" data-href="http://arjang.ac.ir/remis/"></div></div>
//<div class="simplesocialbutton ssb-button-fblike"><!-- Facebook like--><div id="fb-root"></div><div class="fb-like" data-href="http://arjang.ac.ir/remis/" data-send="false" data-layout="button_count" data-width="100" data-show-faces="false"></div></div>
//<div class="simplesocialbutton ssb-buttom-twitter"><!-- Twitter--><a href="https://twitter.com/share" class="twitter-share-button" data-text="درباره ما" data-url="http://arjang.ac.ir/remis/" data-via="arjangins" rel="nofollow"></a></div>
//</div>
//<ul class="nav nav-tabs">
//<li class="active"><a href="#about_arjang" data-toggle="tab">درباره آموزشگاه</a></li>
//<li><a href="#our_team" data-toggle="tab">تیم ما</a></li>
//</ul>
//<div class="tab-content">
//<div class="tab-pane active" id="about_arjang">
//<div>
//<p><strong>مؤسسه آموزش عالی آزاد ارژنگ</strong> با سابقه ای درخشان در ارائه دوره های آموزش تخصصی فناوری اطلاعات فعالیت خود را ۸ سال پیش در قالب <strong>مرکز آموزش های پیشرفته رمیس</strong> آغاز نمود. برگزاری  آغاز نمود. برگزاری دوره های تخصصی شبکه و امنیت، توسط زبده ترین اساتید ایران که خود عمدتاًً در بزرگترین پروژه های فناوری اطلاعات کشورمشغول فعالیت هستند،در آزمایشگاه های مجهز و با تجهیزات پیشرفته با استقبال کم نظیر مخاطبان روبرو شد. درخواست های مکرر برای افزوده شدن دیگر دوره های تخصصی IT و نیز اصرار به حفظ و افزایش کیفیت برگزاری دوره ها مجموعه رمیس را بر آن داشت تا در قالبی جدید و تخصصی فعالیت آموزشی خود را ادامه دهد و به این ترتیب مؤسسه آموزش عالی آزاد ارژنگ متولد شد. به منظور فراهم آوردن تجربه دلچسب حضور در دوره های آموزشی تخصصی بین المللی، ارژنگ اقدام به عقد قرارداد همکاری با معروفترین برگزار کنندگان دوره های موسسه ارژنگ (مرکز آموزش رمیس) شامل:</p>
//<ul style="float: right:;">
//<li><strong>دوره های سیسکو(Cisco)<strong>کلاسهای تخصصی اچ پی (HP)</strong></li>
//<li><strong>مایکروسافت(MCITP)</strong></li>
//<li><strong>مجازی سازی(VMware Vsphere)</strong></li>
//<li><strong>جونیپر (Juniper)</strong></li>
//<li><strong>لینوکس (LPI )</stronلینوکس (LPI )</strong></li>
//<li><strong>مدیرت فتاوری اطلاعات (ITIL)</strong></li>
//<li><strong>دوره های EMC<br />
//</strong></li>
//</ul>
//<div class="clearfix">
//<div>
//<p style="text-align: center;">&nbsp;</p>
//<p>&nbsp;</p>
//<p>اساتید موسسه آموزش عالی ارژنگ:
//<p><a href="http://arjang.ac.ir/wp-content/uploads/2010/12/Arjang-Training-Center-Teachers.png"><img class="aligncenter size-full wp-image-3812" alt="Arjang-Training-Center-Teachers" src="http://arjang.ac.ir/wp-content/uploads/2010/12/Arjang-Training-Center-Teachers.png" width="650" height="389" /></a></p>
//</div>
//</div>
//</div>
//</div>
//<div class="tab-pane" id="our_team">
//<div>
//<div style="width: 600px; height: 340px;">
//<div style="width: 320px; height: 320px; margin-right: 178px; background: url('http://arjang.ac.ir/wp-content/themes/remis/images/ourteam/manager-bg-team.png') no-repeat;">
//<div><img style="border-radius: 10px; margin-right: 35px; margin-top: 30px;" alt="" src="http://arjang.ac.ir/wp-content/themes/remis/images/ourteam/arash-dehghan.png" /></div>
//<div style="margin-top: 10px; color: #fff;">
//<p style="font-family: 'BNazanin', tahoma; font-size: 24px; margin-right: 95px;"><strong>آرش دهقان</strong></p>
//<p style="margin-right: 95px;">مدیریت موسسه</p>
//</div>
//</div>
//</div>
//<div style="color: #fff; margin-right: 37px; width: 600px; height: 290px; background: url('http://arjang.ac.ir/wp-content/themes/remis/images/ourteam/training-girls-bg.png') no-repeat;">
//<div style="width: 150px; min-height: 100; float: right; margin: 10px; margin-top: 30px; margin-right: 30px;">
//<div><img style="border-radius: 10px;" alt="" src="http://arjang.ac.ir/wp-content/themes/remis/images/ourteam/tina-taebi.png" /></div>
//<div style="margin-top: 10px;">
//<p style="text-align: center;"><strong>تینا تائبی</strong></p>
//<p style="text-align: center;">کارشناس آموزش</p>
//</div>
//</div>
//<div style="width: 150px; min-height: 100; float: right; margin: 10px; margin-top: 30px;">
//<div>
//<div><img alt="" src="http://arjang.ac.ir/wp-content/themes/remis/images/ourteam/farzad-kafi.png" /></div>
//</div>
//<div style="margin-top: 10px;">
//<p style="text-align: center;"><strong>فرزاد کافی<br />
//</strong></p>
//<p style="text-align: center;">کارشناس آموزش</p>
//</div>
//</div>
//<div style="width: 150px; min-height: 100; float: right; margin: 10px; margin-top: 30px;">
//<div><img style="border-radius: 10px;" alt="" src="http://arjang.ac.ir/wp-content/themes/remis/images/ourteam/zahra-rezaei.png" /></div>
//<div style="margin-top: 10px;">
//<p style="text-align: center;"><strong>زهرا رضایی</strong></p>
//<p style="text-align: center;">امور اداری</p>
//</div>
//</div>
//</div>
//<p><br style="color: #fff; margin-right: 37px; width: 600px; height: 320px; background: url('http://arjang.ac.ir/wp-content/themes/remis/images/ourteam/technical-boys-bg.png') no-repeat;" /></p>
//<div style="color: #fff; margin-right: 37px; width: 600px; height: 320px; background: url('http://arjang.ac.ir/wp-content/themes/remis/images/ourteam/technical-boys-bg.png') no-repeat;">
//<div style="width: 150px; min-height: 100; float: right; margin: 10px; margin-top: 30px;">
//<div><img style="border-radius: 10px;" alt="" src="http://arjang.ac.ir/wp-content/themes/remis/images/ourteam/saman-ismael.png" /></div>
//<div style="margin-top: 10px;">
//<p style="text-align: center;"><strong>سامان اسمعیل</strong></p>
//<p style="text-align: center;">کارشناس نرم افزار</p>
//</div>
//</div>
//<div style="width: 150px; min-height: 100; float: right; margin: 10px; margin-top: 30px;"></div>
//</div>
//</div>
//</div>
//</div>
//<p><!-- tab content --></p>
//        </div>
//      </div>
//   </div>
//</div>


                string str_html_darbarema = "";
                str_html_darbarema += "<div class=\"about-us-page\"><div class=\"post hentry single\" id=\"post-73\"><div class=\"postContent\"><h2 class=\"entry-title\">درباره ما</h2><div class=\"entry-content\"><div class=\"simplesocialbuttons\">";
                str_html_darbarema += "<div class=\"simplesocialbutton ssb-button-googleplus\"><!-- Google Plus One--><div class=\"g-plusone\" data-size=\"medium\" data-href=\"http://arjang.ac.ir/remis/\"></div></div><div class=\"simplesocialbutton ssb-button-fblike\"><!-- Facebook like--><div id=\"fb-root\"></div><div class=\"fb-like\" data-href=\"http://arjang.ac.ir/remis/\" data-send=\"false\" data-layout=\"button_count\" data-width=\"100\" data-show-faces=\"false\"></div></div><div class=\"simplesocialbutton ssb-buttom-twitter\"><!-- Twitter--><a href=\"https://twitter.com/share\" class=\"twitter-share-button\" data-text=\"درباره ما\" data-url=\"http://arjang.ac.ir/remis/\" data-via=\"arjangins\" rel=\"nofollow\"></a></div></div><ul class=\"nav nav-tabs\"><li class=\"active\"><a href=\"#about_arjang\" data-toggle=\"tab\">درباره آموزشگاه</a></li><li><a href=\"#our_team\" data-toggle=\"tab\">تیم ما</a></li></ul><div class=\"tab-content\"><div class=\"tab-pane active\" id=\"about_arjang\"><div><p><strong>موسسه آموزشی مجازی مصباح سافت</strong>\"";
                str_html_darbarema += DT.Rows[0][1].ToString();
                str_html_darbarema += "</p>";
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                  
                    str_html_darbarema += "<li><strong>";
                    str_html_darbarema += DT.Rows[i][10].ToString();
                    str_html_darbarema += "</strong></li></ul><div class=\"clearfix\"><div><p style=\"text-align: center;\">&nbsp;</p><p>&nbsp;</p><p>اساتید موسسه آموزشی مجازی مصباح سافت:<p><a href=\"";
                     str_html_darbarema += DT.Rows[0][2].ToString();
                    str_html_darbarema += "><img class=\"aligncenter size-full wp-image-3812\" alt=\"\" src=\"";
                    str_html_darbarema += DT.Rows[0][2].ToString();
                    str_html_darbarema += "\" width=\"650\" height=\"389\" /></a></p>";

                    str_html_darbarema +="</div></div></div></div><div class=\"tab-pane\" id=\"our_team\"><div><div style=\"width: 600px; height: 340px;\">";
                        str_html_darbarema +="<div style=\"width: 320px; height: 320px; margin-right: 178px; background: url('http://arjang.ac.ir/wp-content/themes/remis/images/ourteam/manager-bg-team.png') no-repeat;\">";
                       str_html_darbarema +="<div><img style=\"border-radius: 10px; margin-right: 35px; margin-top: 30px;\" alt=\"\" src=\"";
                       str_html_darbarema += DT.Rows[0][2].ToString();
                http://arjang.ac.ir/wp-content/themes/remis/images/ourteam/arash-dehghan.png" /></div>
                        //<div style="margin-top: 10px; color: #fff;">
                        //<p style="font-family: 'BNazanin', tahoma; font-size: 24px; margin-right: 95px;"><strong>آرش دهقان</strong></p>
                        //<p style="margin-right: 95px;">مدیریت موسسه</p>
                        //</div>
                        //</div>
                        //</div>
                        //<div style="color: #fff; margin-right: 37px; width: 600px; height: 290px; background: url('http://arjang.ac.ir/wp-content/themes/remis/images/ourteam/training-girls-bg.png') no-repeat;">
                        //<div style="width: 150px; min-height: 100; float: right; margin: 10px; margin-top: 30px; margin-right: 30px;">
                        //<div><img style="border-radius: 10px;" alt="" src="http://arjang.ac.ir/wp-content/themes/remis/images/ourteam/tina-taebi.png" /></div>
                        //<div style="margin-top: 10px;">
                        //<p style="text-align: center;"><strong>تینا تائبی</strong></p>
                        //<p style="text-align: center;">کارشناس آموزش</p>
                        //</div>
                        //</div>
                        //<div style="width: 150px; min-height: 100; float: right; margin: 10px; margin-top: 30px;">
                        //<div>
                        //<div><img alt="" src="http://arjang.ac.ir/wp-content/themes/remis/images/ourteam/farzad-kafi.png" /></div>
                        //</div>
                        //<div style="margin-top: 10px;">
                        //<p style="text-align: center;"><strong>فرزاد کافی<br />
                        //</strong></p>
                        //<p style="text-align: center;">کارشناس آموزش</p>
                        //</div>
                        //</div>
                        //<div style="width: 150px; min-height: 100; float: right; margin: 10px; margin-top: 30px;">
                        //<div><img style="border-radius: 10px;" alt="" src="http://arjang.ac.ir/wp-content/themes/remis/images/ourteam/zahra-rezaei.png" /></div>
                        //<div style="margin-top: 10px;">
                        //<p style="text-align: center;"><strong>زهرا رضایی</strong></p>
                        //<p style="text-align: center;">امور اداری</p>
                        //</div>
                        //</div>
                        //</div>
                        //<p><br style="color: #fff; margin-right: 37px; width: 600px; height: 320px; background: url('http://arjang.ac.ir/wp-content/themes/remis/images/ourteam/technical-boys-bg.png') no-repeat;" /></p>
                        //<div style="color: #fff; margin-right: 37px; width: 600px; height: 320px; background: url('http://arjang.ac.ir/wp-content/themes/remis/images/ourteam/technical-boys-bg.png') no-repeat;">
                        //<div style="width: 150px; min-height: 100; float: right; margin: 10px; margin-top: 30px;">
                        //<div><img style="border-radius: 10px;" alt="" src="http://arjang.ac.ir/wp-content/themes/remis/images/ourteam/saman-ismael.png" /></div>
                        //<div style="margin-top: 10px;">
                        //<p style="text-align: center;"><strong>سامان اسمعیل</strong></p>
                        //<p style="text-align: center;">کارشناس نرم افزار</p>
                        //</div>
                        //</div>
                        //<div style="width: 150px; min-height: 100; float: right; margin: 10px; margin-top: 30px;"></div>
                        //</div>
                        //</div>
                        //</div>
                        //</div>
                        //<p><!-- tab content --></p>
                        //        </div>
                        //      </div>
                        //   </div>
                        //</div>
                    str_html_darbarema += "\" class=\"course-item-obj\">";
                    str_html_darbarema += DT.Rows[i][2].ToString();
                    str_html_darbarema += "<br /><a href=\"";
                    str_html_darbarema += DT.Rows[i][4].ToString();
                    str_html_darbarema += DT.Rows[i][0].ToString();
                    str_html_darbarema += "\" target=_blank >ادامه ي مطلب</a></div><div style=\"clear:both\"></div></div></div>";
                }
                return str_html_darbarema;

            }
            if (type == "html_matnemaghalat")
            {
//                 <h3>چگونه اوراکل جلوی شکست ارتقای ERP اش را می گیرد؟</h3>

          
//          <div class="postDate"><span>تاريخ انتشار : </span>مهر ۱۹, ۱۳۹۳</div>

//         <div style="width: 100%; text-align: center; margin-top: 20px; margin-bottom: 20px;">
//          </div>

//          <div class="entry-content">
//              <div class="simplesocialbuttons">
//<div class="simplesocialbutton ssb-button-googleplus"><!-- Google Plus One--><div class="g-plusone" data-size="medium" data-href="http://arjang.ac.ir/%da%86%da%af%d9%88%d9%86%d9%87-%d8%a7%d9%88%d8%b1%d8%a7%da%a9%d9%84-%d8%ac%d9%84%d9%88%db%8c-%d8%b4%da%a9%d8%b3%d8%aa-%d8%a7%d8%b1%d8%aa%d9%82%d8%a7%db%8c-erp-%d8%a7%d8%b4-%d8%b1%d8%a7-%d9%85%db%8c/"></div></div>
//<div class="simplesocialbutton ssb-button-fblike"><!-- Facebook like--><div id="fb-root"></div><div class="fb-like" data-href="http://arjang.ac.ir/%da%86%da%af%d9%88%d9%86%d9%87-%d8%a7%d9%88%d8%b1%d8%a7%da%a9%d9%84-%d8%ac%d9%84%d9%88%db%8c-%d8%b4%da%a9%d8%b3%d8%aa-%d8%a7%d8%b1%d8%aa%d9%82%d8%a7%db%8c-erp-%d8%a7%d8%b4-%d8%b1%d8%a7-%d9%85%db%8c/" data-send="false" data-layout="button_count" data-width="100" data-show-faces="false"></div></div>
//<div class="simplesocialbutton ssb-buttom-twitter"><!-- Twitter--><a href="https://twitter.com/share" class="twitter-share-button" data-text="چگونه اوراکل جلوی شکست ارتقای ERP اش را می گیرد؟" data-url="http://arjang.ac.ir/%da%86%da%af%d9%88%d9%86%d9%87-%d8%a7%d9%88%d8%b1%d8%a7%da%a9%d9%84-%d8%ac%d9%84%d9%88%db%8c-%d8%b4%da%a9%d8%b3%d8%aa-%d8%a7%d8%b1%d8%aa%d9%82%d8%a7%db%8c-erp-%d8%a7%d8%b4-%d8%b1%d8%a7-%d9%85%db%8c/" data-via="arjangins" rel="nofollow"></a></div>
//</div>
//<p dir="RTL">در حالیکه رییس اوراکل، لری الیسون به کرات از آرمان های رو به رشد این شرکت در محاسبات ابری در مراسم OpenWorld این هفته صحبت می کرد، بسیاری از مشتریان حاضر در مراسم ذهنشان روی مسائل مهم تری مثل ارتقاء سیستم های ERP  کهنه شده ( برنامه ریزی منابع سازمانی ) بسیار مهم و مخاطره آمیز تمرکز داشت.</p>
//<p dir="RTL">نماینده گروه پزشکی smiths  در مجمع OpenWorld گفت این گروه پزشکی مجبور شد به علت مشکلات مهم و ضروری مثل انقضای حمایت از نرم افزار و سخت افزار  منسوخ، امسال شروع به ارتقاء بزرگی در پیاده سازی کسب و کار مجازی کند.</p>
//<p dir="RTL">این شرکت تولید تجهیزات پزشکی موفق شد ارتقاء از نسخه ی ۱۱ به ۱۲٫۱٫۳ را در طی ۱۰ ماه انجام دهد. قائم مقام گروه پزشکی اسمیت، وگان هنوم و مدیر پروژه بین المللی، لیزا رادل اذعان کردند این ارتقا به علت برنامه ریزی بسیار دقیق و پیشرفته و اقدامات به موقع و روی برنامه بود که با موفقیت انجام شد.</p>
//<p dir="RTL">این شرکت یک کمیته راهبری اجرایی ایجاد کرد که جلسات ماهانه برگزار می کرد.</p>
//<p dir="RTL">هنوم گفت: &#8221; همکاری نزدیک متخصصین موضوع &#8211; محور از جایی که همگی درباره بسته ی تجارت الکترونیکی اطلاعات کامل داشتند، ضروری بود.&#8221;</p>
//<p dir="RTL">گروه پزشکی اسمیت حدود ۷۹۰۰ کارمند دارد که ۵۰۰۰ تای آنها کاربران بسته ی تجارت الکترونیکی هستند. هنوم گفت پیاده سازی ۲۵ محیط عامل، ۳۰ هزار SKU و ۲۰ نرم افزار عمده که همگی آنها می بایست ارتقاء می یافتند ، که مجموعه ی بسیار بزرگی بود.</p>
//<p dir="RTL">چهارصد کارمند در روند آزمایشی به گروه کمک کردند.</p>
//<p dir="RTL">رادل گفت حجم بسیار بالایی از فعالیت آزمایشی داشتیم که باید مراقب آن می بودیم. تیم پروژه از تحلیل های تحلیلگران برای توسعه جداول و گراف ها که وضعیت آزمایش ها را به صورت بصری به تصویر کشیده استفاده شد. این قضیه تجارت را پرانگیزه نگه داشت. و از این طریق هرکسی متوجه میشد که کجای رقابت ایستاده است.</p>
//<p dir="RTL">تغییر نهایی به سیستم جدید که در ماه آگوست اتفاق افتاد موفق بود اما هنوز در مرحله تثبیت است. رادل گفت: &#8221; ما داریم مشکلاتش را بررسی میکنیم و نمی گوییم که مشکلات وجود ندارد.&#8221;</p>
//<p dir="RTL">با اینکه پروژه به شکل عمومی موفقیت آمیز بود اما به گروه پزشکی اسمیت درسهایی هم داد. اول اینکه نسخه ی ۱۲٫۱٫۳ تغییرات زیادی در بخش مالی دارد و شرکت ها باید مطمئن باشند کارکنان آموزش دیده و متخصص در این زمینه دارند.</p>
//<p dir="RTL">مشتریان همچنین باید متوجه عملکرد برنامه باشند چرا که نسبت به نسخه های قبلی تغییر ظاهری زیادی داشته است.</p>
//<p dir="RTL">کلید دیگر برای ارتباط نزدیک با اوراکل قبل از ارتقاء و بعد از ارتقاء با به گفته ی هنوم این است که: &#8221; بعد از ارتقاء نمی توانید به اندازه قبل به با اوراکل راحت باشید چرا که مشکلاتی به وجود خواهند امد. طبیعی است که پس از ارتقاء مشکلاتی پیش بیاید و آنها حل خواهند شد.&#8221;</p>
//<p dir="RTL">ارتقای ERP گروه پزشکی اسمیت یک مثال و الگوی ساده برای مشخص کردن راه اوراکل و دیگر کمپانی های ارتقاء دهنده است.</p>
//<p dir="RTL">اگر تیم کمپانی اوراکل بداند که مشتریان قرار است با نسخه ی جدید کار کنند، در صورت نیاز به راحتی می توان مساله پشتیبانی را به سطح اولویت بالاتری برد.</p>
//<p dir="RTL"><a href="http://www.networkworld.com/article/2691314/how-to-avoid-an-oracle-erp-upgrade-disaster.html" target="_blank">لینک خبر</a></p>
//          </div>

                string str_html_matnemaghalat = "";

                for (int i = 0; i < DT.Rows.Count; i++)
                {

                    str_html_matnemaghalat  += " <h3>";
                    str_html_matnemaghalat  += DT.Rows[i][1].ToString();
                    str_html_matnemaghalat  += "</h3>";
                    str_html_matnemaghalat  += " <div class=\"postDate\"><span>تاريخ انتشار : </span>";
                    str_html_matnemaghalat  += DT.Rows[i][5].ToString();
                    str_html_matnemaghalat  += "</div>";
                    str_html_matnemaghalat += "<div style=\"width: 100%; text-align: center; margin-top: 20px; margin-bottom: 20px;\"></div> <div class=\"entry-content\"><div class=\"simplesocialbuttons\">";
                    str_html_matnemaghalat  += "<div class=\"simplesocialbutton ssb-button-googleplus\"><!-- Google Plus One--><div class=\"g-plusone\" data-size=\"medium\" data-href=\"http://arjang.ac.ir/%d8%b3%db%8c%d8%b3%da%a9%d9%88-%d8%b1%d9%88%db%8c-%d9%be%d8%b1%d9%88%da%98%d9%87-80-%d9%85%db%8c%d9%84%db%8c%d9%88%d9%86-%d8%af%d9%84%d8%a7%d8%b1%db%8c-%d9%81%d8%b6%d8%a7%db%8c-%d8%a7%d8%a8%d8%b1-clo/\"></div></div>";
                    str_html_matnemaghalat  += "<div class=\"simplesocialbutton ssb-button-fblike\"><!-- Facebook like--><div id=\"fb-root\"></div><div class=\"fb-like\" data-href=\"http://arjang.ac.ir/%d8%b3%db%8c%d8%b3%da%a9%d9%88-%d8%b1%d9%88%db%8c-%d9%be%d8%b1%d9%88%da%98%d9%87-80-%d9%85%db%8c%d9%84%db%8c%d9%88%d9%86-%d8%af%d9%84%d8%a7%d8%b1%db%8c-%d9%81%d8%b6%d8%a7%db%8c-%d8%a7%d8%a8%d8%b1-clo/\" data-send=\"false\" data-layout=\"button_count\" data-width=\"100\" data-show-faces=\"false\"></div></div>";
                    str_html_matnemaghalat  += "<div class=\"simplesocialbutton ssb-buttom-twitter\"><!-- Twitter--><a href=\"https://twitter.com/share\" class=\"twitter-share-button\" data-text=\"";
                    str_html_matnemaghalat  += DT.Rows[i][1].ToString();
                    str_html_matnemaghalat  += " \" data-url=\"http://arjang.ac.ir/%d8%b3%db%8c%d8%b3%da%a9%d9%88-%d8%b1%d9%88%db%8c-%d9%be%d8%b1%d9%88%da%98%d9%87-80-%d9%85%db%8c%d9%84%db%8c%d9%88%d9%86-%d8%af%d9%84%d8%a7%d8%b1%db%8c-%d9%81%d8%b6%d8%a7%db%8c-%d8%a7%d8%a8%d8%b1-clo/\" data-via=\"arjangins\" rel=\"nofollow\"></a></div>";
                    str_html_matnemaghalat  += "</div><p dir=\"RTL\">";
                    str_html_matnemaghalat  += DT.Rows[i][3].ToString();
                    str_html_matnemaghalat  += "</p><p dir=\"RTL\"><a href=\"";
                    str_html_matnemaghalat  += DT.Rows[i][6].ToString();
                    str_html_matnemaghalat  += "\" target=\"_blank\">لینک خبر</a></p></div>";
                }
                return str_html_matnemaghalat;

            }
            if (type == "html_maghalat")
            {
//    <div>
//            <div class="course-item-0" >
//                <div class="course-list-box-article" onclick="openSection(0)">
//                <div class="header-clb"> اینترنت روی هر وسیله (IoE) در تحصیلات عالی </div>
//                </div>
				
//                <div id="course-item-desc-0" class="course-item-obj">
//                 اینترنت روی هر وسیله ( IoE) و فناوری های پیش برنده ی آن، به طریقی روی مسائل آموزشی به خصوص آموزش عالی اثر می گذارند که دو دهه پیش اصلا تصور نمی شد. در این عصر اطلاعات و داده های بی پایان، این حتی باعث می شود موسسه شما مسائل پایه ی آموزشهایش را مورد تجدید نظر قرار دهد. و پیشروان IT آنها برای مطمئن شدن از موفقیت شان، به شما بازمی گردند، آیا آماده اید؟
//اینترنت روی هر وسیله ای...
//                 <br />                            
//                 <a href="http://arjang.ac.ir/?p=4643" target=_blank >ادامه ي مطلب</a>
//                </div>

//                <div style="clear:both"></div>
//            </div>
//        </div>


                string str_html_maghalat = "";

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    str_html_maghalat += "<div><div class=\"course-item-";
                    str_html_maghalat += i;
                    str_html_maghalat += "\" >";
                    str_html_maghalat += "<div class=\"course-list-box-article\" onclick=\"openSection(";
                    str_html_maghalat += i;
                    str_html_maghalat += ")\">";
                    str_html_maghalat += "<div class=\"header-clb\">";
                    str_html_maghalat += DT.Rows[i][1].ToString();
                    str_html_maghalat += "</div></div>";
                    str_html_maghalat += "<div id=\"course-item-desc-";
                    str_html_maghalat +=i;
                    str_html_maghalat += "\" class=\"course-item-obj\">";
                    str_html_maghalat += DT.Rows[i][2].ToString();
                    str_html_maghalat += "<br /><a href=\"";
                    str_html_maghalat += DT.Rows[i][4].ToString();
                    str_html_maghalat += DT.Rows[i][0].ToString();
                    str_html_maghalat += "\" target=_blank >ادامه ي مطلب</a></div><div style=\"clear:both\"></div></div></div>";
                }
                return str_html_maghalat;

            }
            if (type == "html_sharhenews")
            {

//   <h3>سیسکو روی پروژه ۸۰ میلیون دلاری فضای ابر (Cloud) چینی سرمایه گذاری می‌کند</h3>

          
//          <div class="postDate"><span>تاريخ انتشار : </span>مهر ۱۹, ۱۳۹۳</div>

//         <div style="width: 100%; text-align: center; margin-top: 20px; margin-bottom: 20px;">
//          </div>

//          <div class="entry-content">
//              <div class="simplesocialbuttons">
//<div class="simplesocialbutton ssb-button-googleplus"><!-- Google Plus One--><div class="g-plusone" data-size="medium" data-href="http://arjang.ac.ir/%d8%b3%db%8c%d8%b3%da%a9%d9%88-%d8%b1%d9%88%db%8c-%d9%be%d8%b1%d9%88%da%98%d9%87-80-%d9%85%db%8c%d9%84%db%8c%d9%88%d9%86-%d8%af%d9%84%d8%a7%d8%b1%db%8c-%d9%81%d8%b6%d8%a7%db%8c-%d8%a7%d8%a8%d8%b1-clo/"></div></div>
//<div class="simplesocialbutton ssb-button-fblike"><!-- Facebook like--><div id="fb-root"></div><div class="fb-like" data-href="http://arjang.ac.ir/%d8%b3%db%8c%d8%b3%da%a9%d9%88-%d8%b1%d9%88%db%8c-%d9%be%d8%b1%d9%88%da%98%d9%87-80-%d9%85%db%8c%d9%84%db%8c%d9%88%d9%86-%d8%af%d9%84%d8%a7%d8%b1%db%8c-%d9%81%d8%b6%d8%a7%db%8c-%d8%a7%d8%a8%d8%b1-clo/" data-send="false" data-layout="button_count" data-width="100" data-show-faces="false"></div></div>
//<div class="simplesocialbutton ssb-buttom-twitter"><!-- Twitter--><a href="https://twitter.com/share" class="twitter-share-button" data-text="سیسکو روی پروژه ۸۰ میلیون دلاری فضای ابر (Cloud) چینی سرمایه گذاری می‌کند" data-url="http://arjang.ac.ir/%d8%b3%db%8c%d8%b3%da%a9%d9%88-%d8%b1%d9%88%db%8c-%d9%be%d8%b1%d9%88%da%98%d9%87-80-%d9%85%db%8c%d9%84%db%8c%d9%88%d9%86-%d8%af%d9%84%d8%a7%d8%b1%db%8c-%d9%81%d8%b6%d8%a7%db%8c-%d8%a7%d8%a8%d8%b1-clo/" data-via="arjangins" rel="nofollow"></a></div>
//</div>
//<p dir="RTL">سیسکو در حال شروع یک سرمایه گذاری ۸۰ میلیون دلاری به همکاری شرکت مخابراتی چینی TCL  است.</p>
//<p dir="RTL">این سرمایه گذاری به ایجاد یک فضای ابر عمومی با همکاری گسترده ی سیسکو و TCL منجر خواهد شد که این فضای ابر پیشرفته برای نرم افزارهای مربوط به همکاری سازمان ها، جلسات آنلاین، کنفرانس های ویدئویی و صوتی، مناسب خواهد بود.</p>
//<p dir="RTL">سیسکو ۱۶ میلیون دلار و ۲۰% سهام پروژه، و TCL چینی ۶۴ میلیون دلار و ۸۰% سهام پروژه را به خود اختصاص دادند.</p>
//<p dir="RTL">اخیراً سیسکو ۱ میلیارد دلار برای  InterCloud که در حال ساخت یک فضای ابر جهانی برای ارتباط نزدیک تامین کنندگان است، سرمایه گذاری کرده بود.</p>
//<p dir="RTL"><a href="http://www.networkworld.com/article/2824504/cisco-subnet/cisco-invests-in-80m-chinese-cloud.html" target="_blank">لینک خبر</a></p>
//          </div>



                string str_html_sharhenews = "";

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    str_html_sharhenews += " <h3>";
                    str_html_sharhenews += DT.Rows[i][1].ToString();
                    str_html_sharhenews += "</h3>";
                    str_html_sharhenews += " <div class=\"postDate\"><span>تاريخ انتشار : </span>";
                    str_html_sharhenews += DT.Rows[i][6].ToString();
                    str_html_sharhenews += "</div>";
                    str_html_sharhenews += "<div style=\"width: 100%; text-align: center; margin-top: 20px; margin-bottom: 20px;\"></div> <div class=\"entry-content\"><div class=\"simplesocialbuttons\">";
                    str_html_sharhenews += "<div class=\"simplesocialbutton ssb-button-googleplus\"><!-- Google Plus One--><div class=\"g-plusone\" data-size=\"medium\" data-href=\"http://arjang.ac.ir/%d8%b3%db%8c%d8%b3%da%a9%d9%88-%d8%b1%d9%88%db%8c-%d9%be%d8%b1%d9%88%da%98%d9%87-80-%d9%85%db%8c%d9%84%db%8c%d9%88%d9%86-%d8%af%d9%84%d8%a7%d8%b1%db%8c-%d9%81%d8%b6%d8%a7%db%8c-%d8%a7%d8%a8%d8%b1-clo/\"></div></div>";
                    str_html_sharhenews += "<div class=\"simplesocialbutton ssb-button-fblike\"><!-- Facebook like--><div id=\"fb-root\"></div><div class=\"fb-like\" data-href=\"http://arjang.ac.ir/%d8%b3%db%8c%d8%b3%da%a9%d9%88-%d8%b1%d9%88%db%8c-%d9%be%d8%b1%d9%88%da%98%d9%87-80-%d9%85%db%8c%d9%84%db%8c%d9%88%d9%86-%d8%af%d9%84%d8%a7%d8%b1%db%8c-%d9%81%d8%b6%d8%a7%db%8c-%d8%a7%d8%a8%d8%b1-clo/\" data-send=\"false\" data-layout=\"button_count\" data-width=\"100\" data-show-faces=\"false\"></div></div>";
                    str_html_sharhenews += "<div class=\"simplesocialbutton ssb-buttom-twitter\"><!-- Twitter--><a href=\"https://twitter.com/share\" class=\"twitter-share-button\" data-text=\"";
                    str_html_sharhenews += DT.Rows[i][1].ToString();
                    str_html_sharhenews += " \" data-url=\"http://arjang.ac.ir/%d8%b3%db%8c%d8%b3%da%a9%d9%88-%d8%b1%d9%88%db%8c-%d9%be%d8%b1%d9%88%da%98%d9%87-80-%d9%85%db%8c%d9%84%db%8c%d9%88%d9%86-%d8%af%d9%84%d8%a7%d8%b1%db%8c-%d9%81%d8%b6%d8%a7%db%8c-%d8%a7%d8%a8%d8%b1-clo/\" data-via=\"arjangins\" rel=\"nofollow\"></a></div>";
                    str_html_sharhenews += "</div><p dir=\"RTL\">";
                    str_html_sharhenews += DT.Rows[i][2].ToString();
                    str_html_sharhenews += "</p><p dir=\"RTL\"><a href=\"";
                    str_html_sharhenews += DT.Rows[i][7].ToString();
                    str_html_sharhenews += "\" target=\"_blank\">لینک خبر</a></p></div>";
                }
                return str_html_sharhenews;

            }

            if (type == "html_akhbar")
            { 
                
       //<li class="news-item">
       // <div class="dateItem" style="width:140px;">
       // <span style="font-size: 28px;">
       // 1393/7/16        </span>
       // </div>
       // <div style="float: right; width: 780px;">
       //  <div class="triSign"></div> <a href="10-%d8%ac%d8%b1%db%8c%d8%a7%d9%86-%d9%81%d9%86%d8%a7%d9%88%d8%b1%db%8c-%d9%85%d9%87%d9%85-%d8%af%d9%86%db%8c%d8%a7%db%8c-it-%d8%af%d8%b1-%d8%b3%d8%a7%d9%84-2015-%da%a9%d9%87-%d9%86%d9%85%db%8c-%d8%aa" rel="bookmark" >10 جریان فناوری مهم دنیای IT در سال 2015 که نمی توان نادیده گرفت </a>
       //  <div>
       // </div>
       //  </div>
       // <div class="clearfix"></div>
       //</li>
                string str_html_akhbar = "";

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    str_html_akhbar += "<li class=\"news-item\"><div class=\"dateItem\" style=\"width:140px;\"><span style=\"font-size: 20px;\">";              
                    str_html_akhbar += DT.Rows[i][6].ToString();
                    str_html_akhbar += " </span></div><div style=\"float: right; width: 780px;\">";
                    str_html_akhbar += "<div class=\"triSign\"></div> <a href=\"";
                    str_html_akhbar += DT.Rows[i][5].ToString();
                    str_html_akhbar += DT.Rows[i][0].ToString();
                    str_html_akhbar += "\" rel=\"bookmark\">";
                    str_html_akhbar += DT.Rows[i][1].ToString();
                    str_html_akhbar += " </a><div></div></div>";   
                    str_html_akhbar += " <div class=\"clearfix\"></div></li>";
              }
                return str_html_akhbar;

            }
            if (type == "html_instructor")
            {                
       
//                <div class='teacher-box' data='0' ><div class='pull-right pic'><img src='http://arjang.ac.ir/wp-content/themes/remis/images/teachers/hamedi.png/wp-content/themes/remis/images/sample-teacher.png'/></div><div class='teacher-box-hidden-data' id='box-tch-0'  ><div style='direction: rtl; height: 100px; width: 545px; overflow-x:hidden;'><a href="http://arjang.ac.ir/instructor-cv/hamedi.pdf" target=_blank class="teacher-download-btn normalTip exampleTip" title="<div class='tooltip-teacher'><ul>
//            <li> فوق لیسانس نرم افزار از دانشگاه علم و صنعت ایران </li>
//            <li> دارای مدارک بین المللی: <br />
//                <p style='direction: ltr'>
                    //            VMware(VCP510,VCP410)
                    //,         Cisco(CCDP,CCNP,CCDA,CCNA)
                    //,        HP (AIS-Blade,AIS-ML/DL,APS-MSA,APS-TAPE)
//                </p>
//            </li>	
//            <li>دوره های بین المللی گذرانده شده:
//                <p style='direction: ltr'>
			
//        EMC VNX Block Storage Deployment and Management(EMC-Singapore)

//,        Replication Solution for EVA storage(HP-Dubai)

//,        Vmware vsphere:Troubleshooting(VMware-Dubai)

//,        Vmware vsphere install,configure,manage(Vmware-Dubai)
//</p>
//</li>
 			
//            </ul></div>" >  مشاهده <br /> رزومه</a><div style='float: left; width: 340px; padding-left: 15px;'>CCNA, NXOS, Accelerated SAN Essentials, CCDA, EMC, Managing HP StorageWorks EVA</div><div class='clearfix'></div></div></div><div class='pull-left name' id='box-tc-0' >علي حامدي</div><div class='clearfix'></div></div>

                string str_html_instructor = "";

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                  
                    str_html_instructor += "<div class='teacher-box' data='";
                    str_html_instructor += i;
                    str_html_instructor += "' ><div class='pull-right pic'><img src='";
                    str_html_instructor += DT.Rows[i][2].ToString();
                    str_html_instructor += "'/></div><div class='teacher-box-hidden-data' id='box-tch-";
                    str_html_instructor += i;
                    str_html_instructor += "'  ><div style='direction: rtl; height: 100px; width: 545px; overflow-x:hidden;'><a href=\"";
                    str_html_instructor += DT.Rows[i][3].ToString();
                    str_html_instructor += "\" target=_blank class=\"teacher-download-btn normalTip exampleTip\" title=\"<div class='tooltip-teacher'><ul>";
                   for (int k =10; k <16; k++)
                {
                    if (DT.Rows[i][k].ToString() != "")
                    {
                        str_html_instructor += "<li>";
                        str_html_instructor += DT.Rows[i][k].ToString();
                        str_html_instructor += "<p style='direction: ltr'>";
                        str_html_instructor += DT.Rows[i][k + 6].ToString();
                        str_html_instructor += "</p>";
                        str_html_instructor += "</li>";
                    }
                }
                    str_html_instructor += "</ul></div>\" >  مشاهده <br /> رزومه</a><div style='float: left; width: 340px; padding-left: 15px;'>";
                    str_html_instructor += DT.Rows[i][5].ToString();
                    str_html_instructor += " </div><div class='clearfix'></div></div></div><div class='pull-left name' id='box-tc-";
                    str_html_instructor += i;
                    str_html_instructor += "' >";
                    str_html_instructor += DT.Rows[i][1].ToString();
                    str_html_instructor += "</div><div class='clearfix'></div></div>";

                }
                return str_html_instructor;
            }
            if (type == "meta_title")
            {
                string str_meta_html_tags = "";
                str_meta_html_tags += DT.Rows[0][4].ToString();
                return str_meta_html_tags;
            }
            else if (type == "html_toplinkbar")
            {
                //<li><a href="http://arjang.ac.ir/">آغازگاه</a></li>
                //<li class="page_item page-item-3369"><a href="http://arjang.ac.ir/courses-list">دوره ها</a></li>
                //<li class="page_item page-item-1281"><a href="http://arjang.ac.ir/schedule">تقویم دوره ها</a></li>
                //<li class="page_item page-item-66"><a href="http://arjang.ac.ir/certification/">آزمون های بین المللی</a></li>
                //<li class="page_item page-item-91"><a href="http://arjang.ac.ir/?post_type=job">فرصت های شغلی</a></li>
                //<li class="page_item page-item-1822"><a href="http://arjang.ac.ir/learning">مقالات</a></li>
                //<li class="page_item page-item-91"><a href="http://arjang.ac.ir/contact/">تماس با ما</a></li>
                string str_html_toplinkbar = "";
                //str_html_toplinkbar+= 

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    str_html_toplinkbar += "<li><a href=\"";
                    str_html_toplinkbar += DT.Rows[i][3].ToString();
                    str_html_toplinkbar += "\">";
                    str_html_toplinkbar += DT.Rows[i][1].ToString();
                    str_html_toplinkbar += "</a></li>\n            ";
                }

                return str_html_toplinkbar;
            }
          
            else if (type == "html_nextcources")
            {
                //<tr>
                //    <td style="text-align: center;"> 1392/11/27 </td>
                //        <td style="direction: ltr; width: 385px;">
                //            <a href="http://my.arjang.ac.ir/course/403" target="_blank" style="color: rgb(0, 0, 0); text-shadow: rgb(255, 255, 255) 0px 1px 1px;"> 
                //                LPIC-2	                                    </a>
                //    </td>
                //</tr>

                string str_html_nextcourses = "";

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    str_html_nextcourses += "<tr><td style=\"text-align: center;\">";
                    str_html_nextcourses += DT.Rows[i][2].ToString();
                    str_html_nextcourses += "</td><td style=\"direction: ltr; width: 385px;\"> <a href=\"";
                    str_html_nextcourses += DT.Rows[i][3].ToString();
                    str_html_nextcourses += "\" target=\"_blank\" style=\"color: rgb(0, 0, 0); text-shadow: rgb(255, 255, 255) 0px 1px 1px;\"> ";
                    str_html_nextcourses += DT.Rows[i][1].ToString();
                    str_html_nextcourses += "</a></td></tr>";
                }
                return str_html_nextcourses;
            }
            else if (type == "html_certified")
            {
                //<tr>
                //<td class="engline">CCIE Written  </td>
                //<td>Alireza Aeinechian</td>
                //</tr>            

                string str_html_certified = "";

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    str_html_certified += "<tr>                <td class=\"engline\">";
                    str_html_certified += DT.Rows[i][1].ToString();
                    str_html_certified += "</td><td>";
                    str_html_certified += DT.Rows[i][0].ToString();
                    str_html_certified += "</td></tr>";
                }
                return str_html_certified;

            }
            else if (type == "meta")
            {
                //<meta name="description" content="یادگیری شبانه روزی و ارزان و بدون جابجایی">
                //<meta name="keywords" content="کنترل پروژه, پراجکت سرور, پروجکت سرور, شرپوینت,شیرپونت,اکسچینج,سی آر ام, مدیریت ارتباط با مشتری,دی وی دی, سی دی,فروشگاه, خرید, آنلاین,virtualization,مجازی سازی,sharepoint,">

                string str_meta_html_tags = "<meta name=\"";
                str_meta_html_tags += DT.Rows[0][0].ToString();
                str_meta_html_tags += "\" content=\"";
                str_meta_html_tags += DT.Rows[0][1].ToString();
                str_meta_html_tags += "\">";

                str_meta_html_tags += "\n";

                str_meta_html_tags += "<meta name=\"";
                str_meta_html_tags += DT.Rows[1][0].ToString();
                str_meta_html_tags += "\" content=\"";
                str_meta_html_tags += DT.Rows[1][1].ToString();
                str_meta_html_tags += "\">";

                return str_meta_html_tags;
            }
            else if (type == "adv_header")
            {
                //<div style="width:201;margin:0 auto;text-align:center;">
                //<a href="http://crm4.persianblog.ir/" target="_blank">
                //<img src="./etc/ad_75F1071D.png" alt="Microsoft Dynamics CRM 2011" title="Microsoft Dynamics CRM 2011">
                //</a>
                //</div>

            }
            else if (type == "adv_footer")
            {
                //<div style="width:201;margin:0 auto;text-align:center;">
                //<a href="http://kms.persianblog.ir/" target="_blank">
                //<img src="./etc/ad_0DF5894A.png" alt="Knowledge Management Systems" title="Knowledge Management Systems">
                //</a>
                //</div>
            }
            else if (type == "quicklunch")
            {
                //<ul class="menu">
                //<li><a href="./etc/default.htm">صفحه اصلی</a></li>
                //<li><a href="http://mesbahsoft.com/products/">محصولات</a></li>
                //<li><a href="http://mesbahsoft.com/pages/about">درباره ما</a></li>
                //<li><a href="http://mesbahsoft.com/pages/contact">تماس</a></li>
                //<li><a href="http://mesbahsoft.com/tracking/">پیگیری خرید</a></li>
                //<li><a href="http://mesbahsoft.com/news/">اخبار</a></li>
                //<li><a href="http://mesbahsoft.com/p-register/">ثبت نام همکاران</a></li>
                //<li><a href="http://mesbahsoft.com/p-cp/">کنترل پنل همکاران</a></li>
                //</ul>

                string str_menu_ql_html_tags = "<ul class=\"menu\">\n            ";

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    str_menu_ql_html_tags += "<li><a href=\"";
                    str_menu_ql_html_tags += DT.Rows[i][0].ToString();
                    str_menu_ql_html_tags += "\">";
                    str_menu_ql_html_tags += DT.Rows[i][1].ToString();
                    str_menu_ql_html_tags += "</a></li>\n            ";
                }

                str_menu_ql_html_tags += "</ul>";

                return str_menu_ql_html_tags;
            }
            else if (type == "products")
            {

                //generate meta tag from setting table iamges
                string storeprocedurename = "mysp_learnkey_settings";
                DataTable DT_settings_button = runstoreprocedure(storeprocedurename, "button");


                //generate meta tag from setting table insert into head
                storeprocedurename = "mysp_learnkey_settings";
                DataTable DT_settings_link = runstoreprocedure(storeprocedurename, "link");




                //<div class="product">
                //<h2><a href="http://mesbahsoft.com/product/Virtualization-VMWare-vSphere-cloud-computing-4-ESX-4-%D9%85%D8%AC%D8%A7%D8%B2%DB%8C-%D8%B3%D8%A7%D8%B2%DB%8C">آموزش فارسی مجازی سازی سرور با  VMWare vSphere4 یا ESX 4 (کاملا فارسی)</a></h2>
                //<div class="product-image" style="height: 64px">
                //<a href="http://mesbahsoft.com/product/Virtualization-VMWare-vSphere-cloud-computing-4-ESX-4-%D9%85%D8%AC%D8%A7%D8%B2%DB%8C-%D8%B3%D8%A7%D8%B2%DB%8C"><img src="./etc/13900421575_a.jpg" alt="آموزش فارسی مجازی سازی سرور با  VMWare vSphere4 یا ESX 4 (کاملا فارسی)" title="آموزش فارسی مجازی سازی سرور با  VMWare vSphere4 یا ESX 4 (کاملا فارسی)" width="115" height="64"></a>		</div>
                //<div class="summary">
                //دی وی دی آموزشی مجازی سازی نرم افزار شرکت VMware بنام VSphere4 یا ESX4		</div>
                //<div class="price">
                //<s>۴۰۰۰۰</s> &nbsp; ۱۴۰۰۰ تومان
                //</div>
                //<div class="list-buttons">
                //<a href="http://mesbahsoft.com/product/Virtualization-VMWare-vSphere-cloud-computing-4-ESX-4-%D9%85%D8%AC%D8%A7%D8%B2%DB%8C-%D8%B3%D8%A7%D8%B2%DB%8C"><img src="./etc/more.gif" alt="اطلاعات بیشتر آموزش فارسی مجازی سازی سرور با  VMWare vSphere4 یا ESX 4 (کاملا فارسی)" title="اطلاعات بیشتر آموزش فارسی مجازی سازی سرور با  VMWare vSphere4 یا ESX 4 (کاملا فارسی)" width="99" height="26"></a>
                //<a href="http://mesbahsoft.com/basket/1"><img src="./etc/buy.gif" alt="خرید آموزش فارسی مجازی سازی سرور با  VMWare vSphere4 یا ESX 4 (کاملا فارسی)" title="خرید آموزش فارسی مجازی سازی سرور با  VMWare vSphere4 یا ESX 4 (کاملا فارسی)" width="90" height="26"></a>
                //</div>
                //</div>

                string str_products_html_tags = "";

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    str_products_html_tags += "\n<div class=\"product\">            \n<h2><a href=\"";
                    str_products_html_tags += DT.Rows[i][1].ToString();
                    str_products_html_tags += "\">";
                    str_products_html_tags += DT.Rows[i][2].ToString();
                    str_products_html_tags += "</a></h2>            \n<div class=\"product-image\" style=\"height: 64px\">            \n<a href=\"";
                    str_products_html_tags += DT.Rows[i][1].ToString();
                    str_products_html_tags += "\"><img src=\"";
                    str_products_html_tags += DT.Rows[i][3].ToString();
                    str_products_html_tags += "\" alt=\"";
                    str_products_html_tags += DT.Rows[i][2].ToString();
                    str_products_html_tags += "\" title=\"";
                    str_products_html_tags += DT.Rows[i][2].ToString();
                    str_products_html_tags += "\" width=\"115\" height=\"64\"></a>		</div>            \n<div class=\"summary\">            \n";
                    str_products_html_tags += DT.Rows[i][4].ToString();
                    str_products_html_tags += "</div>            \n<div class=\"price\">            \n<s>";
                    str_products_html_tags += DT.Rows[i][6].ToString();
                    str_products_html_tags += "</s> &nbsp; ";
                    str_products_html_tags += DT.Rows[i][7].ToString();
                    str_products_html_tags += "                \n</div>                \n<div class=\"list-buttons\">                \n<a href=\"";
                    str_products_html_tags += DT.Rows[i][1].ToString();
                    str_products_html_tags += "\"><img src=\"./etc/";
                    str_products_html_tags += DT_settings_button.Rows[1][1].ToString();
                    str_products_html_tags += "\" alt=\"";
                    str_products_html_tags += "اطلاعات بیشتر درباره ی ";
                    str_products_html_tags += DT.Rows[i][2].ToString();
                    str_products_html_tags += "\" title=\"";
                    str_products_html_tags += "اطلاعات بیشتر درباره ی ";
                    str_products_html_tags += DT.Rows[i][2].ToString();
                    str_products_html_tags += "\" width=\"99\" height=\"26\"></a>            \n<a href=\"";
                    //str_products_html_tags += "http://mesbahsoft.com/basket/" + DT.Rows[i][0].ToString();
                    str_products_html_tags += DT_settings_link.Rows[0][1].ToString();
                    str_products_html_tags += DT_settings_link.Rows[1][0].ToString();
                    str_products_html_tags += "=";
                    str_products_html_tags += DT_settings_link.Rows[1][1].ToString();
                    str_products_html_tags += "&";
                    str_products_html_tags += DT_settings_link.Rows[2][0].ToString();
                    str_products_html_tags += "=";
                    str_products_html_tags += DT_settings_link.Rows[2][1].ToString();
                    str_products_html_tags += "&";
                    str_products_html_tags += DT_settings_link.Rows[3][0].ToString();
                    str_products_html_tags += "=";
                    str_products_html_tags += DT.Rows[i][5].ToString();
                    str_products_html_tags += "&";
                    str_products_html_tags += DT_settings_link.Rows[4][0].ToString();
                    str_products_html_tags += "=";
                    str_products_html_tags += DT_settings_link.Rows[4][1].ToString();
                    str_products_html_tags += "\"><img src=\"./etc/";
                    str_products_html_tags += DT_settings_button.Rows[0][1].ToString();
                    str_products_html_tags += "\" alt=\"";
                    str_products_html_tags += "خرید ";
                    str_products_html_tags += DT.Rows[i][2].ToString();
                    str_products_html_tags += "\" title=\"";
                    str_products_html_tags += "خرید ";
                    str_products_html_tags += DT.Rows[i][2].ToString();
                    str_products_html_tags += "\" width=\"90\" height=\"26\"></a>            \n</div>            \n</div>\n";
                }


                return str_products_html_tags;

            }
            return "";
        }

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}