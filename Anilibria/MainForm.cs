using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;


namespace Anilibria
{
    public partial class MainForm : Form
    {
        string url = "https://www.anilibria.tv/pages/catalog.php";
        private async Task PageLoad(int TimeOut)
        {
            TaskCompletionSource<bool> PageLoaded = null;
            PageLoaded = new TaskCompletionSource<bool>();
            int TimeElapsed = 0;
            webBrowser1.DocumentCompleted += (s, e) =>
            {
                if (webBrowser1.ReadyState != WebBrowserReadyState.Complete) return;
                if (PageLoaded.Task.IsCompleted) return; PageLoaded.SetResult(true);
            };
            //
            while (PageLoaded.Task.Status != TaskStatus.RanToCompletion)
            {
                await Task.Delay(10);//interval of 10 ms worked good for me
                TimeElapsed++;
                if (TimeElapsed >= TimeOut * 100) PageLoaded.TrySetResult(true);
            }
        }

        public MainForm()
        {
            InitializeComponent();
            webBrowser1.Navigate(url);
            webBrowser1.ScriptErrorsSuppressed = true;
            try
            {
                using (StreamReader sr = new StreamReader(Application.StartupPath + @"\last_title.txt", System.Text.Encoding.Default))
                {
                    InputURL_tb.Text = sr.ReadToEnd();
                }
            }
            catch
            {

            }
        }

        private async Task tmp()
        {
            await PageLoad(10); //await for page to load, timeout 10 seconds.
        }
        
        public string GetHTMLCodPage(string uri)
        {
            WebBrowser webBrowser1 = new WebBrowser();
            webBrowser1.Navigate(uri);
            webBrowser1.ScriptErrorsSuppressed = true;
            while (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }
            string txt = webBrowser1.DocumentText;
            return txt;
        }

