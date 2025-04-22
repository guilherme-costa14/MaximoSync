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
            //Abrir o formulário em tamanho normal, quando clicado em definições.
            if(e.ClickedItem.Name.ToString() == "tsmiDefinicoes")
            {
                this.WindowState = FormWindowState.Normal;
                txtUrlLink.Focus();
            }
        }

        private void btnSincronizar_Click(object sender, EventArgs e)
        {
            //Verifica se o campo é nulo ou tem espaços em branco se, sim, exibe uma mensagem.
            if (string.IsNullOrWhiteSpace(txtUrlLink.Text))
            {
                MessageBox.Show("Preencher o campo URL", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUrlLink.Clear();
                txtUrlLink.Focus();
            }
            //Verifica se o campo está vazio se, sim, exibe uma mensagem.
            else if (txtTempo.Text == "")
            {
                MessageBox.Show("Preencher o campo Tempo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTempo.Focus();
            }
            else
            {
                //Inicializa os métodos dentro de uma variável local, e armazena as informações dos campos dentro dos objetos da classe Formulario();
                var formulario = new Formulario();
                formulario.UrlLink = txtUrlLink.Text.Trim();
                formulario.TempoMinutos = Convert.ToInt32(txtTempo.Text);

                try
                {
                    //Converte os dados para o formato .json e salva no caminho específicado.
                    using (StreamWriter sw = new StreamWriter(@"C:\Users\guilh\Documents\PROJETOS\MaximoSync\MaximoSync\REGISTROS\registro.json"))
                    {
                        sw.WriteLine(formulario.JsonSerializar(formulario));
                    }

                    MessageBox.Show("Registro salvo com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //Exibe uma mensagem de erro, caso de errado.
                catch (Exception ex)
                {
                    MessageBox.Show("Falha: " + ex.Message);
                }
                //MessageBox.Show(formulario.JsonSerializar(formulario)); - mostra como o arquivo vai ser salvo no formato json
            }
        }

        private void txtTempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Função para permitir apenas números no campo.
            Program.NumeroInteiro(e);
        }
    }
}
