/*
 * Created by SharpDevelop.
 * User: Rikelme
 * Date: 25/06/2020
 * Time: 20:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Registro_de_empregados
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
		void Label3Click(object sender, EventArgs e)
		{		
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
		try {
				richTextBox1.LoadFile("arquivo.txt" , RichTextBoxStreamType.PlainText);
			
		} catch (Exception exc) {
			
				richTextBox1.Text = "\n";
				richTextBox1.SaveFile("arquivo.txt" , RichTextBoxStreamType.PlainText);
		}
		
			Novo();
			btnGravar.Enabled = true;
			
		}
		
	
		
		void BtNovoClick(object sender, EventArgs e)
		{
			Novo();
		}
		
		void Novo()
		{
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			label3.Text = (richTextBox1.Lines.Length -1).ToString();
			btnGravar.Enabled = true;
		}
		void BtnGravarClick(object sender, EventArgs e)
		{
			string linha = textBox1.Text + "#" + textBox2.Text + "#" + textBox3.Text + "#" +
				textBox4.Text;
			
			richTextBox1.Text += linha + "\n";
			
			richTextBox1.SaveFile("arquivo.txt" , RichTextBoxStreamType.PlainText);
			
			MessageBox.Show("Dados gravados com sucesso", "Aviso");
			
			Novo();
			btnGravar.Enabled = true;
		}
		void SalvarClick(object sender, EventArgs e)
		{
	
		}
		void BtnAbrirClick(object sender, EventArgs e)
		{
			richTextBox1.LoadFile("arquivo.txt", RichTextBoxStreamType.PlainText);
		}
		void BtnConsultarClick(object sender, EventArgs e)
		{
			int nLinha = int.Parse(textBox4.Text);
			
			if (nLinha > 0 && nLinha < richTextBox1.Lines.Length -1) {
				
				label3.Text = nLinha.ToString();
				
				string linha = richTextBox1.Lines[nLinha];
				string[] dados = linha.Split('#');
				
				textBox1.Text = dados[0];
				textBox2.Text = dados[1];
				textBox3.Text = dados[2];
				
			}
			else{
				MessageBox.Show("Erro!! Dados não gravados" , "aviso");
			}
			
			textBox4.Clear();
			btnGravar.Enabled = false;
		}
		void BtnAlterarClick(object sender, EventArgs e)
		{
			
			
			
		}
		void BtnDeletarClick(object sender, EventArgs e)
		{
			int nlinha = int.Parse(label3.Text);
			
			string linhaAntiga = richTextBox1.Lines[nlinha];
			string linhaNova = textBox1.Text + "#" + textBox2.Text + "#" + textBox3.Text + "#" 
				+ textBox4.Text;
			
			if (MessageBox.Show("Deseja realmente excluir este campo?" , "Aviso" ,
			          MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
				
				richTextBox1.Text = richTextBox1.Text.Replace(linhaAntiga , linhaNova);
				richTextBox1.SaveFile("arquivo.txt" , RichTextBoxStreamType.PlainText);
				Novo();
				btnGravar.Enabled = false;
				
			}else{
				MessageBox.Show("Dados não deletados" ,  "Aviso");
					
			}
			
		}
		
		
	
	}
	
}
