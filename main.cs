using System;

class MainClass {
  public static void Main (string[] args) {
    
    Agendamento marcar = new Agendamento();
    string nom;
    int id, membros,d;
    char sa, desem, s, sair ;

    Pessoa cadastro = new Pessoa ();
    //CADASTRO
    Console.WriteLine("Digite seu nome: ");
    nom = Console.ReadLine();
    Console.WriteLine("Digite sua idade: ");
    id = int.Parse(Console.ReadLine());
    Console.WriteLine("Está dempregado?");
    desem = char.Parse(Console.ReadLine());
    Console.WriteLine("Renda familiar de até um salario minino?");
    sa = char.Parse(Console.ReadLine());
    cadastro.MeusDados(nom,id,sa,desem);
    
    Console.WriteLine("Quantas pessoas moram com você?");
    membros = int.Parse(Console.ReadLine());
    cadastro.RendaFamiliar(membros);
    
    //Agendamento
    //Console.WriteLine("Digite a opção desejada: {0}");
    //d= int.Parse(Console.ReadLine());
    Console.WriteLine("Se foi aprovado aperte 's' para continuar ou aparte qualaquer tecla para sair");
    sair = char.Parse(Console.ReadLine());
    marcar.Agenda(sair);
    
    
   
  }
}