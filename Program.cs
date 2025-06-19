namespace Selection
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[5] { 15, 3, 7, 1, 5};
            arr = SelectionSort(arr);
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }

        static int[] SelectionSort(int[] arr) {
            for (int i = 0; i < arr.Length; i++)
            {
                int menorElement = arr[i];
                for (int j = 0; j < arr.Length; j++)
                {
                    if (menorElement < arr[j])
                    {
                        int aux = arr[j];
                        arr[j] = arr[i];
                        arr[i] = aux;
                    }
                }
            }
            return arr;
        }
    }
}