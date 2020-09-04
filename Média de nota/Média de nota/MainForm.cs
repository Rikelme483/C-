/*
 * Created by SharpDevelop.
 * User: Rikelme
 * Date: 18/06/2020
 * Time: 14:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Média_de_nota
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
			BackColor = Color.Aqua;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		string[] name = new string[2];  // declaração de arrays de forma global para ser usada em botões
		int cont = 0; // declaração de contagem
		float[] nota1 = new float[2];
		float[] nota2 = new float[2];
		
		void Media(object sender, EventArgs e)
		{
			float n1 = float.Parse(textBox2.Text); 
			float n2 = float.Parse(textBox3.Text);  // declaraçoes de nome e notas 
			string nome = textBox1.Text;
			
			
			
			float media = (n1 + n2) / 2; // calculo de media
			
			label4.Text = "Resultado: " + media; // inserir a media no label
			
			if (media >= 7) { // comando if para ver a situação do aluno
				label5.Text = "Situção: " + nome + ", Aprovado!!!";  
				pictureBox1.Load("Aprovado.jpg"); // carregar imagem de aprovado
			}else if (media < 5) {
				label5.Text = "Situação: " + nome + ", Reprovado!!!";
				pictureBox1.Load("Reprovado.jpg"); // carregar imade de reprovado
			}else{
				label5.Text = "Situação: " + nome + ", Recuperação...";
				pictureBox1.Load("Recuperação.jpg"); // carregar imagem de recuperação
			}
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			label4.Text = "Resultado: ";  // limpar os textboxes e labels
			label5.Text = "Situação: "; 
			
		}
		void Button3Click(object sender, EventArgs e)
		{
			
			name[cont] = textBox4.Text;
			nota1[cont] = float.Parse(textBox5.Text);  // Arrays para armazenar nome e notas do aluno, especificada em global
			nota2[cont] = float.Parse(textBox6.Text);
			
			cont++; // cont++ para contar os elementos digitados depois de guardar no botão
			textBox4.Clear();
			textBox5.Clear(); // limpar os textboxes
			textBox6.Clear();
			
			if (cont == 2) { // se cont for igual a 2, o botao ficará insdisponivel para inserir mais dados
				button3.Enabled = false; // comando para desabilitar o botão
				MessageBox.Show("Dados gravados!" , "aviso"); // mensagem na tela para confirmação de dados gravados
			}
			
		}
		void Button4Click(object sender, EventArgs e)
		{
			for (int i = 0; i < cont; i++) {  // for para fazer um loop dos arrays declarados
				//listBox1.Items.Add("Olá " + name[i] + ", sua nota 1 é: " + nota1[i] + " e nota 2 é: " + nota2[i]);
				
				float media = (nota1[i] + nota2[i]) / 2; // para cada contagem de i, irá armazenar a media na variavel
				listBox1.Items.Add("Olá " + name[i] + ", sua média é: " + media + "!!"); // exibir nome e media no listbox
				
			}
	
		}
	}
}
