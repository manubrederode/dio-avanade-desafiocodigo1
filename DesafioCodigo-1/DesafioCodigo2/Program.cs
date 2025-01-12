﻿//Desafio 2: Lista de itens

/*
Desafio
Em um jogo de RPG, os personagens geralmente possuem uma lista de itens que podem ser utilizados durante o jogo. Esses itens podem ser armas, armaduras, poções de cura, entre outros. É importante que o jogador tenha um controle desses itens para poder utilizá-los no momento adequado.

Crie um programa que permita cadastrar uma lista de itens que o personagem possui. A lista deve conter o valor fixo de 3 itens e deve ser exibida na tela.

Entrada
O programa deve solicitar ao usuário o nome dos 3 itens que o personagem possui. Cada item deve ser cadastrado separadamente.

Saída
Após receber os itens cadastrados pelo usuário, o programa deve exibir na tela a lista de itens que o personagem possui. A saída deve ter o seguinte formato:

Lista de itens:
- [item1]
- [item2]
- [item3]
*/

//Solução

using System;
using System.Collections.Generic;

namespace DesafioCodigo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista para armazenar os itens
            List<string> itens = new List<string>();

            //Solicitação dos itens ao usuário
            Console.WriteLine("Digite 3 itens: ");
            for (int i = 1; i <= 3; i++)
            {
                string item = Console.ReadLine();
                itens.Add(item);
            }

            //Exibe a lista de itens
            Console.WriteLine("Lista de itens:");
            foreach (string item in itens)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}

