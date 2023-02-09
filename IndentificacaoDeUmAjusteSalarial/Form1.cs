using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndentificacaoDeUmAjusteSalarial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtBoxSalarioMinimo.Text == String.Empty || txtBoxHorasTrabalhadas.Text == String.Empty)
            {

                MessageBox.Show("Preencha todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {


                RadioButton rbnTurno = gbxTurno.Controls.OfType<RadioButton>()
                .SingleOrDefault(r => r.Checked);

                RadioButton rbnCategoria = gbxCategoria.Controls.OfType<RadioButton>()
                .SingleOrDefault(r => r.Checked); //Verificãção para ver se o RadioButton está selecionado

                RealizarProcessamento(rbnTurno, rbnCategoria, Convert.ToDouble
                (txtBoxHorasTrabalhadas.Text), Convert.ToDouble(txtBoxSalarioMinimo.Text));
                //Método que recebe os valor das horas trabalhas e salario minimo
            }

        }
        
        private void RealizarProcessamento(RadioButton rbnTurno, RadioButton rbnCategoria,
        double horasTrabalhadas, double valorSalarioMinimo)
        {
            double valorCoeficiente = GetCoeficiente(rbnTurno);

            double valorGratificacao = GetGratificacao(rbnTurno, horasTrabalhadas);

            double valorSalarioBruto = horasTrabalhadas * valorCoeficiente;

            double valorImposto = GetValorImposto(rbnCategoria, valorSalarioBruto);

            double valorAuxilioAlimentacao = GetValorAuxilioAlimentacao(rbnCategoria,
            valorSalarioBruto, valorSalarioMinimo);

            double valorSalarioLiquido = (valorSalarioBruto + 
            (valorGratificacao + valorAuxilioAlimentacao) - valorImposto);

            ApresentarResultados(valorCoeficiente, valorSalarioBruto, valorImposto,
            valorGratificacao,valorAuxilioAlimentacao, valorSalarioLiquido);
        }

        #region Metodos especifico

        private double GetCoeficiente (RadioButton rbnTurno) // Calculando o coeficiente de acordo com o horario de tratablho
        {
            double valorCoeficiente = 0;
            switch (rbnTurno.Text)
            {
                case "Matutino":
                    valorCoeficiente = Convert.ToDouble(txtBoxSalarioMinimo.Text) * 0.01;
                    break;
                case "Vespertino":
                    valorCoeficiente = Convert.ToDouble(txtBoxSalarioMinimo.Text) * 0.02;
                    break;
                case "Noturno":
                    valorCoeficiente = Convert.ToDouble(txtBoxSalarioMinimo.Text) * 0.03;
                   break;
            }
            return valorCoeficiente;
        }

        private double GetGratificacao (RadioButton rbnTurno, double horasTrabalhadas) //gratificaçao de 50 reais caso preencha os requesitos 
        {
            double valorGratificacao = 30;
            if (rbnTurno.Text.Equals
                ("Noturno") && horasTrabalhadas > 80)
            valorGratificacao = 50;
            return valorGratificacao;

        }

        private static double GetValorImposto(RadioButton rbnCategoria, double valorSalarioBruto) // com o valor do salario bruto calculado é possivel fazer o calculo do imposto 
        {
            double valorImposto = 0;
            switch (rbnCategoria.Text) { 
            case "Calouro":
                if (valorSalarioBruto < 300)
                valorImposto = valorSalarioBruto * 0.01;
            else
                valorImposto = valorSalarioBruto * 0.02;
                    break;

                case "Veterano":
                    if (valorSalarioBruto < 400)
                        valorImposto = valorSalarioBruto * 0.03;
                    else
                        valorImposto = valorSalarioBruto * 0.04;
                    break;
            }
            return valorImposto;
        }

        private double GetValorAuxilioAlimentacao(RadioButton rbnCategoria, //calculando o valor do auxilio alimentação
        double valorSalarioBruto, double valorSalarioMinimo)
        {
            double valorAuxilioAlimentacao = (valorSalarioBruto / 3) / 2;
            
            if(rbnCategoria.Text.Equals("Calouro") && (valorSalarioBruto < valorSalarioMinimo /2))
                valorAuxilioAlimentacao = (valorSalarioBruto/3);
            return valorAuxilioAlimentacao;
        }

        private void ApresentarResultados(double valorCoeficiente, double valorSalarioBruto, double valorImposto,
        double valorGratificacao, double valorAuxilioAlimentacao, double valorSalarioLiquido)
        {
            txtSituacaoEstagiario.Text = GetSituacaoEstagiario(valorSalarioLiquido);

            lbxResultado.Items.Add(String.Format("{0,-29 }{1,12:C}", "Valor do coeficiente:", valorCoeficiente));

            lbxResultado.Items.Add(String.Format("{0,-29}{1,12:C}", "Salario Bruto:", valorSalarioBruto));

            lbxResultado.Items.Add(String.Format("{0,-29}{1,12:C}", "Valor do imposto:", valorImposto));

            lbxResultado.Items.Add(String.Format("{0,-29}{1,12:C}", "Valor da gratificação:", valorGratificacao));

            lbxResultado.Items.Add(String.Format("{0,-29}{1,12:C}", "Valor auxilio Alimentação:", valorAuxilioAlimentacao));

            lbxResultado.Items.Add(String.Format("{0,-29}{1,12:C}", "Valor Salario Liquido:", valorSalarioLiquido));
       
        
        }
        private string GetSituacaoEstagiario(double valorSalarioLiquido) 
        {
            if (valorSalarioLiquido < 350)
                return "Mal remunerado";
            else if (valorSalarioLiquido < 600)
                return "Nomal";
            else
                return "Bem remunerado";
        }

        #endregion

        //private void limparListBox()
        //{
        //    lbxResultado.Items.Clear();
        //}

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lbxResultado.Items.Clear();
        }
    }
}
