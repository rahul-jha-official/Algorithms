public class BinarySearch
{
    public int Search(int[] list, int element)
    {
        int start = 0, end = list.Length - 1;
        while (start <= end)
        {
            int middle = (end - start) / 2 + start;
            if (list[middle] == element) return middle;
            else if (list[middle] < element) start = middle + 1;
            else end = middle - 1;
        }
        return -1;
    }

    //Recursive Search
    public int Search(int[] list, int element, int start, int end)
    {
        if (start > end) return -1;

        int middle = (end - start) / 2 + start;

        if (list[middle] == element) return middle;
        else if (list[middle] < element) return Search(list, element, middle + 1, end);
        else return Search(list, element, start, middle - 1);
    }
}
