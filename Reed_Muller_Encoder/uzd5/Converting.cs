using System.Text;

namespace uzd5
{
    public class Converting
    {
        //Function splits array to based sizes, mostly based on the given index
        public List<T[]> SplitArray<T>(T[] arrayToSplit, int size)
        {
            var list = new List<T[]>();

            for (int i = 0; i < arrayToSplit.Length; i += size)
            {
                int chunkSize = (arrayToSplit.Length - i) < size ? (arrayToSplit.Length - i) : size;
                T[] chunk = new T[chunkSize];
                Array.Copy(arrayToSplit, i, chunk, 0, chunkSize);
                list.Add(chunk);
            }

            return list;
        }

        public string ConvertSentenceToBinary(string sentence)
        {
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(sentence); ;
            StringBuilder binaryStringBuilder = new StringBuilder();

            foreach (byte b in bytes)
            {
                binaryStringBuilder.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
            }
            //Console.WriteLine("Byte sentence "+binaryStringBuilder.ToString());
            return binaryStringBuilder.ToString();
        }

        public int[] ConvertCharArrayToIntArray(char[] charArray)
        {
            int length = charArray.Length;
            int[] intArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                intArray[i] = int.Parse(charArray[i].ToString());
            }

            return intArray;
        }

        public string BinaryToSentence(string binaryString)
        {
            if (binaryString.Length % 8 != 0)
            {
                throw new ArgumentException("Binary string length must be a multiple of 8.");
            }

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < binaryString.Length; i += 8)
            {
                string binaryChar = binaryString.Substring(i, 8);
                char character = Convert.ToChar(Convert.ToByte(binaryChar, 2));
                result.Append(character);
            }

            return result.ToString();
        }

        public char[]? BmpToBinary(string inputImagePath)
        {
            try
            {
                using (Bitmap bmp = new Bitmap(inputImagePath))
                {
                    char[] binaryData = new char[bmp.Width * bmp.Height];

                    int index = 0;
                    for (int y = 0; y < bmp.Height; y++)
                    {
                        for (int x = 0; x < bmp.Width; x++)
                        {
                            Color pixelColor = bmp.GetPixel(x, y);
                            byte pixelValue = (byte)((pixelColor.R + pixelColor.G + pixelColor.B) / 3);
                            binaryData[index++] = Convert.ToString(pixelValue, 2).PadLeft(8, '0')[0];
                        }
                    }

                    return binaryData;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null; 
            }
        }

        public void BinaryToBmp(string binaryData, string outputImagePath)
        {
            try
            {
                int width = (int)Math.Sqrt(binaryData.Length);
                int height = width;

                using (Bitmap bmp = new Bitmap(width, height))
                {
                    int index = 0;
                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            int newPixelValue = (binaryData[index] == '1') ? 255 : 0; // 255 for '1', 0 for '0'

                            Color newPixelColor = Color.FromArgb(newPixelValue, newPixelValue, newPixelValue);
                            bmp.SetPixel(x, y, newPixelColor);

                            index++;
                        }
                    }

                    bmp.Save(outputImagePath, System.Drawing.Imaging.ImageFormat.Bmp);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        //This function converts the inputString to the same sizes as the given list. It is used when getting user manual input in the binary section.
        public List<char[]> ConvertToSameLength(string inputString, List<char[]> charArrays)
        {
            int totalLength = charArrays.Sum(arr => arr.Length);
            List<char[]> result = new List<char[]>();
            int currentIndex = 0;

            foreach (var arr in charArrays)
            {
                char[] convertedArray = inputString.Substring(currentIndex, arr.Length).ToCharArray();
                result.Add(convertedArray);

                currentIndex += arr.Length;
            }

            return result;
        }

    }
}

