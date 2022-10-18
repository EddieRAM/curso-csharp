// --------------------- Age App ---------------------

// Console.Write("Digite seu nome: ");
// string nameInput = Console.ReadLine();
// Console.WriteLine($"Olá {nameInput}!");
// Console.WriteLine("Digite o ano de seu nascimento");
// int yearInput = int.Parse(Console.ReadLine());
// int userAge = 2022 - yearInput;
// Console.WriteLine($"Você tem {userAge} anos.");
// if(userAge > 18) {
//   Console.WriteLine("Você é maior de idade");
// }else if (userAge == 18){
//   Console.WriteLine("Você já fez aniversário esse ano?");
//   Console.WriteLine("Digite 's' ou 'n'");  
//   string userAnswer = Console.ReadLine();
//   string y = "s";
//   string n = "n";
//   if (userAnswer == y) {
//     Console.WriteLine("Você é maior de idade");
//   } else if (userAnswer == n) {
//     Console.WriteLine("Você é menor de idade");
//   } else {
//     Console.WriteLine("Responda com 's' ou 'n'. Retornando ao início...");
//   }
// }else {
//   Console.WriteLine("Você é menor de idade.");
// }

// --------------------- for ---------------------

// class Program {
//   static void Main(){

//     string[] names = { "Edu", "Guaxi", "Ninja"};
//     for (int i = 0; i < names.Length; i++)
//     {
//       Console.WriteLine(names[i]);
//     }
//   }
// }

// --------------------- for each ---------------------

class Program {
  static void Main(){

    string[] names = { "Edu", "Guaxi", "Ninja"};

    if (string.Equals(names[0],"edu", StringComparison.OrdinalIgnoreCase)) { // returns bool
      Console.WriteLine("Ok");
    }
      
    foreach (string name in names)
    {        
      Console.WriteLine(name);     
    }
    
  }
}

// --------------------- strings ---------------------


//   static void Main(){

//   string name = "Eduardo";
// }



