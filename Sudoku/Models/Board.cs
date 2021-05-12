using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku.Models
{
    public class Board
    {
        public List<Row> _rows { get; set; }
    }

    public class Row
    {
        public List<Square> _squares { get; set; }
    }

    public class Square
    {
        public int square { get; set; }
    }
}
