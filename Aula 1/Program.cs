using static System.Console;

public class Program {

    static void Demo6(){
        int[] numeros = new int[]{0, 2, 4, 6, 8, 10};
        WriteLine($"Qual numero deseja encontrar? ");
        var numero = int.Parse(ReadLine());
        var IdxEcontrado = EncontrarNumero(numeros, numero);

        if (IdxEcontrado >= 0){
            WriteLine($"O número foi encontrado e está na posição {IdxEcontrado}");
        }
        else {
            WriteLine("O número não foi encontrado");
        }
    }
    static void Demo5(){
        int[] pares = new int[]{0, 2, 4, 6, 8, 10};

        MudaImpar(pares);
        
        WriteLine($"os Ímpares {string.Join(", ", pares)}");
    }
    static void Demo4(){
        string Nome = "Carlos";

        TrocaNome(Nome, "Luciano");

        WriteLine($"Novo nome é {Nome}");

    }

    static void Demo3(){
        StrucPessoa p1 = new StrucPessoa(){
            Documento = "55621",
            Nome = "Marcelo",
            Idade = 19
        };

        var p2 = p1;

        p1 = TrocaNome(p1, "João");
        WriteLine($@"
        Nome p1: {p1.Nome}
        Nome p2: {p2.Nome}
        ");    
    }

    static void Demo2(){
        Pessoa p1 = new Pessoa();
        p1.Nome = "Ricardo";
        p1.Idade = 25;
        p1.Documento = "135567898";

        Pessoa p2 = p1.Clone();
        

        TrocaNome(p1,"Carlos");

        WriteLine($@"
        O nome de P1 é: {p1.Nome}
        O nome de P2 é: {p2.Nome}
        ");
    }
    
    static void Demo1(){

        int valor = 10;

       valor = Adicionar20(valor);

        WriteLine($"O valor é {valor}");
    }
    static int Adicionar20(int x) {
        return x + 20; 
    }

    static void TrocaNome(Pessoa p1, string NovoNome){

        p1.Nome = NovoNome;
    }
    
    static StrucPessoa TrocaNome(StrucPessoa p1, string NovoNome){
        p1.Nome = NovoNome;
        return p1;
    }
    
    static void TrocaNome(string Nome,string NovoNome){
        Nome = NovoNome;
    }

    static void MudaImpar(int[] pares){
        for (int i = 0; i < pares.Length; i++)
        {
            pares[i] = pares[i] + 1;
        }
    }

    static int EncontrarNumero(int[] numeros, int numero){
        for (int i = 0; i < numeros.Length; i++)
        {
            if(numeros[i] == numero)
            return i;
        }
        return -1;
    }

    static bool EncontrarNome(List<Pessoa> pessoas, Pessoa pessoa){
        foreach (var item in pessoas)
        {
            if(item == pessoa){
                return true;
            }

        }
        return false;
    }
    static bool EncontrarNome(List<StrucPessoa> pessoas, StrucPessoa pessoa){
        foreach (var item in pessoas)
        {
            if(item.Equals(pessoa)){
                return true;
            }

        }
        return false;
    }


    
    public static void Main(){  

        List<StrucPessoa> pessoas = new List<StrucPessoa>(){
            new StrucPessoa(){Nome = "Carlos"},
            new StrucPessoa(){Nome = "Antônio"},
            new StrucPessoa(){Nome = "Josemar"},
            new StrucPessoa(){Nome = "Lucas"},
            new StrucPessoa(){Nome = "Camila"},
            new StrucPessoa(){Nome = "Matheus"}
        };

        WriteLine("Digite o nome que quer encontar");
        var NomePessoa = ReadLine();
        var pessoa = new StrucPessoa(){Nome = NomePessoa};
        var Encontrado = EncontrarNome(pessoas, pessoa);
        if(Encontrado){
            WriteLine("Pessoa Localizada!");
        }
        else {
            WriteLine("Pessoa não encontrada");
        }
    }
}

