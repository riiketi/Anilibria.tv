using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anilibria
{
    public partial class RUSure : Form
    {
        public RUSure()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string url = Clipboard.GetText();
            WebBrowser webbrow = new WebBrowser();
            webbrow.Navigate(url);
            Close();
        }

        private void Play_btn_Click(object sender, EventArgs e)
        {
            string url = Clipboard.GetText();
            MainForm mf = new MainForm();
            Close();



            mf.PlayUrl(url);


            /*
            string rf = Properties.Resources.player;
            string str1 = "<source src=" + '"' + '"';
            string str2 = "<source src=" + '"' + url + '"';
            rf = rf.Replace(str1, str2);
            File.WriteAllText("newplayer.htm", rf); // Сохраняем html файл с плеером

            string path = Application.StartupPath + @"\newplayer.htm";
            System.Diagnostics.Process.Start(@"iexplore.exe", path);
            */
            
        }
    }
}
