/*
 * Created by SharpDevelop.
 * User: Rikelme
 * Date: 01/07/2020
 * Time: 20:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ListaFuncionários
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
		void BtnAbrirClick(object sender, EventArgs e)
		{
			Lista();
		}
		
		void Lista(){
			richTextBox1.LoadFile("listaFuncionarios.txt" , RichTextBoxStreamType.PlainText);
		}
		void BtnListarClick(object sender, EventArgs e)
		{
			float total = 0;
			
			for (int i = 0; i < richTextBox1.Lines.Length-1; i++) {
				
				string linha = richTextBox1.Lines[i];
				string[] dados = linha.Split(',');
					
				listBox1.Items.Add(dados[0] + ", da seção " + dados[1] +  ", possui salário mensal de R$ " +  dados[2]);
				
				
				float salario = float.Parse(dados[2]);
						
				total += salario;
				
				label12.Text = "Salário total: R$ " + total;
				
			}
				
		}
		
		void BtnSomarClick(object sender, EventArgs e)
		{
			listBox2.Items.Clear();
			int nSecao = int.Parse(textBox1.Text);
			
			float total = 0;
			
			for (int i = 0; i < richTextBox1.Lines.Length-1; i++) {
				string linha = richTextBox1.Lines[i];
				string[] dados = linha.Split(',');
				
				if (int.Parse(dados[1]) == nSecao) {
					
					float salario = float.Parse(dados[2]);
					
					total += salario;
					
					
					listBox2.Items.Add(dados[0] + ", seção " + dados[1] + ", Salário: R$" + dados[2] );
					label10.Text = "Salário total da seção " + dados[1] + ": R$" + total;
					
				}
			
			}
		}
	}
}