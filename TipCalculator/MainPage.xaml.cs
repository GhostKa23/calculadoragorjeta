namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void ArredondarParaCimaButton_Clicked(object sender, EventArgs e)
        {
            double ValorGorjeta = Convert.ToDouble(GorjetaLabel.Text);
            GorjetaLabel.Text = Math.Ceiling(ValorGorjeta).ToString();
        }

        private void ArredondarParaBaixoButton_Clicked(object sender, EventArgs e)
        {
            double ValorGorjeta = Convert.ToDouble(GorjetaLabel.Text);
            GorjetaLabel.Text = Math.Floor(ValorGorjeta).ToString();

        }

        private void PorcentagemSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            PorcentagemGorjetaLabel.Text = PorcentagemSlider.Value.ToString() + "%";
            double porcentagemDaGorjeta = PorcentagemSlider.Value / 100;
            double valorDaConta = Convert.ToDouble(ContaEntry.Text);
            double valorDaGorjeta = valorDaConta * porcentagemDaGorjeta;
            GorjetaLabel.Text = valorDaGorjeta.ToString();
            ValorTotalLabel.Text = Convert.ToString(valorDaConta + valorDaGorjeta);

        }


        private void Gorjeta15PorcentoButton_Clicked(object sender, EventArgs e)
        {

        }

        private void Gorjeta20PorcentoButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}


//.toString converte o que recebe para texto
//quando queremos algo de uma classe colocamos o ."o nome da classe que que quer", nesse caso queremos o value do slider
//para converter de string para double precisa da classe Convert com o metodo .toDouble(o nome do que sera convertido.text)