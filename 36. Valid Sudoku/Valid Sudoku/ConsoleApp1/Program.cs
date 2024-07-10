using System.Linq;

namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        char[][] board =
        [['5','3','.','.','7','.','.','.','.']
        ,['6','.','.','1','9','5','.','.','.']
        ,['.','9','8','.','.','.','.','6','.']
        ,['8','.','.','.','6','.','.','.','3']
        ,['4','.','.','8','.','3','.','.','1']
        ,['7','.','.','.','2','.','.','.','6']
        ,['.','6','.','.','.','.','2','8','.']
        ,['.','.','.','4','1','9','.','.','5']
        ,['.','.','.','.','8','.','.','7','9']];

        char[][] board2 =
        [['8','3','.','.' ,'7','.','.','.','.']
        ,['6','.','.','1','9','5','.','.','.']
        ,['.','9','8','.','.','.','.','6','.']

        ,['8','.','.','.','6','.','.','.','3']
        ,['4','.','.','8','.','3','.','.','1']
        ,['7','.','.','.','2','.','.','.','6']

        ,['.','6','.','.','.','.','2','8','.']
        ,['.','.','.','4','1','9','.','.','5']
        ,['.','.','.','.','8','.','.','7','9']];

        Console.WriteLine(IsValidSudoku(board));
    }

    public static bool IsValidSudoku(char[][] board)
    {
        var list = new List<(int, char)>();

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                var casa = ((i + 1) + (j + 1));
                var value = board[i][j];
                var bloco = casa / 9;
                

                if (value == '.')
                {
                    list.Add((bloco, '.'));
                    continue;
                }

                if (value == '9')
                {
                    list.Add((bloco, '.'));
                    continue;
                }


                if (list.Contains((bloco, value)))
                    return false;

                list.Add((bloco, value));
            }
        }

        return true;
    }
}
