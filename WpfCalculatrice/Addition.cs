﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCalculatrice
{
    /// <summary>
    /// simple addition
    /// </summary>
    class Addition
    {
        private double val1;
        private double val2;

        /// <summary>
        /// Constructeur 
        /// </summary>
        /// <param name="val1">First value double</param>
        /// <param name="val2">Second value double</param>
       public Addition(double val1,double val2)
        {
            this.val1 = val1;
            this.val2 = val2;
        }

        /// <summary>
        /// Add the two setted values 
        /// </summary>
        /// <returns>Result of sum</returns>
       public double Addtionne()
        {
            return val1 + val2;
        }

        /// <summary>
        /// Get the first value
        /// </summary>
        /// <returns>value</returns>
        public double getVal1()
        {
            return this.val1;
        }

        /// <summary>
        /// Get the second value
        /// </summary>
        /// <returns>value</returns>
        public double getVal2()
        {
            return this.val2;
        }


        /// <summary>
        /// Set the first value
        /// </summary>
        /// <param name="val">value</param>
        public void setVal1(double val)
        {
            this.val1 = val;
        }

        /// <summary>
        /// Set the second value
        /// </summary>
        /// <param name="val">value</param>
        public void setVal2(double val)
        {
            this.val2 = val;
        }

        public string Affiche()
        {
            return "the sum of " + val1.ToString()
                + " and " + val2.ToString()
                + " is " + Addtionne().ToString();
        }

    }
}
