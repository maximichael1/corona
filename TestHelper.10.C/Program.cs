using System;
using System.Collections.Generic;
using System.Linq;

namespace TestHelper._10.C
{
    public class Program
    {
        public static int SortDecending(int num)//not done >;(
        {

            List<int> r = new List<int>();
            foreach (char i in num.ToString())
            {
                r.Add(i);
            }
            r.Sort();
            return System.Convert.ToInt32(r);
        }
        public static string RemoveVowels(string str)
        {
            //List<char> R =new List<char>();
            string R = "";
            char[] c = str.ToCharArray();
            foreach (char a in c)
            {
                if (a != 'a' && a != 'e' && a != 'i' && a != 'o' && a != 'u' &&
                    a != 'A' && a != 'E' && a != 'I' && a != 'O' && a != 'U' )
                {
                    R += a;
                }
            }
            return R;

        }
        public static int CountOnes(int i)
        {
            int c = 0;
            int b = 2;
            string binaryForm = Convert.ToString(i, b);
            foreach (int n in binaryForm)
                if (n == 1)
                    c++;
            return c;
        }
        public static int SumSmallest(int[] values)//WORKES (only positoiv numbers):D
        {
            List<int> n = new List<int>();
            foreach (int i in values)
                if (i > 0)
                    n.Add(i);
            n.Sort();
            values =n.ToArray();
            int r = values[0] + values[1];
            return r;
        }
        public static bool IsIsogram(string str)// working but there is a smarter way
        {
            str = str.ToLower();
            for (int i = 0; i < str.Length; i++)
                for (int j = i + 1; j < str.Length; j++)
                    if (str[i] == str[j])
                        return false;
            return true;
            //not working
            /*int count = 0;
            foreach(char i in str)
            {
                foreach (char n in str)
                {
                    if (n == i && !(str.IndexOf(n) == str.IndexOf(i)))
                        count++;
                }
            }
            if (count > 0)
                return true;
            else
                return false;*/
        }
        public static bool IsPalindrome(int num)
        {
            string nr = "";
            string n = num.ToString();
            for (int i = n.Length-1; i >= 0; i--)
            {
                nr += n[i];
            }
            if (n == nr)
                return true;
            else;
                 return false;

        }
        public static bool IsStrangePair(string str1, string str2)// Done men rekke følgen betyer noget 
        {
            if (str1.Length == 0 && str2.Length == 0) //hvir begge er 0 så er det true 
                return true;
            if (str1.Length == 0 && str2.Length != 0 || str1.Length != 0 && str2.Length == 0)// hvis den ene er 0 og den anden ik er så siger vi false
                return false;
            string c1E = str1.ToCharArray()[str1.Length - 1].ToString(),//definer c1 og c2 
                   c2E = str2.ToCharArray()[str2.Length - 1].ToString();
            if (str1.StartsWith(c2E) && str2.StartsWith(c1E)) // og hvis den ene er starter med hvad den anden slutter med så er det true 
                return true;
            else // ellers så er det false 
                return false;
        }
        public static double Mean(int[] arr)//FAILS IN TEST
        {
            double s = arr.Sum();
            int l = arr.Length;
            return s / l;

        }
        public static string SubReddit(string link) // done optimal
        {
            /*
            int n = 24;
            int end = link.Length-1;
            List<string> r = new List<string>();
            while (n > end)
            {
                r.Add(link[n]);
                n++;
            }*/
            string[]arr = link.Split('/');
            return arr[arr.Length - 2];

        }
        public static double[] CumulativeSum(double[] arr)
        {
            double n = 0;
            List<double> r = new List<double>();
            foreach (Double i in arr)
            {
                n = n + i;
                r.Add(n);
            }
            return r.ToArray();
        }
        public static double[] UniqueSort(double[] arr)//Done Deacent
        {
            var a = new List<double>(arr);
            a.Sort();
            return a.Distinct().ToArray();
        }
        public static double[] FindLargest(double[][] values)// Done deacent 
        {
            var result = new List<double>();// min samling af relsutater det er en liste så jeg kan add sener hen 
            foreach (double[] a in values) // går igennem det hele og smider maxverdierne ind i result 
            {
                
                result.Add(a.Max());
            }
            return result.ToArray();
        }
        public static string LettersOnly(string str)//Done Good 
        {
            return str = new string(str.Where(char.IsLetter).ToArray());
            
        }
        public static int Equal(int a, int b, int c) //Done not optimal
        {
            int n = 0;
            if (a == b)
                n++;
            if (a == c)
                n++;
            if (b == c)
                n++;
            if (n == 1)
                return 2;
            else
            {
                return n;
            }
        }
        //ekesemble til liste
        /*
        class Program
        {
         static void Main()
            {
            // Version 1: create a List of ints.
            // ... Add 4 ints to it.
            var numbers = new List<int>();
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(5);
            numbers.Add(7);
            Console.WriteLine("LIST 1: " + numbers.Count);

            // Version 2: create a List with an initializer.
            var numbers2 = new List<int>() { 2, 3, 5, 7 };
            Console.WriteLine("LIST 2: " + numbers2.Count);
            }
        }
        */
        public static bool IsValid(string zip)//Done men muligt at optimere i frem tiden
        {
            int i = 0;
            if (zip.Length == 5)
            {
                while (i < 5)
                {
                    if (char.IsDigit(zip[i]))
                        i++;
                    else
                        return false;

                }
                return true;
            }
            else
                return false;
        }
        public static bool CheckPalindrome(string str) //Done might need to be optimal
        {
            string rev = new string(str.Reverse().ToArray());
            if (rev == str)
                return true;
            else
                return false;
        }
        public static int HammingDistance(string str1, string str2)//Done godt optimeret
        {
            int i = 0, count = 0;
            while (i != str1.Length)
            {
                if (str1[i] != str2[i])
                    count++;
                i++;

            }
            return count;
        }
        public List<int> Dice(int maxnum, int dices)//NOT! Done næsten done med plads til forbedring
        {
            List<int> result = new List<int>();
            while (0 < dices)
            {
                Random random = new Random();
                result.Add(random.Next(0, maxnum));
                dices--;
            }
            return result;
        }
        public static int MissingNum(int[] arr)//Done godt optimeret
        {
            int num2 = 55;
            int num = arr.Sum();
            return num2 - num;

            /*
                List<int> arrl = new List<int>();
                arrl = arr.ToList();
                arrl.Sort();
                arrl.Reverse();
                int i = 0;
                while (i < 1)
                {
                    if (i+1 != arrl[i]) 
                    {
                        return i;
                    }
                    i++;
                }
                return i;
            */
        }
        public static bool XO(string str)//Done deacent
        {
            str = str.ToLower();
            int num = 0;
            foreach (char x in str)
            {
                if (x == 'x')
                {
                    num++;
                }
                if (x == 'o')
                {
                    num--;
                }
            }
            if (num == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string ReplaceVowels(string str, string ch)//Done højt optimeret 
        {
            ch.ToCharArray();
            return str = str.Replace('a', ch[0]).Replace('e', ch[0]).Replace('i', ch[0]).Replace('o', ch[0]).Replace('u', ch[0]).Replace('y', ch[0]);
        }
        public static object[] RemoveDups(object[] str)//Done kompliceret og liste
        {
            List<object> obj = new List<object>();
            foreach (object n in str)
            {
                obj.Add(n);
            }
            IEnumerable<object> result = obj.Distinct();
            return result.ToArray();
        }
        public static string[] IsFourLetters(string[] arr)//Done kompliceret 
        {
            List<string> r = new List<string>();
            foreach (string s in arr)
            {
                if (s.Length == 4)
                {
                    r.Add(s);
                }
            }
            arr = r.ToArray();
            return arr;
        }
        //public static double Mean(int[] arr)//Done højt optimeret
        //{
        //    return Math.Round(arr.Average());
        //}
        public static string AlphabetSoup(string str)//Done optimeret
        {
            char[] arr = str.ToCharArray();
            Array.Sort(arr);
            return new string(arr);
        }
        public static string Reverse(string str)//Done open to see more details
        {
            //worked :)
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
            //don't Work :(
           // return str.ToCharArray().Reverse().ToString();
        }
        public static string FormatPhoneNumber(int[] numbers)//Done open to see more details
        {
            //de andres metode men optimal
            string numbersString = "(";
            foreach (int number in numbers)
            {
                numbersString += number.ToString();
            }
            return numbersString.ToString().Insert(4, ") ").Insert(9, "-");
            //min første måde virker men er ik optimal
          /*  int FirstPart = numbers[0] * 100 + numbers[1] * 10 + numbers[2];
            int SekundPart = numbers[3] * 100 + numbers[4] * 10 + numbers[5];
            int LastPart = numbers[6] * 1000 + numbers[7] * 100 + numbers[8] * 10 + numbers[9];
            string result = "(" + FirstPart + ") " + SekundPart + "-" + LastPart;
            return result;*/
        }
        public static int[] NoOdds(int[] arr)//Done højt optimeret
        {
            List<int> result = new List<int>();
            foreach (int num in arr)
            {
                if (num % 2 == 0)
                {
                    result.Add(num);
                }
            }
            return result.ToArray();
        }
        public static bool isBetween(string first, string last, string word)//Done optimeret
        {
            string[] startSrray = { first, last, word };
            string[] result = { first, word, last };
            Array.Sort(startSrray);
            if (startSrray[0] == result[0] & startSrray[1] == result[1] & startSrray[2] == result[2])
                return true;
            else
                return false;
        }
        public static bool SameCase(string str)//Done optimeret
        {
            if (str == str.ToLower())
                return true;
            if (str == str.ToUpper())
                return true;
            else
                return false;

            //Array.Sort(str);
        }
        static void Main(string[] args)// testine list
        {
            int num = 1231;
            IsPalindrome(num);
            Console.ReadKey();
        }
    }
}
