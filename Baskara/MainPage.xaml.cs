namespace Baskara
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(inputA.Text);
            double b = Convert.ToDouble(inputB.Text);
            double c = Convert.ToDouble(inputC.Text);

            double delta = (b * b) - (4 * a * c);

            if(delta < 0){
                ResultadoLabel.Text = "A equação não possui raízes reais.";
            }
            else if(delta == 0){

                double x = -b / (2 * a);

                ResultadoLabel.Text = $"Delta = 0\nX = {x:F2}";

            }
            else{

                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                ResultadoLabel.Text = $"Delta = {delta:F2}\nX₁ = {x1:F2}\nX₂ = {x2:F2}";

            }
            }
        }
    }
