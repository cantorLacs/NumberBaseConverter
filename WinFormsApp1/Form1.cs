namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private void button1_Click(object sender, EventArgs e)
        {
            string[] ansrs = new string[3];

            string number = txtNumber.Text == "" ? "0" : txtNumber.Text;
            bool numberIsValid = false;

            //Number validation
            foreach (char item in number.ToCharArray())
            {
                numberIsValid = (item >= 48 && item <= 57 || char.ToUpper(item) >= 65 && char.ToUpper(item) <= 90);
                if (!numberIsValid)
                {
                    txtResult.Text = $"The entered number ({number}) contains \n" +
                        $"the character ({item}), which is an\ninvalid digit.\nTry again: ";
                }
            }

            char charMax = number.ToCharArray().Max();

            byte sourceBase;
            bool sourceBaseIsValid;

            //SourceBase validation
            sourceBaseIsValid = byte.TryParse(txtSource.Text, out sourceBase) && sourceBase > ConvertToDecimal(charMax) && sourceBase <= 36;
            if (!sourceBaseIsValid)
            {
                txtResult.Text = (sourceBase <= 36) ?
                    $"The entered source base ({sourceBase}) is not valid\n" +
                    $"for the entered number ({number}).\nTry again: "
                    :
                    $"The entered source base ({sourceBase}) can NOT\n be greater than 36.\nTry again: ";
            }

            byte targetBase;
            bool targetBaseIsValid;

            //targetBase validation
            targetBaseIsValid = byte.TryParse(txtTarget.Text, out targetBase) && targetBase <= 36 && targetBase > 1;
            if (!targetBaseIsValid) { txtResult.Text = $"The target base must be a \nnatural number between 2 and 36.\nTry again: "; }


            string result;

            if (numberIsValid && sourceBaseIsValid && targetBaseIsValid)
            {
                result = ConvertBase(number, sourceBase, targetBase);

                txtResult.Text = $"{number} base {sourceBase} = {result} base {targetBase}";
            } // Now that I cannot use do while loops to validate I had to use an If statement so ConvertBase() 
              // is not call with invalid arguments that crash the whole programme 


            string ConvertBase(string number, int sourceBase, int targetBase)
            {

                // this part split the number into whole and fractional parts
                string[] parts = number.Split('.'); // string.split returns an array with the two new strings created after spliting
                string wholePart = parts[0];
                string fractionalPart = parts.Length > 1 ? parts[1] : "";


                double wholeValue = 0;
                if (true)
                {
                    int power = 0;
                    for (int i = wholePart.Length - 1; i >= 0; i--)
                    {
                        wholeValue = wholeValue + ConvertToDecimal(wholePart[i]) * Math.Pow(sourceBase, power);
                        power++;
                    }
                }    // this part convert the wholePart number to decimal

                double fractionalValue = 0;
                if (true)
                {
                    int power = -1;
                    for (int i = 0; i < fractionalPart.Length; i++)
                    {
                        fractionalValue = fractionalValue + ConvertToDecimal(fractionalPart[i]) * Math.Pow(sourceBase, power);
                        power--;
                    }
                }    // this part convert the fractional part to decimal

                string result = "";

                if (true)
                {
                    while (wholeValue >= 1)
                    {
                        double remainder = wholeValue % targetBase;
                        result = ConvertToTargetBase((int)remainder) + result; //I had to confirm that targetBase never
                                                                               //receive as value 0 or 1 because that breaks the counter
                                                                               //created with the decimalValue been round down to less than 1
                                                                               //that happen because any number divided by 1 is the same number
                                                                               //and when we devided by 0 it doesn't crash but the while loop
                                                                               //runs forever frezeng the program
                        wholeValue = Math.Floor(wholeValue / targetBase);

                    }
                }    // this part convert the decimal whole number part to the target base

                if (fractionalValue > 0)
                {
                    result = result + ".";
                    int fractionalLength = 10; // this is the amound of fractional digits
                    for (int i = 0; i < fractionalLength; i++)
                    {
                        fractionalValue = fractionalValue * targetBase;
                        int wholePartForFractionalPart = (int)Math.Floor(fractionalValue);
                        result = result + ConvertToTargetBase(wholePartForFractionalPart);
                        fractionalValue = fractionalValue - wholePartForFractionalPart; //TEST!! this loop will end when fractionalValue is 0
                    }
                }    // this part convert the decimal fractional part to the target base



                return result;
            }


            int ConvertToDecimal(char digit)
            {
                if (char.IsDigit(digit))
                {
                    return (int)(digit - '0');
                }
                else
                {
                    return (int)(char.ToUpper(digit) - 'A' + 10);
                }
            }

            char ConvertToTargetBase(int value)
            {
                if (value < 10)
                {
                    return (char)(value + '0');
                }
                else
                {
                    return (char)(value + 'A' - 10);
                }
            }


        }
        //--------------------------------------------------------//

        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}