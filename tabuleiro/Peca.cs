using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Peca  //peça generica
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
    }
}
