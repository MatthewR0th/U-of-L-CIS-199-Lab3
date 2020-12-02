//Grading ID: K1791
//Lab 3
//20 September 2020
//CIS 199-02
//This lab calculates the diameter, surface area, and volume from the radius of a sphere.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Lab3
{
    public partial class Lab3 : Form
    {
        public Lab3()
        {
            InitializeComponent();
        }
        //IGNORE THIS, I CAN'T REMOVE IT WITHOUT EVERYTHING BREAKING!
        private void pictureBox1_Click(object sender, EventArgs e) 
        {

        }
        
        //When the calculation button is pressed, the calculations below will take place.
        private void calculationButton_Click(object sender, EventArgs e) 
        {

            double Two = 2; //Two is used a lot in these calculations 
         
            double four = 4; //The surface area and volume equations involve 4
            double three = 3; //The volume equation involves 3

            string input2;
            input2 = radiusOfSphereTextbox.Text; //The value that the user enters is assigned as an input

          double radiusOfSphere = double.Parse(input2);

            double diameterCalculation = Two * radiusOfSphere; //Calculates diameter and assigns the result as a double.
            double surfaceAreaCalculation = four * Math.PI * Math.Pow(radiusOfSphere, 2); //Calculates surface area and assigns the result as a double.
            double volumeCalculation = (four * Math.PI * Math.Pow(radiusOfSphere, 3))/three ; //Calculates volume and assigns the result as a double.

            diameterOutput.Text = diameterCalculation.ToString("N2"); //Displays the diameter value, as calculated above, to two decimal places
                surfaceAreaOutput.Text = surfaceAreaCalculation.ToString("N2"); //Displays the surface area value, as calculated above, to two decimal places
            volumeOutput.Text = volumeCalculation.ToString("N2"); //Displays the volume value, as calculated above, to two decimal places

            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Matthew\OneDrive - University of Louisville\lab3\Lab3\Lab3\BlackPhillip.wav");
            splayer.Play();

        }

        private void radiusOfSphereTextbox_TextChanged(object sender, EventArgs e)
        {
            int
        }
    }
}
