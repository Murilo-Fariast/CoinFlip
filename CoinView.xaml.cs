using CoinFlip.ViewModels;

namespace CoinFlip.Views;

public partial class CoinView : ContentPage
{
	public CoinView()
	{
		InitializeComponent();

		this.BindingContext = new CoinViewModel();
	}
		public String Lado { get; set; }
		public String Jogar()
	{ 
		int ladoSorteado = new Random().Next(2);
		Lado = ladoSorteado == 0 ? "cara" : "coroa";
		return (Lado);
	}
	public String Jogar(String ladoEscolhido)
	{
		int ladoSorteado = new Random().Next(2);
		Lado = ladoSorteado == 0 ? "cara" : "coroa";
		string resultado = Lado == ladoEscolhido ?
			$"Parabens, voce pediu {ladoEscolhido} e deu {Lado}" :
			$"Que pena, voce pediu {ladoEscolhido} e deu {Lado}";
		return (resultado);
	}


	
}