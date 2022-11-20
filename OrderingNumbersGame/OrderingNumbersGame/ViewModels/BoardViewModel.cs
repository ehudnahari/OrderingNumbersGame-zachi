using OrderingNumbersGame.Models;
using OrderingNumbersGame.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingNumbersGame.ViewModels
{
	public class BoardViewModel : NotificationObject
	{
		private int _size;
		private Board _board;

		public Board Board
		{
			get => _board;
			set { _board = value; OnPropertyChanged(() => Board); }
		}

		public int Size
		{
			get { return _size; }
			set
			{
				_size = value; OnPropertyChanged(() => Size);
			}
		}


		public BoardViewModel(int size)
		{
			Board = new Board(size);
		}

		public void Shuffle()
		{
			Board.Shuffle();
		}

		internal void TryMoveSelectedCellToEmptyCell(int xSource, int ySource)
		{
			// Board.TryMoveSelectedCellToEmptyCell(xSource, ySource);

		}
	}
}
