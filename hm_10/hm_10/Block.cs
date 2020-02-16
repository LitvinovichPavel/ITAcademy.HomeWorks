using System;
using System.Collections.Generic;
using System.Text;

namespace hm_10
{
    class Block
    {
        int _width;
        int _length;
        int _height;
        public int GetWidth()
        {
            return _width;
        }
        public int GetLength()
        {
            return _length;
        }
        public int GetHeight()
        {
            return _height;
        }
        public int GetVolume()
        {
            return _width * _length * _height;
        }
        public int GetSurfaceArea()
        {
            return _width * _height * 6;
        }
        public Block(int[] array)
        {
            _width = array[0];
            _length = array[1];
            _height = array[2];
        }
        public void BlockMethod()
        {
            Block block = new Block(new int[] { 2, 4, 6 });
            Console.WriteLine(block.GetSurfaceArea());
            Console.WriteLine(block.GetVolume());
        }
    }
}
