﻿using tabuleiro;

namespace xadrez_console
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.peca(i,j) == null)
                    {
                        System.Console.Write("- ");
                    }
                    System.Console.Write(tab.peca(i,j)  );
                }
                System.Console.WriteLine();
            }
        }
    }
}
