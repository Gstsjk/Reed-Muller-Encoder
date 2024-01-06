using System.Text;

namespace uzd5
{
    public partial class Form1 : Form
    {
        Converting converting = new Converting();
        Encoding encoding = new Encoding();
        Decoding decoding = new Decoding();
        Channel channel = new Channel();
        private int index;
        private string? bitSequence;
        private string? sentence;
        private List<char[]> bitSequences;
        private List<char[]> encodedBitSequences;
        private List<char[]> decodedBitSequences;
        private List<string> decodedSequences;
        private List<char[]> distortedBitSequences;
        private List<string> distortedSequences;
        char lastElement;

        private List<char[]> showDistortedBitSequences;

        //Show encoded bit sequence 
        private void DisplayEncodedString()
        {
            StringBuilder encodedString = new StringBuilder();

            foreach (char[] sequence in encodedBitSequences)
            {
                encodedString.Append(sequence);
                encodedString.Append(" | ");
            }

            lblEncoded.Text = "Encoded sequences:   " + encodedString.ToString();
        }
        //Show the distorted encoded sequence
        private void DisplayDistortedString()
        {
            StringBuilder distortedString = new StringBuilder();

            foreach (char[] sequence in distortedBitSequences)
            {
                distortedString.Append(sequence);
                distortedString.Append(" | ");
            }

            lblDistorted.Text = "Distorted sequences: " + distortedString.ToString();
        }
        //Show the line below distorted message
        private void DisplayDifferences()
        {
            StringBuilder difString = new StringBuilder();

            foreach (char[] sequence in showDistortedBitSequences)
            {
                difString.Append(sequence);
                difString.Append(" | ");
            }
            lblCompare.Text = "Differences:         " + difString.ToString();

            string dif = difString.ToString();
            int starCount = dif.Count(c => c == '*');
            lblAmount.Text = "Amount of distorted bits:" + starCount.ToString();
        }
        //Divides the number by 2 and returns how many times it has done it
        private int CountDivisionsByTwo(int number)
        {
            int count = 1;
            while (number > 2)
            {
                number /= 2;
                count++;
            }

            return count;
        }


        public Form1()
        {
            InitializeComponent();
            encodedBitSequences = new List<char[]>();
            bitSequences = new List<char[]>();
            decodedBitSequences = new List<char[]>();
            decodedSequences = new List<string>();
            distortedBitSequences = new List<char[]>();
            distortedSequences = new List<string>();
            showDistortedBitSequences = new List<char[]>();


        }

        private void RBtnBinary_CheckedChanged(object sender, EventArgs e)
        {
            gBoxBinary.Visible = true;
            gBoxSentence.Visible = false;
            gBoxPhoto.Visible = false;
        }

        private void RBtnSentence_CheckedChanged(object sender, EventArgs e)
        {
            gBoxBinary.Visible = false;
            gBoxSentence.Visible = true;
            gBoxPhoto.Visible = false;
        }

