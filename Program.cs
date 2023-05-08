namespace Test_App_Sudoku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] sudokuSampleTrue = new int[9, 9]
            {
                { 5, 3, 4, 6, 7, 8, 9, 1, 2 },
                { 6, 7, 2, 1, 9, 5, 3, 4, 8 },
                { 1, 9, 8, 3, 4, 2, 5, 6, 7 },
                { 8, 5, 9, 7, 6, 1, 4, 2, 3 },
                { 4, 2, 6, 8, 5, 3, 7, 9, 1 },
                { 7, 1, 3, 9, 2, 4, 8, 5, 6 },
                { 9, 6, 1, 5, 3, 7, 2, 8, 4 },
                { 2, 8, 7, 4, 1, 9, 6, 3, 5 },
                { 3, 4, 5, 2, 8, 6, 1, 7, 9 }
            };

            int[,] sudokuSampleFalse = new int[9, 9]
            {
                { 5, 3, 4, 6, 7, 8, 9, 1, 2 },
                { 6, 7, 2, 1, 9, 0, 3, 4, 8 },
                { 1, 0, 0, 3, 4, 2, 5, 6, 0 },
                { 8, 5, 9, 7, 6, 1, 0, 2, 0 },
                { 4, 2, 6, 8, 5, 3, 7, 9, 1 },
                { 7, 1, 3, 9, 2, 4, 8, 5, 6 },
                { 9, 0, 1, 5, 3, 7, 2, 1, 4 },
                { 2, 8, 7, 4, 1, 9, 6, 3, 5 },
                { 3, 0, 0, 4, 8, 1, 1, 7, 9 }
            };

            Console.WriteLine(ValidSolution(sudokuSampleTrue));

            Console.WriteLine(ValidSolution(sudokuSampleFalse));
        }
        static bool ValidSolution(int[,] sudokuSamples)
        {
            // If a Sudoku game is completed correctly,
            // sum of any column or row must be equal to 45
            int TrueSumOfOneRowOrCol = 45;

            int elemsSum = 0;
            int count = 0;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                    elemsSum += sudokuSamples[i, j];

                if (elemsSum == TrueSumOfOneRowOrCol)
                    count++;

                elemsSum = 0;
            }
            return count % 9 == 0;
        }
    }
}