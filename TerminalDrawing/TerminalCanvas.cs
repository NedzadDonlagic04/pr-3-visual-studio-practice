﻿using System.Drawing;
using CharMatrixExtensions;

namespace TerminalDrawing
{
    internal class TerminalCanvas
    {
        private readonly char[,] _matrix;
        private readonly string _borderTopBottom;
        private readonly int _rows; 
        private readonly int _cols; 

        public TerminalCanvas(int width, int height) {
            _rows = height;
            _cols = width;

            _matrix = new char[_rows, _cols];
            _matrix.Fill(' ');
            
            _borderTopBottom = new string('-', _cols + 2);
        }

        public void PrintCanvas() {
            Console.WriteLine(_borderTopBottom);
            for (int i = 0; i < _rows; ++i)
            {
                Console.Write('|');
                for (int ii = 0; ii < _cols; ++ii)
                {
                    Console.Write(_matrix[i, ii]);
                }
                Console.WriteLine('|');
            }
            Console.WriteLine(_borderTopBottom);
        }

        public void SetPixel(Point position, char value) {
            _matrix[position.Y, position.X] = value;
        }

        public void SaveToFile(string filePath) { 
            using var streamWriter = File.CreateText(filePath);

            for (int i = 0; i < _rows; ++i)
            {
                for (int ii = 0; ii < _cols; ++ii)
                {
                    streamWriter.Write(_matrix[i, ii]);
                }
                
                if (i + 1 < _rows) {
                    streamWriter.WriteLine();
                }
            }
        }
    }
}
