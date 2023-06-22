namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int[] arr={11,2,3,4,5,6,7,8,9,10};
        List<int> lstArr=arr.ToList();
        //lstArr=
        BubbleSortGenerics<int>.BubbleSort(lstArr);
        //arr=SelectionSortIntArray.SelectionSort(arr);


//Console.WriteLine("No of iterations " + BubbleSortGenerics<int>.GetTotalNoOfIterations());
        foreach (var item in arr)
        {
            Console.Write(item+" ");
        }
    }
}