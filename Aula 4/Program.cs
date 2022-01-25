using static System.Console;

Numero a = new Numero(2);
Numero b = new Numero(2);

if(a == b){
   WriteLine("A e B são iguais");
}
else{
    WriteLine("A e B são Diferentes");
}
class Numero{
    public int N { get; set; }

    public Numero(int n){
        N = n;
    }
}