public class MetaBinarySearch
{
    public int Search<T>(T[] list, T element) where T : IComparable<T>
    {
        int bitsNeededForMaxIndex = (int)Math.Ceiling(Math.Log2 (list.Length));
        int cutoff = 0;
        for (int i = bitsNeededForMaxIndex - 1; i >= 0; i--)
        {
            if (element.CompareTo(list[cutoff]) == 0) return cutoff;

            int cutoffCandidate = cutoff | (1 << i);

            if (cutoffCandidate < list.Length && element.CompareTo(list[cutoffCandidate]) >= 0)
            {
                cutoff = cutoffCandidate;
            }
        }
        if (element.CompareTo(list[cutoff]) == 0) return cutoff;
        return -1;
    }
}
