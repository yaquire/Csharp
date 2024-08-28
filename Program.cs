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





void main()
{
  input_choice_function();
}

main();
