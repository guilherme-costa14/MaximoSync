using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaximoSync
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmsOpcoes_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem.Name.ToString() == "tsmiDefinicoes")
            {
                this.WindowState = FormWindowState.Normal;
                txtUrlLink.Focus();
            }
        }

        private void btnSincronizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrlLink.Text))
            {
                MessageBox.Show("Preencher o campo URL", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUrlLink.Clear();
                txtUrlLink.Focus();
            }
            else if (txtTempo.Text == "")
            {
                MessageBox.Show("Preencher o campo Tempo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTempo.Focus();
            }
            else
            {
                var formulario = new Formulario();
                formulario.UrlLink = txtUrlLink.Text.Trim();
                formulario.TempoMinutos = Convert.ToInt32(txtTempo.Text);

                try
                {
                    using (StreamWriter sw = new StreamWriter(@"C:\Users\guilh\Documents\PROJETOS\MaximoSync\MaximoSync\REGISTROS\registro.json"))
                    {
                        sw.WriteLine(formulario.JsonSerializar(formulario));
                    }

                    MessageBox.Show("Registro salvo com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha: " + ex.Message);
                }
                //MessageBox.Show(formulario.JsonSerializar(formulario)); - mostra como o arquivo vai ser salvo no formato json
            }
        }

        private void txtTempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.NumeroInteiro(e);
        }
    }
}
