public class BinarySearch
{
    public int Search<T>(T[] list, T element) where T : IComparable<T>
    {
        int start = 0, end = list.Length - 1;
        while (start <= end)
        {
            int middle = (end - start) / 2 + start;
            int status = element.CompareTo(list[middle]);
            if (status == 0) return middle;
            else if (status > 0) start = middle + 1;
            else end = middle - 1;
        }
        return -1;
    }

    //Recursive Search
    public int Search<T>(T[] list, T element, int start, int end) where T : IComparable<T>
    {
        if (start > end) return -1;

        int middle = (end - start) / 2 + start;
        int status = element.CompareTo(list[middle]);

        if (status == 0) return middle;
        else if (status > 0) return Search(list, element, middle + 1, end);
        else return Search(list, element, start, middle - 1);
    }
}
