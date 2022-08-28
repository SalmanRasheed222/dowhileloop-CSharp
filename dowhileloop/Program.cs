
////// Mini Program Convert Your  Age into Days//////


//double age;
//char choice;
//do
//{

//	Console.Write("Enter Your Age: ");
//	age = Convert.ToDouble(Console.ReadLine());
//	Console.WriteLine("Your Are " + age * 365 + " Days Old");
//	Console.WriteLine("");
//	Console.WriteLine("If You Want To Convert Your Age into Days Agin?" + Environment.NewLine + "Press Y to Continue or Press Any Key to Close...");
//	Console.WriteLine("");
//	choice = Console.ReadKey.KeyChar;
//}
//while (choice == 'y' || choice == 'Y');



            // Ctrl+K+C to Comment  Code.
			// Ctrl+K+U to UnComment Code.


                                                         
                                                           ////// Do While Loop //////



double fvalue, svalue;
char choice, operation;


do
{

	Console.Write("Enter First Value: ");
	fvalue = Convert.ToDouble(Console.ReadLine());

	Console.WriteLine("enter operator");
	operation = Console.ReadKey().KeyChar;
	Console.WriteLine("");

	Console.WriteLine("Enter Second Value: ");
	svalue = Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("");


	if (operation == '+')
	{
		Console.WriteLine("Result: " + Convert.ToDouble(fvalue + svalue));
	}

	else if (operation == '-')
	{
		Console.WriteLine("Result: " + Convert.ToDouble(fvalue - svalue));
	}

	else if (operation == '*')
	{
		Console.WriteLine("Result: " + Convert.ToDouble(fvalue * svalue));
	}

	else if (operation == '/')
	{
		Console.WriteLine("Result: " + Convert.ToDouble(fvalue / svalue));
	}
	else
	{
		Console.WriteLine("Wrong Input...");
	}


	Console.WriteLine("did you want to use calculator?" + Environment.NewLine + "Press Y to Continue or press any key to exit.");
	choice = Console.ReadKey().KeyChar;
	Console.WriteLine("");


} while (choice == 'y' || choice == 'Y');





