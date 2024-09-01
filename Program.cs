// See https://aka.ms/new-console-template for more information
// This is meant to be a binary-decimal converter in the CLI
//


string input_choice_function()//This function lets the user choses which way to conver the number
{
  while (true)
  {
    Console.Write("1) binary-decimal \n2) decimal-binary \nYour choice:");
    int user_input = Convert.ToInt32(Console.ReadLine());
    if (user_input == 1 || user_input == 2)
    {
      string user_choice = (user_input == 1) ? "binary-decimal" : "decimal-binary";
      Console.WriteLine(user_choice);
      return user_choice;
    }
    else
    {
      Console.WriteLine("ERROR of the choices");
    }
  }
}

string binary_decimal_function()
{
  int number = 0;

  while (true)
  {
    Console.Write("Please Enter the Binary Number: ");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
      Console.Write("Invalid Input. PLease Enter a proper Binary Number: ");
    }
    //Console.Write(number);
    string user_number = Convert.ToString(number);
    int no_binary = 0;
    for (int i = 0; i < user_number.Length; i++)
    {
      //Console.WriteLine($"Number is:{user_number[i]}");
      Console.WriteLine($"{user_number[i]}; {user_number[i].GetType()}");
      if (user_number[i] == '1' || user_number[i] == '0')
      {
        no_binary += 0;
        //Console.WriteLine("TRUE"); 
      }
      else
      {
        //Console.WriteLine("FALSE"); 
        no_binary += 1;
      }
    }

    if (no_binary == 0)
    {
      break;
    }
    else
    {
      Console.WriteLine("ERROR wrong value");
      continue;
    }
  }
  //Console.WriteLine(number);
  int final_decimal_from_bianry = 0;
  string user_binary = Convert.ToString(number);
  for (int i = 1; i <= user_binary.Length; i++)
  {
    int interger_bi = Convert.ToInt16(user_binary[^i]);
    Console.WriteLine($"interger_bi: {interger_bi}");
    final_decimal_from_bianry += (interger_bi * 2 ^ i);
    Console.WriteLine($"From Binary to Decimal: {final_decimal_from_bianry}");

  }
  //  Console.WriteLine($"From Binary to Decimal: {final_decimal_from_bianry}");


  return "binary-decimal";
}



void main()
{
  string user_choice = input_choice_function();
  if (user_choice == "binary-decimal")
  {
    binary_decimal_function();
  }
}

main();
