using System.Runtime.CompilerServices;
using Algoritmos_SENAC;
using ConsoleTables;

class GerenciadorEstoque {
    
    Produto[] produtos = new Produto[0];
    public void listarTabela(int posicao){
        var table = new ConsoleTable("Id","Nome", "Modelo", "Dimensões", "Escala", "Led", "Valor", "Estoque");
        table.AddRow($"{posicao}", $"{produtos[posicao - 1].Nome}", $"{produtos[posicao - 1].Modelo}", $"{produtos[posicao - 1].DAltura}cm X {produtos[posicao - 1].DLargura}cm X {produtos[posicao - 1].DProfundidade}cm", $"{produtos[posicao - 1].Escala}", $"{produtos[posicao - 1].Led}", $"R$ {produtos[posicao - 1].Valor}", $"{produtos[posicao - 1].Estoque} un");
        table.Write();
    }
    public void cadastrarProduto(Produto novoDorama){
        Produto[] novoArray = new Produto[produtos.Length + 1];
        for (int posicao = 0; posicao < produtos.Length; posicao++) {
            novoArray[posicao] = produtos[posicao];
        }
        novoArray[novoArray.Length - 1] = novoDorama;
        produtos = novoArray;
        
    }

    public void listarProdutos(){
        var table = new ConsoleTable("Id","Nome", "Modelo", "Dimensões", "Escala", "Led", "Valor", "Estoque");
        for(int posicao = 0 ; posicao < produtos.Length; posicao++){
            Produto item = produtos[posicao];
            table.AddRow($"{posicao+1}", $"{item.Nome}", $"{item.Modelo}", $"{item.DAltura}cm X {item.DLargura}cm X {item.DProfundidade}cm", $"{item.Escala}", $"{item.Led}", $"R$ {item.Valor}", $"{item.Estoque} un");
        }
        table.Write();
    }

    public void removerProduto(){
        Program.Mensagem("____________________");
        Program.Mensagem("-- Saída de Estoque --");
        int posicaoRemover = Program.PedirNumeroInteiro("Informe o produto a ser removido:");
        Produto[] novoArray = new Produto[produtos.Length - 1];
        for (int pos = 0; pos < novoArray.Length; pos++){
            if(pos >= posicaoRemover - 1){
                novoArray[pos] = produtos[pos + 1];
            }else{
                novoArray[pos] = produtos[pos];
            }
        }
        produtos = novoArray;
        
        listarProdutos();
    }

    public void entradaEstoque(){
        Program.Mensagem("____________________");
        Program.Mensagem("-- Entrada de Estoque --");
        listarProdutos();
        int posicao = Program.PedirNumeroInteiro("Informe o Identificador do produto:");
        int estoque = Program.PedirNumeroInteiro("Informe quantos produtos entraram:");
        produtos[posicao -1].Estoque += estoque;
        
        Program.Mensagem("---- !! Estoque Atualizado!! !! ----");
        listarTabela(posicao);
    }

    public void saidaEstoque(){
        Program.Mensagem("-- Saída de Estoque --");
        listarProdutos();
        int posicao = Program.PedirNumeroInteiro("Informe o Identificador do produto:");
        int estoque = Program.PedirNumeroInteiro("Informe quantos produtos sairam:");
        produtos[posicao -1].Estoque -= estoque;
        if(produtos[posicao -1].Estoque < 0){
            produtos[posicao -1].Estoque = 0;
        }
        
        Program.Mensagem("---- !! Estoque Atualizado!! !! ----");
        listarTabela(posicao);
    }
}