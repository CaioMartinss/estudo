// See https://aka.ms/new-console-template for more information
using static System.Console;

using System;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Threading.Tasks.Dataflow;
using System.Net;

namespace livrocsharp
{
    class funcoesTexto
    {
        static void Main(string[] args)
        {
            WriteLine("------Funções de Textos------ -");
            string empresa = " Microsoft Corporation ";

            WriteLine("TRIM - retira os espaços em branco antes e após a expressão");
            WriteLine($"Nome sem espaços: {empresa.Trim()}");
            WriteLine($"Tamanho do texto: {empresa.Length}");
            empresa = empresa.Trim();
            WriteLine($"Tamanho do texto após o TRIM(): {empresa.Length}");

            WriteLine("toUpper - Converte os caracteres em maisculos");
            WriteLine($"Converte para maísculo: {empresa.ToUpper()}");

            WriteLine("A propredade toLowecase converte uma string em minisculo, por exemplo: ");
            WriteLine($"Converet para minisculo: {empresa.ToLower()}");


            string nomeUpper = "AIRTON SENNA";
            string nomeLower = "airton senna";
            // comparação 1
            if (nomeUpper == nomeLower)
                WriteLine("1 - nomes iguais");
            else
                WriteLine("1 - nomes diferentes");
            // comparação 2
            if (nomeUpper.ToLower() == nomeLower)
                WriteLine("2 - nomes iguais");
            else
                WriteLine("2 - nomes diferentes");
            // comparação 3
            if (nomeUpper.Equals(nomeLower, StringComparison.OrdinalIgnoreCase))
                WriteLine("3 - nomes iguais");
            else
                WriteLine("3 - nomes diferentes");


            WriteLine("Remove - extrai x caracteres a partir da esquerda da expressão");
            WriteLine($"Texto esquerdo: {empresa.Remove(9)}");



            WriteLine("==========================");
            string[] nomes = { "Fabricio dos Santos", "José da", "Roberta Brasil" };

            foreach (var n in nomes)
            {
                int indexOfSpace = n.IndexOf(' '); // Encontra o índice do primeiro espaço em branco
                if (indexOfSpace >= 0)
                {
                    string primeiroNome = n.Substring(0, indexOfSpace); // Pega o primeiro nome
                    WriteLine(primeiroNome);
                }
                else
                {
                    WriteLine(n); // Se não houver espaço em branco, imprime o nome completo
                }
            }

            WriteLine("==========================");
            WriteLine("Replace - troca o conteúdo da expressão");
            WriteLine("Nome da empresa atual: " + empresa);
            string nova_empresa = empresa.Replace("Microsoft", "Google");
            WriteLine($"nome da nova empresa: {nova_empresa}");
           

        }


    }

    }


