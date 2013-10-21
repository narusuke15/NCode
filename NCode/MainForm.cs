/*
 * Created by SharpDevelop.
 * User: Narudon
 * Date: 14/7/2556
 * Time: 8:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace NCode
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		const float VERSION = 1.12f;
		
		public string inputEncode;
		public string InputDecode;
		public int key;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			LblVersion.Text = "v." + VERSION.ToString();
		}
		
		#region UserDefine
		
		private string LoadText () {
			DialogResult result = openFileDialog1.ShowDialog();
		    if (result == DialogResult.OK) // Test result.
		    {
		    	string file = openFileDialog1.FileName;
				try
				{
				    string text = File.ReadAllText(file);
				    //System.Diagnostics.Process.Start(file);
				    return text;
				}
				catch (IOException)
				{
				}
		    }
		    return null;
		}
		
		#endregion
		
		
		#region Button
		
		void BtnEncodeClick(object sender, EventArgs e)
		{
			if(TxtKey.Text == "")
			{
				MessageBox.Show("Need key to encode your message!","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}else if(TxtEncode.Text == ""){
				MessageBox.Show("Text is none, Can't Encode Message","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}else{
				key = System.Convert.ToInt32(TxtKey.Text);
				TxtDecode.Text = Encode.Word(TxtEncode.Text, key);
			}
		}
		
		void BtnDecodeClick(object sender, EventArgs e)
		{	
			if(TxtKey.Text == "")
			{
				MessageBox.Show("Need key to decode your message!","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}else if(TxtDecode.Text == ""){
				MessageBox.Show("Text is none, Can't Decode Message","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}else{
				key = System.Convert.ToInt32(TxtKey.Text);
				TxtEncode.Text = Decode.Word(TxtDecode.Text, key);
			}
		}
		
		void BtnLoadEncodeClick(object sender, System.EventArgs e){
			
		   TxtEncode.Text = LoadText();
		}
		
		void BtnLoadDecodeClick(object sender, EventArgs e)
		{
			TxtDecode.Text = LoadText();
		}
		
		void BtnSaveEncodeClick(object sender, System.EventArgs e)
		{
			saveText = TxtEncode.Text;
			saveFileDialog1.ShowDialog();
		}
		
		void BtnSaveDecodeClick(object sender, EventArgs e)
		{
			saveText = TxtDecode.Text;
			saveFileDialog1.ShowDialog();
		}
		
		#endregion
		
		
		
		void TxtEncodeTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TxtDecodeTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TxtKeyTextChanged(object sender, EventArgs e)
		{
		
		}
		
		void FolderBrowserDialog1HelpRequest(object sender, EventArgs e)
		{
			
		}
		
		void SaveFileDialog1FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			string name = saveFileDialog1.FileName;
			File.WriteAllText(name, saveText);
		}
		
		#region Menu
		
		public string saveText;
		
		void MenuFileItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			
		}
		
		void EncodeToolStripMenuItemClick(object sender, EventArgs e)
		{
			saveText = TxtEncode.Text;
			saveFileDialog1.ShowDialog();
		}
		
		void DecodeToolStripMenuItemClick(object sender, EventArgs e)
		{
			saveText = TxtDecode.Text;
			saveFileDialog1.ShowDialog();
		}
		
		void QuitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void ToEncodeToolStripMenuItemClick(object sender, EventArgs e)
		{
			TxtEncode.Text = LoadText();
		}
		
		void ToDecodeToolStripMenuItemClick(object sender, EventArgs e)
		{
			TxtDecode.Text = LoadText();
		}
		
		#endregion
		
		
		
		
		void VersionToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("Version "+VERSION.ToString() ,"Version info",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		
		
	}
	
	public static class Encode
	{
		
		public static string Word (string word, int key) 
		{
		
			string newWord = "";
			foreach (char c in word){
				newWord += Letter(c, key);
			}

			return newWord;
		}
	
		public static char Letter (char letter, int key) 
		{
	
			int unicode = letter;
			unicode += key ;
			char nt = System.Convert.ToChar(unicode);
			return nt;
		}
	}
	
	public static class Decode
	{
		public static string Word (string word, int key) 
		{
		
			string newWord = "";
			foreach (char c in word){
				newWord += Letter(c, key);
			}

			return newWord;
		}
	
		public static char Letter (char letter, int key) 
		{
	
			int unicode = letter;
			unicode -= key ;
			char nt = System.Convert.ToChar(unicode);
			return nt;
		}
	}
}
