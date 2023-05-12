using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_pagamento
{
    public class Beep
    {
        public void PlayMarioMusic()
        {
            int[] frequencias = { 659, 659, 0, 659, 0, 523, 659, 0, 784 };
        int[] duracoes = { 500, 500, 500, 500, 500, 500, 1000, 500, 500 };

        // Toca cada nota musical uma após a outra
        for (int i = 0; i < frequencias.Length; i++)
        {
            if (frequencias[i] == 0)  // Nota pausa
            {
                Thread.Sleep(duracoes[i]);
            }
            else  // Nota musical
            {
                Console.Beep(frequencias[i], duracoes[i]);
            }
        }
        }
    }
}