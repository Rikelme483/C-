/*
 * Created by SharpDevelop.
 * User: Rikelme
 * Date: 10/06/2020
 * Time: 16:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Mini_teclado
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
			
			
		} 
		void Button1Click(object sender, EventArgs e)
		{
			string C = "C";
			
			
			
			textBox1.Text = textBox1.Text + C;
			
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			string A = "A";
			
			textBox1.Text = textBox1.Text + A;
			
			/*for (int i = 0; i < A.Length; i++) {
				
				listBox1.Items.Add(A[i] + ": " + (i+1));
				
			}*/
			
		}
		void Button3Click(object sender, EventArgs e)
		{
			string R = "R";
			
			textBox1.Text = textBox1.Text + R;
			
		}
		void Button5Click(object sender, EventArgs e)
		{
			string O = "O";
			
			textBox1.Text = textBox1.Text + O;
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		void Button4Click(object sender, EventArgs e)
		{ 
			
			textBox1.Clear();
			
			textBox2.Clear();
			/*string s = textBox1.Text;
			
			for (int i = 0; i < s.Length; i++) {
				
				listBox1.Items.Add(s[i] + ": " + (i+1));
				label2.Text = s[i] + ": " + (i+1);
				
			}*/
		}
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		void Button6Click(object sender, EventArgs e)
		{
			int cont = 0;
			
			char letra = textBox2.Text[0];
			string texto = textBox1.Text;
			
			
		
				for (int i = 0; i <= texto.Length-1; i++) {
				//label2.Text = "Quantidade de letras: " + letra[i] + ": " + (i+1);
				
				
				if(texto[i] == letra){
					
					
					cont++;
					label2.Text = "Quantidade de letras: " + cont; // no label 2, aparece a quantidade de letras pesquisada no textbox2
					
				}
				
				}
			
			
			
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Button7Click(object sender, EventArgs e)
		{
				string Q = "Q";
			
			textBox1.Text = textBox1.Text + Q;
	
		}
		void Button23Click(object sender, EventArgs e)
		{
				string W = "W";
			
			textBox1.Text = textBox1.Text + W;
	
		}
		void Button24Click(object sender, EventArgs e)
		{
				string E = "E";
			
			textBox1.Text = textBox1.Text + E;
		}
		void Button25Click(object sender, EventArgs e)
		{
				string T = "T";
			
			textBox1.Text = textBox1.Text + T;
		}
		void Button26Click(object sender, EventArgs e)
		{
				string Y = "Y";
			
			textBox1.Text = textBox1.Text + Y;
		}
		void Button27Click(object sender, EventArgs e)
		{
				string U = "U";
			
			textBox1.Text = textBox1.Text + U;
		}
		void Button28Click(object sender, EventArgs e)
		{
				string I = "I";
			
			textBox1.Text = textBox1.Text + I;
		}
		void Button29Click(object sender, EventArgs e)
		{
				string P = "P";
			
			textBox1.Text = textBox1.Text + P;
		}
		void Button14Click(object sender, EventArgs e)
		{
				string S = "S";
			
			textBox1.Text = textBox1.Text + S;
		}
		void Button15Click(object sender, EventArgs e)
		{
				string D = "D";
			
			textBox1.Text = textBox1.Text + D;
		}
		void Button16Click(object sender, EventArgs e)
		{
				string F = "F";
			
			textBox1.Text = textBox1.Text + F;
		}
		void Button17Click(object sender, EventArgs e)
		{
				string G = "G";
			
			textBox1.Text = textBox1.Text + G;
		}
		void Button18Click(object sender, EventArgs e)
		{
				string H = "H";
			
			textBox1.Text = textBox1.Text + H;
		}
		void Button19Click(object sender, EventArgs e)
		{
				string J = "J";
			
			textBox1.Text = textBox1.Text + J;
		}
		void Button20Click(object sender, EventArgs e)
		{
				string K = "K";
			
			textBox1.Text = textBox1.Text + K;
		}
		void Button21Click(object sender, EventArgs e)
		{
				string L = "L";
			
			textBox1.Text = textBox1.Text + L;
		}
		void Button22Click(object sender, EventArgs e)
		{
				string Ç = "Ç";
			
			textBox1.Text = textBox1.Text + Ç;
		}
		void Button8Click(object sender, EventArgs e)
		{
				string Z = "Z";
			
			textBox1.Text = textBox1.Text + Z;
		}
		void Button9Click(object sender, EventArgs e)
		{
				string X = "X";
			
			textBox1.Text = textBox1.Text + X;
		}
		void Button10Click(object sender, EventArgs e)
		{
				string V = "V";
			
			textBox1.Text = textBox1.Text + V;
		}
		void Button11Click(object sender, EventArgs e)
		{
				string B = "B";
			
			textBox1.Text = textBox1.Text + B;
		}
		void Button12Click(object sender, EventArgs e)
		{
				string N = "N";
			
			textBox1.Text = textBox1.Text + N;
		}
		void Button13Click(object sender, EventArgs e)
		{
				string M = "M";
			
			textBox1.Text = textBox1.Text + M;
		}
		void Button30Click(object sender, EventArgs e)
		{
				string space = " ";
			
			textBox1.Text = textBox1.Text + space;
		}

	}
}
