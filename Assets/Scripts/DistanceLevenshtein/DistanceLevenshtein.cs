using System;

namespace DistanceLevenshtein
{
    public class DistanceLevenshtein
    {
        public int Execute(string firstWord, string secondWord)
        {
            if (string.IsNullOrEmpty(firstWord) || string.IsNullOrEmpty(secondWord)) 
                throw new Exception("The field is empty");
            
            return DirectMethod(firstWord, secondWord);
        }

        private static int DirectMethod(string firstWord, string secondWord)
        {
            int firstWordLength = firstWord.Length + 1;
            int secondWordLength = secondWord.Length + 1;
            int[,] matrixD = new int[firstWordLength, secondWordLength];

            const int deletionCost = 1;
            const int insertionCost = 1;

            for (int i = 0; i < firstWordLength; i++)
            {
                matrixD[i, 0] = i;
            }
            
            for (int i = 0; i < secondWordLength; i++)
            {
                matrixD[0, i] = i;
            }

            for (int i = 1; i < firstWordLength; i++)
            {
                for (int j = 1; j < secondWordLength; j++)
                {
                    int substitutionCost = firstWord[i - 1] == secondWord[j - 1] ? 0 : 1;

                    matrixD[i, j] = Minimum(
                        matrixD[i - 1, j] + deletionCost,
                        matrixD[i, j - 1] + insertionCost,
                        matrixD[i - 1, j - 1] + substitutionCost
                    );
                }
            }

            return matrixD[firstWordLength - 1, secondWordLength - 1];
        }

        private static int Minimum(int a, int b, int c) => (a = a < b ? a : b) < c ? a : c;
    }
}