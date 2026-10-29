using System.Collections.Generic;

namespace HomeWork7.Task9
{
    internal class DuplicateChecker
    {
        public bool HasDuplicate(int[] numbers)
        {
            var seen = new HashSet<int>();
            foreach (int num in numbers)
            {
                if (!seen.Add(num))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
