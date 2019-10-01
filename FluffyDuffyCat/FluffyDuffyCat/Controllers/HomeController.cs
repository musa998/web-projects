using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FluffyDuffyCat.Models;
using FluffyDuffyCat.Data.Models;
using System.Data.SqlClient;

namespace FluffyDuffyCat.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<CatViewModel> catsList = new List<CatViewModel>();
            var connectionString = "Server=(localdb)\\mssqllocaldb;Integrated Security=True;" +
                "Database=FluffyCatDB;Trusted_Connection=True;MultipleActiveResultSets=true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //SqlDataReader
                connection.Open();
                Console.WriteLine("ServerVersion: {0}", connection.ServerVersion);
                Console.WriteLine("State: {0}", connection.Database);

                string sql = "Select * From Cats";
                SqlCommand command = new SqlCommand(sql, connection);

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        CatViewModel cat = new CatViewModel();
                        cat.CatId = Convert.ToInt32(dataReader["CatId"]); 
                        cat.Name = Convert.ToString(dataReader["Name"]);
                        cat.Age= Convert.ToInt32(dataReader["Age"]);
                        cat.Breed= Convert.ToString(dataReader["Breed"]);
                        cat.Url= Convert.ToString(dataReader["ImageUrl"]);
                        catsList.Add(cat);
                    }
                }
                connection.Close();
            }
            return View(catsList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
