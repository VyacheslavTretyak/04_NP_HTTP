using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordDictionary
{
	public partial class Form1 : Form
	{
		private Dictionary<string, int> dic = new Dictionary<string, int>();
		public Form1()
		{
			InitializeComponent();
			buttonGet.Click += ButtonGet_Click;			
		}

		private void ButtonGet_Click(object sender, EventArgs e)
		{
			listBox.Items.Clear();
			buttonGet.Enabled = false;
			Task.Run(() => GetWords());
		}

		private void GetWords()
		{
			WebClient client = new WebClient();			
			byte[] urlData = client.DownloadData(textBoxURI.Text); 			
			string page = Encoding.UTF8.GetString(urlData);
			string pattern = @">(.[^(<|>)]*)<";			
			RegexOptions options = RegexOptions.Multiline;
			int matches = Regex.Matches(page, pattern, options).Count;
			int n = 0;
			foreach (Match m in Regex.Matches(page, pattern, options))
			{
				string str = m.Groups[1].ToString();
				string[] split = str.Split(" .,[]{}()-+=_;:\"'\t".ToCharArray());
				foreach (string s in split)
				{
					string t = s.Trim();
					int count = 0;
					if (dic.Keys.Contains(t))
					{
						count = dic[t];
					}
					dic[t] = ++count;
				}
				progressBar.Invoke(new Action(()=>
				{
					float v = ((float)n / matches) * 100f;
					progressBar.Value = (int)v;
				}));
				n++;
			}
			foreach(var val in dic)
			{
				listBox.Invoke(new Action(() =>
				{
					listBox.Items.Add($"{val.Key} : {val.Value}");
				}));
				
			}
			buttonGet.Invoke(new Action(()=>{
				buttonGet.Enabled = true;
				progressBar.Value = 0;
			}));
		}




	}
}
