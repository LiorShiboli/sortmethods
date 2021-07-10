using System;

namespace practice
{
    public class sort
    {
        public void Insertion(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int u = i;
                while(u-1!=0&& arr[u] <= arr[u - 1])
                {
                    double tmp = arr[u];
                    arr[u] = arr[u - 1];
                    arr[u - 1] = arr[u];
                    u--;
                }
            }
        }

        public void bubble()
    }
}
