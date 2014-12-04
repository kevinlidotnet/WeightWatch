using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data.Sql;

namespace MvcApplicationSnow.Controllers
{
    /// <summary>
    ///  
    /// </summary>
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "ASP.NET MVC(ViewBag.Message).";

            return View();
        }
         
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";
            //Create("1", "about");
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            //Create("1", "contact");
            return View();
        }

        ///// <summary>
        ///// data updating or not
        ///// ADO .NET 
        ///// Not using 
        ///// </summary>
        //private bool Create(string fieldA, string fieldB)
        //{
        //    SqlConnection con = new SqlConnection("Data Source=localhost;" +
        //                                            "Initial Catalog=Snow;" +
        //                                            "User id=sa;" +
        //                                            "Password=123;");
        //    try
        //    {
        //        string comFind = string.Format(@"select fieldB from TableWeight where fieldA = {0}  ", fieldA);
        //        string comStr = string.Format(@"INSERT INTO [dbo].[TableWeight] ([FieldA],[FieldB]) VALUES({0},'{1}')", fieldA, fieldB);
        //        SqlCommand com = new SqlCommand(comFind, con);
        //        con.Open(); 

        //        if (com.ExecuteScalar() == null)
        //        { 
        //            //need to be added
        //            com.CommandText = comStr; 
        //        } 
        //        else if (string.Compare( com.ExecuteScalar().ToString(),fieldB) == 0)
        //        {
        //            //existing 
        //            return false;
        //        }
        //        else  
        //        {
        //            //need to be updated 
        //            com.CommandText = string.Format(@"UPDATE [dbo].[TableWeight] SET [FieldB] = '{1}' WHERE  FieldA = {0} ", fieldA, fieldB);
        //        } 

        //        if (com.ExecuteNonQuery() == 1)
        //        {
        //            return true;
        //        }
        //        return false; 
                  
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}
    }
}