        private void RBtnPhoto_CheckedChanged(object sender, EventArgs e)
        {
            gBoxBinary.Visible = false;
            gBoxSentence.Visible = false;
            gBoxPhoto.Visible = true;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            encodedBitSequences = new List<char[]>();
            distortedBitSequences = new List<char[]>();
            decodedBitSequences = new List<char[]>();
            decodedSequences = new List<string>();
            distortedSequences = new List<string>();
            showDistortedBitSequences = new List<char[]>();

            index = Int32.Parse(txtIndex.Text);
            //lblEntered.Text = "Decoded bit sequence: ";

            lblCarry.Visible = false;
            lastElement = '5';
            //The 3 ifs are for different calculations - binary, sentence and photo.
            // Almost every if is the same just before encoding,  sentence and photo are converted to a binary sequence
            if (rBtnBinary.Checked == true)
            {
                bitSequence = txtBitSequence.Text;

                //Project -> Properties -> Application -> Output Type -> Console Application
                bitSequences = converting.SplitArray(bitSequence.ToCharArray(), index + 1);
                //This part checks if there is only a bit left in the sequence. If it will be added to the answer seperately.
                if (bitSequences.Last().Length < 2)
                {
                    char[] lastSequence = bitSequences.Last();
                    bitSequences.RemoveAt(bitSequences.Count - 1);
                    lastElement = lastSequence[0];
                    //Console.WriteLine(lastElement);

                }
                //Every foreach is mostly the same: go through a list of char array, encode or distort or decode them and show it to the user.
                foreach (char[] sequence in bitSequences)
                {
                    char[] encodedMessage = encoding.EncodeMessage(sequence);
                    encodedBitSequences.Add(encodedMessage);
                }
                DisplayEncodedString();
                foreach (var sequence in encodedBitSequences)
                {
                    char[] distortedMessagge = channel.DistortMessage(sequence, Int32.Parse(txtDistortation.Text));
                    distortedBitSequences.Add(distortedMessagge);
                }
                DisplayDistortedString();

                //Manually change the distorted bits
                txtChange.Text = "";
                foreach (var sequence in distortedBitSequences)
                {
                    txtChange.Text += new string(sequence.ToArray());
                }
                showDistortedBitSequences = channel.CompareMessage(encodedBitSequences, distortedBitSequences);
                DisplayDifferences();
                foreach (var sequence in distortedBitSequences)
                {
                    //Console.WriteLine("sequence "+new string( sequence));
                    char[] decodedMessage = decoding.Hadamard(sequence, CountDivisionsByTwo(sequence.Length));
                    decodedBitSequences.Add(decodedMessage);
                    decodedSequences.Add(new string(decodedMessage));
                    //Console.WriteLine(decodedMessage);
                }
                //This the part about adding the last bit to the answer
                if (lastElement != '5')
                {
                    decodedSequences.Add(lastElement.ToString());
                    lblCarry.Visible = true;
                }

                lblEntered.Text = "Decoded bit sequence: " + string.Join("", decodedSequences);
            }
            else if (rBtnSentence.Checked == true)
            {
                sentence = txtSentence.Text;
                bitSequence = converting.ConvertSentenceToBinary(sentence);

                bitSequences = converting.SplitArray(bitSequence.ToCharArray(), index + 1);
                if (bitSequences.Last().Length < 2)
                {
                    char[] lastSequence = bitSequences.Last();
                    bitSequences.RemoveAt(bitSequences.Count - 1);
                    lastElement = lastSequence[0];
                    //Console.WriteLine(lastElement);

                }
                foreach (char[] sequence in bitSequences)
                {
                    char[] encodedMessage = encoding.EncodeMessage(sequence);
                    encodedBitSequences.Add(encodedMessage);
                }
                foreach (var sequence in encodedBitSequences)
                {
                    char[] distortedMessagge = channel.DistortMessage(sequence, Int32.Parse(txtDistortation.Text));
                    distortedBitSequences.Add(distortedMessagge);
                }
                foreach (var sequence in distortedBitSequences)
                {
                    char[] decodedMessage = decoding.Hadamard(sequence, CountDivisionsByTwo(sequence.Length));
                    decodedBitSequences.Add(decodedMessage);
                    decodedSequences.Add(new string(decodedMessage));
                }
                if (lastElement != '5')
                {
                    decodedSequences.Add(lastElement.ToString());
                }
                string decoded = converting.BinaryToSentence(string.Join("", decodedSequences));
                lblDecodedSentence.Text = "Using encoding and decoding: " + decoded;

                //Only distorting
                distortedBitSequences = new List<char[]>();
                foreach (var sequence in bitSequences)
                {
                    char[] distortedMessagge = channel.DistortMessage(sequence, Int32.Parse(txtDistortation.Text));
                    distortedBitSequences.Add(distortedMessagge);
                    distortedSequences.Add(new string(distortedMessagge));
                }
                string distorted = converting.BinaryToSentence(string.Join("", distortedSequences));
                lblDistortedSentence.Text = "Not using encoding: " + distorted;
            }
            else
            {
                string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string parentDirectory = Path.Combine(appDirectory, @"..\..\..\..\");
                parentDirectory = Path.GetFullPath(Path.Combine(parentDirectory, "Photos"));
                //Console.WriteLine("Current directory is: " + Directory.GetCurrentDirectory());
                Console.WriteLine("Photos file: " + parentDirectory);
                bitSequence = new string(converting.BmpToBinary(txtDirectory.Text));
                pBoxOriginal.ImageLocation = txtDirectory.Text;
                //Console.WriteLine(bitSequence);
                bitSequences = converting.SplitArray(bitSequence.ToCharArray(), index + 1);
                if (bitSequences.Last().Length < 2)
                {
                    char[] lastSequence = bitSequences.Last();
                    bitSequences.RemoveAt(bitSequences.Count - 1);
                    lastElement = lastSequence[0];
                    //Console.WriteLine(lastElement);
                }
                foreach (char[] sequence in bitSequences)
                {
                    char[] encodedMessage = encoding.EncodeMessage(sequence);
                    encodedBitSequences.Add(encodedMessage);
                }
                foreach (var sequence in encodedBitSequences)
                {
                    char[] distortedMessagge = channel.DistortMessage(sequence, Int32.Parse(txtDistortation.Text));
                    distortedBitSequences.Add(distortedMessagge);
                }
                foreach (var sequence in distortedBitSequences)
                {
                    char[] decodedMessage = decoding.Hadamard(sequence, CountDivisionsByTwo(sequence.Length));
                    decodedBitSequences.Add(decodedMessage);
                    decodedSequences.Add(new string(decodedMessage));
                }
                if (lastElement != '5')
                {
                    decodedSequences.Add(lastElement.ToString());
                }
                string decoded = string.Join("", decodedSequences);
                //Console.WriteLine(decoded);
                string tempDirectory = Path.Combine(parentDirectory, "EncodedBMP.bmp");
                converting.BinaryToBmp(decoded, tempDirectory);
                pBoxEncoded.ImageLocation = tempDirectory;

                //Only distorting
                distortedBitSequences = new List<char[]>();
                foreach (var sequence in bitSequences)
                {
                    char[] distortedMessagge = channel.DistortMessage(sequence, Int32.Parse(txtDistortation.Text));
                    distortedBitSequences.Add(distortedMessagge);
                    distortedSequences.Add(new string(distortedMessagge));
                }
                string distorted = string.Join("", distortedSequences);
                tempDirectory = Path.Combine(parentDirectory, "NotEncoded.bmp");
                converting.BinaryToBmp(distorted, tempDirectory);
                pBoxNotEncoded.ImageLocation = tempDirectory;
            }

        }


        private void cboxChange_CheckedChanged(object sender, EventArgs e)
        {

            if (cboxChange.Checked)
            {
                txtChange.Enabled = true;
                btnContinue.Enabled = true;
            }
            else
            {
                txtChange.Enabled = false;
                btnContinue.Enabled = false;
            }
        }
        //This part is for calculating the hand changed sequence and showing it
        private void btnContinue_Click(object sender, EventArgs e)
        {
            decodedSequences = new List<string>();
            string changedBitSequence = txtChange.Text;
            List<char[]> changeBitSequences = converting.ConvertToSameLength(changedBitSequence, encodedBitSequences);
            foreach (var sequence in changeBitSequences)
            {
                //Console.WriteLine("sequence "+new string( sequence));
                char[] decodedMessage = decoding.Hadamard(sequence, CountDivisionsByTwo(sequence.Length));
                decodedBitSequences.Add(decodedMessage);
                decodedSequences.Add(new string(decodedMessage));
                //Console.WriteLine(decodedMessage);
            }

            if (lastElement != '5')
            {
                decodedSequences.Add(lastElement.ToString());
                lblCarry.Visible = true;
            }

            lblEntered.Text = "Decoded bit sequence: " + string.Join("", decodedSequences);
        }
    }
}
