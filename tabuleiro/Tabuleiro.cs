using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        //metodo para dar acesso para uma peça individial
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        //sobrecarga do metodo peca
        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }

        //verificar se tem peça em uma dada posição
        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }



        //colocar uma peça no tabuleiro
        public void colocarPeca(Peca p, Posicao pos)
        {

            // validar se já nem uma peça na mesma posição
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            //matriz de peças
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        public bool posicaoValida(Posicao pos)
        {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }
            return true;
        }

        //lançar exception personalizada
        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida!");
            }
        }
    }
}
