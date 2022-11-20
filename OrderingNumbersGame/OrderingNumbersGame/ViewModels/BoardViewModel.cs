using OrderingNumbersGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingNumbersGame.ViewModels
{
    public class BoardViewModel
    {
        private Board _board;

        private int _size;

        public int Size
        {
            get { return _size; }
            set
            {
                _size = value;
            }
        }

        public BoardViewModel(int size)
        {
            _board = new Board(size);
        }

        public void Shuffle()
        {
            _board.Shuffle();
        }

        internal void TryMoveSelectedCellToEmptyCell(int xSource, int ySource)
        {
            _board.TryMoveSelectedCellToEmptyCell(xSource, ySource);

        }
    }
}
