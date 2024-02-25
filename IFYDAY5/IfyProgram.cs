using Day5;
using System.Transactions;

BankOps bankOps = new BankOps();

Console.WriteLine("Welcome to my Bank!");

bool goOn = true;
while (goOn)
{
    if (!goOn)
    {
        Environment.Exit(0);
    }

    Console.Clear();

    Console.WriteLine("Press the number to perform the following actions.");
    Console.WriteLine("1: Deposit");
    Console.WriteLine("2: Withdrawal");
    Console.WriteLine("3: Transfer");
    Console.WriteLine("4. Get Current Balance");
    Console.WriteLine("5. Get Transaction History");

    int choice = 0;

    if (int.TryParse(Console.ReadLine(), out choice))
    {
        if (choice < 1 || choice > 5)
        {
            Console.WriteLine("Please enter a valid choice of operation\n");
        }

        if (choice == 1)
        {
            Console.WriteLine("Enter an amount\n");
            decimal amt = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter an note\n");
            string note = Console.ReadLine();
            var response= bankOps.Deposit(amt, note);
            bankOps.Transactions.Add(new TransactionsHistory
            {
                Id = bankOps.Transactions.Count + 1,
                Amount = amt,
                Note = note,
                UpdateOn = DateTime.Now,
                TransactionType = "deposit"
            });

            if(response.Success)
            {
                Console.WriteLine($"Amount deposited successfully, balance is: {response.Data}");
            }
            else
            {
                Console.WriteLine($"Message: {response.Message}, Error: {response.Errors[0]}");
            }
        }
        else if (choice == 2)
        {
            Console.WriteLine("Enter an amount\n");
            decimal amt = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter an note\n");
            string note = Console.ReadLine();
            var response = bankOps.Withdrawal(amt, note);
            bankOps.Transactions.Add(new TransactionsHistory
            {
                Id = bankOps.Transactions.Count + 1,
                Amount = amt,
                Note = note,
                UpdateOn = DateTime.Now,
                TransactionType = "withdraw"
            });

            if (response.Success)
            {
                Console.WriteLine($"Amount deposited successfully, balance is: {response.Data}");
            }
            else
            {
                Console.WriteLine($"Message: {response.Message}, Error: {response.Errors[0]}");
            }
        }
        else if (choice == 3)
        {
            Console.WriteLine("Enter an amount\n");
            decimal amt = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter an note\n");
            string note = Console.ReadLine();
            var response = bankOps.Transfer(amt, note);
            bankOps.Transactions.Add(new TransactionsHistory
            {
                Id = bankOps.Transactions.Count + 1,
                Amount = amt,
                Note = note,
                UpdateOn = DateTime.Now,
                TransactionType = "Transfer"
            });


            if (response.Success)
            {
                Console.WriteLine($"Amount deposited successfully, balance is: {response.Data}");
            }
            else
            {
                Console.WriteLine($"Message: {response.Message}, Error: {response.Errors[0]}");
            }
        }
    }
    else
    {
        Console.WriteLine("Please enter a digit for your choice of operation\n");
    }

    Console.WriteLine("To continue, press Y. To discontinue press any key");
    string choice2 = Console.ReadLine();
    if (!choice2.ToUpper().Equals("Y"))
    {
        goOn = false;
    }
}
return;








QuadraticEquationSoln qtn = new QuadraticEquationSoln();
double a = 1;
double b = 4;
double c = 3;
double d, x, x1, x2;
d = x = x1 = x2 = 0;

d = qtn.GetDeterminant(a, b,c);

if(d < 0)
{
    Console.WriteLine("You got complex roots");
}else if(d == 0)
{
    x = qtn.CalculateForLinearRoots(a, b);
    Console.WriteLine(($"You got linear root: x: {x}"));
}
else
{
    var roots = qtn.CalculateForQuadRoots(a, b, d);
    Console.WriteLine(($"You got quadratic roots: x1: {roots[0]}, x2: {roots[1]}"));
}

return;


MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
myDictionary.Add(1, "One");
myDictionary.Add(2, "Two");
myDictionary.Add(3, "Three");

Console.WriteLine("List of key value pairs added to my dictionary");
myDictionary.Print();

return;
//Dog chihuahua = new Dog();
//Dog germanShephard = new Dog();
//Dog bullDog = new Dog();

Calculator calc = new Calculator();

var result = calc.Add(5, 7);
Console.WriteLine(result);

var result2 = calc.Add(1,3,4,5,6,7,8,4,6,7,4,7,8,6);
Console.WriteLine(result2);

calc.Equality();

GenericSampleClass<int> genericSampleClass = new GenericSampleClass<int>();
var Id = genericSampleClass.GetId();

GenericSampleClass<string> gsc = new GenericSampleClass<string>();
var Id2 = gsc.GetId();

Dictionary<int, string> dict =  new Dictionary<int, string>();