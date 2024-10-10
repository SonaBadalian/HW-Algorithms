namespace Sorting
{
    public static class SortingAlgorithms
    {
        public static void InsertionSortRecursive(int[] array)
        {
            InsertionSortRecursiveHelper(array, array.Length);
        }

        private static void InsertionSortRecursiveHelper(int[] array, int n)
        {
            if (n <= 1)
                return;

            InsertionSortRecursiveHelper(array, n - 1);

            int last = array[n - 1];
            int j = n - 2;

            while (j >= 0 && array[j] > last)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = last;
        }
    }
}
