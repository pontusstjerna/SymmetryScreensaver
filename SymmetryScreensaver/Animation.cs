using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymmetryScreensaver
{
    class Animation
    {
        public Edge[] Edges { get; set; }

        private int[] origin = { 0, 0 };
        private Point[] vertices;
        private int scale = 1;

        public Animation(int originX, int originY)
        {
            this.origin[0] = originX;
            this.origin[1] = originY;
        }

        public void CreateStdGraph(int width, int height)
        {
            Random rand = new Random();
            const int scaleF = 23;
            scale = Math.Min(width, height) / scaleF;
            int yOffset = (height / 2) - ((20 * scale) / 2);

            int x = origin[0];
            int y = origin[1] + yOffset;
            // int y = origin[1] + (20*(height/25))/8;

            vertices = new Point[]
                    {new Point(x - 5 * scale, y),    //0
                     new Point(x - 9 * scale, y + 6 * scale), //1
                     new Point(x, y + 20 * scale),    //2
                     new Point(x, y + 13 * scale),    //3
                     new Point(x + 5 * scale, y),     //4
                     new Point(x + 9 * scale, y + 6 * scale)};//5

            Edges = new Edge[]{
                new Edge(vertices[0], vertices[1], rand.Next()),//1
                new Edge(vertices[1], vertices[2], rand.Next()),//2
                new Edge(vertices[1], vertices[3], rand.Next()),//3
                new Edge(vertices[1], vertices[4], rand.Next()),//4
                new Edge(vertices[0], vertices[3], rand.Next()),//5
                new Edge(vertices[0], vertices[4], rand.Next()),//6
                new Edge(vertices[0], vertices[5], rand.Next()),//7
                new Edge(vertices[4], vertices[3], rand.Next()),//8
                new Edge(vertices[5], vertices[3], rand.Next()),//9
                new Edge(vertices[4], vertices[5], rand.Next()),//10
                new Edge(vertices[5], vertices[2], rand.Next()),//11
                new Edge(vertices[3], vertices[2], rand.Next())//12
        };
        }

        public float GetThickness(Edge edge)
        {
            return edge.Thickness * scale;
        }

        public void SetThickness(float thickness)
        {
            for (int i = 0; i < Edges.Length; i++)
            {
                Edges[i].Thickness = thickness * scale;
            }
        }

        public void SetColor(Edge.Colors color)
        {
            for (int i = 0; i < Edges.Length; i++)
            {
                Edges[i].SetColor(color);
            }
        }

        public void EnableColorChange(bool willChange)
        {
            for (int i = 0; i < Edges.Length; i++)
            {
                Edges[i].ChangeColorEnabled = willChange;
            }
        }
    }
}
