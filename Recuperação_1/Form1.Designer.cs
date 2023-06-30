namespace Recuperação_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            mt_cpf = new MaskedTextBox();
            tb_nome = new TextBox();
            tb_data_inic = new TextBox();
            cb_profissao = new ComboBox();
            mt_data_nasc = new MaskedTextBox();
            cb_sexo = new ComboBox();
            bt_verificar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Pink;
            label1.Font = new Font("Book Antiqua", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(266, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 26);
            label1.TabIndex = 0;
            label1.Text = "Cadastrar Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Pink;
            label2.Font = new Font("Book Antiqua", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(77, 26);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Pink;
            label3.Font = new Font("Book Antiqua", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 107);
            label3.Name = "label3";
            label3.Size = new Size(57, 26);
            label3.TabIndex = 2;
            label3.Text = "CPF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Pink;
            label4.Font = new Font("Book Antiqua", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 143);
            label4.Name = "label4";
            label4.Size = new Size(209, 26);
            label4.TabIndex = 3;
            label4.Text = "Data de nascimento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Pink;
            label5.Font = new Font("Book Antiqua", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 185);
            label5.Name = "label5";
            label5.Size = new Size(59, 26);
            label5.TabIndex = 4;
            label5.Text = "Sexo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Pink;
            label6.Font = new Font("Book Antiqua", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 223);
            label6.Name = "label6";
            label6.Size = new Size(106, 26);
            label6.TabIndex = 5;
            label6.Text = "Profissão:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Pink;
            label7.Font = new Font("Book Antiqua", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 264);
            label7.Name = "label7";
            label7.Size = new Size(360, 26);
            label7.TabIndex = 6;
            label7.Text = "Data de incio do exercício profissão:";
            // 
            // mt_cpf
            // 
            mt_cpf.BackColor = Color.Pink;
            mt_cpf.Location = new Point(75, 110);
            mt_cpf.Mask = "000,000,000-00";
            mt_cpf.Name = "mt_cpf";
            mt_cpf.Size = new Size(100, 23);
            mt_cpf.TabIndex = 7;
            // 
            // tb_nome
            // 
            tb_nome.BackColor = Color.Pink;
            tb_nome.Location = new Point(98, 72);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(100, 23);
            tb_nome.TabIndex = 8;
            // 
            // tb_data_inic
            // 
            tb_data_inic.BackColor = Color.Pink;
            tb_data_inic.Location = new Point(383, 270);
            tb_data_inic.Name = "tb_data_inic";
            tb_data_inic.Size = new Size(173, 23);
            tb_data_inic.TabIndex = 11;
            // 
            // cb_profissao
            // 
            cb_profissao.BackColor = Color.Pink;
            cb_profissao.FormattingEnabled = true;
            cb_profissao.Items.AddRange(new object[] { "Professor", "Saúde", "Agentes de segurança ", "Demais serviços" });
            cb_profissao.Location = new Point(124, 226);
            cb_profissao.Name = "cb_profissao";
            cb_profissao.Size = new Size(121, 23);
            cb_profissao.TabIndex = 12;
            // 
            // mt_data_nasc
            // 
            mt_data_nasc.BackColor = Color.Pink;
            mt_data_nasc.Location = new Point(227, 146);
            mt_data_nasc.Mask = "00/00/0000";
            mt_data_nasc.Name = "mt_data_nasc";
            mt_data_nasc.Size = new Size(100, 23);
            mt_data_nasc.TabIndex = 13;
            // 
            // cb_sexo
            // 
            cb_sexo.BackColor = Color.Pink;
            cb_sexo.FormattingEnabled = true;
            cb_sexo.Items.AddRange(new object[] { "Feminino", "Masculino", "Outro" });
            cb_sexo.Location = new Point(77, 185);
            cb_sexo.Name = "cb_sexo";
            cb_sexo.Size = new Size(121, 23);
            cb_sexo.TabIndex = 14;
            // 
            // bt_verificar
            // 
            bt_verificar.BackColor = Color.LightPink;
            bt_verificar.Font = new Font("Book Antiqua", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            bt_verificar.Location = new Point(613, 329);
            bt_verificar.Name = "bt_verificar";
            bt_verificar.Size = new Size(137, 37);
            bt_verificar.TabIndex = 15;
            bt_verificar.Text = "Verificar";
            bt_verificar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(784, 378);
            Controls.Add(bt_verificar);
            Controls.Add(cb_sexo);
            Controls.Add(mt_data_nasc);
            Controls.Add(cb_profissao);
            Controls.Add(tb_data_inic);
            Controls.Add(tb_nome);
            Controls.Add(mt_cpf);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private MaskedTextBox mt_cpf;
        private TextBox tb_nome;
        private TextBox tb_data_inic;
        private ComboBox cb_profissao;
        private MaskedTextBox mt_data_nasc;
        private ComboBox cb_sexo;
        private Button bt_verificar;
    }
}