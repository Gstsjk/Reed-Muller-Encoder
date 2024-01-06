using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace uzd5
{
    //Used for getting the answer
    public class MaxValueResult
    {
        public int Value { get; set; }
        public int Position { get; set; }
    }

    class Decoding
    {
        private int[,] H = { { 1, 1 }, { 1, -1 } };
        private Converting converting = new Converting();
        //Returns Matrix duplication
        public int[,] BlockMatrix(int[,] A, int[,] B)
        {
            int m = A.GetLength(0);
            int n = A.GetLength(1);
            int p = B.GetLength(0);
            int q = B.GetLength(1);

            int resultRows = m * p;
            int resultCols = n * q;

            int[,] result = new int[resultRows, resultCols];

            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    for (int k = 0; k < p; ++k)
                    {
                        for (int l = 0; l < q; ++l)
                        {
                            result[i * p + k, j * q + l] = A[i, j] * B[k, l];
                        }
                    }
                }
            }
            return result;
        }
        //Function that returns the I Matix - diagonal 1, everything else 0. 
        public int[,] IdentityMatrix(int size)
        {
            int[,] result = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result[i, j] = (i == j) ? 1 : 0;
                }
            }
            return result;
        }
       //Converts 0's in array to -1. Needed for multiplication 
        public int[] ConvertZerosToMinusOne(int[] array)
        {
            int[] resultArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    resultArray[i] = -1;
                }
                else
                {
                    resultArray[i] = array[i];
                }
            }

            return resultArray;
        }
        //Formula is Im-i * H * Ii-1 so we need to different Identity matrixs
        public int FirstIMatrix(int m, int i)
        {
            int result = 1;
            for(int j=i; j< m; j++)
            {
                result *= 2;
            }
            // Console.WriteLine("result First: "+result);
            return result;
        }

        public int SecondIMatrix(int i)
        {
            int result = 1;
            for (int j = 1; j < i; j++)
            {
                result *= 2;
            }
            // Console.WriteLine("result Second: " + result);
            return result;
        }
        //This function is for testing and printing to console
        public void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            Console.WriteLine("Matrix:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        //Function that muliplies the vector (ex. 1 -1 1 -1) with the already multiplied I*H*I part
        public int[] MatrixMultiplication(int[] vector, int[,] matrix)
        {
            int vectorLength = vector.Length;
            int matrixRows = matrix.GetLength(0);
            int matrixCols = matrix.GetLength(1);

            //Console.WriteLine("Vector: " + vectorLength);
            //Console.WriteLine("Matrix cols: " + matrixCols);

            if (vectorLength != matrixCols)
            {
                throw new ArgumentException("Length of the vector must be equal to the number of columns in the matrix.");
            }

            int[] result = new int[matrixRows];

            for (int i = 0; i < matrixRows; i++)
            {
                int sum = 0;
                for (int j = 0; j < vectorLength; j++)
                {
                    sum += vector[j] * matrix[i, j];
                }
                result[i] = sum;
            }

            return result;
        }
        //Finds the biggest value, no matter the sign 
        public MaxValueResult FindMaxValue(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array must not be null or empty.");
            }

            int maxAbsoluteValue = GetAbsoluteValue(array[0]);
            int result = array[0];
            int position = 0;

            for (int i = 1; i < array.Length; i++)
            {
                int absoluteValue = GetAbsoluteValue(array[i]);
                if (absoluteValue > maxAbsoluteValue)
                {
                    maxAbsoluteValue = absoluteValue;
                    result = array[i];
                    position = i;
                }
            }

            return new MaxValueResult { Value = result, Position = position };
        }
        //Returns the value without the minus
        public int GetAbsoluteValue(int number)
        {
            return (number < 0) ? -number : number;
        }
        //Converts the biggest number to its binary form and flips it
        static char[] ConvertToReversedBinary(int number, int length)
        {
            string binary = Convert.ToString(number, 2);
            if (binary.Length < length)
            {
                binary = binary.PadLeft(length, '0');
            }
            else if (binary.Length > length)
            {
                binary = binary.Substring(binary.Length - length);
            }
            char[] binaryArray = binary.ToCharArray();
            Array.Reverse(binaryArray);
            return binaryArray;
        }
        //Adds the last character to the sequence
        static char[] AddChar(char[] charArray, char characterToAdd)
        {
            char[] newArray = new char[charArray.Length + 1];
            newArray[0] = characterToAdd;
            Array.Copy(charArray, 0, newArray, 1, charArray.Length);

            return newArray;
        }

        //This function calls every function above 
        public char[] Hadamard(char[] encodedChar, int index)
        {
            int[] wSequence = converting.ConvertCharArrayToIntArray(encodedChar);
            int[,] iMatrix;
            int[,] hMultiplication;
            int[,] hOld;

            MaxValueResult number ;
            
            wSequence = ConvertZerosToMinusOne(wSequence);
            //Console.WriteLine(string.Join("", wSequence));
            for (int i = 1; i <= index; i++)
            {
                hOld = H;
                iMatrix = IdentityMatrix(FirstIMatrix(index, i));
                //PrintMatrix(iMatrix);
                hMultiplication = BlockMatrix(iMatrix, hOld);
                hOld = hMultiplication;

                iMatrix = IdentityMatrix(SecondIMatrix(i));
                //PrintMatrix(iMatrix);
                hMultiplication = BlockMatrix(hOld, iMatrix);
                hOld = hMultiplication;
                //PrintMatrix(hOld);
                wSequence = MatrixMultiplication(wSequence,hOld);
                //Console.WriteLine("Sequence: "+string.Join("", wSequence));
            }
            number = FindMaxValue(wSequence);

            char[] result = ConvertToReversedBinary(number.Position, index);
            if (number.Value>0)
            {
                result = AddChar(result, '1');
                return result;
            }
            else
            {
                result = AddChar(result, '0');
                return result;
            }
        }
    }
}
