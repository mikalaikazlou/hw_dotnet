using System;
using System.Collections.Generic;
using System.Text;

namespace Task8
{
    class Thing
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return "things";
        }
    }

    class Gun : Thing
    {
        public override string ToString()
        {
            return "gun";
        }
    }

    class Laptop : Thing
    {
        public override string ToString()
        {
            return "laptop";
        }
    }

    class Shoes : Thing
    {
        public override string ToString()
        {
            return "shoes";
        }
    }

    class Camera : Thing
    {
        public override string ToString()
        {
            return "camera";
        }
    }

    class MeansOfHygiene : Thing
    {
        public override string ToString()
        {
            return "means of hygiene";
        }
    }
}