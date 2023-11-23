using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class GraphicsEditor
    {
        private List<GraphicPrimitive> primitives;

        public GraphicsEditor()
        {
            primitives = new List<GraphicPrimitive>();
        }

        public void AddPrimitive(GraphicPrimitive primitive)
        {
            primitives.Add(primitive);
        }

        public void DrawAll()
        {
            foreach (var primitive in primitives)
            {
                primitive.Draw();
            }
        }

        public void MoveAll(int x, int y)
        {
            foreach (var primitive in primitives)
            {
                primitive.Move(x, y);
            }
        }

        public void ScaleAll(float factor)
        {
            foreach (var primitive in primitives)
            {
                primitive.Scale(factor);
            }
        }
    }
}
