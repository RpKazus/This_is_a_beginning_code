using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApplication17
{
    class Calculator
    {
        static double Polish;
        List<string> Xes = new List<string>();
        private static DataTable dt = new DataTable();
        private static Dictionary<char, int> priora = new Dictionary<char, int>();
        public static string FindExpression(string str, int step)
        {
            string st = FindValue(step, str, false);
            string rd = FindValue(step, str, true);
            return st + str[step] + rd;
        }
        private static void Begin()
        {
            if (priora.Count == 0)
            {
                priora.Add('+', 1);
                priora.Add('-', 2);
                priora.Add('/', 4);
                priora.Add('*', 3);
            }
        }
        private static string FindValue(int root, string str, bool isTrue)
        {
            try
            {
                int i;
                int barrier = root;
                if (isTrue)
                    for (i = root + 1; i < str.Length; i++)
                    {
                        try
                        {
                            (Convert.ToDouble(str.Substring(barrier + 1, i - barrier))).ToString();
                        }
                        catch (FormatException)
                        {
                            if (str[i] == '(')
                                do
                                    i++;
                                while (str[i] != ')');
                            else if (str[i] == ')')
                                return str.Substring(root + 1, i - root - 1);
                            else if (i > root + 1)
                                if (priora[str[i]] > priora[str[root]])
                                    barrier = i;
                                else
                                    return str.Substring(root + 1, i - root - 1);
                            else
                                continue;
                        }
                        if (i == str.Length - 1)
                            return str.Substring(root + 1, i - root);
                    }
                else
                    for (i = root - 1; i >= 0; i--)
                    {
                        try
                        {
                            double temp = Convert.ToDouble(str.Substring(i, barrier - i));
                            if (temp < 0 || str[i] == '+')
                                throw new FormatException();
                        }
                        catch (FormatException)
                        {
                            if (str[i] == ')')
                                do
                                    i--;
                                while (str[i] != '(');
                            else if (str[i] == '(')
                                return str.Substring(i + 1, root - i - 1);
                            else if (priora[str[i]] >= priora[str[root]])
                                barrier = i;
                            else
                                return str.Substring(i + 1,root - i - 1);
                        }
                        if (i == 0)
                            return str.Substring(0, root);
                    }
                return str.Substring(0, root);
            }
            catch(Exception)
            {
                throw new DivideByZeroException();
            }
        }
        public static double Compute(string str, int location)
        {
            Begin();
            return Convert.ToDouble(dt.Compute(FindExpression(str, location), string.Empty));
        }
        /*public static string Simpler(string str)
        {
            int lastLenght = str.Length;
            int st = 0;
            for (int i = 0; i < str.Length; i++)
                try
                {
                    Convert.ToDouble(str.Substring(st, i + 1 - st));
                    if (i == str.Length - 1)
                    {
                        i++;
                        throw new DivideByZeroException();
                    }
                }
                catch(Exception)
                {
                    if (!Char.IsLetter(str[st]) && str[st] != '/' && str[st] != '*' && str[st] != '=')
                        str = str.Substring(0, st) + (Convert.ToDouble(str.Substring(st, i - st)) / Polish).ToString() + str.Substring(i, str.Length - i);
                        i += str.Length - lastLenght;
                        if (i < str.Length - 1)
                            if (i < str.Length - 1 & str[i] == '+')
                                i++;
                                st = i;
                    lastLenght = str.Length;
                }
            return str; 
                        
        }*/
        /*public string Simpler(string str)
        {
            int step = 1;
            int marker1;
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                {
                    if(step == 0) marker1 = i;
                    step++;
                }
                else if (str[i] == ')')
                    if(step == 1)
                    {

                        //str = str.Substring(0, i) + CountBracket(str.Substring(marker1, i)) + str.Substring(i + 1,);
                    }
                    else
                    step--;
            }
        }
        public string CountBracket(string str, int begin, int end, int mode)
        {
            try
            {
                if(priora[str[begin - 1]] >= 3)
                {
                    try
                    {
                        int marker1;
                        int step = 0;
                        for(int i = begin - 2; i >= 0; i--)
                        {
                            if (str[i] == '(')
                            {
                                if(step == 0) marker1 = i;
                                step++;
                            }
                            else if (str[i] == ')')
                                if(step == 1)
                                {

                                    
                                }
                                else
                                step--;
                            //else if()
                        }
                    }
                    catch (Exception)
                    {
                        begin--;
                    }
                }
            }
            catch (Exception)
            {

            }
        }*/
        public static double Compute(string str, char ch, double polish)
        {
            Begin();
            return FindXExpression(str, ch);
        }
        public static double FindXExpression(string str, char ch)
        {
            string tempstring = str;
            double value = -1;
                do
                {
                    value++;
                    str = tempstring;
                    for (int i = 0; i < str.Length; i++)
                        if (str[i] == ch)
                            str = str.Substring(0, i) + "(" + value + "/" + (1 / Polish) + ")" + str.Substring(i + 1, str.Length - i - 1);
                }
                while (!Convert.ToBoolean(dt.Compute(str, string.Empty)));
            return value * Polish;
        }
    }
}
