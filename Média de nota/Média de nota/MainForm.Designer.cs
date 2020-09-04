/*
 * Created by SharpDevelop.
 * User: Rikelme
 * Date: 18/06/2020
 * Time: 14:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Média_de_nota
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button Média;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.Média = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.button4 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(56, 43);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(120, 20);
			this.textBox1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nome:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(68, 88);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(51, 20);
			this.textBox2.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "1º Nota:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 134);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "2º Nota:";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(68, 134);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(51, 20);
			this.textBox3.TabIndex = 5;
			// 
			// Média
			// 
			this.Média.Location = new System.Drawing.Point(21, 174);
			this.Média.Name = "Média";
			this.Média.Size = new System.Drawing.Size(75, 23);
			this.Média.TabIndex = 6;
			this.Média.Text = "Média";
			this.Média.UseVisualStyleBackColor = true;
			this.Média.Click += new System.EventHandler(this.Media);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(102, 174);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 7;
			this.button2.Text = "Reset";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(21, 216);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(155, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Resultado:";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label5.Location = new System.Drawing.Point(231, 65);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(188, 20);
			this.label5.TabIndex = 0;
			this.label5.Text = "Situação:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(231, 88);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(162, 105);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// listBox1
			// 
			this.listBox1.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Location = new System.Drawing.Point(610, 50);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(231, 144);
			this.listBox1.TabIndex = 11;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(471, 47);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(120, 20);
			this.textBox4.TabIndex = 12;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(540, 138);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(51, 20);
			this.textBox6.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(427, 47);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(38, 20);
			this.label6.TabIndex = 15;
			this.label6.Text = "Nome:";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(484, 141);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(50, 20);
			this.label8.TabIndex = 17;
			this.label8.Text = "2º Nota:";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(448, 174);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 18;
			this.button3.Text = "Guardar";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(484, 92);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 20);
			this.label7.TabIndex = 16;
			this.label7.Text = "1º Nota:";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(540, 92);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(51, 20);
			this.textBox5.TabIndex = 13;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(529, 174);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 19;
			this.button4.Text = "Média";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(853, 305);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.Média);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Name = "MainForm";
			this.Text = "Média de nota";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
