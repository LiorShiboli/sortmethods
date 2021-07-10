using System;

namespace practice
{
    public class sort
    {
        
            public static void Swpbig (double[] arry,int big,int sml)//swap numbers in an array  so the bigger number is in the place thats specified and so is the smaller number
        {
            double tmp = Math.Min(arry[big], arry[sml]);
            arry[big] = Math.Max(arry[big], arry[sml]);
            arry[sml] = tmp;
        }




        public static void Insertion(double[] arr)// classic insertion sort
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int u = i;
                while (u!= 0 && arr[u] <= arr[u - 1])
                {
                    double tmp = arr[u];
                    arr[u] = arr[u - 1];
                    arr[u - 1] = tmp;
                    u--;
                }
            }
        }






        public static void Bubble(double[] arr)
        { bool ordered = false;
            while (!ordered)// runs for as long as the array isnt ordered
            {
                ordered = true;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    
                    ordered = arr[i] < arr[i + 1] && ordered;//slightly fancy way to update ordered
                    Swpbig(arr, i + 1, i);
                   
                    
                }
            }
        }





        public static int[] CountingSort(int[] arry, int exp)//counting sort sorts array by digits of the exponnential specified
        {
            int[] count = new int[10];
            int[] sorted = new int[arry.Length];
            for (int i = 0; i < 10; i++)//builds array that keeps track of every occourance of each digit
            {

                count[i] = 0;

            }
            for (int i = 0; i < arry.Length; i++)//adds the count of the occu=ourance of each digit
            {

                count[(arry[i] / exp) % 10]++;

            }
            for (int i = 1; i < 10; i++)//adds together the occourances from the last digits as to create a "map" the describes the sorted array by digits  
            {
                count[i] += count[i - 1];
            }
            for (int i = arry.Length - 1; i >= 0; i++)//builds the final array based on the digits in the array
            {

                sorted[count[(arry[i] / exp) % 10] - 1] = arry[i];

            }

            return sorted;
        }





        public static int[] radix(int[] arry)//works only on positive numbers but is rather fast for big arrays
        {
            int max = arry[0];
            int[] sorted = new int[arry.Length];
            for (int i = 0; i < arry.Length; i++)
            {

                sorted[i] = arry[i];

            }
            for (int i = 0; i < 10; i++)//finds the biggest number in the array
            {

                max = Math.Max(max, arry[i]);

            }
            for (int i = 1; max / 10 == 0; i *= 10) //runs counting sort for each digit in the biggest number of the array
            {
                sorted = CountingSort(sorted, i);


            }

            return sorted;
        }


    }
}
