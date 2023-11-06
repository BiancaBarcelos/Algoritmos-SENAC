﻿using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
namespace Algoritmos_SENAC;
class Program
{
    GerenciadorEstoque gerenciadorEstoque = new GerenciadorEstoque();
    static void Main(string[] args)
    {       
        Mensagem("---- Estoque Loja Miniatura - Dorama ----");
        
       //Enquanto for verdadeiro mantém o programa ativo 
        bool executando = true;
        Program program = new Program();

        //Produto Padrão Cadastrado
        Produto DoramaPadrao = new Produto {
            Nome = "Kit Noite Feliz",
            Modelo = "Miniatura",
            DAltura = 21,
            DLargura = 13,
            DProfundidade = 15,
            Escala = "1:24",
            Led = "Sim",
            Valor = 379.97,
            Estoque = 8
        };
        program.gerenciadorEstoque.cadastrarProduto(DoramaPadrao);


        while (executando == true){
            int opcaoMenu = Menu.MostrarMenu();

            //Se for 0 fecha o programa
            if (opcaoMenu == 0) 
            {
                executando = false;
                Mensagem("Fechando Controle de Estoque!");
            }
            //Caso contrario executa uma das opções
            else {
                //Se for 1 abre o cadastro de produto
                if (opcaoMenu == 1){

                    Produto novoDorama = new Produto {

                        Nome = PedirTexto("Nome:"),
                        Modelo = PedirTexto("Modelo:"),
                        DAltura = PedirNumeroInteiro("Dimensões (altura):"),
                        DLargura = PedirNumeroInteiro("Dimensões (largura):"),
                        DProfundidade = PedirNumeroInteiro("Dimensões (profundidade):"),
                        Escala = PedirTexto("Escala:"),
                        Led = PedirTexto("Contém Luz:"),
                        Valor = PedirNumeroDouble("Valor:"),
                        Estoque = 0
                    }; 
                    Program.Mensagem("Cadastrando Dorama!");
                    program.gerenciadorEstoque.cadastrarProduto(novoDorama);
                    Program.Mensagem("Produto cadastrado!!");
                    Program.Mensagem("____________________");
                }

                if (opcaoMenu == 2) {
                    program.gerenciadorEstoque.listarProdutos();
                }
                if (opcaoMenu == 3){
                    //listar arrays: lista dos produtos pelo identificador, selecionar e excluir
                    //Identificador
                    //PedirNumeroInteiro("Qual produto deseja excluir?"); //selecionar
                    //excluir

                }
                if (opcaoMenu == 4){
                    //listar arrays: lista dos produtos pelo identificador, selecionar a quantidade e atribui valor
                    //Identificador
                    //PedirNumeroInteiro("Qual produto deseja dar entrada no estoque?"); //selecionar
                    //estoque = valor atual + n2(incremento);

                }
                if (opcaoMenu == 5){
                    //listar arrays: lista dos produtos pelo identificador, selecionar a quantidade e atribui valor
                    //Identificador
                    //PedirNumeroInteiro("Qual produto deseja dar saída no estoque?"); //selecionar
                    //estoque = valor atual + n2(incremento);

                }
            }

        }
    }



//Funções Padrão


     //Renderiza Menu
    public static void RenderizaMenu(string msg){
        Console.WriteLine($"{msg}");
    }
    //Escreve Mensagens
    public static void Mensagem(string msg){
        Console.WriteLine($"\n{msg}");
    }

    //Pede Texto para o usuário
    public static string PedirTexto(string msg){
        Mensagem(msg);
        string? txt = Console.ReadLine();
        while (String.IsNullOrWhiteSpace(txt)) {
            Mensagem("---- !! Esse campo é obrigatório !! ----");
            Mensagem(msg);
            txt = Console.ReadLine();
        }
        return txt;
    }

    //Pede número Inteiro para o usuário
    public static int PedirNumeroInteiro(string msg){
        Mensagem(msg);
        string? n = Console.ReadLine(); 
        int number;
        int numericValue;
        bool isNumber = int.TryParse(n, out numericValue);
        while(!isNumber) {
            Mensagem("---- !! Aceita somente número !! ----");
            Mensagem(msg);
            n = Console.ReadLine();
            isNumber = int.TryParse(n, out numericValue);      
        }
        number = Convert.ToInt32(n);

        return number;
    }

    //Pede número e converte para Double para o usuário
    public static double PedirNumeroDouble(string msg){
        Mensagem(msg);
        //double val = Convert.ToDouble(Console.ReadLine());
        
        string? n = Console.ReadLine(); 
        double number;
        double numericValue;
        bool isDouble = double.TryParse(n, out numericValue);
        while(!isDouble) {
            Mensagem("---- !! Aceita somente número !! ----");
            Mensagem(msg);
            n = Console.ReadLine();
            isDouble = double.TryParse(n, out numericValue);      
        }
        number = Convert.ToDouble(n);
        return Math.Round(number, 2);
    }


}
