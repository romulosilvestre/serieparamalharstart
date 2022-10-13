namespace SerieParaMalharStart.VoeAirlinesEstudo.WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidarCodigo_Click(object sender, EventArgs e)
        {
            Aeronave aeronave = new Aeronave();
            var codigo = txtCodigo.Text;
            bool reposta = aeronave.ValidarCodigo(codigo);
            MessageBox.Show(reposta.ToString());
            
        }
    }
}