        private static string getResponse(string uri)
        {
            string data = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;
                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }
                data = readStream.ReadToEnd();
                response.Close();
                readStream.Close();
            }
            return data;
        }

        private int counter(string html)
        {
            int ind0 = 1;
            int count = 0;
            while (ind0 >0)
            {
                ind0 = html.IndexOf(".mp4", ind0) + 1;
                ++count;
            }
            

            return (count - 1) / 2;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Output_dataGridView.Rows.Clear();

            string html_page = GetHTMLCodPage(InputURL_tb.Text);

            try
            {
                int ind0 = html_page.IndexOf("var player"); // индекс начала нужного нам блока
                html_page = html_page.Substring(ind0);  // избавляемся от лишней части


                string html_page_title = html_page;
                // title
                int ind_end = 0;
                int ind_start = html_page.IndexOf("title", ind_end) + 8;  // 8 = length(title':'")

                int N = counter(html_page); // количество серий

                for (int i = 0; i < N; ++i)
                {
                    //title
                    ind_end = html_page.IndexOf("'", ind_start);
                    string title = html_page.Substring(ind_start, ind_end - ind_start); // заголовок

                    //download
                    ind_start = html_page.IndexOf("download", ind_end) + 10; // 10 = length(download:")
                    ind_end = html_page.IndexOf("?", ind_start);
                    string url = html_page.Substring(ind_start, ind_end - ind_start);   // URL

                    //Выводим строчку на экран
                    Output_dataGridView.Rows.Add(title, url);

                    //Перемещаем курсор на след серию
                    ind_start = html_page.IndexOf("title", ind_end) + 8; // 8 = length(title':'")

                }                
                using (StreamWriter sw = new StreamWriter(Application.StartupPath + @"\last_title.txt", false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(InputURL_tb.Text);
                }
            }
            catch (Exception)
            {
            }
        }

        private void Output_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            string url = Output_dataGridView.CurrentCell.Value.ToString();
            Clipboard.SetText(url);

            RUSure Diagform = new RUSure();
            Diagform.ShowDialog();

            //pl.Title1_tb.Text = Output_dataGridView.CurrentRow.Cells[0].Value.ToString();
            //Title_tb.Text = Output_dataGridView.CurrentRow.Cells[0].Value.ToString();
            
            
            string rf = Properties.Resources.player;
            string str1 = "<source src=" + '"' + '"';
            string str2 = "<source src=" + '"'+ url + '"';
            rf = rf.Replace(str1, str2);

            File.WriteAllText("newplayer.htm", rf); // Сохраняем html файл с плеером
            
            string path = Application.StartupPath + @"\newplayer.htm";
            //pl.webBrowser2.Navigate(path);
            //pl.webBrowser2.ScriptErrorsSuppressed = false;
            //while (pl.webBrowser2.ReadyState != WebBrowserReadyState.Complete)
            //{
            //    Application.DoEvents();
            //}
            //pl.Show();
            */
        }

        private void GetList_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                HtmlElement tbody = webBrowser1.Document.GetElementsByTagName("tbody")[0];
                HtmlElementCollection tr = tbody.GetElementsByTagName("tr");
            
                for (int i = 0; i < tr.Count; ++i)
                {
                    HtmlElementCollection td = tr[i].GetElementsByTagName("td");
                    for (int j = 0; j < td.Count; ++j)
                    {
                    
                        HtmlElement a = td[j].GetElementsByTagName("a")[0];
                        string href = a.GetAttribute("href");
                        //href = "https://anilibria.tv" + href;
                        string name = a.GetElementsByTagName("div")[0].GetElementsByTagName("span")[0].InnerText;
                        dataGridView1.Rows.Add(name, href);
                    
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка данные не прогрузились, попробуйте обновить!");
            }
        }

        private void GetList()
        {
            dataGridView1.Rows.Clear();
            HtmlElement tbody = webBrowser1.Document.GetElementsByTagName("tbody")[0];
            HtmlElementCollection tr = tbody.GetElementsByTagName("tr");

            for (int i = 0; i < tr.Count; ++i)
            {
                HtmlElementCollection td = tr[i].GetElementsByTagName("td");
                for (int j = 0; j < td.Count; ++j)
                {
                    try
                    {
                        HtmlElement a = td[j].GetElementsByTagName("a")[0];
                        string href = a.GetAttribute("href");
                        string name = a.GetElementsByTagName("div")[0].GetElementsByTagName("span")[0].InnerText;
                        dataGridView1.Rows.Add(name, href);
                    }
                    catch
                    {

                    }
                }
            }
        }
        

        private void Button1_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Navigate(url);
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void Next_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                HtmlElementCollection ul = webBrowser1.Document.GetElementsByTagName("ul");//[0];
                HtmlElementCollection li = ul[ul.Count - 2].GetElementsByTagName("li");
                string class1 = li[li.Count - 1].GetAttribute("class");
                if (class1 != "disabled")
                {
                    li[li.Count - 1].GetElementsByTagName("a")[0].InvokeMember("Click");
                    while (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
                        Application.DoEvents(); //Выполняем другие события системы, пока страница не загрузилась
                    GetList();
                }
            }
            catch
            {
                
            }
            
        }


        private void Prev_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                HtmlElementCollection ul = webBrowser1.Document.GetElementsByTagName("ul");
                HtmlElementCollection li = ul[ul.Count - 2].GetElementsByTagName("li");
                string class1 = li[0].GetAttribute("class");
                
                if (class1 != "disabled")
                {
                    li[0].GetElementsByTagName("a")[0].InvokeMember("Click");
                    while (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
                        Application.DoEvents(); //Выполняем другие события системы, пока страница не загрузилась
                    GetList();
                }
            }
            catch
            {

            }
            
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string url = dataGridView1.CurrentCell.Value.ToString();
            Clipboard.SetText(url);
            InputURL_tb.Text = url;
            tabControl1.SelectedIndex = 1;
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();

                HtmlElement result = webBrowser1.Document.GetElementById("smallSearchTable");
                HtmlElementCollection href = result.GetElementsByTagName("a");
                HtmlElementCollection name = result.GetElementsByTagName("span");

                if (href.Count == 0)
                {
                    MessageBox.Show("По вашему запросу ничего не найдено!");
                }
                else
                    for (int i = 0; i < href.Count; ++i)
                    {
                        dataGridView1.Rows.Add(name[i].InnerText, href[i].GetAttribute("href"));
                    }
            }
            catch
            {
                MessageBox.Show("Ошибка данные не прогрузились, попробуйте обновить!");
            }
        }

        /*
        private void SearchInput_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search_btn_Click(sender, e);
            }
        }
        */
        private void SearchInput_tb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                    
                HtmlElement search = webBrowser1.Document.GetElementById("smallSearchInput");
                search.InvokeMember("Focus");
                search.InnerText = SearchInput_tb.Text;
                SearchInput_tb.Focus();
            }
            catch
            {
                MessageBox.Show("Ошибка данные не прогрузились, попробуйте обновить!");
            }
        }

        private void SearchInput_tb_KeyDown(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Search_btn_Click(sender, e);
            }
        }

        private void InputURL_tb_KeyDown(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Button1_Click(sender, e);
            }
        }

        public void PlayUrl(string url)
        {
            //tabControl1.SelectTab(tabPage3);
            //axWindowsMediaPlayer1.Focus();
            //axWindowsMediaPlayer1.URL = url;
            //axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void Play_btn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage3);
            //axVLCPlugin21.playlist.add(Output_dataGridView.SelectedCells[0].Value.ToString());
            //axVLCPlugin21.playlist.play();
            axWindowsMediaPlayer1.URL = Output_dataGridView.SelectedCells[0].Value.ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void Output_dataGridView_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (Output_dataGridView.Focused)
            {
                Play_btn.Enabled = true;
                Download_btn.Enabled = true;
            }
            else
            {
                Play_btn.Enabled = false;
                Download_btn.Enabled = false;
            }
        }

        private void Download_btn_Click(object sender, EventArgs e)
        {
            string url = Clipboard.GetText();
            WebBrowser webbrow = new WebBrowser();
            webbrow.Navigate(url);
        }
    }
}
