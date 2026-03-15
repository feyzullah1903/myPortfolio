
class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int newsize = 10;
        int[] newarr = new int[newsize];
        CustomArrSize(newarr, arr);
        for (int i = 0; i < newarr.Length; i++)
        {

            Console.WriteLine(newarr[i]+""  );
        
    
        }



    }
    public static void CustomArrSize( int[] NewArr, int[] nums)
    {
        for (int i = 0; i < NewArr.Length; i++)
        {
            if (i < nums.Length)
            {
                NewArr[i] = nums[i];
            }
             else
            {
                NewArr[i] = 0;
            }
        }
    }
}