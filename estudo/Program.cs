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


            WriteLine("==========================");
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

            WriteLine("Split - recebe um arra, e partir de uma 'chave' este array é dividido em vario outros");

            WriteLine("==========================");
            string blocos = "este é um livro de c# para iniciantes";
            string[] livros = blocos.Split(" ");
            var contador = 0;

            foreach(var exp in livros)
            {
                WriteLine($"Textos: {contador++}: {exp}");
            }

            WriteLine($"número de palavras: {blocos.Count()}");


            WriteLine("==========================");
            WriteLine("O Método é substring é usado para extrair partes de um texto a partir de uma posição inicial");
            string nivel_livro = "livro inicial para estudantes";
            WriteLine($"{nivel_livro.Substring(0,5)}");

            string[] frutas = { "5 Laranjas", "10 Goiabas vermelhas", "5 Pêssegos doces", "5 Bananas"};

            foreach (var item in frutas)
            {
                WriteLine($"{item.Substring(item.IndexOf("") + 1)}");
            }

            WriteLine("==========================");
            WriteLine("O Método ISNULLOREMPTY verifica se uma String está nula ou vazia");

            string nome = "Renato";
            string sobrenome = null;

            if(!String.IsNullOrEmpty(nome) && !String.IsNullOrEmpty(sobrenome))
            {
                WriteLine($"NOME: {nome}");
                WriteLine($"SOBRENOME: {sobrenome}");
            }
            else
            {
                WriteLine($"NOME: {nome}");
            }

            WriteLine("==========================");
            WriteLine("FORMAS DE DECLARAR UM ARRAY");

            /*Declarando uma array com
            cinco elementos do tipo inteiro*/
            int[] primeiraArray = new int[100];

            /*Declarando uma array e já atribuindo valores*/
            int[] segundaArray = new int[] { 1, 3, 5, 7, 9 };

            //Forma alternativa de criar array
            int[] terceiraArray = { 1, 2, 3, 4, 5, 6 };

            // Declarando uma array multi-demensional
            int[,] arrayMultiDimensional = new int[2, 3];

            /*[,] arrayMultiDimensional2 = { { 1, 2, 3 }, { 4, 5, 6 } };*/

            WriteLine("ACESSANDO UM ARRAY: ");
            string[] fruitas = { "maça", "pera", "abacate" };

            WriteLine($"fruta na posição 2: {fruitas[3 - 1]}");

            WriteLine("==========================");
            WriteLine("LIST: têm a finalidade de armazenar um tipo de dados no sistema" +
                "Esses tipos de dados comumente são denominados\r\ncomo listas tipadas" +
                "Ao se referir a “tipadas”, estamos meramente informando ou entendendo que ao criar uma lista com um tipo de dados");

            List<string>  nomes_funcionarios =  new List<string>();

            nomes_funcionarios.Add("Caio Martins");
            nomes_funcionarios.Add("Rafael");

            foreach(string funcionarios in nomes_funcionarios)
            {
               
                /*WriteLine(funcionarios);*/
            }
            nomes_funcionarios.RemoveAt(0);
            WriteLine(nomes_funcionarios[0]);


            WriteLine("==========================");
            WriteLine("Orientação a objetos:");
        }


    }

    // Declarando uma classe genérica
    public class ListaGenerica<T>
    {
        public void Adicionar(T input) { }
    }
    class TestListaGenerica
    {
        private class ExampleClass { }
        static void Testa()
        {
            // Declarando uma lista do tipo inteiro
            ListaGenerica<int> lista1 = new ListaGenerica<int>();
           

            lista1.Adicionar(1);
            // Declarando uma lista do tipo string
            ListaGenerica<string> lista2 = new ListaGenerica<string>();
            lista2.Adicionar("");
            /// Declarando uma lista do tipo de uma classe
             ListaGenerica<ExampleClass> lista3 = new ListaGenerica<ExampleClass>();
            lista3.Adicionar(new ExampleClass());
        }
    }

   
}









