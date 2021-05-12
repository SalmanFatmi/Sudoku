using System;
using System.Collections.Generic;
using System.Linq;
using Sudoku.Models;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            var sudokuBoard = new List<List<int>>
            {
                new List<int>
                {
                    5,3,4,6,7,8,9,1,2
                },
                new List<int>
                {
                    5,3,4,6,7,8,9,1,2
                }
            };
            var result = ValidateSolution(sudokuBoard);
            Console.WriteLine(result);
        }

        private static bool ValidateSolution(List<List<int>> sudokuBoard) 
        {
            var correctedList = Enumerable.Range(1, 9).ToList();

            foreach (var row in sudokuBoard)
            {
                var orderedRow = row.OrderBy(item => item);
                var isEqual = Enumerable.SequenceEqual(correctedList, orderedRow);
                if(!isEqual)
                {
                    return false;
                }
            }

            var board = new Board();

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {

                }
            }

            return true;
        }
    }
}
