/*
 * Created by SharpDevelop.
 * User: Narudon
 * Date: 14/7/2556
 * Time: 8:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NCode
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.TxtEncode = new System.Windows.Forms.TextBox();
			this.TxtDecode = new System.Windows.Forms.TextBox();
			this.BtnEncode = new System.Windows.Forms.Button();
			this.BtnDecode = new System.Windows.Forms.Button();
			this.TxtKey = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.BtnLoadEncode = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toEncodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toDecodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.svaeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.encodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.decodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnLoadDecode = new System.Windows.Forms.Button();
			this.BtnSaveEncode = new System.Windows.Forms.Button();
			this.BtnSaveDecode = new System.Windows.Forms.Button();
			this.LblVersion = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// TxtEncode
			// 
			this.TxtEncode.Location = new System.Drawing.Point(12, 30);
			this.TxtEncode.Multiline = true;
			this.TxtEncode.Name = "TxtEncode";
			this.TxtEncode.Size = new System.Drawing.Size(176, 89);
			this.TxtEncode.TabIndex = 0;
			this.TxtEncode.TextChanged += new System.EventHandler(this.TxtEncodeTextChanged);
			// 
			// TxtDecode
			// 
			this.TxtDecode.Location = new System.Drawing.Point(194, 30);
			this.TxtDecode.Multiline = true;
			this.TxtDecode.Name = "TxtDecode";
			this.TxtDecode.Size = new System.Drawing.Size(181, 89);
			this.TxtDecode.TabIndex = 1;
			this.TxtDecode.TextChanged += new System.EventHandler(this.TxtDecodeTextChanged);
			// 
			// BtnEncode
			// 
			this.BtnEncode.Location = new System.Drawing.Point(12, 125);
			this.BtnEncode.Name = "BtnEncode";
			this.BtnEncode.Size = new System.Drawing.Size(176, 23);
			this.BtnEncode.TabIndex = 2;
			this.BtnEncode.Text = "Encode";
			this.BtnEncode.UseVisualStyleBackColor = true;
			this.BtnEncode.Click += new System.EventHandler(this.BtnEncodeClick);
			// 
			// BtnDecode
			// 
			this.BtnDecode.Location = new System.Drawing.Point(194, 125);
			this.BtnDecode.Name = "BtnDecode";
			this.BtnDecode.Size = new System.Drawing.Size(181, 23);
			this.BtnDecode.TabIndex = 3;
			this.BtnDecode.Text = "Decode";
			this.BtnDecode.UseVisualStyleBackColor = true;
			this.BtnDecode.Click += new System.EventHandler(this.BtnDecodeClick);
			// 
			// TxtKey
			// 
			this.TxtKey.Location = new System.Drawing.Point(13, 154);
			this.TxtKey.MaxLength = 4;
			this.TxtKey.Name = "TxtKey";
			this.TxtKey.Size = new System.Drawing.Size(314, 20);
			this.TxtKey.TabIndex = 4;
			this.TxtKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.TxtKey.TextChanged += new System.EventHandler(this.TxtKeyTextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(333, 152);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Key";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// BtnLoadEncode
			// 
			this.BtnLoadEncode.Location = new System.Drawing.Point(13, 180);
			this.BtnLoadEncode.Name = "BtnLoadEncode";
			this.BtnLoadEncode.Size = new System.Drawing.Size(83, 23);
			this.BtnLoadEncode.TabIndex = 6;
			this.BtnLoadEncode.Text = "Load";
			this.BtnLoadEncode.UseVisualStyleBackColor = true;
			this.BtnLoadEncode.Click += new System.EventHandler(this.BtnLoadEncodeClick);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "Text files|*.txt;*.text";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = "Text files|*.txt";
			this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog1FileOk);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(387, 24);
			this.menuStrip1.TabIndex = 7;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.loadToolStripMenuItem,
									this.svaeToolStripMenuItem,
									this.quitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toEncodeToolStripMenuItem,
									this.toDecodeToolStripMenuItem});
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.loadToolStripMenuItem.Text = "Load";
			// 
			// toEncodeToolStripMenuItem
			// 
			this.toEncodeToolStripMenuItem.Name = "toEncodeToolStripMenuItem";
			this.toEncodeToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.toEncodeToolStripMenuItem.Text = "toEncode";
			this.toEncodeToolStripMenuItem.Click += new System.EventHandler(this.ToEncodeToolStripMenuItemClick);
			// 
			// toDecodeToolStripMenuItem
			// 
			this.toDecodeToolStripMenuItem.Name = "toDecodeToolStripMenuItem";
			this.toDecodeToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.toDecodeToolStripMenuItem.Text = "toDecode";
			this.toDecodeToolStripMenuItem.Click += new System.EventHandler(this.ToDecodeToolStripMenuItemClick);
			// 
			// svaeToolStripMenuItem
			// 
			this.svaeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.encodeToolStripMenuItem,
									this.decodeToolStripMenuItem});
			this.svaeToolStripMenuItem.Name = "svaeToolStripMenuItem";
			this.svaeToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.svaeToolStripMenuItem.Text = "Save";
			// 
			// encodeToolStripMenuItem
			// 
			this.encodeToolStripMenuItem.Name = "encodeToolStripMenuItem";
			this.encodeToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.encodeToolStripMenuItem.Text = "Encode";
			this.encodeToolStripMenuItem.Click += new System.EventHandler(this.EncodeToolStripMenuItemClick);
			// 
			// decodeToolStripMenuItem
			// 
			this.decodeToolStripMenuItem.Name = "decodeToolStripMenuItem";
			this.decodeToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.decodeToolStripMenuItem.Text = "Decode";
			this.decodeToolStripMenuItem.Click += new System.EventHandler(this.DecodeToolStripMenuItemClick);
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.quitToolStripMenuItem.Text = "Exit";
			this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItemClick);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.versionToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// versionToolStripMenuItem
			// 
			this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
			this.versionToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.versionToolStripMenuItem.Text = "Version";
			this.versionToolStripMenuItem.Click += new System.EventHandler(this.VersionToolStripMenuItemClick);
			// 
			// BtnLoadDecode
			// 
			this.BtnLoadDecode.Location = new System.Drawing.Point(194, 180);
			this.BtnLoadDecode.Name = "BtnLoadDecode";
			this.BtnLoadDecode.Size = new System.Drawing.Size(83, 23);
			this.BtnLoadDecode.TabIndex = 8;
			this.BtnLoadDecode.Text = "Load";
			this.BtnLoadDecode.UseVisualStyleBackColor = true;
			this.BtnLoadDecode.Click += new System.EventHandler(this.BtnLoadDecodeClick);
			// 
			// BtnSaveEncode
			// 
			this.BtnSaveEncode.Location = new System.Drawing.Point(105, 180);
			this.BtnSaveEncode.Name = "BtnSaveEncode";
			this.BtnSaveEncode.Size = new System.Drawing.Size(83, 23);
			this.BtnSaveEncode.TabIndex = 9;
			this.BtnSaveEncode.Text = "Save";
			this.BtnSaveEncode.UseVisualStyleBackColor = true;
			this.BtnSaveEncode.Click += new System.EventHandler(this.BtnSaveEncodeClick);
			// 
			// BtnSaveDecode
			// 
			this.BtnSaveDecode.Location = new System.Drawing.Point(292, 180);
			this.BtnSaveDecode.Name = "BtnSaveDecode";
			this.BtnSaveDecode.Size = new System.Drawing.Size(83, 23);
			this.BtnSaveDecode.TabIndex = 10;
			this.BtnSaveDecode.Text = "Save";
			this.BtnSaveDecode.UseVisualStyleBackColor = true;
			this.BtnSaveDecode.Click += new System.EventHandler(this.BtnSaveDecodeClick);
			// 
			// LblVersion
			// 
			this.LblVersion.Location = new System.Drawing.Point(286, 206);
			this.LblVersion.Name = "LblVersion";
			this.LblVersion.Size = new System.Drawing.Size(100, 23);
			this.LblVersion.TabIndex = 11;
			this.LblVersion.Text = "v1.2";
			this.LblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(387, 225);
			this.Controls.Add(this.LblVersion);
			this.Controls.Add(this.BtnSaveDecode);
			this.Controls.Add(this.BtnSaveEncode);
			this.Controls.Add(this.BtnLoadDecode);
			this.Controls.Add(this.BtnLoadEncode);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TxtKey);
			this.Controls.Add(this.BtnDecode);
			this.Controls.Add(this.BtnEncode);
			this.Controls.Add(this.TxtDecode);
			this.Controls.Add(this.TxtEncode);
			this.Controls.Add(this.menuStrip1);
			this.Name = "MainForm";
			this.Text = "NCode";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label LblVersion;
		private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.Button BtnSaveDecode;
		private System.Windows.Forms.Button BtnSaveEncode;
		private System.Windows.Forms.Button BtnLoadDecode;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem decodeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem encodeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem svaeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toDecodeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toEncodeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button BtnLoadEncode;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TxtKey;
		private System.Windows.Forms.Button BtnDecode;
		private System.Windows.Forms.Button BtnEncode;
		private System.Windows.Forms.TextBox TxtDecode;
		private System.Windows.Forms.TextBox TxtEncode;
		
		
		
		
	}
}

