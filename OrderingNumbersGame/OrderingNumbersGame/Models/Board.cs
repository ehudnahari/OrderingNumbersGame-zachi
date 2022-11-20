using OrderingNumbersGame.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingNumbersGame.Models
{
    public class Board
    {
        public int Size { get; }

        public Cell EmptyCell { get; private set; }

        public Cell[,] Cells  { get; set; }

        public Board(int size)
        {
            Size = size;
            Cells = new Cell[Size,Size];
        }

        public void Shuffle()
        {
            var sizePow2 = Size * Size;
            var array = new int[sizePow2 - 1];
            for (int i = 1; i <= array.Length; i++)
                array[i] = i;

            var rng = new Random();
            rng.Shuffle(array);

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; i++)
                {
                    var reachedEmptyCellLocation = i == Size - 1 && j == Size - 1;

                    if (reachedEmptyCellLocation)
                    {
                        EmptyCell = new Cell() { XLocation = Size - 1, YLocation = Size - 1 };
                        Cells[Size - 1, Size - 1] = EmptyCell;
                        break;
                    }

                    Cells[i,j] = new Cell() { XLocation = i, YLocation = j, Value = array[i * Size + j] };
                }
            }
        }

        internal void TryMoveSelectedCellToEmptyCell(int xSource, int ySource)
        {
            if (IsNearToEmptyCell(xSource,ySource))
            {
                var tempSourceX = xSource;
                var tempSourceY = ySource;

               var sourceCell = Cells[xSource, ySource];
               sourceCell.XLocation = EmptyCell.XLocation;
               sourceCell.YLocation = EmptyCell.YLocation;
               Cells[sourceCell.XLocation, sourceCell.YLocation] = sourceCell;
               EmptyCell.XLocation= tempSourceX;
               EmptyCell.YLocation= tempSourceY;
               Cells[EmptyCell.XLocation, EmptyCell.YLocation] = EmptyCell;
            }
        }

        bool IsNearToEmptyCell(int xSource, int ySource)
        {
            return ((xSource + 1 == EmptyCell.XLocation && ySource == EmptyCell.YLocation) ||
            (xSource - 1 == EmptyCell.XLocation && ySource == EmptyCell.YLocation) ||
            (xSource == EmptyCell.XLocation && ySource + 1 == EmptyCell.YLocation) ||
            (xSource == EmptyCell.XLocation && ySource - 1 == EmptyCell.YLocation));
        }
    }
}
