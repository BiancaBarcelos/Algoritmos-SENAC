using System.Runtime.CompilerServices;
using Algoritmos_SENAC;
using ConsoleTables;

class GerenciadorEstoque {
    
    Produto[] produtos = new Produto[0];

    public void cadastrarProduto(Produto novoDorama){
        Produto[] novoArray = new Produto[produtos.Length + 1];
        for (int posicao = 0; posicao < produtos.Length; posicao++) {
            novoArray[posicao] = produtos[posicao];
        }
        novoArray[novoArray.Length - 1] = novoDorama;
        produtos = novoArray;
        
    }

    public void listarProdutos(){
        Program.Mensagem("Listando...");
        var table = new ConsoleTable("Id","Nome", "Modelo", "Dimensões", "Escala", "Led", "Valor", "Estoque");
        for(int posicao = 0 ; posicao < produtos.Length; posicao++){
            Produto item = produtos[posicao];
            table.AddRow($"{posicao+1}", $"{item.Nome}", $"{item.Modelo}", $"{item.DAltura}cm X {item.DLargura}cm X {item.DProfundidade}cm", $"{item.Escala}", $"{item.Led}", $"R$ {item.Valor}", $"{item.Estoque} un");
            table.Write();
        }
    }
}