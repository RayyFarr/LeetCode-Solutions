using System.Numerics;

Dictionary<int, int> squareOffsets = new Dictionary<int, int> {
    {0, 0  }, {1, 1  }, {2, 2  },
    {3, 9  }, {4, 10 }, {5, 11 },
    {6, 18 }, {7, 19 },{8, 20 }
};


//May be optimizable.
bool IsValidSudoku(char[][] board)
{
    for (int i = 0; i < 9; i++)
    {
        HashSet<char> visited_row = new HashSet<char>();
        HashSet<char> visited_col = new HashSet<char>();

        //Rows.
        for (int y = 0; y < 9; y++)
        {
            if (board[y][i] != '.' && visited_row.Contains(board[y][i])) return false;

            visited_row.Add(board[y][i]);
        }

        //Columns.
        for (int x = 0; x < 9; x++)
        {
            if (board[i][x] != '.' && visited_col.Contains(board[i][x])) return false;

            visited_col.Add(board[i][x]);
        }
    }


    for (int i = 0; i < 9; i++)
    {
        HashSet<char> square3x3 = new HashSet<char>();
        for (int j = 0; j < 9; j++)
        {
            int index = (i/3)*18 +  i * 3 + squareOffsets[j];
            
            char val = board[index/9][index%9];

            if (val != '.' &&  square3x3.Contains(val)) return false;

            if (val != '.') square3x3.Add(val);
        }
    }

    return true;
}
char[][] sudoku = new char[][] {
    new char[] {'.','.','.','.','5','.','.','1','.'},
    new char[] {'.','4','.','3','.','.','.','.','.'},
    new char[] {'.','.','.','.','.','3','.','.','.'},
    new char[] {'8','.','.','.','.','.','.','2','.'},
    new char[] {'.','.','2','.','7','.','.','.','.'},
    new char[] {'.','1','5','.','.','.','.','.','.'},
    new char[] {'.','.','.','.','.','2','.','.','.'},
    new char[] {'.','2','.','9','.','.','.','.','.'},
    new char[] {'.','.','4','.','.','.','.','.','.'}

};

Console.WriteLine(IsValidSudoku(sudoku));
/*
 * [
 * [".",".",".",".","5",".",".","1","."],
 * [".","4",".","3",".",".",".",".","."],
 * [".",".",".",".",".","3",".",".","1"],
 * ["8",".",".",".",".",".",".","2","."],
 * [".",".","2",".","7",".",".",".","."],
 * [".","1","5",".",".",".",".",".","."],
 * [".",".",".",".",".","2",".",".","."],
 * [".","2",".","9",".",".",".",".","."],
 * [".",".","4",".",".",".",".",".","."]
 * ]
 */