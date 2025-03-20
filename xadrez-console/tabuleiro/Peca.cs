

namespace tabuleiro
{
     class Peca
    {
        public Posicao Posicao {  get; set; } 
        public Cor Cor {  get; protected set; }
        public int QteMovimentos {get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tabuleiro, Cor cor)
        {
            Posicao = posicao;
            Cor = cor;
            Tab = tabuleiro;
            QteMovimentos = 0;
        }
    }
}
