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
        public static Image Count_Paint(double st, char val, double nd)
        {
            List<Point> points = new List<Point>();
            List<int> poinList = new List<int>();
            string strSt = st.ToString();
            string strNd = nd.ToString();
            int Stpointpos = Find(strSt, ',');
            strSt = strSt.Replace(",", "");
            int Ndpointpos = Find(strNd, ',');
            strNd = strNd.Replace(",", "");
            int longest = (int)Longer(strSt.Length, strNd.Length, true);
            int shortest = (int)Longer(strSt.Length, strNd.Length, true);
            double answer = st * nd;
                poinList.Add(0);
            int an_len = answer.ToString().Length;
            Font std = new Font("", 35);
            Bitmap bmp = new Bitmap(an_len * 25 + 30, strNd.Length * 50 + 130);
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
                        Graphics gr = Graphics.FromImage(bmp);
                        gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        gr.DrawString(strSt.Substring(0, (Stpointpos != -1) ? Stpointpos : strSt.Length), std, new SolidBrush(Color.Black), new Point(bmp.Width - 20 - (Stpointpos != -1 ? 10 : 0) - strSt.Length * 25, 10));
                        gr.DrawString(strNd.Substring(0, (Ndpointpos != -1) ? Ndpointpos : strNd.Length), std, new SolidBrush(Color.Black), new Point(bmp.Width - 20 - (Ndpointpos != -1 ? 10 : 0) - strNd.Length * 25, 60));
                        if (Stpointpos != -1)
                            gr.DrawString(",", new Font("", 25), new SolidBrush(Color.Black), new Point(bmp.Width - 25 - strSt.Length * 25 + Stpointpos * 25, 22));
                        if(Ndpointpos != -1)
                            gr.DrawString(",", new Font("", 25), new SolidBrush(Color.Black), new Point(bmp.Width - 25 - strNd.Length * 25 + Ndpointpos * 25, 72));
                        gr.DrawString(Stpointpos != -1 ? strSt.Substring(Stpointpos, strSt.Length - Stpointpos) : "", std, new SolidBrush(Color.Black), new Point(bmp.Width - 20 - (strSt.Length - Stpointpos) * 25, 10));
                        gr.DrawString(Ndpointpos != -1 ? strNd.Substring(Ndpointpos, strNd.Length - Ndpointpos) : "", std, new SolidBrush(Color.Black), new Point(bmp.Width - 20 - (strNd.Length - Ndpointpos) * 25, 60));
                        gr.DrawString("×", std, new SolidBrush(Color.Black), new Point(bmp.Width - 57 - ((strSt.Length >= strNd.Length && Stpointpos != -1) || (strSt.Length <= strNd.Length && Ndpointpos != -1) ? 10 : 0) - longest * 25, 35));
                        gr.DrawLine(new Pen(new SolidBrush(Color.Black), 1), new Point(20, 115), new Point(bmp.Width - 10, 115));
                        int plus = 0;
                        int down = 0;
                        int plus_plus = 1;
                        for (int i = strNd.Length - 1; i >= 0 ; i-- )
                        {
                            for (int o = strSt.Length - 1; o >= 0 ; o--)
                            {
                                double dd = Convert.ToDouble(strNd[i].ToString()) * Convert.ToDouble(strSt[o].ToString()) + poinList[0];
                                gr.DrawString(dd >= 10 ? (dd % 10).ToString() : (dd).ToString(), std, new SolidBrush(Color.Black), new Point(bmp.Width - 45 - (plus++) * 25, 120 + down));
                                if (dd >= 10)
                                {
                                    if (points.Contains(  new Point(bmp.Width - 30 - (int)((plus_plus - 1) * 4) - (plus - plus_plus) * 25, 8 - (int)((plus_plus - 1) * 4))))
                                    {
                                        gr.DrawLine(new Pen(new SolidBrush(Color.Black), 1), new Point(bmp.Width - 29 - (int)((plus_plus - 1) * 4) - (plus - plus_plus) * 25, 8 - (int)((plus_plus - 1) * 4) + 11), new Point(bmp.Width - 21 - (int)((plus_plus - 1) * 4) - (plus - plus_plus) * 25, 8 - (int)((plus_plus - 1) * 4) + 5));
                                        points.Remove(new Point(bmp.Width - 30 - plus_plus + 1 - (plus - plus_plus + 1) * 25, 8 - plus_plus + 1));
                                    }
                                    gr.DrawString(((dd - dd % 10) / 10).ToString(), new Font("", 10), new SolidBrush(Color.Black), new Point(bmp.Width - 30 - (int)(plus_plus * 4) - (plus - plus_plus) * 25, 8 - (int)(plus_plus * 4)));
                                    points.Add(new Point(bmp.Width - 30 - (int)(plus_plus * 4) - (plus - plus_plus) * 25, 8 - (int)(plus_plus * 4)));
                                }
                                poinList.Add(Convert.ToInt16((dd - dd % 10) / 10));
                                poinList.Remove(poinList[0]);
                            }
                            if(poinList.Count >= 1 && poinList[0] > 0)
                                gr.DrawString(poinList[0].ToString(), std, new SolidBrush(Color.Black), new Point(bmp.Width - 45 - (plus) * 25, 120 + down));
                            poinList[0] = 0;
                            down += 50;
                            plus = plus_plus++;
                        }
                        return bmp;
                    }
                    break;
                #endregion
                #region deling
                case '/':
                    {

                    }
                    break;
                #endregion
            }
            return bmp;
        }
        public static void DrawString(string str, Image img, Point loc, Font fnt)
        {
            Graphics gr = Graphics.FromImage(img);
            gr.DrawString(str, fnt, new SolidBrush(Color.Black), loc);
            gr.Dispose();
        }
        public static double Calculate(Tree tree)
        {
            try
            {
                Convert.ToDouble(tree.value);
                    return Convert.ToDouble(tree.value);
            }
            catch (FormatException)
            {
                double st = Calculate(tree.leftTree);
                double nd = Calculate(tree.rightTree);
                //object answer = dt.Compute("-140.0+26.8", string.Empty);
                object answer = dt.Compute(st.ToString().Replace(',', '.') + tree.value + nd.ToString().Replace(',', '.').ToString(), string.Empty);
                timeList.Add(move.ToString() + ". " + st + tree.value + nd + "=" + answer);
                move++;
                return Convert.ToDouble(answer);
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
                                (Convert.ToDouble(str.Substring(barrier + 1, i - barrier).Replace('.', ','))).ToString();
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
                            double temp;
                            if (str[i] != '.')
                            {
                                temp = Convert.ToDouble(str.Substring(i, barrier - i).Replace('.', ','));
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
        public static double Compute(string str, int location)
        {
            Begin();
            str = str.Replace(',', '.');
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
           // Bitmap bmp = new Bitmap(1000, 1000);
            float size = 27;
            TreeNode Root = new TreeNode();
            string st = Convert.ToDouble(GetAll(str, 1)).ToString();
            string nd = Convert.ToDouble(GetAll(str, 2)).ToString();
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
            Root.Nodes.Add("= " + (Convert.ToDouble(st) + Convert.ToDouble(nd)));
            Root.Nodes[Root.Nodes.Count - 1].NodeFont = new Font("", size);
            Root.Nodes[Root.Nodes.Count - 1].ForeColor = Color.DarkBlue;
            return Root;
        }
        public static TreeNode Mnossing(string str)
        {
            // Bitmap bmp = new Bitmap(1000, 1000);
            float size = 27;
            TreeNode Root = new TreeNode();
            string st = Convert.ToDouble(GetAll(str, 1)).ToString();
            string nd = Convert.ToDouble(GetAll(str, 2)).ToString();
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
                        Root.Nodes.Add("+ " + (Convert.ToDouble(nd[i].ToString()) + Convert.ToDouble(st)) + tmp);
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
                        Root.Nodes.Add("+ " + (Convert.ToDouble(st[i].ToString()) + Convert.ToDouble(nd)) + tmp);
                        Root.Nodes[Root.Nodes.Count - 1].NodeFont = new Font("", size);
                        Root.Nodes[Root.Nodes.Count - 1].ForeColor = Color.DarkBlue;
                        tmp += '0';
                    }
            }
            Root.Nodes[Root.Nodes.Count - 1].NodeFont = rdtree.NodeFont;
            Root.Nodes[Root.Nodes.Count - 1].Text += "   ";
            nd.Reverse();
            Root.Nodes.Add("= " + (Convert.ToDouble(st) * Convert.ToDouble(nd)));
            Root.Nodes[Root.Nodes.Count - 1].NodeFont = new Font("", size);
            Root.Nodes[Root.Nodes.Count - 1].ForeColor = Color.DarkBlue;
            return Root;
        }
        #endregion
    }
}
