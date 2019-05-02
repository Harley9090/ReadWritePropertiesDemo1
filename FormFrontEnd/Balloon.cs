// Author: Harley Veillette
// Date: 2019-05-02
// Exercise: Demo of propertie
// Notes: 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormFrontEnd
{
    //public = accessible to any librairies that we upside to this one
    public class Balloon
    {
        //create the 3 members of coulour height and diameter
        private string colour;
        private double height;
        private double diameter;


        //create first propertie
        public string Colour
        {
            //give access to private member via the propertie
            get
            {
                return colour;
            }
            set
            {
                colour = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public double Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                diameter = value;
            }
        }    
    }
}
