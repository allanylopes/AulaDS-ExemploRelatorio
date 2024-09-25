using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploRelatorio
{
    public partial class Form1 : Form
    {
        //instaciando objeto
        Empregado emp = new Empregado();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            int codigo;
            string nome;
            double salario;
            //passar valores de texto para cada variável
            codigo = int.Parse(txt_codigo.Text);
            nome = txt_nome.Text;
            salario = double.Parse(msk_salario.Text);

            //passar valores das variáveis para a classe empregado
            emp.Codigo = codigo;
            emp.Nome = nome;
            emp.Salario = salario;

            MessageBox.Show("Dados Empregado Registrado com Sucesso!");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //aqui geramos o relatório
            string dados;
            dados = emp.registrarDados();

            Font fonte25 = new Font("Comic Sans" , 25, FontStyle.Bold);
            SolidBrush corfonteTitulo = new SolidBrush(Color.Red);

            Font fonte16 = new Font("Tahoma", 16, FontStyle.Bold);
            SolidBrush corfontetexto = new SolidBrush(Color.Purple);

            e.Graphics.DrawString("FOLHA EMPREGADO ", fonte25, corfonteTitulo, new Point(100, 170));
            e.Graphics.DrawString(dados, fonte16, corfontetexto, new Point(60,450));
        }

        private void btn_relatorio_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
