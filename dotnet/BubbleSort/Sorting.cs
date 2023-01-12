public static class SortingTwo
{
    public static int[] BubleSort(this int[] collection)
    {
        int size = collection.Length;
        for (int i = 0; i < size; i++)
        {   
            int position = i;
            for (int j = 0; j < size - 1; j++)
            {
                if (collection[j] > collection[j + 1]) 
                {
                    int temp = collection[j];
                    collection[j] = collection[j + 1];
                    collection[j + 1] = temp;
                }
            }

        }
        return collection;
    }
}