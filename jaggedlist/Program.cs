using System;

class jaggedlist

{
    public static void Main()
    {

        int[][] jagged_arr = new int[4][];

        jagged_arr[0] = new int[] { 1, 2, 3, 4, 5 };
        jagged_arr[1] = new int[] {6,7,8,9,10 };
        jagged_arr[2] = new int[] {11,12,13,14,15};
        jagged_arr[3] = new int[] { 0, 45, 78, 53, 99 };

        for (int n = 0; n < jagged_arr.Length; n++)
        {
            System.Console.Write("ClassRoom({0}): ", n);

            for (int k = 0; k < jagged_arr[n].Length; k++)
            {
                System.Console.Write("{0} ", jagged_arr[n][k]);
            }
            System.Console.WriteLine();
        }
    }
}
