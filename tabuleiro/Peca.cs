using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    abstract class Peca  //peça generica
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; } //pode ser acessada por outras classes mas só pode ser alterada ela mesmo sub classes
        public int qteMovimentos { get; protected set; } //pode ser acessada por outras classes mas só pode ser alterada ela mesmo sub classes
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
        }

        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }

        public bool existeMovimentosPossiveis()
        {
            // se a peça pode executar pelo menos um movimento possível, o metoro retorna true
            bool[,] mat = movimentosPossiveis();
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (mat[i,j] == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool podeMoverPara(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }


        public abstract bool[,] movimentosPossiveis();  //metodo abstrato, será usado nas peças especificas
    }
}
