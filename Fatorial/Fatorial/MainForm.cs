/*
 * Created by SharpDevelop.
 * User: Rikelme
 * Date: 03/06/2020
 * Time: 23:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Fatorial
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
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
	
			int n;
			int i=0;
			int fat = 1;
			
			n = int.Parse(textBox1.Text);
			
			for(i = n; i > 1; i--){
				fat = fat * i;
			}
			
			label1.Text = n + "! = " + fat;
			
			
			
			
			
		}
	}
}
