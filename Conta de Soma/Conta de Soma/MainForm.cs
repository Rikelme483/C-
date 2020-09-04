/*
 * Created by SharpDevelop.
 * User: Rikelme
 * Date: 14/05/2020
 * Time: 16:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Conta_de_Soma
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
		void MainFormLoad(object sender, EventArgs e)
		{
			BackColor= Color.Aqua;
		}
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			int num1, num2, soma;
			
			num1 = int.Parse(textBox1.Text);
			num2 = int.Parse(textBox2.Text);
			soma = num1 + num2;
			
			textBox3.Text= soma.ToString();
			
			
			
			
		}
		void TextBox3TextChanged(object sender, EventArgs e)
		{
			
	  			
		}
	}
}
