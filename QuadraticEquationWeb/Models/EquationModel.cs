using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace QuadraticEquationWeb.Models
{
    public class EquationModel
    {

        public string Coef_A { get; set; }
        public string Coef_B { get; set; }
        public string Coef_C { get; set; }


        [Display (Name ="Root x1")]
        public string RootX1 { get; set; }

        [Display(Name = "Root x2")]
        public string RootX2 { get; set; }
        public string solveStatus { get; set; }




    }
}