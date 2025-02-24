// Written by Chloe jensrud
// 2/24/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAndAreas
{// circle subclass
    public class Circle : Shape
    { // class variables
        private double radius = 0.0;

        // gets and sets
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        // constructor calling base
        public Circle(string color, double radius) : base(color)
        {
            this.radius = radius;
        }
        // area method
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
        // ToString
        public override string ToString()
        {
            return $"{Color} Circle: \n Radius: {Radius} \n Area: {GetArea()}";
        }
    }
    //rectangle subclass
    public class Rectangle : Shape
    { // class variables
        private double height = 0.0;
        private double width = 0.0;

        // gets and sets
        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        // constructor calling base
        public Rectangle(string color, double width, double height) : base(color)
        {
            this.width = width;
            this.height = height;
        }

        // are method
        public override double GetArea()
        {
            return Width * height;
        }

        // ToString
        public override string ToString()
        {
            return $"{Color} Rectangle: \nWidth: {Width} \nHeight: {Height} \nArea: {GetArea()}";
        }
    }
}
