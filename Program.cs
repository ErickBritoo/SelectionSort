namespace Selection
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[5] { 15, 3, 7, 1, 5};
            arr = SelectionSort(arr);
         
        }

        static int[] SelectionSort(int[] arr) {
            for (int i = 0; i < arr.Length; i++)
            {
                foreach (var item in arr)
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine();
                int menorIndex = i;

                for (int j = i + 1; j < arr.Length; j++)
                {

                    if (arr[j] < arr[menorIndex])
                    {
                        menorIndex = j;
                    }
                }

                int aux = arr[menorIndex];
                arr[menorIndex] = arr[i];
                arr[i] = aux;
            }
            return arr;
        }
    }
}