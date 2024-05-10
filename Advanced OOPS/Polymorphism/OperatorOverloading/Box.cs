using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Box
    {
        private int _length;
        private int _width;
        private int _height;

        public Box()
        {

        }

        public Box(int length,int height, int width)
        {
            _length = length;
            _height = height;
            _width = width;
        }

        public double CalculateVolume()
        {
            return _length*_height*_width;
        }

        public static Box operator+(Box box1, Box box2)
        {
            Box box = new Box();
            box._length = box1._length + box2._length;
            box._height = box1._height;
            box._width = box1._width;
            return box;
        }
    }
}