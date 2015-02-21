using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.Differentiation; //http://numerics.mathdotnet.com/, Documentation @ http://numerics.mathdotnet.com/api/
using Microsoft.SolverFoundation.Common; // https://msdn.microsoft.com/en-us/devlabs/hh145003.aspx
using Microsoft.SolverFoundation.Services;
using Microsoft.SolverFoundation.Solvers;


namespace CloudCamGUI
{
    

    public partial class Form1 : Form
    {
        public static double h = 0;
        public static double[] v = new double[] { 0 }; // the reason v is a vector is because of the NelderMeadSolver likes function that takes vector
        public static double radDiff = 0;

        public static double rad = 0;
        public static double w = 0;
        public static double newspd = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            v[0] = double.Parse(setSpeed.Text);
            rad =  double.Parse(Rad.Text);
            w = double.Parse(wind.Text);
            h = double.Parse(grade.Text);
            radDiff = rad - MyCal.avgRad; 
            MyCal.lamda = MyCal.calLamda(v, MyCal.force, MyCal.dforce);
            newspd = MyCal.calNewspeed(v, MyCal.energy, ref MyCal.optenergy);
            this.newSpeed.Text = newspd.ToString();
            this.lamda.Text = MyCal.lamda.ToString();
            this.energy.Text = MyCal.optenergy.ToString();
        }

        private void setSpeed_TextChanged(object sender, EventArgs e)
        {
        
          
          //  v = int.Parse(setSpeed.Text);
        }

        private void Rad_TextChanged(object sender, EventArgs e)
        {
            
           
            //rad = int.Parse(Rad.Text);
        }

        private void wind_TextChanged(object sender, EventArgs e)
        {
            
           
           // w = int.Parse(wind.Text);
        }

        private void newSpeed_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void grade_TextChanged(object sender, EventArgs e)
        {
            
            //h = int.Parse(grade.Text);
        }




      
    }
    public class MyCal
    {
        private static double Cda = .1;
        private static double Crr1 = .002;
        private static double Crr2 = .4;
        private static double m = 300;//kg mass
        private static double r = .25; //m radius
        private static double g = 9.81; // m/(s^2) gravity
        private static double area = 6;// m^2 area of solar cells
        private static double eff = .20; //effciency of the solar cells

        public static double avgRad = 0;// w/(m^2) avg radiation
        //public static double radDiff = Form1.rad - avgRad;  //w/(m^2) radiation difference of the segment
        public static double optenergy = 0;
        public static double lamda = 0;

        static NumericalDerivative diff = new NumericalDerivative();

        public static Func<double, double>force = calForce;
        public static Func<double, double> dforce = diff.CreateDerivativeFunctionHandle(force,1);
        public static Func<double[], double> energy = calEnergy;

       static double a = .6 * Cda;
       static double b = Crr2 + 2 * a * Form1.w;
       static double c = Crr1 * m * g / Math.Sqrt(1 + Math.Pow(Form1.h, 2))
                                + m * g * Form1.h / Math.Sqrt(1 + Math.Pow(Form1.h, 2))
                                + a * Math.Pow(Form1.w, 2);

        public static double calForce(double v)
        {
            b = Crr2 + 2 * a * Form1.w;
            c = Crr1 * m * g / Math.Sqrt(1 + Math.Pow(Form1.h, 2))
                                + m * g * Form1.h / Math.Sqrt(1 + Math.Pow(Form1.h, 2))
                                + a * Math.Pow(Form1.w, 2);
            return a * Math.Pow(v, 2) + b * v + c;
        }
        public static double calLamda(double[] v, Func<double, double> force, Func<double, double> dforce)
        {
            double result;
            result = Math.Pow(v[0], 2) * dforce(v[0]) + 2 * v[0] * .1765 * Math.Pow(r, 2) * force(v[0]) * dforce(v[0])
                       - .1765 * Math.Pow(r, 2) * Math.Pow(force(v[0]), 2) - avgRad * area * eff;
            return result;
        }
        public static double calEnergy(double[] v)
        {
            return a * Math.Pow(v[0], 2) + b * v[0] + c
                + .1765 * Math.Pow(r, 2) * Math.Pow(a * Math.Pow(v[0], 2) + b * v[0] + c, 2) / v[0]
                + lamda / v[0] - Form1.radDiff / v[0];

        }
        
        public static double calNewspeed(double[] v, Func<double[], double> energy, ref double optenergy)
        {
            double[] ub = new double [] {v[0] + 2.5}; // upper bound
            double[] lb = new double [] {v[0] - 2.5}; // lower bound
            double[] init = new double [] {v[0]}; // starting point 
            NelderMeadSolver mysolver = new NelderMeadSolver();
            var solution = NelderMeadSolver.Solve(energy, init, lb, ub);
            optenergy = solution.GetSolutionValue(0);
            return solution.GetValue(1);
        }



    }
}
