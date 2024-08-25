public class Solution
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        var width = matrix[0].Length;
        var height = matrix.Length;
        var lenght = width * height;

        var result = new List<int>(lenght);
        var x = 0;
        var y = 0;
        var yy = 1;
        var xx = 1;

        while (result.Count < lenght)
        {
            result.Add(matrix[y][x]);

            if (y == yy - 1 && x < width - xx)
            {
                x++;
            }
            else if (x == width - xx && y < height - yy)
            {
                y++;
            }
            else if (x > xx - 1)
            {
                x--;
            }
            else if (y > yy)
            {
                y--;
                if (y == yy && x == xx - 1)
                {
                    xx++;
                    yy++;
                }
            }
        }

        return result;
    }
}