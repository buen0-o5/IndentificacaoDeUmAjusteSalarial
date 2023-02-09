
namespace IndentificacaoDeUmAjusteSalarial
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbxCategoria = new System.Windows.Forms.GroupBox();
            this.gbxTurno = new System.Windows.Forms.GroupBox();
            this.Calouro = new System.Windows.Forms.RadioButton();
            this.Veterano = new System.Windows.Forms.RadioButton();
            this.Matutino = new System.Windows.Forms.RadioButton();
            this.Vespertino = new System.Windows.Forms.RadioButton();
            this.Noturno = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxSalarioMinimo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.lbxResultado = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtSituacaoEstagiario = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gbxCategoria.SuspendLayout();
            this.gbxTurno.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCategoria
            // 
            this.gbxCategoria.Controls.Add(this.Veterano);
            this.gbxCategoria.Controls.Add(this.Calouro);
            this.gbxCategoria.Location = new System.Drawing.Point(15, 88);
            this.gbxCategoria.Name = "gbxCategoria";
            this.gbxCategoria.Size = new System.Drawing.Size(187, 55);
            this.gbxCategoria.TabIndex = 1;
            this.gbxCategoria.TabStop = false;
            this.gbxCategoria.Text = "Categoria";
            // 
            // gbxTurno
            // 
            this.gbxTurno.Controls.Add(this.Matutino);
            this.gbxTurno.Controls.Add(this.Vespertino);
            this.gbxTurno.Controls.Add(this.Noturno);
            this.gbxTurno.Location = new System.Drawing.Point(244, 22);
            this.gbxTurno.Name = "gbxTurno";
            this.gbxTurno.Size = new System.Drawing.Size(95, 121);
            this.gbxTurno.TabIndex = 2;
            this.gbxTurno.TabStop = false;
            this.gbxTurno.Text = "Turno";
            // 
            // Calouro
            // 
            this.Calouro.AutoSize = true;
            this.Calouro.Location = new System.Drawing.Point(6, 28);
            this.Calouro.Name = "Calouro";
            this.Calouro.Size = new System.Drawing.Size(61, 17);
            this.Calouro.TabIndex = 3;
            this.Calouro.TabStop = true;
            this.Calouro.Text = "Calouro";
            this.Calouro.UseVisualStyleBackColor = true;
            // 
            // Veterano
            // 
            this.Veterano.AutoSize = true;
            this.Veterano.Location = new System.Drawing.Point(112, 28);
            this.Veterano.Name = "Veterano";
            this.Veterano.Size = new System.Drawing.Size(68, 17);
            this.Veterano.TabIndex = 4;
            this.Veterano.TabStop = true;
            this.Veterano.Text = "Veterano";
            this.Veterano.UseVisualStyleBackColor = true;
            // 
            // Matutino
            // 
            this.Matutino.AutoSize = true;
            this.Matutino.Location = new System.Drawing.Point(0, 19);
            this.Matutino.Name = "Matutino";
            this.Matutino.Size = new System.Drawing.Size(66, 17);
            this.Matutino.TabIndex = 4;
            this.Matutino.TabStop = true;
            this.Matutino.Text = "Matutino";
            this.Matutino.UseVisualStyleBackColor = true;
            // 
            // Vespertino
            // 
            this.Vespertino.AutoSize = true;
            this.Vespertino.Location = new System.Drawing.Point(0, 57);
            this.Vespertino.Name = "Vespertino";
            this.Vespertino.Size = new System.Drawing.Size(75, 17);
            this.Vespertino.TabIndex = 5;
            this.Vespertino.TabStop = true;
            this.Vespertino.Text = "Vespertino";
            this.Vespertino.UseVisualStyleBackColor = true;
            // 
            // Noturno
            // 
            this.Noturno.AutoSize = true;
            this.Noturno.Location = new System.Drawing.Point(0, 94);
            this.Noturno.Name = "Noturno";
            this.Noturno.Size = new System.Drawing.Size(63, 17);
            this.Noturno.TabIndex = 6;
            this.Noturno.TabStop = true;
            this.Noturno.Text = "Noturno";
            this.Noturno.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Salário Mínimo:";
            // 
            // txtBoxSalarioMinimo
            // 
            this.txtBoxSalarioMinimo.Location = new System.Drawing.Point(124, 22);
            this.txtBoxSalarioMinimo.Name = "txtBoxSalarioMinimo";
            this.txtBoxSalarioMinimo.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSalarioMinimo.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtBoxSalarioMinimo, "Informe o valor atual para o salário minímo");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Horas trabalhadas:";
            // 
            // txtBoxHorasTrabalhadas
            // 
            this.txtBoxHorasTrabalhadas.Location = new System.Drawing.Point(124, 53);
            this.txtBoxHorasTrabalhadas.Name = "txtBoxHorasTrabalhadas";
            this.txtBoxHorasTrabalhadas.Size = new System.Drawing.Size(100, 20);
            this.txtBoxHorasTrabalhadas.TabIndex = 7;
            // 
            // lbxResultado
            // 
            this.lbxResultado.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxResultado.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbxResultado.FormattingEnabled = true;
            this.lbxResultado.ItemHeight = 14;
            this.lbxResultado.Location = new System.Drawing.Point(15, 159);
            this.lbxResultado.MultiColumn = true;
            this.lbxResultado.Name = "lbxResultado";
            this.lbxResultado.Size = new System.Drawing.Size(324, 116);
            this.lbxResultado.TabIndex = 8;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Ajuda";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(264, 281);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtSituacaoEstagiario
            // 
            this.txtSituacaoEstagiario.BackColor = System.Drawing.Color.Yellow;
            this.txtSituacaoEstagiario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSituacaoEstagiario.Enabled = false;
            this.txtSituacaoEstagiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSituacaoEstagiario.ForeColor = System.Drawing.Color.Blue;
            this.txtSituacaoEstagiario.Location = new System.Drawing.Point(15, 299);
            this.txtSituacaoEstagiario.Name = "txtSituacaoEstagiario";
            this.txtSituacaoEstagiario.Size = new System.Drawing.Size(233, 22);
            this.txtSituacaoEstagiario.TabIndex = 10;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(264, 310);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 334);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtSituacaoEstagiario);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lbxResultado);
            this.Controls.Add(this.txtBoxHorasTrabalhadas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxSalarioMinimo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxTurno);
            this.Controls.Add(this.gbxCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxCategoria.ResumeLayout(false);
            this.gbxCategoria.PerformLayout();
            this.gbxTurno.ResumeLayout(false);
            this.gbxTurno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxCategoria;
        private System.Windows.Forms.RadioButton Veterano;
        private System.Windows.Forms.RadioButton Calouro;
        private System.Windows.Forms.GroupBox gbxTurno;
        private System.Windows.Forms.RadioButton Matutino;
        private System.Windows.Forms.RadioButton Vespertino;
        private System.Windows.Forms.RadioButton Noturno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxSalarioMinimo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxHorasTrabalhadas;
        private System.Windows.Forms.ListBox lbxResultado;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtSituacaoEstagiario;
        private System.Windows.Forms.Button btnLimpar;
    }
}

