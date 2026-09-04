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

        }

        private void ArredondarParaBaixoButton_Clicked(object sender, EventArgs e)
        {

        }

        private void PorcentagemSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            PorcentagemGorjetaLabel.Text = PorcentagemSlider.Value.ToString() + "%"; //.toString converte o que recebe para texto
            double porcentagemDaGorjeta = PorcentagemSlider.Value/100; //quando queremos algo de uma classe colocamos o ."o nome da classe que que quer", nesse caso queremos o value do slider
            double valorDaConta = Convert.ToDouble(ContaEntry.Text); //para converter de string para double precisa da classe Convert com o metodo .toDouble(o nome do que sera convertido.text)
            double valorDaGorjeta = valorDaConta * porcentagemDaGorjeta;
            GorjetaLabel.Text = valorDaGorjeta.ToString();
            ValorTotalLabel.Text = Convert.ToString(valorDaConta + valorDaGorjeta);
             
        }
    }
}
