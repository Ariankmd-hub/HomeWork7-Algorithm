using System.Collections.Generic;

namespace HomeWork7.Task8
{
    internal class Permutation
    {
        public List<string> GeneratePermutations(string str)
        {
            var result = new List<string>();
            if (string.IsNullOrEmpty(str)) return result;

            PermuteHelper(str, "", result);
            return result;
        }

        private void PermuteHelper(string remaining, string current, List<string> result)
        {
            if (remaining.Length == 0)
            {
                result.Add(current);
                return;
            }

            for (int i = 0; i < remaining.Length; i++)
            {
                char ch = remaining[i];
                string nextRemaining = remaining.Substring(0, i) + remaining.Substring(i + 1);
                PermuteHelper(nextRemaining, current + ch, result);
            }
        }
    }
}
