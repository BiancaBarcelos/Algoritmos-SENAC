using Algoritmos_SENAC;

class Menu {

    public static int MostrarMenu(){

        Program.Mensagem("____________________");
        Program.Mensagem("-- Menu --");
        Program.Mensagem("1. Cadastrar Produto");
        Program.RenderizaMenu("2. Listar Produtos");
        Program.RenderizaMenu("3. Remover Produto");
        Program.RenderizaMenu("4. Entrada Estoque");
        Program.RenderizaMenu("5. Saída Estoque");
        Program.RenderizaMenu("0. Sair");
        int n = Program.PedirNumeroInteiro("Selecione a opção desejada, informando um número:");
        return n;
    }


    
}