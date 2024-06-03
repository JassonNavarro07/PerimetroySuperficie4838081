namespace PerimetroySuperficie4838081

{



    public partial class MainPage : ContentPage
    {

        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        #region evento button
        /// <summary>
        /// evento de button que acciona el calculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Clicked(object sender, EventArgs e)
        {
            //declaracion de variables
            double altura,basee,perimetro,superficie;
            altura = Convert.ToDouble(entryA.Text);
            basee = Convert.ToDouble(entryB.Text);
            perimetro = 2 * (basee + altura);
            superficie = basee * altura;
            //mostrando resultados
            entryP.Text = perimetro.ToString();
            entryS.Text = superficie.ToString();
        }
        #endregion
    }

}
