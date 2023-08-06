namespace Problem13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("III"));
            Console.WriteLine(RomanToInt("IV"));
            Console.WriteLine(RomanToInt("IX"));
            Console.WriteLine(RomanToInt("II"));
            Console.WriteLine(RomanToInt("I"));
            Console.WriteLine(RomanToInt("X"));
            Console.WriteLine(RomanToInt("LVIII"));
            Console.WriteLine(RomanToInt("MCMXCIV"));
            Console.WriteLine(RomanToInt("DCXXI"));
            Console.WriteLine("Hello, World!");
        }
        public static int RomanToInt(string s)
        {
            /*
             * I             1
             * V             5
             * X             10
             * L             50
             * C             100
             * D             500
             * M             1000
             */
            //III
            //LVIII
            //MCMXCIV
            //MMCM

            Dictionary<char, int> romans = new Dictionary<char, int>();
            romans.Add('I', 1);
            romans.Add('V', 5);
            romans.Add('X', 10);
            romans.Add('L', 50);
            romans.Add('C', 100);
            romans.Add('D', 500);
            romans.Add('M', 1000);

            int ptrL = 0;
            int ptrR = 0;

            int value = 0;
            int tmpvalue = 0;
            while(ptrR < s.Length)
            {
                while (s[ptrL] == s[ptrR] && ptrR < s.Length)
                {
                    value += romans[s[ptrL]];
                    ptrR++;
                    if (ptrR == s.Length) return value;
                }
                if (romans[s[ptrR]] > romans[s[ptrL]])
                {
                    value -= romans[s[ptrL]];
                    value += romans[s[ptrR]] - romans[s[ptrL]];
                    ptrR++;
                    if (ptrR == s.Length) return value;
                }
                ptrL = ptrR;
            }
            return value;
        }
    }
}