namespace Recuperação_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_verificar_Click(object sender, EventArgs e)
        {
            string nome = tb_nome.Text;
            string cpf = mt_cpf.Text;
            double nasciment = Convert.ToDouble(mt_nasciment.Text);
            string sexo = cb_sexo.Text;
            string profissao = cb_profissao.Text;
            double datainicio = Convert.ToDouble(tb_data_inicio.Text);
            double pontosfin = 0;


            Verificar verificando = new Verificar();

        }





    }
}