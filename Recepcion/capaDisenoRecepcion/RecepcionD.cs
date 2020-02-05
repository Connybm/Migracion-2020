using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaDisenoRecepcion
{
    public partial class RecepcionD : UserControl
    {
        private void HideAllTabsOnTabControl(TabControl theTabControl)
        {
            theTabControl.Appearance = TabAppearance.FlatButtons;
            theTabControl.ItemSize = new Size(0, 1);
            theTabControl.SizeMode = TabSizeMode.Fixed;
        }

        public RecepcionD()
        {
            InitializeComponent();
        }

        private void Btn_DPIMayoresACopia_Click(object sender, EventArgs e)
        {
            Ofd_MayoresA.InitialDirectory = "C:\\";
            Ofd_MayoresA.Filter = "Archivo PDF (*.PDF)|*.PDF";

            if (Ofd_MayoresA.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string sRutaMayoresA = Ofd_MayoresA.FileName;
                    Txt_DPICopiaMayoresA.Text = sRutaMayoresA;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void Btn_DPIMayoresCopia_Click(object sender, EventArgs e)
        {
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
        }

        private void Btn_BoletoOrnatoCopiaMayores_Click(object sender, EventArgs e)
        {
            Ofd_Mayores.InitialDirectory = "C:\\";
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
        }

        private void Btn_DPICopiaPadre_Click(object sender, EventArgs e)
        {
            Ofd_Menores.InitialDirectory = "C:\\";
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
        }

        private void Btn_DPICopiaMadre_Click(object sender, EventArgs e)
        {
            Ofd_Menores.InitialDirectory = "C:\\";
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
        }

        private void Btn_CertiNaci_Click(object sender, EventArgs e)
        {
            Ofd_Menores.InitialDirectory = "C:\\";
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
        }

        private void Btn_CartaPoder_Click(object sender, EventArgs e)
        {
            Ofd_Menores.InitialDirectory = "C:\\";
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
        }

        private void Btn_BoletaMenor_Click(object sender, EventArgs e)
        {
            Ofd_Menores.InitialDirectory = "C:\\";
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
        }
    }
}
