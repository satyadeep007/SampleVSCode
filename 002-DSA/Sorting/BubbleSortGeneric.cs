public static class BubbleSortGenerics<T> where T:IComparable<T>
{
    private static int _totalNoOfIterations=0;

    public static int GetTotalNoOfIterations()
    { return _totalNoOfIterations; }
    public static ICollection<T> BubbleSort(ICollection<T> arr)
    {
        int totalNoOfElements=Convert.ToInt32(arr.Count());
       bool isElementSwapped=false;
         _totalNoOfIterations=0;
        for(int outerLoop=0; outerLoop<totalNoOfElements;outerLoop++)
        {
             isElementSwapped=false;
            for(int innerLoop=0;innerLoop<totalNoOfElements-outerLoop-1;innerLoop++)
            {
                _totalNoOfIterations++;
                if(arr.ElementAt(innerLoop).CompareTo(arr.ElementAt(innerLoop+1))>0)
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

    static void swapArrayElements(ICollection<T> arr, int initialIndex, int finalIndex)
    {
        T temp= arr.ElementAt(initialIndex);
        
       arr.ElementAt(initialIndex)=arr.ElementAt(finalIndex);
        arr.ElementAt(finalIndex)=temp;
    }
}