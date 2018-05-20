using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sem3_convexHullPoints
{
    public class Point
    {
        public int X, Y;
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    class Program
    {
        //найти минимальную выпуклую облолочку
        static void Main(string[] args)
        {
            List<Point> test = new List<Point>(
                new Point[]
                    {
                        //new Point(1,1), new Point(4,3), new Point(2,0), new Point(0,0),
                        //new Point(4, 1), new Point(3, 2), new Point(3, 4), new Point(1,3),
                        //new Point(2,3)
                    });

            Console.WriteLine("Minimal Convex Hull");
            foreach (Point point in ConvexHull(test))
            {
                Console.WriteLine("{0}  {1}",point.X, point.Y);
            }

            Console.ReadKey();

        }
        
        public static List<Point> ConvexHull(List<Point> points)
        {
            //if points < 3
            if (points.Count < 3)
            {
                throw new ArgumentException("At least 3 points reqired", "points");
            }
            //list of convex hull points
            List<Point> hull = new List<Point>();

            // get leftmost point
            Point vPointOnHull = points.Where(p => p.X == points.Min(min => min.X)).First();

            Point vEndpoint;
            do
            {
                hull.Add(vPointOnHull);
                vEndpoint = points[0];

                for (int i = 1; i < points.Count; i++)
                {
                    //if convex hull is empty or 
                    // this point is leftmost relative to the previous point of hull
                    if ((vPointOnHull == vEndpoint)
                        || (Orientation(vPointOnHull, vEndpoint, points[i]) == -1))
                    {
                        // add to convex hull
                        vEndpoint = points[i];
                    }
                }

                vPointOnHull = vEndpoint;

            }
            // Do while the hull isnt closes
            while (vEndpoint != hull[0]);

            return hull;
        }

        private static int Orientation(Point p1, Point p2, Point p)
        {
            // Determinant
            int Orin = (p2.X - p1.X) * (p.Y - p1.Y) - (p.X - p1.X) * (p2.Y - p1.Y);
            // Orientation is to the left-hand side  
            if (Orin > 0)
                return -1; 
            // Orientation is to the right-hand side 
            if (Orin < 0)
                return 1;
            // Orientation is neutral (collinear)
            return 0; 
        }
    }
}
