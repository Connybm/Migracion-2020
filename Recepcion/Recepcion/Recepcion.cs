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
        public string tramite;
        public string TipoTramite = " ";
        DateTime fe = new DateTime();
        SQL_Bitacora log = new SQL_Bitacora();

        public void ObtenerCui(string cui)
        {
            this.cui = cui;
        }

            SQL_TipoTramite tipoTramite = new SQL_TipoTramite();
        public void ObtenerTramite(string tramite)
        {
            this.tramite = tramite;
            tipoTramite.obtenerTipoTramite(cui, tramite);
            TipoTramite = tipoTramite.tipoTramite;
            AsignarPestana();
        }

        public void AsignarPestana()
        {
            if (TipoTramite == "Menor")
            {
                Tbc_Recepcion.SelectedIndex = 0;
            }
            else if(TipoTramite == "Mayor")
            {
                Tbc_Recepcion.SelectedIndex = 1;
            }
            else if(TipoTramite == "Mayor 60")
            {
                Tbc_Recepcion.SelectedIndex = 2;
            }
            else
            {

            }
        }

        private void Btn_DPIMayoresACopia_Click(object sender, EventArgs e)
        {
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

            log.Ingresar_Bitacora(cui, "Documentos enviados del Menor de Edad", fe.ToString());
        }

        private void Btn_EnviarMayoresA_Click(object sender, EventArgs e)
        {
            SQL_MayoresA users = new SQL_MayoresA();
            users.Ingresar_MayoresA(tramite, cui, Txt_DPICopiaMayoresA.Text, Txt_BoletaMayoresA.Text);
            this.Hide();

            log.Ingresar_Bitacora(cui, "Documentos enviados del Meyor de Edad", fe.ToString());
        }

        private void Btn_EnviarMayores_Click(object sender, EventArgs e)
        {
            SQL_Mayores users = new SQL_Mayores();
            users.Ingresar_Mayores(tramite, cui, Txt_DPICopiaMayores.Text, Txt_BoletoOrnatoMayores.Text,
                Txt_BoletoOrnatoCopiaMayores.Text, Txt_BoletaMayores.Text);
            this.Hide();

            log.Ingresar_Bitacora(cui, "Documentos enviados del Meyor de 60 Años", fe.ToString());
        }

        private void HideAllTabsOnTabControl(TabControl theTabControl)
        {
            theTabControl.Appearance = TabAppearance.FlatButtons;
            theTabControl.ItemSize = new Size(0, 1);
            theTabControl.SizeMode = TabSizeMode.Fixed;
        }

    }
}
