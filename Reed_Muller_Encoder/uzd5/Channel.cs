

namespace uzd5
{
    public class Channel
    {
        //Function changes bits based on the given probability
        public char[] DistortMessage(char[] message, int probability)
        {

            Random random = new Random();
            char[] distortedMessage = new char[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                int rand = random.Next(1, 10001);

                distortedMessage[i] = (rand <= probability) ? (message[i] == '0' ? '1' : '0') : message[i];
            }

            return distortedMessage;
        }
        //Function returns a list showing where the mistakes are made while distorting
        public List<char[]> CompareMessage(List<char[]> array1, List<char[]> array2)
        {
            List<char[]> result = new List<char[]>();

            int maxLength = array1.Count > array2.Count ? array1.Count : array2.Count;

            for (int i = 0; i < maxLength; i++)
            {
                char[] arr1 = i < array1.Count ? array1[i] : new char[0];
                char[] arr2 = i < array2.Count ? array2[i] : new char[0];

                char[] diff = new char[arr1.Length > arr2.Length ? arr1.Length : arr2.Length];
                for (int j = 0; j < diff.Length; j++)
                {
                    if (j < arr1.Length && j < arr2.Length)
                    {
                        diff[j] = arr1[j] == arr2[j] ? '_' : '*';
                    }
                }

                result.Add(diff);
            }

            return result;
        }

    }
}

