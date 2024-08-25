public class Solution
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        IList<IList<int>> result = new List<IList<int>>();
        Recursive(result, new List<int>(), candidates, target, 0, 0);

        return result;
    }

    void Recursive(IList<IList<int>> result, IList<int> temp, int[] candidates, int target, int c, int i)
    {
        if (c == target)
        {
            result.Add(temp.ToArray());

            return;
        }

        while (c < target && i < candidates.Length)
        {
            temp.Add(candidates[i]);
            Recursive(result, temp, candidates, target, c + candidates[i], i);
            temp.RemoveAt(temp.Count - 1);
            i++;
        }
    }
}