public class LinearSearch
{
    public int Search<T>(IEnumerable<T> list, T element)
    {
        int index = 0;
        
        foreach (var item in list)
        {
            if (item.Equals(element)) return index;
            index++;
        }
        return -1;
    }
}
