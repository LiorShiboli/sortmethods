using System;

namespace practice
{
    public class sort
    {
        public void Insertion(double[] arr)
        {
            public static void Swpbig (double[] arry,int big,int sml)
        {
            double tmp = Math.Min(arry[big], arry[sml]);
            arry[big] = Math.Max(arry[big], arry[sml]);
            arry[sml] = tmp;
        }
        public static void Insertion(double[] arr)
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
      
    }
}
