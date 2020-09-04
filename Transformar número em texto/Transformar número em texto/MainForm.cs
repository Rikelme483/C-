/*
 * Created by SharpDevelop.
 * User: Rikelme
 * Date: 31/05/2020
 * Time: 19:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Transformar_número_em_texto
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
	
			
			int n;
			n = int.Parse(textBox1.Text);
			
			
			if(n == 0){
				label2.Text = "Zero";
			}else if(n == 1){
				label2.Text = "Um";
			}else if (n == 2) {
				label2.Text = "Dois";
			}else if (n == 3) {
				label2.Text = "Três";
			}else if (n == 4) {
				label2.Text = "Quatro";
			}else if (n == 5) {
				label2.Text = "Cinco";
			}else if (n == 6) {
				label2.Text = "Seis";
			}else if (n == 7) {
				label2.Text = "Sete";
			}else if (n == 8) {
				label2.Text = "Oito";
			}else if (n == 9) {
				label2.Text = "Nove";
			}else if (n == 10) {
				label2.Text = "Dez";
			}else if (n == 11) {
				label2.Text = "Onze";
			}else if (n == 12) {
				label2.Text = "Doze";
			}else if (n == 13) {
				label2.Text = "Treze";
			}else if (n == 14) {
				label2.Text = "Quatorze";
			}else if (n == 15) {
				label2.Text = "Quinze";
			}else if (n == 16) {
				label2.Text = "Dezesseis";
			}else if (n == 17) {
				label2.Text = "Dezessete";
			}else if (n == 18) {
				label2.Text = "Dezoito";
			}else if (n == 19) {
				label2.Text = "Dezenove";
			}else if(n == 20){
				label2.Text = "Vinte";
			}else if (n == 21) {
				label2.Text = "Vinte e um";
			}else if (n == 22) {
				label2.Text = "Vinte e dois";
			}else if (n == 23) {
				label2.Text = "Vinte e três";
			}else if (n == 24) {
				label2.Text = "Vinte e quatro";
			}else if (n == 25) {
				label2.Text = "Vinte e cinco";
			}else if (n == 26) {
				label2.Text = "Vinte e seis";
			}else if (n == 27) {
				label2.Text = "Vinte e sete";
			}else if (n == 28) {
				label2.Text = "Vinte e oito";
			}else if (n == 29) {
				label2.Text = "Vinte e nove";
			}else if (n == 30) {
				label2.Text = "Trinta";
			}else if (n == 31) {
				label2.Text = "Trinta e um";
			}else if (n == 32) {
				label2.Text = "Trinta e dois";
			}else if (n == 33) {
				label2.Text = "Trinta e três";
			}else if (n == 34) {
				label2.Text = "Trinta e quatro";
			}else if (n == 35) {
				label2.Text = "Trinta e cinco";
			}
			
			
			
				
			
			
			
			
				
			
			
			
		}
	}
}
