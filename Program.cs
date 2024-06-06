

int FirstNumber = 1995;
int SecondNumber= 2024;

int Yoshim = SecondNumber - FirstNumber;
Console.WriteLine("Mening Yoshim = " + Yoshim + " da");
//Yoshimni nechchidaligi
bool amILearner = true;
Console.WriteLine("am I learner still = " + amILearner);


//4-darsning topshiriqlari
string  firstInput = Console.ReadLine();
string  secondInput = Console.ReadLine();

decimal thirdNumber;
decimal fourthNumber;
decimal.TryParse(secondInput, out fourthNumber);
decimal.TryParse(firstInput, out thirdNumber);
decimal javob = thirdNumber + fourthNumber;
Console.WriteLine("yechim = " + javob );

decimal foiz = (thirdNumber * 100) / fourthNumber;
Console.WriteLine("foizi = " + foiz + " %");



