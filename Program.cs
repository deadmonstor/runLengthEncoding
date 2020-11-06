using System;

namespace runLengthEncoding
{
    class Program
    {
        public static String getEncodedString(String str)
        {
            if (string.IsNullOrEmpty(str))
                return "";

            String returnString = "";

            int n = str.Length;
            int count = 0;

            for (int i = 0; i < n; i++)
            {

                char currentChar = str[i];
                count++;

                if ((i + 1) >= n || str[i] != str[i + 1])
                {
                    returnString += $"{count}{currentChar}";
                    count = 0;
                }

            }

            return returnString;
        }

        public static String getDecodedString(String str)
        {
            String returnString = "";

            int n = str.Length;

            for (int i = 0; i < n; i++)
            {
                char currentChar = str[i];
                String stringNumber = "";

                if (char.IsNumber(currentChar)) // Get index
                {
                    int curNumber = i;

                    while (char.IsNumber(str[curNumber]))
                    {
                        stringNumber += str[curNumber];
                        curNumber++;
                    }

                    int result = Int32.Parse(stringNumber);

                    returnString += new String(str[curNumber], result);

                    i = (curNumber);
                }

            }

            return returnString;
        }

        static void Main(string[] args)
        {
            String encodedString = getEncodedString("HEEEEEELLLOOOO   HOWWWWWWWW AAAAAAAAAAAARRRRRRRRRREEEEEEEEEEEE YYYYYYYYYYUUUUUO?");

            Console.WriteLine(encodedString);

            String decodedString = getDecodedString(encodedString);

            Console.WriteLine(decodedString);
        }
    }
}
