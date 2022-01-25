using static System.Console;
class Aula2 {

    static void Demo5(){    
        var nomes = new string[]{"Carla", "Marcela", "Julia", "Ayumi", "Claire", "Sophie"};
        WriteLine("Qual o nome que quer achar");
        var nome = ReadLine();

        var nomeAchado = ProcuraNome(nomes, nome); 

        if(!string.IsNullOrWhiteSpace(nomeAchado)){
            WriteLine($"O nome {nomeAchado}, foi encontrado");
        }
        else{
            WriteLine("O nome não foi existe");
        }
    }

    static void Demo4(){
        
        var nomes = new string[]{"Carla", "Marcela", "Julia", "Ayumi", "Claire", "Sophie"};
        WriteLine($"Nomes é: {string.Join(", \n", nomes )}");

        WriteLine("Qual o nome que quer Trocar");
        var nome = ReadLine();
        WriteLine("Qual será o novo nome?");
        var nomeNovo = ReadLine();

        ref var nomeAchado = ref LocalizaNome(nomes, nome); 

        if(!string.IsNullOrWhiteSpace(nomeAchado)){
            nomeAchado = nomeNovo;
            WriteLine($"Nomes:{string.Join(", \n", nomes )}");
        }
        else{
            WriteLine("O nome não foi localizado");

         }
    }
    static void Demo3(){
        var nomes = new string[]{"Carla", "Marcela", "Julia", "Ayumi", "Claire", "Sophie"};
        WriteLine($"Nomes é: {string.Join(", \n", nomes )}");

        WriteLine("Qual o nome que quer Trocar");
        var nome = ReadLine();
        WriteLine("Qual será o novo nome?");
        var nomeNovo = ReadLine();

        var indice = LocalizarNome(nomes, nome); 

        if(indice >= 0){
            nomes[indice] = nomeNovo;
            WriteLine($"Nomes:{string.Join(", \n", nomes )}");
        }
        else{
            WriteLine("O nome não foi localizado");
        }

        //AlterarNome(nomes, nome, nomeNovo);
    }
    static void Demo2(){
        var nomes = new string[]{"Carla", "Marcela", "Julia", "Ayumi", "Claire", "Sophie"};
        WriteLine($"Nomes é: {string.Join(", \n", nomes )}");

        WriteLine("Qual o nome que quer Trocar");
        var nome = ReadLine();
        WriteLine("Qual será o novo nome?");
        var nomeNovo = ReadLine();

        AlterarNome(nomes, nome, nomeNovo);
        WriteLine($"Nomes:{string.Join(", \n", nomes )}");
    }
    static void Demo1(){
        int numero = 3;
        Adiconar30(ref numero);
        WriteLine($"O valor é {numero}");
    }
    static void Adiconar30(ref int numero){

        numero += 30;

    }

    static void AlterarNome(string[] nomes, string nome, string NomeNovo){

        for (int i = 0; i < nomes.Length; i++)
        {
            if(nomes[i] ==  nome){
                nomes[i] = NomeNovo;
            }
        }
    }

    static int LocalizarNome(string[] nomes, string nome){

        for (int i = 0; i < nomes.Length; i++)
        {
            if(nomes[i] == nome){
                return i;
            }
        }
        return -1;

    }
        static ref string LocalizaNome(string[] nomes, string nome){

        for (int i = 0; i < nomes.Length; i++)
        {
            if(nomes[i] == nome){
                return ref nomes[i];
            }
        }
        throw new Exception("Nome não Encontrado");

    }

        static string ProcuraNome(string[] nomes, string nome){

            for (int i = 0; i < nomes.Length; i++){
                if(nomes[i] == nome){
                    return nome;
                }

            }
            return "";
            }

    

    static void Main(){

        var nomes = new string[]{"Carla", "Marcela", "Julia", "Ayumi", "Claire", "Sophie"};
        WriteLine($"Nomes é: {string.Join(", \n", nomes )}");

        WriteLine("Qual o nome que quer Trocar");
        var nome = ReadLine();
        WriteLine("Qual será o novo nome?");
        var nomeNovo = ReadLine();

        ref var nomeAchado = ref LocalizaNome(nomes, nome); 

        if(!string.IsNullOrWhiteSpace(nomeAchado)){
            nomeAchado = nomeNovo;
            WriteLine($"Nomes:{string.Join(", \n", nomes )}");
        }
        else{
            WriteLine("O nome não foi localizado");
        }

    }
}