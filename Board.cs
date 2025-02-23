﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C_mmoPart2
{
    internal class Board
    {
        const char CIRCLE = '\u25cf';

        public TileType[,] _tile;
        public int _size;

        public enum TileType
        {
            Empty,
            Wall

        }

        public void Initialize(int size)
        {

            _tile = new TileType[size, size];
            _size = size;

            for (int y = 0; y < _size; y++)
            {
                for (int x = 0; x < _size; x++)
                {
                    if (x == 0 || x == _size - 1 || y == 0 || y == _size - 1)
                        _tile[y, x] = TileType.Wall;

                    else
                        _tile[y, x] = TileType.Empty;
                    
                }
            }
        }
            public void Render()
            {
            ConsoleColor prevColor = Console.ForegroundColor;

                for (int y = 0; y < _size; y++)
                {
                    for (int x = 0; x < _size; x++)
                    {
                        Console.ForegroundColor = GetTileColor(_tile[y, x]);

                        //Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(CIRCLE);
                    }
                    Console.WriteLine();
                }

                Console.ForegroundColor = prevColor;
            }

        ConsoleColor GetTileColor(TileType type)
        { 
            switch(type)
            {
                case TileType.Empty:
                    return ConsoleColor.Green;
                    
                case TileType.Wall:
                    return ConsoleColor.Red;
                default:
                    return ConsoleColor.Green;
            }

        }

    }
}
