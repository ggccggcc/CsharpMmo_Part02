using System;
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
            if (size % 2 == 0)
                return;

            _tile = new TileType[size, size];
            _size = size;


            //GenerateByBinaryTree();
            GenerateBySideWinder();
                   


        }

        void GenerateBySideWinder()
        {
            {
                // 길을 다 막아버리는 작업
                for (int y = 0; y < _size; y++)
                {
                    for (int x = 0; x < _size; x++)
                    {
                        //if (x == 0 || x == _size - 1 || y == 0 || y == _size - 1)
                        if (x % 2 == 0 || y % 2 == 0)
                            _tile[y, x] = TileType.Wall;

                  

                        else
                            _tile[y, x] = TileType.Empty;

                    }
                }

                //랜덤으로 우 혹은 아래로 길을 뚫는 작업

                Random rand = new Random();

                for (int y = 0; y < _size; y++)
                {
                    int count = 0;
                    for (int x = 0; x < _size; x++)
                    {
                        if (x % 2 == 0 || y % 2 == 0)
                            continue;

                              if (y == _size - 2 && x == _size - 2)
                            continue;

                        if (y == _size - 2)
                        {
                            _tile[y, x + 1] = TileType.Empty;
                            continue;
                        }

                        if (x == _size - 2)
                        {
                            _tile[y + 1, x] = TileType.Empty;
                            continue;
                        }

                        if (rand.Next(0, 2) == 0)
                        {
                            _tile[y, x + 1] = TileType.Empty;
                            count++;
                        }
                        else
                        {
                            int randomIndex = rand.Next(0, count);
                            _tile[y + 1, x - randomIndex * 2] = TileType.Empty;
                            count = 1;

                        }


                    }
                }
            }
        }


        void GenerateByBinaryTree()
        {
            // 길을 다 막아버리는 작업
            for (int y = 0; y < _size; y++)
            {
                for (int x = 0; x < _size; x++)
                {
                    //if (x == 0 || x == _size - 1 || y == 0 || y == _size - 1)
                    if (x % 2 == 0 || y % 2 == 0)
                        _tile[y, x] = TileType.Wall;

                    else
                        _tile[y, x] = TileType.Empty;

                }
            }

            //랜덤으로 우 혹은 아래로 길을 뚫는 작업

            Random rand = new Random();

            for (int y = 0; y < _size; y++)
            {
                for (int x = 0; x < _size; x++)
                {
                    if (x % 2 == 0 || y % 2 == 0)
                        continue;

                    if (y == _size - 2 && x == _size - 2)
                        continue;

                    if (y == _size - 2)
                    {
                        _tile[y, x + 1] = TileType.Empty;
                        continue;
                    }

                    if (x == _size - 2)
                    {
                        _tile[y + 1, x] = TileType.Empty;
                        continue;
                    }

                    if (rand.Next(0, 2) == 0)
                    {
                        _tile[y, x + 1] = TileType.Empty;
                    }
                    else
                    {
                        _tile[y + 1, x] = TileType.Empty;

                    }


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
