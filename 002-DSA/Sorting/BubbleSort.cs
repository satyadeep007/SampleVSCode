public static class BubbleSortIntArray
{
    private static int _totalNoOfIterations=0;

    public static int GetTotalNoOfIterations()
    { return _totalNoOfIterations; }
    public static int[] BubbleSort(int[] arr)
    {
        int totalNoOfElements= arr.Length;
       bool isElementSwapped=false;
         _totalNoOfIterations=0;
        for(int outerLoop=0; outerLoop<totalNoOfElements;outerLoop++)
        {
             isElementSwapped=false;
            for(int innerLoop=0;innerLoop<totalNoOfElements-outerLoop-1;innerLoop++)
            {
                _totalNoOfIterations++;
                if(arr[innerLoop]>arr[innerLoop+1])
                {
                    isElementSwapped=true;
                     swapArrayElements(
                        arr,
                        innerLoop,
                        innerLoop + 1);
                }
            }
            if(!isElementSwapped)
            {
                //Console.WriteLine("Array already sorted");
                break;
            }
        }
        return arr;
    }

    static void swapArrayElements(int[] arr, int initialIndex, int finalIndex)
    {
        int temp= arr[initialIndex];
        arr[initialIndex]=arr[finalIndex];
        arr[finalIndex]=temp;
    }
}