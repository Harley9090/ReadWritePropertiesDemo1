// Author: Harley Veillette
// Date: 2019-05-02
// Exercise: Demo of propertie
// Notes: 
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormFrontEnd
{
    //public = accessible to any librairies that we upside to this one
    public class Balloon
    {
        //create the 3 members of coulour height and diameter
        private double diameter;
        private string colour;
        //private double height;
        

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
                //validation for colors that are accepted
                //if (value == string.Empty)
                //{
                //    throw new DataException("You must enter text inside the texboxes");

                //}

                if (value.ToUpper() == "RED" || value.ToUpper() == "BLUE")
                {
                    colour = value;
                }
                else
                {
                    throw new DataException("Colour must be red or blue");
                }
            }
        }

        public double Height
        {
            //get
            //{
            //    return height;
            //}
            //set
            //{
            //    height = value;
            //}
            get;
            set;
        }

        public string BalloonName { get; set; }

        public double Diameter
        {
            //one way to do//
            get
            {
                return diameter;
            }
            set
            {
                if (string.IsNullOrEmpty(colour))
                {
                    throw new DataException("Please enter value into the textboxes");
                }
                else
                {
                    if (colour.ToUpper() == "RED")
                    {
                        if (diameter <= 12)
                        {
                            diameter = value;
                        }
                        else
                        {
                            throw new ConstraintException("The diameter must not be greater than 11");
                        }
                    }
                    else if (colour.ToUpper() == "BLUE")
                    {
                        if(diameter >= 5)
                        {
                            diameter = value;
                        }
                        else
                        {
                            throw new ConstraintException("The diameter must not be smaller than 5");

                        }
                    }
                }
                //if(colour != string.Empty)
                //{
                //    if (colour.ToUpper() == "RED" && diameter > 12)
                //    {
                //        throw new ConstraintException("The diameter must not be greater than 11");
                //    }
                //    else if (colour.ToUpper() == "BLUE" && diameter < 5)
                //    {
                //        throw new ConstraintException("The diameter must not be smaller than 5");
                //    }
                //}
                //else
                //{
                //    if(colour == string.Empty)
                //    {
                //        throw new DataException("Please enter text in textbox");
                //    }
                //}
                //diameter = value;
            }

            //other way//
            //get;
            //set;
        }    
    }
}
