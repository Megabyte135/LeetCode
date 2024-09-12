public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        if (!(IsValidColumns(board) && IsValidRows(board) && IsValidBoxes(board)))
            return false;

        return true;
    }

    public bool IsValidBoxes(char[][] board)
    {
        int row = 1;
        int col = 1;
        while (row <= 3)
        {
            while (col <= 3)
            {
                var validityMatrix = GetValidityMatrix();
                for (int i = (col - 1) * 3; i < (col) * 3; i++)
                {
                    for (int j = (row-1) * 3; j < (row) * 3; j++)
                    {
                        if (!CheckElement(board[i][j], validityMatrix))
                            return false;
                    }
                }
                col++;
            }
            col = 1;
            row++;
        }
        return true;
    }

    public bool IsValidColumns(char[][] board)
    {
        for (int i = 0; i < board.Length; i++)
        {
            var validityMatrix = GetValidityMatrix();
            for (int j = 0; j < board.Length; j++)
            {
                if (CheckElement(board[j][i], validityMatrix))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
        }
        return true;
    }

    public bool IsValidRows(char[][] board)
    {
        for (int i = 0; i < board.Length; i++)
        {
            var validityMatrix = GetValidityMatrix();
            for (int j = 0; j < board.Length; j++)
            {
                if (CheckElement(board[i][j], validityMatrix))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
        }
        return true;
    }

    public Dictionary<char, bool> GetValidityMatrix()
    {
        return new Dictionary<char, bool>
        {
            {'1', true},
            {'2', true},
            {'3', true},
            {'4', true},
            {'5', true},
            {'6', true},
            {'7', true},
            {'8', true},
            {'9', true}
        };
    }

    public bool CheckElement(char element, Dictionary<char, bool> validityMatrix)
    {
        if (element == '.')
        {
            return true;
        }
        else if (validityMatrix[element])
        {
            validityMatrix[element] = false;
            return true;
        }
        else
        {
            return false;
        }
    }
}