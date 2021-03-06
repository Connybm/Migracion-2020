﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace migracion_2020
{
	public partial class Inicio : Form
	{
		string noCui = "";
		public Inicio(string cui)
		{
			noCui = cui;
			InitializeComponent();
		}

		private void PictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void Button1_MouseDown(object sender, MouseEventArgs e)
		{
			System.Drawing.Color CelesteGob = System.Drawing.ColorTranslator.FromHtml("#049dd9");
			pictureBox4.BackgroundImage= global::migracion_2020.Properties.Resources.button_round;
			button1.BackColor = CelesteGob;
			button1.FlatAppearance.BorderColor = CelesteGob;
		}

		private void Button1_MouseEnter(object sender, EventArgs e)
		{
			System.Drawing.Color AzulGob = System.Drawing.ColorTranslator.FromHtml("#024873");
			pictureBox4.BackgroundImage = global::migracion_2020.Properties.Resources.button_round_hover;
			button1.BackColor = AzulGob;
			button1.FlatAppearance.BorderColor = AzulGob;
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Principal nuevo = new Principal();
			nuevo.Show();
		}

		private void Button1_MouseLeave(object sender, EventArgs e)
		{
			System.Drawing.Color CelesteGob = System.Drawing.ColorTranslator.FromHtml("#049dd9");
			pictureBox4.BackgroundImage = global::migracion_2020.Properties.Resources.button_round;
			button1.BackColor = CelesteGob;
			button1.FlatAppearance.BorderColor = CelesteGob;
		}

		private void Button1_Click_1(object sender, EventArgs e)
		{
			SQL_tramites tramite = new SQL_tramites();

			if (txtNom.Text != "" && txtNom.Text != " ")
			{
				tramite.Ingresar_Transacciones(txtNom.Text, noCui, DateTime.Now.ToString("yyyy-MM-dd"));
				this.Hide();
				Principal nuevo = new Principal();
				nuevo.Show();
			}
			else
			{
				MessageBox.Show("Por favor coloque un nombre al tramite");
			}
			
		}

		private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void Inicio_Load(object sender, EventArgs e)
		{
			SQL_LLenar_Tabla tramites = new SQL_LLenar_Tabla();
			OdbcDataAdapter dt = tramites.llenaTbl("tramites",noCui);
			DataTable table = new DataTable();
			dt.Fill(table);
			dataGridView1.DataSource = table;
		}
	}
}
