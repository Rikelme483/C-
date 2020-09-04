/*
 * Created by SharpDevelop.
 * User: Rikelme
 * Date: 25/06/2020
 * Time: 20:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Registro_de_empregados
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button btnGravar;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.Button btnDeletar;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnAbrir;
		private System.Windows.Forms.Button Salvar;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnNovo = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.btnGravar = new System.Windows.Forms.Button();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.btnDeletar = new System.Windows.Forms.Button();
			this.btnAbrir = new System.Windows.Forms.Button();
			this.Salvar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(433, 24);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(355, 142);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(35, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Registro:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(91, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "0";
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// btnNovo
			// 
			this.btnNovo.Location = new System.Drawing.Point(123, 22);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(75, 23);
			this.btnNovo.TabIndex = 3;
			this.btnNovo.Text = "Novo";
			this.btnNovo.UseVisualStyleBackColor = true;
			this.btnNovo.Click += new System.EventHandler(this.BtNovoClick);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(35, 76);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Nome:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(35, 92);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(143, 20);
			this.textBox1.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(35, 119);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Endereço:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(35, 135);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(143, 20);
			this.textBox2.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(35, 167);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(104, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "Salário:";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(35, 183);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(143, 20);
			this.textBox3.TabIndex = 9;
			// 
			// btnGravar
			// 
			this.btnGravar.Location = new System.Drawing.Point(35, 209);
			this.btnGravar.Name = "btnGravar";
			this.btnGravar.Size = new System.Drawing.Size(75, 23);
			this.btnGravar.TabIndex = 10;
			this.btnGravar.Text = "Gravar";
			this.btnGravar.UseVisualStyleBackColor = true;
			this.btnGravar.Click += new System.EventHandler(this.BtnGravarClick);
			// 
			// btnConsultar
			// 
			this.btnConsultar.Location = new System.Drawing.Point(116, 209);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(75, 23);
			this.btnConsultar.TabIndex = 11;
			this.btnConsultar.Text = "Consultar";
			this.btnConsultar.UseVisualStyleBackColor = true;
			this.btnConsultar.Click += new System.EventHandler(this.BtnConsultarClick);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(197, 212);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(25, 20);
			this.textBox4.TabIndex = 12;
			// 
			// btnAlterar
			// 
			this.btnAlterar.Location = new System.Drawing.Point(35, 238);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(75, 23);
			this.btnAlterar.TabIndex = 13;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.UseVisualStyleBackColor = true;
			this.btnAlterar.Click += new System.EventHandler(this.BtnAlterarClick);
			// 
			// btnDeletar
			// 
			this.btnDeletar.Location = new System.Drawing.Point(116, 238);
			this.btnDeletar.Name = "btnDeletar";
			this.btnDeletar.Size = new System.Drawing.Size(75, 23);
			this.btnDeletar.TabIndex = 14;
			this.btnDeletar.Text = "Deletar";
			this.btnDeletar.UseVisualStyleBackColor = true;
			this.btnDeletar.Click += new System.EventHandler(this.BtnDeletarClick);
			// 
			// btnAbrir
			// 
			this.btnAbrir.Location = new System.Drawing.Point(620, 172);
			this.btnAbrir.Name = "btnAbrir";
			this.btnAbrir.Size = new System.Drawing.Size(75, 23);
			this.btnAbrir.TabIndex = 16;
			this.btnAbrir.Text = "Abrir";
			this.btnAbrir.UseVisualStyleBackColor = true;
			this.btnAbrir.Click += new System.EventHandler(this.BtnAbrirClick);
			// 
			// Salvar
			// 
			this.Salvar.Location = new System.Drawing.Point(539, 172);
			this.Salvar.Name = "Salvar";
			this.Salvar.Size = new System.Drawing.Size(75, 23);
			this.Salvar.TabIndex = 17;
			this.Salvar.Text = "Salvar";
			this.Salvar.UseVisualStyleBackColor = true;
			this.Salvar.Click += new System.EventHandler(this.SalvarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(840, 293);
			this.Controls.Add(this.Salvar);
			this.Controls.Add(this.btnAbrir);
			this.Controls.Add(this.btnDeletar);
			this.Controls.Add(this.btnAlterar);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.btnConsultar);
			this.Controls.Add(this.btnGravar);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnNovo);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.richTextBox1);
			this.Name = "MainForm";
			this.Text = "Registro de empregados";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
