using System.Collections.Generic;
using ShapeRunner.Character;

namespace ShapeRunner.Accelerator
{
    public static class ShapesAccelerators
    {
        public static Dictionary<Shape, IAccelerator> Map = new Dictionary<Shape, IAccelerator>() {
            [Shape.Square] = new Linear(), 
            [Shape.Round] = new Linear(),
            [Shape.Triangle] = new Quadratic(), 
        };
    }
}