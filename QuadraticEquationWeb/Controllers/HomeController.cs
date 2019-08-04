using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuadraticEquationWeb.Models;
using QuadraticEquationClass;

namespace QuadraticEquationWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new EquationModel());
        }

        [HttpPost]

        public ActionResult Index(EquationModel equationModel)
        {

            string solveStatus;

            try
            {
                List<double> calculationResult = QuadraticEquation.SolveQuadrEq(Convert.ToDouble(equationModel.Coef_A), Convert.ToDouble(equationModel.Coef_B), Convert.ToDouble(equationModel.Coef_C), out solveStatus);
                equationModel.solveStatus = solveStatus;
                if (calculationResult != null)
                {
                    equationModel.RootX1 = calculationResult[0].ToString();
                    equationModel.RootX2 = calculationResult[1].ToString();
                }
            }

            catch (Exception)
            {
                equationModel.solveStatus = "Input data can't converted to double";
            }

            return View(equationModel);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}