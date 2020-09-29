using System;

class Agendamento {


  

public void Agenda (char exit) { 
  
   
 if (exit == 's') {  
  int d2;
 var dateString = "9/25/2020 8:30:52 AM";
 DateTime date1 = DateTime.Parse(dateString,
                          System.Globalization.CultureInfo.InvariantCulture);

                      



 var dateString2 = "9/29/2020 11:30:00 AM";
 DateTime date2 = DateTime.Parse(dateString2,
                          System.Globalization.CultureInfo.InvariantCulture);

 var dateString3 = "9/29/2020 1:30:00 PM";
 DateTime date3 = DateTime.Parse(dateString3,
                          System.Globalization.CultureInfo.InvariantCulture);

 var dateString4 = "9/29/2020 3:30:00 PM";
 DateTime date4 = DateTime.Parse(dateString4,
                          System.Globalization.CultureInfo.InvariantCulture);

 Console.WriteLine("Horarios disponiveis: 1) {0} 2){1} 3){2} 4){3} ",date1, date2,date3,date4);

 Console.WriteLine("Digite a opção desejada: ");
 d2 = int.Parse(Console.ReadLine());

 switch (d2){
  case 1:
   Console.WriteLine("Horario marcado para: {0}", date1);
   break;
  case 2: 
   Console.WriteLine("Horario marcado para: {0}", date2);
   break;
  case 3: 
   Console.WriteLine("Horario marcado para: {0}", date3);
   break;
  case 4: 
   Console.WriteLine("Horario marcado para: {0}", date4);
   break;   
  }

  Console.WriteLine("Não esquecer documento com foto e comprovantes das informações passadas acima!");

}else {
  Console.WriteLine("FIM.");
}
}
 






}