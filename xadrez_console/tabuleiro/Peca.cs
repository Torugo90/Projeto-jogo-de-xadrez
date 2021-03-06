﻿using System;

namespace tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tab)
        {
            this.Posicao = posicao ?? throw new ArgumentNullException(nameof(posicao));
            this.Cor = cor;
            this.QtdMovimentos = 0;
            this.Tab = tab ?? throw new ArgumentNullException(nameof(tab));
        }
    }
}
