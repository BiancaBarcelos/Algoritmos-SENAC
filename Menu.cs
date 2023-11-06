using Algoritmos_SENAC;

class Menu {

    public static int MostrarMenu(){

        Program.Mensagem("____________________");
        Program.Mensagem("Selecione uma das opções abaixo, informando um número");
        Program.Mensagem("1. Cadastrar Produto");
        Program.RenderizaMenu("2. Listar Produtos");
        Program.RenderizaMenu("3. Remover Produto");
        Program.RenderizaMenu("4. Entrada Estoque");
        Program.RenderizaMenu("5. Saída Estoque");
        Program.RenderizaMenu("0. Sair");
        int n = Program.PedirNumeroInteiro("____________________");
        return n;
    }


    
}