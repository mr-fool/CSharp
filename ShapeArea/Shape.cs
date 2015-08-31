using System;

namespace ShapeArea
{
    class Shape
    {
        protected int width;
        protected int height;

        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
    }
    class Rectange : Shape
    {
        public int getArea()
        {
            return (width * height);
        }
    }
    class Triangle : Shape
    {
        public double getArea()
        {
            return (0.5 * width * height);
        }
    }
    class Circle
    {
        private int radius;
        public void setRadius(int r)
        {
            radius = r;
        }
        public double getArea()
        {
            return (Math.PI * radius * radius);
        }
    }
    class UserInput
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the shape type");
            string type = Convert.ToString(Console.ReadLine());
            if (type.ToLower().Equals("rectangle")){
                Rectange Rect = new Rectange();
                Console.WriteLine("Please enter the width");
                Rect.setWidth(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Please enter the height");
                Rect.setHeight(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Total area: {0}", Rect.getArea());
                Console.ReadKey();
            }
            if (type.ToLower().Equals("triangle"))
            {
                Triangle Tri = new Triangle();
                Console.WriteLine("Please enter the width");
                Tri.setWidth(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Please enter the height");
                Tri.setHeight(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Total area: {0}", Tri.getArea());
                Console.ReadKey();
            }
            if (type.ToLower().Equals("circle"))
            {
                Circle Cir = new Circle();
                Console.WriteLine("Please enter the radius");
                Cir.setRadius(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Total area: {0}", Cir.getArea());
                Console.ReadKey();
            }
        }
    }
}
