using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    public enum PointColour
    {
        Red,
        Green,
        Blue
    }
    interface IReflectable
    {
        void ReflectX();
        void ReflectY();

    }


    class Point : IReflectable
    {
        public virtual bool IsOnAxis
        {
            get
            {
                if (this.X == 0 || this.Y == 0)
                {
                    return true;
                }

                return false;
            }
        }

        private decimal _x;
        private decimal _y;

        public decimal X => _x;

        public decimal Y => _y;

        public Point(decimal x)
        {
            _x = x;
            _y = 0.0m;
        }

        public Point(decimal x, decimal y)
        {
            _x = x;
            _y = y;
        }

        public void ReflectX()
        {
            _x = -X;
        }

        public void ReflectY()
        {
            _y = -Y;
        }
    }

    class ColourfulPoint : Point
    {
        public override bool IsOnAxis
        {
            get
            {
                if (this.X == 0 || this.Y == 0 && this.Colour == PointColour.Green)
                {
                    return true;
                }

                return false;
            }
        }

        private decimal _x;
        private decimal _y;
        public decimal X => _x;
        public decimal Y => _y;
        public PointColour Colour { get; set; }
        public ColourfulPoint(decimal x, decimal y, PointColour colour) : base(x, y)
        {
            _x = x;
            _y = y;
            Colour = colour;
        }

        public ColourfulPoint(decimal x) : base(x)
        {
            Colour = colour;
        }

        public void ChangeColour(PointColour colour)
        {
            this.Colour = colour;
        }

        public void NextColour()
        {
            this.Colour += 1;

            if (Convert.ToInt32(this.Colour) > 2)
            {
                this.Colour = PointColour.Red;
            }
        }
    }
}