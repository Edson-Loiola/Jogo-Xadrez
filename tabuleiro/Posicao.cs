namespace tabuleiro
{
    class Posicao
    {
        public int linha { get; set; }  //get set (incapsulamento) podem ser alterados por outras classes
        public int coluna { get; set; }

        //construtor 
        public Posicao(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        //override para imprimir o objeto inteiro
        public override string ToString()
        {
            return linha
                + ", "
                + coluna;
        }

    }
}
