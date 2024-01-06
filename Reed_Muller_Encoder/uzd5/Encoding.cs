namespace uzd5
{
    public class Encoding
    {
        //Generating the matrix (1,m) 
        public int[][] GeneratorMatrix(int m)
        {
            int numCols = 1 << m;
            int numRows = m + 1;
            int[][] gMatrix = new int[numRows][];
            for (int i = 0; i < numRows; i++)
            {
                gMatrix[i] = new int[numCols];
            }
            for (int j = 0; j < numCols; j++)
            {
                gMatrix[0][j] = 1;
            }
            for (int i = 1; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    gMatrix[i][j] = ((j >> (i - 1)) & 1) == 1 ? 1 : 0;
                }
            }
            //Printing out the Matrix
            /*
            for (int i = 0; i < gMatrix.Length; i++)
            {
                for (int j = 0; j < gMatrix[i].Length; j++)
                {
                    Console.Write(gMatrix[i][j] + " ");
                }
                Console.WriteLine();
            }
            */
            return gMatrix;
        }

        //Vectorial multiply between the matrix and the typed in message
        public char[] EncodeMessage(char[] message)
        {
            int m = message.Length-1;
            int[][] matrix = GeneratorMatrix(m);
            int numRows = matrix.Length;
            int numCols = matrix[0].Length;

            string encodedMessage = "";

            for (int j = 0; j < numCols; j++)
            {
                int result = 0;
                for (int i = 0; i < numRows; i++)
                {
                    result ^= (matrix[i][j] & (message[i] - '0'));
                }
                encodedMessage += result.ToString();
            }

            return encodedMessage.ToCharArray();
        }




    }
}
