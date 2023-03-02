using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace MiMFa.Gadget
{
    public partial class Substitute : Form
    {   
        Dictionary<string, string> Dic = new Dictionary<string, string>();
        bool RevDirection = false;
        static string Dir = "Dictionaries";
        string DicPath = Dir+"\\-Select Source-";
        public Substitute()
        {
            InitializeComponent();

            string[] addreses = Directory.GetFiles(Dir);
            foreach (var addr in addreses)
            {
                string[] parr = addr.Split('\\');
                cb_Languages.Items.Add(parr.Last());
            }
            FillDic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            rtb_Left.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            File.WriteAllText(saveFileDialog1.FileName, rtb_Right.Text,Encoding.UTF8);
        }


        private void btn_Translate_Click(object sender, EventArgs e)
        {
            string oldText = rtb_Left.Text.ToLower();

            foreach (var kvp in Dic)
                oldText = Regex.Replace(oldText,kvp.Key, kvp.Value);
            
            rtb_Right.Text = oldText;
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            //RevDirection = !RevDirection;
            if (RevDirection) RevDirection = false;
            else RevDirection = true;

            FillDic();
        }

        private void FillDic()
        {
            string[] pathParts = DicPath.Split('\\');
            string[] languages = pathParts.Last().Split('-');
            string pattern = @"([^\\][\$\^\|\!\-\.\*\+\?]|\\{1}[dDaAvzZbBwWsS]|\\{1}k\<(\W|\w)*\>|[^\\]\((\w|\W)*\)|[^\\]\{(\w|\W)*\}|[^\\]\[(\w|\W)*\])";
            Dic.Clear();
            if (RevDirection)
            {
                label_Left.Text = languages.Last();
                label_Right.Text = languages.First();
                foreach (var line in File.ReadLines(DicPath))
                {
                    string[] kvp = line.ToLower().Split('¶');
                    if (!Dic.ContainsKey(kvp.Last()))
                    //    Dic[kvp.Last()] = Regex.Unescape(Regex.Replace(kvp.First(), pattern,""));
                    //else 
                        Dic.Add(kvp.Last(), Regex.Unescape(Regex.Replace(kvp.First(), pattern, "")));
                }
            }
            else
            {
                label_Left.Text = languages.First();
                label_Right.Text = languages.Last();
                foreach (var line in File.ReadLines(DicPath))
                {
                    string[] kvp = line.ToLower().Split('¶');
                    if (!Dic.ContainsKey(kvp.First()))
                    //    Dic[kvp.First()] = Regex.Unescape(Regex.Replace(kvp.Last(), pattern, ""));
                    //else
                        Dic.Add(kvp.First(), Regex.Unescape(Regex.Replace(kvp.Last(), pattern,"")));
                }
            }
            Dic = Dic.OrderByDescending(v => v.Key.Length).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
        }

        private void cb_Languages_SelectedIndexChanged(object sender, EventArgs e)
        {
            DicPath = Dir + "\\" + cb_Languages.SelectedItem;
            FillDic();
        }
    }
}
