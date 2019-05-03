using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormFrontEnd
{
    public partial class Form1 : Form
    {
        Balloon myFirstBalloon;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            try
            {
                //create instance of balloon, not living in memory yet
                //must instanciate the object
                myFirstBalloon = new Balloon()
                {
                    Colour = txtColor.Text.Trim(),
                    Diameter = Convert.ToDouble(txtDiameter.Text),
                    
                    Height = Convert.ToDouble(txtHeight.Text)

                            /*same as inside the new balloon*/
                    //myFirstBalloon.Colour = txtColor.Text.Trim();
                    //myFirstBalloon.Diameter = Convert.ToDouble(txtDiameter.Text);
                    //myFirstBalloon.Height = Convert.ToDouble(txtHeight.Text);
                            /*                              */
                    //now it is in memory because of the word "new"
                };
            }
            catch(DataException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            //get access to balloon properties using the gets
            lblOutput.Text = 
                $"Colours: {myFirstBalloon.Colour} \n" +
                $"Diameters: {myFirstBalloon.Diameter.ToString()} \n" +
                $"Height: {myFirstBalloon.Height.ToString()} \n";
        }
    }
}
