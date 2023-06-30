namespace DosNumeros_20367758;

/// <summary>
/// <Createddate>28/06/2023</Createddate>
/// <Company>INDEL</Company>
/// <lastmodificationdate>28/06/2023</lastmodificationdate>
/// <lastmodificationdescription>
/// uando la sentencia if evalua los valores introducidos y manda 
/// un mensaje de error si se introducen valores nulos.
/// </lastmodificationdescription>
/// <lastmodifierautor>Erika Chavez</lastmodifierautor>
/// </summary>
public partial class MainPage : ContentPage
{
	/// <summary>
	/// Constructor
	/// </summary>

	public MainPage()
	{
		InitializeComponent();
	}

	/// <summary>
	/// evento que se ejecuta al presioanr el boton calcular 
	/// declaramos variables para asignarles un valor que el usuario 
	/// va a digitar por medio de los entry.
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>

    private void Button_Clicked(object sender, EventArgs e)
    {
		if(!string.IsNullOrEmpty(datoA.Text) && !string.IsNullOrEmpty(datoB.Text))
		{
			int n1, n2,result;
			n1 = Convert.ToInt32(datoA.Text);
			n2 = Convert.ToInt32(datoB.Text);

			result = (int)(Math.Pow(n1 + n1, 2) / 2);

			resultado.Text = result.ToString("n2");
		}
		else
		{
			DisplayAlert("error", "Introduce datos numericos", "ok");
		}
    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {

    }
}

