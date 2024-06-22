using CoinFlip.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CoinFlip.ViewModels
{
    public partial class CoinViewModel : ObservableObject
    {
        [ObservableProperty]
        public String _ladoEscolhido;

        [ObservableProperty]
        public String _imagem;

        [ObservableProperty]
        public String _resultado;

        public ICommand FlipCommand {  get; set; }

        public CoinViewModel()
        {
            FlipCommand = new Command(Flip);
        }
        public void Flip()
        {
            Coin coin = new Coin();
            Resultado = coin.Jogar(LadoEscolhido);
            Imagem = $"{coin.Lado}";
        }


    }
}
