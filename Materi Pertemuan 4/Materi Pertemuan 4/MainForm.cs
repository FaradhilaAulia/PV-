/*
 * Created by SharpDevelop.
 * User: User
 * Date: 3/2/2022
 * Time: 2:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Materi_Pertemuan_4
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
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
		
		
		void Button1Click(object sender, EventArgs e)
		{
			MessageBox.Show ("Perkenalkan Nama saya " + this.textBox1.Text + " ,Nim " + this.textBox2.Text + " ,Kelas " + this.textBox3.Text + " ,sedang Belajar " + this.textBox4.Text);
		}
		
	}
}
