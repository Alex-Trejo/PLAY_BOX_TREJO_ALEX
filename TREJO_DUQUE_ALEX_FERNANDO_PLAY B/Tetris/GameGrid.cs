namespace Tetris
{
    public class Position
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public Position (int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
TREJO DUQUE ALEX FERNANDO :47
namespace Tetris
{
    public class GameGrid
    {
        private readonly int[,] grid;
        public int Rows { get; }
        public int Columns { get; }

        public int this[int r, int c]
        {
            get => grid[r, c];
            set => grid[r, c] = value;
        }

        public GameGrid(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            grid = new int[rows, columns];
        }

        public bool IsInside (int r, int c) { }
    }
}
