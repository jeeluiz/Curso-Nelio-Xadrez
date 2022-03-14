using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    internal abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimento { get;protected set; }
        public Tabuleiro tab { get; protected set; }

       

        public Peca(Tabuleiro tab, Cor cor, Posicao posicao)
        {
            this.tab = tab;
            this.cor = cor;
            this.posicao = posicao;
        }

        public abstract bool[,] movimentosPossiveis();
      
        

    }
}
