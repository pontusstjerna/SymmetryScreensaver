using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymmetryScreensaver
{
    class Edge
    {
        public enum Colors { BLUE, GREEN, RED, YELLOW, PURPLE, CYAN, RAINBOW}

        public float Thickness { get; set; } = 0.13f;
        public bool ChangeColorEnabled { get; set; } = true;
        public int[] rgbColor { set; get; }
        public Point Start { get; }
        public Point End { get; }

        private int alpha = 255;
        private int change = 1;
        private int rSpeed = 6;
        private bool showRgb = false;
        private int[] cIntervals;

        private Random rand = new Random();
        private int speed;

        public Edge(Point start, Point end)
        {
            cIntervals = new int[] {
                100, 130,  //Red min max
                120, 150,  //Green min max
                200, 250}; //Blue min max

            rgbColor = new int[] { cIntervals[1], cIntervals[3], cIntervals[5] };

            speed = rand.Next(rSpeed);

            this.Start = start;
            this.End = end;
        }

        public int GetAlpha()
        {
            return ColorSafe(alpha);
        }

        private int ColorSafe(int colValue)
        {
            if (colValue > 255)
            {
                return 255;
            }
            else if (colValue < 1)
            {
                return 1;
            }
            return colValue;
        }

        public void ChangeColor()
        {
            for (int i = 0; i < rgbColor.Length && ChangeColorEnabled; i++)
            {
                if (rgbColor[i] < cIntervals[i * 2])
                {
                    rgbColor[i] += rand.Next(speed + 1) + speed;
                }
                else if (rgbColor[i] > cIntervals[i * 2 + 1])
                {
                    rgbColor[i] -= rand.Next(speed + 1) + speed;
                }
                else
                {
                    rgbColor[i] += change * rand.Next(speed + 1);
                }
            }

            alpha += change * speed;

            if (alpha > 250)
            {
                change = -1;
                speed = rand.Next(rSpeed);
            }
            else if (alpha < 10)
            {
                change = 2;
                speed = rand.Next(rSpeed);
            }
        }

        public void SetColor(Colors color)
        {

            switch (color)
            {
                case Colors.BLUE: 
                    cIntervals = new int[]{70, 130, //Red min max
                        120, 160,  //Green min max
                        200, 250};//Blue min max};
                    break;
                case Colors.GREEN:
                    cIntervals = new int[]{30, 100, //Red min max
                        150, 250,  //Green min max
                        100, 140};//Blue min max};
                    break;
                case Colors.RED:
                    cIntervals = new int[]{180, 250, //Red min max
                        50, 90,  //Green min max
                        50, 90};//Blue min max};
                    break;
                case Colors.YELLOW:
                    cIntervals = new int[]{190, 250, //Red min max
                        100, 250,  //Green min max
                        10, 80};//Blue min max};
                    break;
                case Colors.PURPLE:
                    cIntervals = new int[]{140, 250, //Red min max
                        50, 120,  //Green min max
                        150, 250};//Blue min max};
                    break;
                case Colors.CYAN:
                    cIntervals = new int[]{50, 100, //Red min max
                        100, 250,  //Green min max
                        150, 250};//Blue min max};
                    break;
                case Colors.RAINBOW:
                    cIntervals = new int[]{5, 250, //Red min max
                        5, 250,  //Green min max
                        5, 250};//Blue min max};
                    break;
            }
            rgbColor = new int[] { cIntervals[1], cIntervals[3], cIntervals[5] };
        }
    }
}
