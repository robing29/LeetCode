namespace Problem14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestCommonPrefix(new string[] { "cir", "car" }));
            Console.WriteLine("Hello, World!");
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            Dictionary<char, (string prefix, int anzahl)> dict = new Dictionary<char, (string prefix, int anzahl)> ();

            foreach (string str in strs)
            {
                if(String.IsNullOrWhiteSpace(str)) return "";
                if (!dict.ContainsKey(str[0])){
                    dict.Add(str[0], (str,1));
                } else
                {
                    string bisherigesPrefix = dict[str[0]].prefix;
                    int bisherigeAnzahl = dict[str[0]].anzahl;
                    string neuesPrefix = "";
                    int i = 0;
                    while (i < Math.Min(bisherigesPrefix.Length, str.Length) && str[i] == bisherigesPrefix[i])
                    {
                        neuesPrefix += str[i];
                        i++;
                    }
                    dict.Remove(str[0]);
                    dict.Add(str[0], (neuesPrefix, (bisherigeAnzahl + 1)));
                }
            }

            int hoechsteAnzahl = 0;
            foreach (var item in dict)
            {
                hoechsteAnzahl = Math.Max(hoechsteAnzahl, item.Value.anzahl);
            }
            if (hoechsteAnzahl == 0) {
                return "";
            } else if (dict.Select(x => x.Value.anzahl == hoechsteAnzahl).Count() > 1) {
                return "";
            } else
            {
                return dict.Where(x => x.Value.anzahl == hoechsteAnzahl).ToList().First().Value.prefix;
            }
            
        }
    }
}