/*
 * Created by SharpDevelop.
 * User: Rikelme
 * Date: 21/05/2020
 * Time: 19:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Velocidade_média
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
		}
		void Button1Click(object sender, EventArgs e)
		{
	
			float rad1, rad2, t, vm;
			
			rad1 = float.Parse(textBox1.Text);
			rad2 = float.Parse(textBox2.Text);
			t = float.Parse(textBox3.Text);
			
			vm = (rad2 - rad1) / t;
			
			textBox4.Text = vm.ToString();
			
			if (vm > 60) {
				label8.Text = "Velocidade acima da média!! Multa aplicada";
				pictureBox4.Load("multado.png");
			}
			else{
				label8.Text = "Velocidade dentro do limite...";
				pictureBox4.Load("motorista.jpg");
			
			}
			
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
	}
}
