﻿// See https://aka.ms/new-console-template for more information
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
  int number;
  Console.Write("Please Enter the Binary Number: ");
  while (!int.TryParse(Console.ReadLine(), out number))
  {
    Console.Write("Invalid Input. PLease Enter a proper Binary Number: ");
  }
  //Console.Write(number);
  bool has_binary = false;
  for (int i = 0; i < 10; i++)
  {

  }

  return "b-d";
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
