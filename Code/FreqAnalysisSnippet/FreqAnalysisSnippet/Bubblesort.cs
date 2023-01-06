
//bubblesort for sorting letterCount
public static class Bubblesort
{

    public static (int[], int[]) BubbleSort(int[] letterName, int[] letterCount)
    {
        //bool swapped = false;
        bool swapped;
        int n = letterCount.Length;
        //loop until no more swaps occur
        do
        {
            swapped = false;
            for (int i = 0; i < n - 1; i++)
            {
                if (letterCount[i] < letterCount[i + 1])
                {
                    SwapInt(ref letterCount[i], ref letterCount[i + 1]);
                    // swaps character names to keep them paired with frequency
                    SwapInt(ref letterName[i], ref letterName[i + 1]);
                    swapped = true;
                }
            }
            n--;
        }
        while (swapped);
        return (letterName, letterCount);
    }

    private static void SwapInt(ref int v1, ref int v2)
    {
        int temp = v2;
        v2 = v1;
        v1 = temp;
    }
}




