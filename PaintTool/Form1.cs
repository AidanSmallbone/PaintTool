using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintTool
{
    public partial class Form1 : Form
    {
        
        Point lastPoint = Point.Empty; //begin keeping track of the cursor location

        bool isMouseDown; //begin keeping track of whether mouse1 is clicked

        int penSize; //variable to set pen size in pixels
        int lineSize; //variable to set line size in pixels
        int elipseSize; //variable to set elipse size in pixels
        int rectangleSize; //variable to set rectangle size in pixels

        string penColor; //variable to set pen color (allows for web colors, rgb values, and system colors)
        string fillColor; //variable to set fill color (allows for web colors, rgb values, and system colors)
        string lineColor; //variable to set line color (allows for web colors, rgb values, and system colors)
        string elipseColor; //variable to set elipse color (allows for web colors, rgb values, and system colors)
        string rectangleColor; //variable to set rectangle color (allows for web colors, rgb values, and system colors)

        string selectedTool; //checks which radio button is depressed to set the tool

        public Form1()
        {
            InitializeComponent();
         
        }

        private void penRadioButton_Load(object sender, EventArgs e) //upon the form loading, this will check to see which tool is selected
        {
            if (penRadioButton.Checked == true) //checks to see if the tool is selected
            {
                selectedTool = "pen"; //sets the string that keeps track of the selected tool to pen
            }

        }

        private void fillRadioButton_Load(object sender, EventArgs e) //upon the form loading, this will check to see which tool is selected
        {
            if (fillRadioButton.Checked == true) //checks to see if the tool is selected
            {
                selectedTool = "fill"; //sets the string that keeps track of the selected tool to fill
            }
        }

        private void lineRadioButton_Load(object sender, EventArgs e) //upon the form loading, this will check to see which tool is selected
        {
            if (lineRadioButton.Checked == true) //checks to see if the tool is selected
            {
                selectedTool = "line"; //sets the string that keeps track of the selected tool to line
            }
        }

        private void elipseRadioButton_Load(object sender, EventArgs e) //upon the form loading, this will check to see which tool is selected
        {
            if (elipseRadioButton.Checked == true) //checks to see if the tool is selected
            {
                selectedTool = "elipse"; //sets the string that keeps track of the selected tool to elipse
            }
        }

        private void rectangleRadioButton_Load(object sender, EventArgs e) //upon the form loading, this will check to see which tool is selected
        {
            if (rectangleRadioButton.Checked == true) //checks to see if the tool is selected
            {
                selectedTool = "rectangle"; //sets the string that keeps track of the selected tool to rectangle
            }
        }

        private void paintBox_MouseDown(object sender, MouseEventArgs e) //event keeps track of whether mouse1 is pressed
        {

            lastPoint = e.Location; //sets the point mousepos to current mouse position
            isMouseDown = true; //sets the bool ismouseclicked to true -- it is

        }

        private void paintBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown == true) //checks to see if mouse1 is down

            {

                if (lastPoint != null) //this checks to see if we've moved the mouse so we don't waste resources making a bitmap before needed

                {

                    if (paintBox.Image == null) //this makes sure that we haven't already created a bitmap

                    {

                        Bitmap bmp = new Bitmap(paintBox.Width, paintBox.Height); //creates a bitmap to draw on at the size of our panel
                        paintBox.Image = bmp; //gives paintBox a value so that we don't keep making new bitmaps

                    }

                    using (Graphics g = Graphics.FromImage(paintBox.Image)) //this turns out new bitmap into a graphics object we can edit

                    {
                          

                      switch(selectedTool) //checks which tool we have selected, then spawns the correct tool within the graphics engine
                        {
                            case "pen": //if pen is selected
                                    g.DrawLine(new Pen(Color.FromName(penColor), width: 2), lastPoint, e.Location); //create a pen tool
                                break;

                            case "fill": //if fill is selected



                                break;

                            case "line": //if line is selected



                                break;

                            case "elipse": //if elipse is selected



                                break;

                            case "rectangle": //if rectangle is selected



                                break;
                        }

                    }

                    paintBox.Refresh(); //refreshes the picturebox once we're done making it into a graphics object
                    lastPoint = e.Location; //keeps setting the lastPoint var to current mouse position

                }

            }

        }

        private void paintBox_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false; //if the user lets go of mouse1 it is no longer down
            lastPoint = Point.Empty; //stops keeping track of mouse position since we're not using it anymore
        }

        private void penColorSelector_SelectedIndexChanged(object sender, EventArgs e) //event occurs when selection from dropdown is changed
        {
            penColor = penColorSelector.SelectedItem.ToString(); //set the variable pencolor to the selected color
        }

        private void fillColorSelector_SelectedIndexChanged(object sender, EventArgs e) //event occurs when selection from dropdown is changed
        {
            fillColor = fillColorSelector.SelectedItem.ToString(); //set the variable fillcolor to the selected color
        }

        private void lineColorSelector_SelectedIndexChanged(object sender, EventArgs e) //event occurs when selection from dropdown is changed
        {
            lineColor = lineColorSelector.SelectedItem.ToString(); //set the variable linecolor to the selected color
        }

        private void elipseColorSelector_SelectedIndexChanged(object sender, EventArgs e) //event occurs when selection from dropdown is changed
        {
            elipseColor = elipseColorSelector.SelectedItem.ToString(); //set the variable elipsecolor to the selected color
        }

        private void rectangleColorSelector_SelectedIndexChanged(object sender, EventArgs e) //event occurs when selection from dropdown is changed
        {
            rectangleColor = rectangleColorSelector.SelectedItem.ToString(); //set the variable rectanglecolor to the selected color
        }
    }

}

//g.DrawLine(new Pen(Color.Black, width: 10), lastPoint, e.Location); //this creates our tool (for now a 2px black pen, i plan on using variables to change these values)