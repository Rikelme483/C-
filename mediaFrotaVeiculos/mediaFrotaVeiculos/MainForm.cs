/*
 * Created by SharpDevelop.
 * User: Rikelme
 * Date: 14/07/2020
 * Time: 22:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace mediaFrotaVeiculos
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
			richTextBox1.LoadFile("veiculosIn.txt" , RichTextBoxStreamType.PlainText);
		}
		void BtnMediaClick(object sender, EventArgs e)
		{	
			
			listBox1.Items.Clear();
			
			int linha = 1;
			while (linha < richTextBox1.Lines.Length-1) {
				linha += 1;
			}
			float consumoMedio = 0;
			float consumoTotal = 0;
			float mediaGeral = 0;
			
			listBox1.Items.Add("Placa" + "\t\t" + "KM " + "\t" + "L" + "\t" + "Consumo Médio");
			
			
			for (int i = 0; i <	richTextBox1.Lines.Length-1; i++) {
				string[] campos = richTextBox1.Lines[i].Split(' ');
				
				consumoMedio = float.Parse(campos[1]) / float.Parse(campos[2]);
				
				listBox1.Items.Add(campos[0] + "\t\t" + campos[1] + "\t" + campos[2] + "\t" + consumoMedio + " Km/L");
				
				consumoTotal += consumoMedio;
				
				mediaGeral = consumoTotal / 8;
				
				
				
			}
			listBox1.Items.Add("----------------------------------------------");
			listBox1.Items.Add("\n");
			listBox1.Items.Add("Consumo Total: " + consumoTotal + " Km/L");
			listBox1.Items.Add("\n");
			listBox1.Items.Add("Média geral: " + mediaGeral + " Km/L");
		}
		void BtnListarClick(object sender, EventArgs e)
		{	
			listBox2.Items.Clear();
			
			int linha = 1;
			while (linha < richTextBox1.Lines.Length-1) {
				linha += 1;
			}
			
			float consumoMedio = 0;
			float consumoTotal = 0;
			float mediaGeral = 0;
			
			for (int i = 0; i <	richTextBox1.Lines.Length-1; i++) {
				string[] campos = richTextBox1.Lines[i].Split(' ');
				
				consumoMedio = float.Parse(campos[1]) / float.Parse(campos[2]);
				
				consumoTotal += consumoMedio;
				
				mediaGeral = consumoTotal / linha;
				
				if (consumoMedio < mediaGeral) {
					
					listBox2.Items.Add(campos[0]);
					
				}
								
			}	
			
			
		}
		
		void BtnGravarClick(object sender, EventArgs e)
		{
			listBox2.Items.Clear();
			
			int linha = 1;
			while (linha < richTextBox1.Lines.Length-1) {
				linha += 1;
			}
			float consumoMedio = 0;
			float consumoTotal = 0;
			float mediaGeral = 0;
			
			for (int i = 0; i <	richTextBox1.Lines.Length-1; i++) {
				string[] campos = richTextBox1.Lines[i].Split(' ');
				
				consumoMedio = float.Parse(campos[1]) / float.Parse(campos[2]);
				
				consumoTotal += consumoMedio;
				
				mediaGeral = consumoTotal / linha;
				
				if (consumoMedio < mediaGeral ) {
					listBox2.Items.Add(campos[0]);
					
					richTextBox2.Text += campos[0] + "\n";
					richTextBox2.SaveFile("veiculosOut.txt" , RichTextBoxStreamType.PlainText);
					
				}
								
			}
			MessageBox.Show("Dados Gravados com sucesso" , "Aviso" , MessageBoxButtons.OK , MessageBoxIcon.Information);	
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		
	}
}
