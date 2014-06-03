using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KukataIsDancing
{
    class KukataIsDancing
    {
        static void Main(string[] args)
        {
            int numberOfDances = int.Parse(Console.ReadLine());
            string[] dances = new string[numberOfDances];

            for (int z = 0; z < numberOfDances; z++)
            {
                dances[z] = Console.ReadLine();
            }

            int row = 0;
            int col = 0;
            for (int i = 0; i < dances.Length; i++)
            {
                string danceMoves = dances[i];
                row = 1;
                col = 1;
                bool up = true;
                bool down = false;
                bool left = false;
                bool right = false;

                for (int q = 0; q < danceMoves.Length; q++)
                {
                    switch (danceMoves[q])
                    {
                        case 'W':
                            if (up)
                            {
                                if (row > 0)
                                {
                                    row--;
                                }
                                else
                                {
                                    row = 2;
                                }
                            }
                            if (down)
                            {
                                if (row < 2)
                                {
                                    row++;
                                }
                                else
                                {
                                    row = 0;
                                }
                            }
                            if (left)
                            {
                                if (col > 0)
                                {
                                    col--;
                                }
                                else
                                {
                                    col = 2;
                                }
                            }
                            if (right)
                            {
                                if (col < 2)
                                {
                                    col++;
                                }
                                else
                                {
                                    col = 0;
                                }
                            }
                            break;
                        case 'L':
                            if (up)
                            {
                                up = false;
                                down = false;
                                left = true;
                                right = false;
                                break;
                            }
                            if (down)
                            {
                                up = false;
                                down = false;
                                left = false;
                                right = true;
                                break;
                            }
                            if (left)
                            {
                                up = false;
                                down = true;
                                left = false;
                                right = false;
                                break;
                            }
                            if (right)
                            {
                                up = true;
                                down = false;
                                left = false;
                                right = false;
                                break;
                            }
                            break;
                        case 'R':
                            if (up)
                            {
                                up = false;
                                down = false;
                                left = false;
                                right = true;
                                break;
                            }
                            if (down)
                            {
                                up = false;
                                down = false;
                                left = true;
                                right = false;
                                break;
                            }
                            if (left)
                            {
                                up = true;
                                down = false;
                                left = false;
                                right = false;
                                break;
                            }
                            if (right)
                            {
                                up = false;
                                down = true;
                                left = false;
                                right = false;
                                break;
                            }
                            break;
                        default:
                            break;
                    }
                }
                Console.WriteLine(GetColor(row, col));
            }
        }

        private static string GetColor(int row, int col)
        {
            char[,] square = 
            {
            {
                'R',
                'B',
                'R'
            },
            {
                'B',
                'G',
                'B'
            },
            {
                'R',
                'B',
                'R'
            }
            };

            char color = square[row, col];
            if (color == 'R')
            {
                return "RED";
            }
            else if (color == 'G')
            {
                return "GREEN";
            }
            else
            {
                return "BLUE";
            }
        }
    }
}
