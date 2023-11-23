using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GraphicsEditor editor = new GraphicsEditor();

            Circle circle = new Circle(10, 20, 5);
            Rectangle rectangle = new Rectangle(30, 40, 8, 12);
            Triangle triangle = new Triangle(50, 60, 7);

            editor.AddPrimitive(circle);
            editor.AddPrimitive(rectangle);
            editor.AddPrimitive(triangle);

            Group group = new Group(70, 80);
            group.AddPrimitive(new Circle(5, 5, 2));
            group.AddPrimitive(new Rectangle(15, 15, 3, 4));
            group.AddPrimitive(new Triangle(25, 25, 6));

            editor.AddPrimitive(group);

            editor.DrawAll();
            editor.MoveAll(5, 5);
            editor.ScaleAll(1.5f);
            editor.DrawAll();
        }
    }
}
