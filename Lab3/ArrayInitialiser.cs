using static Lab3.ParseHelper;

namespace Lab3
{
    public static class ArrayInitializer
    {
        #region constants

        private const string SizeMessage = "Enter the size of the array: ";
        private const string SizeErrorMessage = "Wrong size format. Please, try again.\n";
        private const string ArrayErrorMessage = "Wrong item format. Please, try again.\n";

        #endregion
        
        public static int GetArraySize()
            => InputParse(SizeMessage,
                SizeErrorMessage);
        
        public static int[] GetArray(int arrSize)
        {
            var arr = new int[arrSize];

            for (var i = 0; i < arrSize; i++)
            {
                arr[i] = InputParse(
                    $"[{i}]: ",
                    ArrayErrorMessage);
            }

            return arr;
        }
    }
}