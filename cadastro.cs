using System;

class Pessoa{ 

private string nome;
private int    idade;
private char  salario, desempregado; 



public void MeusDados (string n, int i, char sal, char d){
  nome = n;
  idade = i;
  salario = sal;
  desempregado = d;

}




public void RendaFamiliar (int mem){
   
   
   if (salario == 's' && desempregado == 's'){
     Console.WriteLine("Aprovado", salario, desempregado);
     Console.WriteLine("Você tem direito há {0} kit.", mem);
     ;

   }
   else if (salario == 's' && desempregado == 'n'){
     Console.WriteLine("Aprovado", salario, desempregado);
     Console.WriteLine("Você tem direito há {0} kits.", mem);
     ;
   }  
   else if (salario == 'n' && desempregado == 's'){
     Console.WriteLine("Aprovado", salario, desempregado);
     Console.WriteLine("Você tem direito há {0} kits.", mem);
     ;  
   }
   else{
     Console.WriteLine("Reprovado");
     
     
   }  
} 

  
     
      



  
   

}