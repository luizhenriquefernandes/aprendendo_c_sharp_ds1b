namespace Calc
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }        

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            int.TryParse(txtNum1.Text, out int num1);
            int.TryParse(txtNum2.Text, out int num2);
            Soma soma = new Soma(num1, num2);
            int resultado = soma.Somar(soma.Num1, soma.Num2);

            MessageBox.Show($"O resultado da soma é: {resultado.ToString()}");

        }
    }
}
