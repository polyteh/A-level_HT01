using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuadraticEquationClass;

namespace QuadraticEquationForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lb_warning.Visible = false;
            lb_Decomp.Text = "";
            string solveStaus;


            try
            {
                List<double> calculationResult = QuadraticEquation.SolveQuadrEq(Convert.ToDouble(tb_coefA.Text), Convert.ToDouble(tb_coefB.Text), Convert.ToDouble(tb_coefC.Text), out solveStaus);

                if (calculationResult != null)
                {
                    tb_X1.Text = calculationResult[0].ToString();
                    tb_X2.Text = calculationResult[1].ToString();

                    lb_Decomp.Text = QuadraticEquation.DecompositionEquation;
                }
                else
                {
                    tb_X1.Clear();
                    tb_X2.Clear();

                }

                lb_warning.Text = solveStaus;
                lb_warning.Visible = true;

            }
            catch (Exception)
            {

                tb_X1.Clear();
                tb_X2.Clear();
                MessageBox.Show("Input data can't converted to double", "Wrong input", MessageBoxButtons.OK);
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb_warning.Visible = false;
        }


    }
}
