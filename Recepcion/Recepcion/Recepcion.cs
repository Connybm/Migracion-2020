using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Recepcion
{
    public partial class Recepcion : UserControl
    {
        public Recepcion()
        {
            InitializeComponent();
        }

        public string cui;
        public int tramite;
        public string TipoTramite = " ";

        public void ObtenerCui(string cui)
        {
            this.cui = cui;
        }

        public void ObtenerTramite(int tramite)
        {
            this.tramite = tramite;
        }

        public void AsignarPestana(String Tipo)
        {
            switch (Tipo)
            {
                case "Mayor de edad":
                    Tbc_Recepcion.SelectedIndex = 0;
                    break;
                case "Menor de edad":
                    Tbc_Recepcion.SelectedIndex = 1;
                    break;
                case "Adulto Mayor de 60 años":
                    Tbc_Recepcion.SelectedIndex = 2;
                    break;
            }
        }

        private void Btn_DPIMayoresACopia_Click(object sender, EventArgs e)
        {
            /*
               Ofd_MayoresA.InitialDirectory = "C:\\Documents";
               Ofd_MayoresA.Filter = "Archivo PDF (*.PDF)|*.PDF";

               if (Ofd_MayoresA.ShowDialog() == DialogResult.OK)
               {
                   try
                   {
                       this.fileUpload = Ofd_MayoresA.FileName.ToString();
                       nombre = this.fileUpload.Split('\\');
                       string sRutaMayoresA = Ofd_MayoresA.FileName;
                       Txt_DPICopiaMayoresA.Text = sRutaMayoresA;
                   }
                   catch (Exception)
                   {
                       throw;
                   }
               }
            */

            String[] nombre;
            String fileUpload;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "allfiles|*.pdf";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                fileUpload = openFileDialog.FileName.ToString();
                nombre = fileUpload.Split('\\');
                Txt_DPICopiaMayoresA.Text = nombre[nombre.Length - 1];
            }
        }

        private void Txt_DPIMayoresA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar));
        }

        private void Txt_BoletaMayoresA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar));
        }

        private void Btn_DPIMayoresCopia_Click(object sender, EventArgs e)
        {
            /*
            Ofd_Mayores.InitialDirectory = "C:\\Documents";
            Ofd_Mayores.Filter = "Archivo PDF (*.PDF)|*.PDF";

            if (Ofd_Mayores.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string sRutaDPIMayores = Ofd_Mayores.FileName;
                    Txt_DPICopiaMayores.Text = sRutaDPIMayores;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            */

            String[] nombre;
            String fileUpload;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "allfiles|*.pdf";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                fileUpload = openFileDialog.FileName.ToString();
                nombre = fileUpload.Split('\\');
                Txt_DPICopiaMayores.Text = nombre[nombre.Length - 1];
            }
        }

        private void Btn_BoletoOrnatoCopiaMayores_Click(object sender, EventArgs e)
        {
            /*
            Ofd_Mayores.InitialDirectory = "C:\\Documents";
            Ofd_Mayores.Filter = "Archivo PDF (*.PDF)|*.PDF";

            if (Ofd_MayoresA.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string sRutaBoletoMayores = Ofd_Mayores.FileName;
                    Txt_DPICopiaMayores.Text = sRutaBoletoMayores;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            */

            String[] nombre;
            String fileUpload;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "allfiles|*.pdf";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                fileUpload = openFileDialog.FileName.ToString();
                nombre = fileUpload.Split('\\');
                Txt_BoletoOrnatoCopiaMayores.Text = nombre[nombre.Length - 1];
            }
        }

        private void Txt_DPIMayores_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar));
        }

        private void Txt_BoletoOrnatoMayores_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar));
        }

        private void Txt_BoletaMayores_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar));
        }

        private void Btn_DPICopiaPadre_Click(object sender, EventArgs e)
        {
            /*
            Ofd_Menores.InitialDirectory = "C:\\Documents";
            Ofd_Menores.Filter = "Archivo PDF (*.PDF)|*.PDF";

            if (Ofd_Menores.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string sRutaDPIPadre = Ofd_Menores.FileName;
                    Txt_DPIPadreCopia.Text = sRutaDPIPadre;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            */

            String[] nombre;
            String fileUpload;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "allfiles|*.pdf";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                fileUpload = openFileDialog.FileName.ToString();
                nombre = fileUpload.Split('\\');
                Txt_DPIPadreCopia.Text = nombre[nombre.Length - 1];
            }
        }

        private void Btn_DPICopiaMadre_Click(object sender, EventArgs e)
        {
            /*
            Ofd_Menores.InitialDirectory = "C:\\Documents";
            Ofd_Menores.Filter = "Archivo PDF (*.PDF)|*.PDF";

            if (Ofd_Menores.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string sRutaDPIMadre = Ofd_Menores.FileName;
                    Txt_DPIMadreCopia.Text = sRutaDPIMadre;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            */

            String[] nombre;
            String fileUpload;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "allfiles|*.pdf";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                fileUpload = openFileDialog.FileName.ToString();
                nombre = fileUpload.Split('\\');
                Txt_DPIMadreCopia.Text = nombre[nombre.Length - 1];
            }
        }

        private void Btn_CertiNaci_Click(object sender, EventArgs e)
        {
            /*
            Ofd_Menores.InitialDirectory = "C:\\Documents";
            Ofd_Menores.Filter = "Archivo PDF (*.PDF)|*.PDF";

            if (Ofd_Menores.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string sRutaCertificado = Ofd_Menores.FileName;
                    Txt_CertiNaci.Text = sRutaCertificado;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            */

            String[] nombre;
            String fileUpload;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "allfiles|*.pdf";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                fileUpload = openFileDialog.FileName.ToString();
                nombre = fileUpload.Split('\\');
                Txt_CertiNaci.Text = nombre[nombre.Length - 1];
            }
        }

        private void Btn_CartaPoder_Click(object sender, EventArgs e)
        {
            /*
            Ofd_Menores.InitialDirectory = "C:\\Documents";
            Ofd_Menores.Filter = "Archivo PDF (*.PDF)|*.PDF";

            if (Ofd_Menores.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string sRutaCartaPoder = Ofd_Menores.FileName;
                    Txt_CartaPoder.Text = sRutaCartaPoder;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            */

            String[] nombre;
            String fileUpload;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "allfiles|*.pdf";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                fileUpload = openFileDialog.FileName.ToString();
                nombre = fileUpload.Split('\\');
                Txt_CartaPoder.Text = nombre[nombre.Length - 1];
            }
        }

        private void Btn_BoletaMenor_Click(object sender, EventArgs e)
        {
            /*
            Ofd_Menores.InitialDirectory = "C:\\Documents";
            Ofd_Menores.Filter = "Archivo PDF (*.PDF)|*.PDF";

            if (Ofd_Menores.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string sRutaBoletoMenor = Ofd_Menores.FileName;
                    Txt_BoletoOrnatoCopiaMenor.Text = sRutaBoletoMenor;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            */

            String[] nombre;
            String fileUpload;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "allfiles|*.pdf";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                fileUpload = openFileDialog.FileName.ToString();
                nombre = fileUpload.Split('\\');
                Txt_BoletoOrnatoCopiaMenor.Text = nombre[nombre.Length - 1];
            }
        }

        private void Txt_DPIPadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar));
        }

        private void Txt_DPIMadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar));
        }

        private void Txt_BoletoOrnatoMenor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar));
        }

        private void Txt_BoletaMenor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar));
        }

        private void Btn_EnviarMenor_Click(object sender, EventArgs e)
        {
            SQL_Menores users = new SQL_Menores();
            users.Ingresar_Menores(tramite, cui, Txt_DPIMadre.Text, Txt_DPIPadre.Text, Txt_DPIPadreCopia.Text, Txt_DPIMadreCopia.Text,
                Txt_CertiNaci.Text, Txt_CartaPoder.Text, Txt_BoletoOrnatoMenor.Text, Txt_BoletoOrnatoCopiaMenor.Text, Txt_BoletaMenor.Text);
            this.Hide();
        }

        private void Btn_EnviarMayoresA_Click(object sender, EventArgs e)
        {
            SQL_MayoresA users = new SQL_MayoresA();
            users.Ingresar_MayoresA(tramite, cui, Txt_DPICopiaMayoresA.Text, Txt_BoletaMayoresA.Text);
            this.Hide();
        }

        private void Btn_EnviarMayores_Click(object sender, EventArgs e)
        {
            SQL_Mayores users = new SQL_Mayores();
            users.Ingresar_Mayores(tramite, cui, Txt_DPICopiaMayores.Text, Txt_BoletoOrnatoMayores.Text, Txt_BoletoOrnatoCopiaMayores.Text, Txt_BoletaMayores.Text);
            this.Hide();
        }

        private void HideAllTabsOnTabControl(TabControl theTabControl)
        {
            theTabControl.Appearance = TabAppearance.FlatButtons;
            theTabControl.ItemSize = new Size(0, 1);
            theTabControl.SizeMode = TabSizeMode.Fixed;
        }

    }
}
