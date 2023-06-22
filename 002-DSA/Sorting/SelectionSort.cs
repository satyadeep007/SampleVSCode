public static class SelectionSortIntArray
{
    private static int _totalNoOfIterations = 0;

    public static int GetTotalNoOfIterations()
    { return _totalNoOfIterations; }
    public static int[] SelectionSort(int[] arr)
    {
        int totalNoOfElements = arr.Length;
        _totalNoOfIterations = 0;
        for (int outerLoop = 0; outerLoop < totalNoOfElements; outerLoop++)
        {
            int maxElement = arr[outerLoop];
            int maxIndex = 0;
            for (int innerLoop = 0; innerLoop < totalNoOfElements - outerLoop - 1; innerLoop++)
            {
                _totalNoOfIterations++;
                if (arr[innerLoop] > arr[innerLoop + 1])
                {
                    maxIndex = innerLoop ;
                    maxElement = arr[innerLoop];
                }

            }
            swapArrayElements(arr,maxIndex,totalNoOfElements - outerLoop - 1);
            
       }
        return arr;
    }
    static void swapArrayElements(int[] arr, int initialIndex, int finalIndex)
    {
        int temp = arr[initialIndex];
        arr[initialIndex] = arr[finalIndex];
        arr[finalIndex] = temp;
    }
}