// Class for Display

using System;
using System.Text;

namespace CellPhone
{
    public class Display
    {
        private int size;
        private int? numberOfColors; // using nullable type

        public Display(int size) : this(size, null)
        { 
        }

        public Display(int size, int? numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        
        public int Size // Size property
        {
            get { return this.size; }

            set  // validation of the Size
            {
                if (value >= 0 || value == null) 
                {
                    this.size = value; 
                }
                else
                {
                    throw new ArgumentException("The size can't be null!");
                }
            }
        }

        public int? NumberOfColors // Colors property
        {
            get { return this.numberOfColors; }

            set  // validation of Number of colors
            {
                if (value >= 0 || value == null)
                {
                    this.numberOfColors = value; 
                }
                else
                {
                    throw new ArgumentException("The color can't be null!");
                }
            }
        }

        // method for displaying
        public override string ToString()
        {
            StringBuilder displayText = new StringBuilder();
            displayText.AppendLine("--Display Test--");
            displayText.AppendLine(this.size.ToString());
            displayText.AppendLine(this.numberOfColors.ToString());
            return displayText.ToString();
        }
    }
}