// See https://aka.ms/new-console-template for more information
using JobNimubsAssessment;

BracesChecker bc = new BracesChecker();

string input = "[()]{}{[()()]()}";

if (bc.AreBracesMatched(input))
    Console.WriteLine("true");
else
    Console.WriteLine("false");

Console.ReadLine();