using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula63_wf.Telas
{
    public partial class Carros : Form
    {
        public Carros()
        {
            InitializeComponent();
        }
        //List<Classes.Carro> itens;
        List<Classes.Carro> itens1 = Classes.Carro.InitializeCarros();
        double valor;
        double valorFinal;
        
        
        private void Carros_Load(object sender, EventArgs e)
        {     
            comboBox1.Items.AddRange(Classes.Carro.InitializeCarros().ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int itemSelecionado = comboBox1.SelectedIndex;
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {    
                if (itemSelecionado == i)
                {   
                   
                    if (itens1[i].Status == true)
                    {
                        valor = itens1[i].ValorDiario;
                        groupBox2.Visible = true;
                        itens1[i].Status = false;
                        comboBox1.Items.Clear();
                        comboBox1.Items.AddRange(itens1.ToArray());
                    }
                    else if(itens1[i].Status == false)
                    {
                        MessageBox.Show("Carro indisponível");
                    }
                    
                }
            }
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int dtInicial = DateTime.Parse(txtDtInicio.Text).Day;
            int dtFinal = DateTime.Parse(txtDtFinal.Text).Day;
            if(txtDtInicio.Text != null && txtDtFinal.Text != null)
            {
                valorFinal = Classes.Locacao.CalcularValor(dtInicial, dtFinal, valor);
            }
            groupBox3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Classes.Cliente> cliente = Classes.Cliente.AdicionarCliente(txtNome.Text, txtCPF.Text, txtEmail.Text, uint.Parse(txtCEP.Text), long.Parse(txtTelefone.Text));
            MessageBox.Show($"{cliente[0].ToString()} \nValor: {valorFinal}");
        }

        
    }
}
