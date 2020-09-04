/*
 * Created by SharpDevelop.
 * User: Rikelme
 * Date: 03/06/2020
 * Time: 21:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Numeros_pares_0_a_100
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
			
			int i = 0;
			
			while (i < 50) {
				i++;
				int npar;
				npar = 2 * i;
				listBox1.Items.Add(npar);
				
			}
			
			
		}
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
			
			
			
			
			
		}
	}
}
