using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    class Calculator
    {
        public static bool Polish = false;
        List<string> Xes = new List<string>();
        private static DataTable dt = new DataTable();
        private static Dictionary<char, int> priora = new Dictionary<char, int>();
        #region Moves
        public static List<string> timeList = new List<string>();
        public static int move = 1;
        public static Tree AnalyzeString(string str)
        {
            string left = GetAll(str, 1);
            string right = GetAll(str, 2);
            if (left == "" || right == "")
                return new Tree(new Tree(), str, new Tree());
            while (left[0] == '(' && left[left.Length - 1] == ')' && FindBracket(left, 0) == left.Length - 1)
                left = left.Substring(1, left.Length - 2);
            while (right[0] == '(' && right[right.Length - 1] == ')' && FindBracket(right, 0) == right.Length - 1)
                right = right.Substring(1, right.Length - 2);
            return new Tree(AnalyzeString(left), GetChar(str, true), AnalyzeString(right));
        }
        public static float Longer(float st, float nd, bool b)
        {

            return (b) ? ((st >= nd) ? st : nd) : ((st < nd) ? st : nd);
        }
        public static int Lenght(string str, Font font)
        {
            PaintEventArgs e = new PaintEventArgs(ServerMachine.ActivePage.CreateGraphics(), new Rectangle(0, 0, 1000, 1000));
            return (int)e.Graphics.MeasureString(str, font, 1000000).Width - 1 * str.Length;
            //return (int)(str.Length * font.Size / (35 / 33));
        }
        public static Image Count_Paint(Decimal st, char val, Decimal nd)
        {
            List<Point> points = new List<Point>();
            List<int> poinList = new List<int>();
            string strSt = st.ToString();
            string strNd = nd.ToString();
            int Stpointpos = Find(strSt, ',');
            int Ndpointpos = Find(strNd, ',');
            int afterPoint = ServerMachine.usage;
            
            while (strSt.Length - (Stpointpos == -1 ? strSt.Length : Stpointpos) > strNd.Length - (Ndpointpos == -1 ? strNd.Length : Ndpointpos) && (val == '-' || val == '+'))
            {
                if (Ndpointpos == -1)
                {
                    Ndpointpos = strNd.Length;
                    strNd += ',';
                }
                strNd += '0';
            }
            while (strSt.Length - (Stpointpos == -1 ? strSt.Length : Stpointpos) < strNd.Length - (Ndpointpos == -1 ? strNd.Length : Ndpointpos) && (val == '-' || val == '+'))
            {
                if (Stpointpos == -1)
                {
                    Stpointpos = strSt.Length;
                    strSt += ',';
                }
                strSt += '0';
            }
            int longest = (int)Longer(strSt.Length, strNd.Length, true);
            int shortest = (int)Longer(strSt.Length, strNd.Length, true);
            int scale = (val == '/') ? 3 : 6;
            Decimal answer = st / nd;
                poinList.Add(0);
            int an_len = answer.ToString().Length;
            Font std = new Font("", scale * 35);
            Bitmap bmp = new Bitmap(100, 100);
            int moveCheck = -1;
            if (Find_Period(st, nd, 1) != "")
                moveCheck = Convert.ToInt16(Find_Period(st, nd, 2)) + Find_Period(st, nd, 1).Length / 2;
            switch (val)
            {
                #region plussing
                case '+':

                    {

                    }
                    break;
                #endregion
                #region minussing
                case '-':
                    {

                    }
                    break;
                #endregion
                #region mnossing
                case '*':
                    {
                        strSt = strSt.Replace(",", "");
                        strNd = strNd.Replace(",", "");
                        bmp = new Bitmap((an_len * 25 + 30) * scale, (strNd.Length * 50 + 180) * scale);
                        Graphics gr = Graphics.FromImage(bmp);
                        gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        int bmp_Height = strNd.Length * 50 + 180;
                        int bmp_Width = an_len * 25 + 30;
                        gr.DrawString(strSt.Substring(0, (Stpointpos != -1) ? Stpointpos : strSt.Length), std, new SolidBrush(Color.Black), new Point((bmp_Width - 20 - (Stpointpos != -1 ? 10 : 0) - strSt.Length * 25) * scale, 10 * scale));
                        gr.DrawString(strNd.Substring(0, (Ndpointpos != -1) ? Ndpointpos : strNd.Length), std, new SolidBrush(Color.Black), new Point((bmp_Width - 20 - (Ndpointpos != -1 ? 10 : 0) - strNd.Length * 25) * scale, 60 * scale));
                        if (Stpointpos != -1)
                            gr.DrawString(",", new Font("", 25 * scale), new SolidBrush(Color.Black), new Point((bmp_Width - 25 - strSt.Length * 25 + Stpointpos * 25) * scale, 22 * scale));
                        if(Ndpointpos != -1)
                            gr.DrawString(",", new Font("", 25 * scale), new SolidBrush(Color.Black), new Point((bmp_Width - 25 - strNd.Length * 25 + Ndpointpos * 25) * scale, 72 * scale));
                        gr.DrawString(Stpointpos != -1 ? strSt.Substring(Stpointpos, strSt.Length - Stpointpos) : "", std, new SolidBrush(Color.Black), new Point((bmp_Width - 20 - (strSt.Length - Stpointpos) * 25) * scale, 10 * scale));
                        gr.DrawString(Ndpointpos != -1 ? strNd.Substring(Ndpointpos, strNd.Length - Ndpointpos) : "", std, new SolidBrush(Color.Black), new Point((bmp_Width - 20 - (strNd.Length - Ndpointpos) * 25) * scale, 60 * scale));
                        gr.DrawString("×", std, new SolidBrush(Color.Black), new Point((bmp_Width - 57 - ((strSt.Length >= strNd.Length && Stpointpos != -1) || (strSt.Length <= strNd.Length && Ndpointpos != -1) ? 10 : 0) - longest * 25) * scale, 35 * scale));
                        gr.DrawLine(new Pen(new SolidBrush(Color.Black), 1), new Point(20 * scale, 115 * scale), new Point((bmp_Width - 10) * scale, 112 * scale));
                        int plus = 0;
                        int down = 0;
                        int plus_plus = 1;
                        int additional = 0;
                        for (int i = strNd.Length - 1; i >= 0 ; i-- )
                        {
                            for (int o = strSt.Length - 1; o >= 0 ; o--)
                            {
                                Decimal dd = Convert.ToDecimal(strNd[i].ToString()) * Convert.ToDecimal(strSt[o].ToString()) + poinList[0];
                                gr.DrawString(dd >= 10 ? (dd % 10).ToString() : (dd).ToString(), std, new SolidBrush(Color.Black), new Point((bmp_Width - 45 - (plus++) * 25) * scale, (120 + down + additional) * scale));
                                //return bmp;
                                if (dd >= 10)
                                {
                                    if (points.Contains(new Point(bmp_Width - 30 - (int)((plus_plus - 1) * 4) - (plus - plus_plus) * 25, 8 - (int)((plus_plus - 1) * 4))))
                                    {
                                        gr.DrawLine(new Pen(new SolidBrush(Color.Black), 1), new Point((bmp_Width - 29 - (int)((plus_plus - 1) * 4) - (plus - plus_plus) * 25) * scale, (8 - (int)((plus_plus - 1) * 4) + 11 + additional) * scale), new Point((bmp_Width - 21 - (int)((plus_plus - 1) * 4) - (plus - plus_plus) * 25) * scale, (8 - (int)((plus_plus - 1) * 4) + 5 + additional) * scale));
                                        points.Remove(new Point(bmp_Width - 30 - plus_plus + 1 - (plus - plus_plus + 1) * 25, 8 - plus_plus + 1));
                                    }
                                    if ((8 - (int)(plus_plus * 4)) * scale < 0)
                                    {
                                        Image img = (Image)bmp.Clone();
                                        gr.Clear(Color.Transparent);
                                        bmp = new Bitmap(bmp.Width, bmp.Height + 15 * scale);
                                        gr = Graphics.FromImage(bmp);
                                        gr.DrawImage(img, 0, 15 * scale);
                                        additional += 15;
                                    }
                                    gr.DrawString(((dd - dd % 10) / 10).ToString(), new Font("", 10 * scale), new SolidBrush(Color.Black), new Point((bmp_Width - 30 - (int)(plus_plus * 4) - (plus - plus_plus) * 25) * scale, (8 - (int)(plus_plus * 4) + additional) * scale));
                                    points.Add(new Point(bmp_Width - 30 - (int)(plus_plus * 4) - (plus - plus_plus) * 25, 8 - (int)(plus_plus * 4)));
                                }
                                poinList.Add(Convert.ToInt16((dd - dd % 10) / 10));
                                poinList.Remove(poinList[0]);
                            }
                            if(poinList.Count >= 1 && poinList[0] > 0)
                                gr.DrawString(poinList[0].ToString(), std, new SolidBrush(Color.Black), new Point((bmp_Width - 45 - (plus) * 25) * scale, (120 + down) * scale));
                            poinList[0] = 0;
                            down += 50;
                            plus = plus_plus++;
                        }
                        gr.DrawLine(new Pen(new SolidBrush(Color.Black), 1), new Point(20 * scale, (bmp_Height - 55 + additional) * scale), new Point((bmp_Width - 10) * scale, (bmp_Height - 58 + additional) * scale));
                        gr.DrawString(answer.ToString(), std, new SolidBrush(Color.Black), new Point(10 * scale, (bmp_Height - 52 + additional) * scale));
                        return bmp;
                    }
                    break;
                #endregion
                #region deling
                case '/':
                    {
                        int pluss = 1;
                        while (Find_Form(strSt, ',') >= Find_Form(strNd, ',') ? Find_Form(strSt, ',') != -1 : Find_Form(strNd, ',') != -1)
                        {
                            strSt = (Convert.ToDecimal(strSt) * 10).ToString();
                            strNd = (Convert.ToDecimal(strNd) * 10).ToString();
                        }
                        while (Convert.ToDecimal(strSt) * pluss < Convert.ToDecimal(strNd))
                            pluss *= 10;
                        int bmp_Height = (strNd.Length + strSt.Length) * 25 + 60 + (pluss.ToString().Length - 1) * 25 ;
                        int bmp_Width = 120;
                        bmp = new Bitmap(((strNd.Length + strSt.Length) * 25 + 60 + (pluss.ToString().Length - 1) * 25) * scale, 120 * scale);
                        Graphics gr = Graphics.FromImage(bmp);
                        gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        gr.DrawString(strSt, std, new SolidBrush(Color.Black), new Point(0, 10 * scale));
                        strSt = (Convert.ToDecimal(strSt) * pluss).ToString();
                        int locX = Lenght(strSt, new Font("", std.Size / scale));
                        gr.DrawLine(new Pen(new SolidBrush(Color.Black), scale), new Point(5 * scale + Lenght(strSt, std), 55 * scale), new Point((bmp.Width - 10 * scale), 55 * scale));
                        gr.DrawLine(new Pen(new SolidBrush(Color.Black), scale), new Point(5 * scale + Lenght(strSt, std), 105 * scale), new Point(5 * scale + Lenght(strSt, std), 5 * scale));
                        gr.DrawString(strNd, std, new SolidBrush(Color.Black), new Point(5 * scale + Lenght(strSt, std), 10 * scale));
                        int found = Find_Form(answer.ToString(), ',');
                        if(found == -1) found = 0;
                        bmp = change(5 + Lenght(strSt, new Font("", std.Size / scale)), 65, answer, std, bmp, scale);
                        gr = Graphics.FromImage(bmp);
                        string anString = (ServerMachine.usage > 0) ? answer.ToString().Substring(0, (found != 0) ? found + 1 + (afterPoint + 1 + found < answer.ToString().Length ? afterPoint + 1 + found : answer.ToString().Length - found - 1) : answer.ToString().Length) : answer.ToString().Substring(0, Convert.ToInt32(Find_Period(st, nd, 3))) + Find_Period(st, nd, 1);
                        gr.DrawString(anString, std, new SolidBrush(Color.Black), new Point(5 * scale + Lenght(strSt, std), 65 * scale));
                        int length = 1;
                        while (((strSt[length - 1] == ',') ? Convert.ToDecimal(strSt.Substring(0, length - 1)) : Convert.ToDecimal(strSt.Substring(0, length))) < Convert.ToDecimal(strNd))
                        {
                            length++;
                            if (length == strSt.Length)
                                break;
                        }
                        int length2 = 1;
                        while (((strNd[length2 - 1] == ',') ? Convert.ToDecimal(strNd.Substring(0, length2 - 1)) : Convert.ToDecimal(strNd.Substring(0, length2))) < nd)
                        {
                            length2++;
                            if (length2 == strNd.Length)
                                break;
                        }
                        gr.DrawArc(new Pen(new SolidBrush(Color.Black), 5), new Rectangle(new Point(10 * scale, 0), new Size((length * 25) * scale, 30 * scale)),  180 , 180);
                        int locY = 65;
                        bool canUp = true;
                        Decimal tempSt = Convert.ToDecimal(strSt.Substring(0, length));
                        Decimal tempNd = Convert.ToDecimal(strNd);
                        Decimal plus = tempSt;
                        Decimal oldSt = 0;
                        int moves = 0;
                        do
                        {
                            canUp = true;
                            gr.DrawLine(new Pen(new SolidBrush(Color.Black), scale * 2), new Point((locX - 7) * scale - Lenght(tempSt.ToString(), std), (locY - 5) * scale), new Point((locX + 2) * scale - Lenght(tempSt.ToString(), std), (locY - 5) * scale));
                            oldSt = tempSt;
                            tempSt = plus - plus % tempNd;
                            bmp = change(locX, locY, tempSt, std, bmp, scale);
                            gr = Graphics.FromImage(bmp);
                            gr.DrawString(tempSt.ToString(), std, new SolidBrush(Color.Black), new Point(locX * scale - Lenght(tempSt.ToString(), std), locY * scale));
                            gr.DrawLine(new Pen(new SolidBrush(Color.Black), scale), new Point((locX + 7) * scale - Lenght(tempSt.ToString(), std), (locY + 45) * scale), new Point((locX + 21) * scale, (locY + 45) * scale));
                            plus = (tempSt == 0) ? 0 : plus % tempSt;
                            if (plus == 0)
                                canUp = false;
                            locY += 50;
                            locX += 25;
                            //locX += (plus.ToString().Length - tempSt.ToString().Length) * 25 + 5;
                            bmp = change(locX, locY, plus, std, bmp, scale);
                            gr = Graphics.FromImage(bmp);
                            if (moves == moveCheck && afterPoint == 0)
                            {
                                //locY += 50;
                                gr.DrawString(plus.ToString(), std, new SolidBrush(Color.Black), new Point(locX * scale - Lenght(plus.ToString(), std), locY * scale));
                                gr.DrawString(">> в периоде...", new Font("", std.Size / 4 + std.Size / 2), new SolidBrush(Color.Blue), new Point(locX * scale, (locY + 12) * scale));
                                break;
                            }
                            string plusa = plus.ToString();
                            if (plus < tempNd && canUp)
                            {
                                while (plus < tempNd && (plus != 0 ? true : strSt.Length > length))
                                    if (strSt.Length > length)
                                    {
                                        plus = Convert.ToDecimal(plus.ToString() + strSt[length]);
                                        length++;
                                    }
                                    else if(plus != 0)
                                        plus *= 10;
                            }
                            gr.DrawString(plus.ToString(), std, new SolidBrush(Color.Black), new Point(locX * scale - Lenght(plus.ToString(), std), locY * scale));
                            locY += 50;
                            moves++;
                        }
                        while (moves < an_len - Convert.ToInt16(Find_Form(answer.ToString(), ',') != -1) && moves < afterPoint && (tempSt != 0 &&));
                    }
                    break;
                #endregion
            }
            Graphics gro = Graphics.FromImage(bmp);
            gro.DrawRectangle(new Pen(new SolidBrush(Color.Black), 3), 0, 0, bmp.Width - 1, bmp.Height - 1);
            return bmp;
        }
        private static Bitmap change(int locX, int locY, Decimal tempSt, Font std, Bitmap bmp, int scale)
        {
                if (locX * scale + Lenght(tempSt.ToString(), std) >= bmp.Width)
                {
                    Image img = bmp;
                    bmp = new Bitmap(bmp.Width - (bmp.Width - (locX * scale + Lenght(tempSt.ToString(), std))), bmp.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    gr.DrawImage(img, 0, 0);
                    gr.Dispose();
                    img.Dispose();
                }
                GC.Collect();
                if (locY * scale + 50 * scale >= bmp.Height)
                {
                    Image img = bmp;
                    bmp = new Bitmap(bmp.Width, bmp.Height - (bmp.Height - (locY * scale + 50 * scale)));
                    Graphics gr = Graphics.FromImage(bmp);
                    gr.DrawImage(img, 0, 0);
                    gr.Dispose();
                    img.Dispose();
                }
                GC.Collect();
                return bmp;
        }
        public static Decimal Calculate(Tree tree)
        {
            try
            {
                Convert.ToDecimal(tree.value);
                    return Convert.ToDecimal(tree.value);
            }
            catch (FormatException)
            {
                Decimal st = Calculate(tree.leftTree);
                Decimal nd = Calculate(tree.rightTree);
                //object answer = dt.Compute("-14 * scale0.0+26.8", string.Empty);
                object answer = dt.Compute(st.ToString().Replace(',', '.') + tree.value + nd.ToString().Replace(',', '.').ToString(), string.Empty);
                timeList.Add(move.ToString() + ". " + st + tree.value + nd + "=" + answer);
                move++;
                return Convert.ToDecimal(answer);
            }
        }
        public static Tree SetTree(Tree leftTree, string str, Tree rightTree)
        {
            if (GetChar(str) != -1)
                return new Tree(leftTree, GetChar(str, true), rightTree);
            return new Tree(leftTree, str, rightTree);
        }
        public static string GetAll(string str, int num)
        {
            int i = GetChar(str);
            if (i != -1)
            {
                string left = str.Substring(0, i);
                string right = str.Substring(i + 1, str.Length - i - 1);
                if (num == 1)
                    return left;
                return right;
            }
            return "";
        }
        public static int GetChar(string str)
        {
            if (Find(str, '+') > -1)
                return Find(str, '+');
            else if (Find(str, '-') > -1)
                return Find(str, '-');
            else if (Find(str, '*') > -1)
                return Find(str, '*');
            else if (Find(str, '/') > -1)
                return Find(str, '/');
            return -1;
        }
        public static string GetChar(string str, bool type)
        {
            return str.Substring(GetChar(str), 1);
        }
        public static List<string> MakePrimer(string str)
        {
            Calculate(AnalyzeString(str));
            return timeList;
        }
        public static void Sort()
        {
            List<string> time2 = timeList;
            foreach(string stora in time2)
                timeList[Convert.ToInt32(stora.Substring(0, Find(stora, '.')))] = stora;
        }
        #endregion
        #region Main
        public static bool IsInPeriod(decimal st, decimal nd)
        {
            return true;
        }
        //Код симулирует решение в столбик
        static int Find_Form(string str, char ch)
        {
            if(Convert.ToDecimal(str) % 1 != 0)
            {
                for (int i = 0; i < str.Length; i++)
                    if (str[i] == ch)
                        return i;
            }
            return -1;
        }
        static int FindValua(List<int[]> list, int[] val)
        {
            for (int i = 0; i < list.Count; i++)
                if (list[i][0].Equals(val[0]) && list[i][1].Equals(val[1]))
                    return i;
            return -1;
        }
        public static string Find_Period(decimal st, decimal nd, int bab)
        {
            string answer = (st / nd).ToString();
            string halfAnswer = answer.Substring(Find_Form(answer, ',') + 1);
            List<int[]> listing = new List<int[]>();
            string k = "";
            int found = Find_Form(answer, ',');
            int length = 1;
            string strSt = st.ToString();
            string strNd = nd.ToString();
            int move = 0;
            //подгон чисел
            while (Find_Form(strSt, ',') >= Find_Form(strNd, ',') ? Find_Form(strSt, ',') != -1 : Find_Form(strNd, ',') != -1)
            {
                strSt = (Convert.ToDecimal(strSt) * 10).ToString();
                strNd = (Convert.ToDecimal(strNd) * 10).ToString();
            }
            int pluss = 1;
            while (Convert.ToDecimal(strSt) * pluss < Convert.ToDecimal(nd.ToString()))
                pluss *= 10;
            if (pluss != 1)
                move = pluss.ToString().Length - 1;
            strSt = (Convert.ToDecimal(strSt) * pluss).ToString();
            while (((strSt[length - 1] == ',') ? Convert.ToDecimal(strSt.Substring(0, length - 1)) : Convert.ToDecimal(strSt.Substring(0, length))) < Convert.ToDecimal(nd.ToString()))
            {
                if (length >= strSt.Length)
                    break;
                else length++;
            }
            decimal tempSt = Convert.ToDecimal(strSt.Substring(0, length));
            decimal plus = tempSt;
            decimal tempNd = Convert.ToDecimal(strNd);
            for (int i = 0; i < 31 + answer.Length - halfAnswer.Length; i++)
            {
                if (plus < tempNd)
                {
                    if (plus == 0)
                        return "";
                    while (plus < tempNd)
                    {
                        if (st.ToString().Length > length)
                        {
                            plus = Convert.ToDecimal(plus.ToString() + strSt[length]);
                            length++;
                        }
                        else
                            plus *= 10;
                        i++;
                    }
                    i--;
                }
                tempSt = plus - plus % tempNd;
                plus = plus % tempSt;
                if (i >= answer.Length - halfAnswer.Length - 1)
                {
                    if (FindValua(listing, new int[2] { Convert.ToInt32(tempSt), Convert.ToInt32(plus) }) != -1)
                    {
                        int ff = FindValua(listing, new int[2] { Convert.ToInt32(tempSt), Convert.ToInt32(plus) });
                        k = halfAnswer.Substring(ff, i - 1 - ff);
                        if (bab == 1)
                            return "(" + k + ")";
                        else if (bab == 2)
                            return ff.ToString();
                        else if (bab == 3)
                            return (answer.Length - halfAnswer.Length + ff).ToString();
                    }
                    else
                        listing.Add(new int[2] { Convert.ToInt32(tempSt), Convert.ToInt32(plus) });
                }
                else move++;

            }
            return "";
        }
        public static string FindExpression(string str, int step)
        {
            string st = FindValue(step, str, false);
            string rd = FindValue(step, str, true);
            return st + str[step] + rd;
        }
        public static int Find(string str, char ch)
        {
            int stat = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                    stat++;
                else if (str[i] == ')')
                    stat--;
                else if (str[i] == ')' && stat > 0)
                    stat--;
                else if (str[i] == ')' && stat <= 0)
                    return i - 1;
                else if (stat == 0 && (str[i] == ch))
                    return i;
            }
            return -1;
        }
        public static void Begin()
        {
            if (priora.Count == 0)
            {
                priora.Add('+', 1);
                priora.Add('-', 1);
                priora.Add('/', 3);
                priora.Add('*', 3);
            }
        }
        public static string MakeX(string str)
        {
            while (FindInnest(str) != -1)
            {
                string str1 = Simpler(str, FindInnest(str), FindBracket(str, FindInnest(str)), 1, true);
                string str2 = Simpler(str, FindInnest(str), FindBracket(str, FindInnest(str)), 1, false);
                str = str.Replace(str2, str1);
            }
            
            return (Polish) ? dt.Compute(str, string.Empty).ToString() : str.Substring(1, str.Length - 1);
        }
        public static List<string> FindOut(string str)
        {
            int marker = 0;
            List<string> slist = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] == '+' || str[i] == '-') && i > 0)
                    if (str[i - 1] != '*' || str[i - 1] != '/' || str[i - 1] != '-' || str[i - 1] != '+')
                    {
                        slist.Add(str.Substring(marker, i - marker));
                        marker = i;
                    }
                if (i + 1 == str.Length)
                    slist.Add(str.Substring(marker, i - marker + 1));
            }
                return slist;
        }
        public static string AnalyzeString(string left, string right, int mode)
        {
            string answer = "";
            char symbol = '*';
            left = left.Replace("(", "");
            left = left.Replace(")", "");
            right = right.Replace("(", "");
            right = right.Replace(")", "");
            if (left != "" && right != "")
            {
                if (mode == 0)
                {
                    symbol = left[left.Length - 1];
                    left = left.Substring(0, left.Length - 1);
                }
                else
                {
                    symbol = right[0];
                    right = right.Substring(1, right.Length - 1);
                } 
                List<string> leftListr = FindOut(left);
                List<string> rightListr = FindOut(right);
                for (int st = 0; st < leftListr.Count; st++)
                    for (int nd = 0; nd < rightListr.Count; nd++)
                    {
                        leftListr[st] = (leftListr[st][0] != '+' && leftListr[st][0] != '-') ? '+' + leftListr[st] : leftListr[st];
                        answer += leftListr[st] + symbol + rightListr[nd];
                    }
                answer = answer.Replace("*+", "*");
                answer = answer.Replace("/+", "/");
                answer = answer.Replace("++", "+");
                answer = answer.Replace("-+", "-");
                answer = answer.Replace("--", "-");
                answer = answer.Replace("+-", "-");
                return (answer[0] == '+') ? answer.Substring(1, answer.Length - 1) : answer;
            }
            if (left != "")
                return left;
            else
                return right;
        }
        public static int FindInnest(string str)
        {
            int br = -1;
            int depth = 0;
            int marker_depth = 0;
            for (int i = 0; i < str.Length; i++)
                if (str[i] == '(')
                {
                    depth++;
                    if(depth > marker_depth)
                    {
                        marker_depth = depth;
                        br = i;
                    }
                }
                else if (str[i] == ')')
                    depth--;
            return br;
        }
        private static int FindBracket(string str, int st)
        {
            if (st != -1)
            {
                int brcount = 0;
                for (int i = st; i < str.Length; i++)
                    if (str[i] == '(')
                        brcount++;
                    else if (str[i] == ')')
                        if (brcount == 1)
                            return i;
                        else
                            brcount--;
            }
            return -1;
        }
        private static int RefindBracket(string str, int st)
        {
            if (st != -1)
            {
                int brcount = 0;
                for (int i = st; i >= 0; i--)
                    if (str[i] == ')')
                        brcount++;
                    else if (str[i] == '(')
                        if (brcount == 1)
                            return i;
                        else
                            brcount--;
            }
            return -1;
        }
        private static string FindValue(int root, string str, bool isTrue)
        {
            //try
            {
                int i;
                int barrier = root;
                if (isTrue)
                    for (i = root + 1; i < str.Length; i++)
                    {
                        try
                        {
                            if(str[i] != '.')
                                (Convert.ToDecimal(str.Substring(barrier + 1, i - barrier).Replace('.', ','))).ToString();
                        }
                        catch (FormatException)
                        {
                            if (str[i] == '(')
                                i = FindBracket(str, i);
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
                            Decimal temp;
                            if (str[i] != '.')
                            {
                                temp = Convert.ToDecimal(str.Substring(i, barrier - i).Replace('.', ','));
                                if (temp < 0 || str[i] == '+')
                                    throw new FormatException();
                            }
                        }
                        catch (FormatException)
                        {
                            if (str[i] == ')')
                                i = RefindBracket(str, i);
                            else if (str[i] == '(')
                                return str.Substring(i + 1, root - i - 1);
                            else if (priora[str[i]] >= priora[str[root]])
                                barrier = i;
                            else
                                return str.Substring(i + 1, root - i - 1);
                        }
                        if (i == 0)
                            return str.Substring(0, root);
                    }
                return str.Substring(0, root);
            }
            /*catch(Exception)
            {
                throw new DivideByZeroException();
            }*/
        }
        public static Decimal Compute(string str, int location)
        {
            Begin();
            str = str.Replace(',', '.');
            return Convert.ToDecimal(dt.Compute(FindExpression(str, location), string.Empty));
        }
        public static string Simpler(string str,int beg, int end, int mode, bool may)
        {
             Begin();
            string st = "";
            string nd = "";
            int lastLenght = str.Length;
            if ((str[beg - 1] == '*' || str[beg - 1] == '/') && mode != 2)
                st = Simpler(str, beg - 1 - FindValue(beg - 1, str, false).Length, beg - 2, 0, true) + str[beg - 1];
            if(end + 1 < str.Length)
                if ((str[end + 1] == '*' || str[end + 1] == '/') && mode != 0)
                    nd = str[end + 1] + Simpler(str, end + 2, end + 1 + FindValue(end + 1, str, true).Length, 2, true);
            if (may)
            {
                str = str.Replace(str.Substring(beg, end + str.Length - lastLenght - beg + 1), AnalyzeString(st, str.Substring(beg, end + str.Length - lastLenght - beg + 1), 0));
                str = str.Replace(str.Substring(beg, end + str.Length - lastLenght - beg + 1), AnalyzeString(str.Substring(beg, end + str.Length - lastLenght - beg + 1), nd, 1));
                try
                {
                    if(Polish)
                        return dt.Compute(str.Substring(beg, end + str.Length - lastLenght - beg + 1), string.Empty).ToString();
                    else
                        throw new FormatException();
                }
                catch (Exception)
                {
                    if (str[beg - 1] == '-' && may)
                    {
                        str = str.Substring(0, beg) + str.Substring(beg, end + str.Length - lastLenght - beg + 1).Replace('+', '$') + str.Substring(end + str.Length - lastLenght + 1, str.Length - 1 - end - str.Length + lastLenght);
                        str = str.Substring(0, beg) + str.Substring(beg, end + str.Length - lastLenght - beg + 1).Replace('-', '#') + str.Substring(end + str.Length - lastLenght + 1, str.Length - 1 - end - str.Length + lastLenght);
                        str = str.Substring(0, beg) + str.Substring(beg, end + str.Length - lastLenght - beg + 1).Replace('$', '-') + str.Substring(end + str.Length - lastLenght + 1, str.Length - 1 - end - str.Length + lastLenght);
                        str = str.Substring(0, beg) + str.Substring(beg, end + str.Length - lastLenght - beg + 1).Replace('#', '+') + str.Substring(end + str.Length - lastLenght + 1, str.Length - 1 - end - str.Length + lastLenght);
                    }
                    return str.Substring(beg, end + str.Length - lastLenght - beg + 1);
                }
            }
            if ((str[beg - 1] == '*' || str[beg - 1] == '/') && mode != 2)
                st = Simpler(str, beg - 1 - FindValue(beg - 1, str, false).Length, beg - 2, 0, false) + str[beg - 1];
            if(end + 1 < str.Length)
                if ((str[end + 1] == '*' || str[end + 1] == '/') && mode != 0)
                    nd = str[end + 1] + Simpler(str, end + 2, end + 1 + FindValue(end + 1, str, true).Length, 2, false);
            return st + str.Substring(beg, end + str.Length - lastLenght - beg + 1) + nd;
        }
        #endregion
        #region Tree
        public static TreeNode TreeSimp(TreeNode trn)
        {
            switch(GetChar(trn.Text, true))
            {
                case "+":
                    return Plussing(trn.Text.Substring(Find(trn.Text, '.') + 1, Find(trn.Text, '=') - Find(trn.Text, '.') - 1));
                case "*":
                    return Mnossing(trn.Text.Substring(Find(trn.Text, '.') + 1, Find(trn.Text, '=') - Find(trn.Text, '.') - 1));
            }
            return new TreeNode();
        }
        public static TreeNode Plussing(string str)
        {
           // Bitmap bmp = new Bitmap(10 * scale00, 10 * scale00);
            float size = 27;
            TreeNode Root = new TreeNode();
            string st = Convert.ToDecimal(GetAll(str, 1)).ToString();
            string nd = Convert.ToDecimal(GetAll(str, 2)).ToString();
            TreeNode begtree = new TreeNode();
            begtree.Text = "   " + st + "   ";
            begtree.NodeFont = new Font("", size);
            begtree.ForeColor = Color.DarkBlue;
            Root.Nodes.Add(begtree);
            TreeNode ndtree = new TreeNode();
            ndtree.NodeFont = new Font("", size);
            ndtree.Text = "+";
            ndtree.ForeColor = Color.DarkBlue;
            Root.Nodes.Add(ndtree);
            TreeNode rdtree = new TreeNode();
            rdtree.NodeFont = new Font("", size);
            rdtree.Text = "   " + nd + "   ";
            rdtree.ForeColor = Color.DarkBlue;
            rdtree.NodeFont = new Font("", size, FontStyle.Underline);
            Root.Nodes.Add(rdtree);
            Root.Nodes.Add("= " + (Convert.ToDecimal(st) + Convert.ToDecimal(nd)));
            Root.Nodes[Root.Nodes.Count - 1].NodeFont = new Font("", size);
            Root.Nodes[Root.Nodes.Count - 1].ForeColor = Color.DarkBlue;
            return Root;
        }
        public static TreeNode Mnossing(string str)
        {
            // Bitmap bmp = new Bitmap(10 * scale00, 10 * scale00);
            float size = 27;
            TreeNode Root = new TreeNode();
            string st = Convert.ToDecimal(GetAll(str, 1)).ToString();
            string nd = Convert.ToDecimal(GetAll(str, 2)).ToString();
            TreeNode begtree = new TreeNode();
            begtree.Text = "   " + st + "   ";
            begtree.NodeFont = new Font("", size);
            begtree.ForeColor = Color.DarkBlue;
            Root.Nodes.Add(begtree);
            TreeNode ndtree = new TreeNode();
            ndtree.NodeFont = new Font("", size);
            ndtree.Text = "*";
            ndtree.ForeColor = Color.DarkBlue;
            Root.Nodes.Add(ndtree);
            TreeNode rdtree = new TreeNode();
            rdtree.NodeFont = new Font("", size);
            rdtree.Text = "   " + nd + "   ";
            rdtree.ForeColor = Color.DarkBlue;
            rdtree.NodeFont = new Font("", size, FontStyle.Underline);
            Root.Nodes.Add(rdtree);
            string tmp = "";
            if (nd.ToString().Length <= st.ToString().Length)
            {
                nd.Reverse();
                for (int i = 0; i < nd.Length; i++)
                    if (nd[i] != '.')
                    {
                        Root.Nodes.Add("+ " + (Convert.ToDecimal(nd[i].ToString()) + Convert.ToDecimal(st)) + tmp);
                        Root.Nodes[Root.Nodes.Count - 1].NodeFont = new Font("", size);
                        Root.Nodes[Root.Nodes.Count - 1].ForeColor = Color.DarkBlue;
                        tmp += '0';
                    }
            }
            else
            {
                st.Reverse();
                for (int i = 0; i < st.Length; i++)
                    if (st[i] != '.')
                    {
                        Root.Nodes.Add("+ " + (Convert.ToDecimal(st[i].ToString()) + Convert.ToDecimal(nd)) + tmp);
                        Root.Nodes[Root.Nodes.Count - 1].NodeFont = new Font("", size);
                        Root.Nodes[Root.Nodes.Count - 1].ForeColor = Color.DarkBlue;
                        tmp += '0';
                    }
            }
            Root.Nodes[Root.Nodes.Count - 1].NodeFont = rdtree.NodeFont;
            Root.Nodes[Root.Nodes.Count - 1].Text += "   ";
            nd.Reverse();
            Root.Nodes.Add("= " + (Convert.ToDecimal(st) * Convert.ToDecimal(nd)));
            Root.Nodes[Root.Nodes.Count - 1].NodeFont = new Font("", size);
            Root.Nodes[Root.Nodes.Count - 1].ForeColor = Color.DarkBlue;
            return Root;
        }
        #endregion
    }
}
