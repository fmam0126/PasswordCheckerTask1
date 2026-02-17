Console.WriteLine("Please Enter Your Password:");
string? password = Console.ReadLine();
if (password?.Length > 8 && password.Any(char.IsDigit) && password.Any(char.IsAsciiLetterUpper) && (password.Any(char.IsPunctuation) || password.Any(char.IsSymbol)))
{
    Console.WriteLine("This is a Good Password");
}
else if (password?.Length > 8 && password.Any(char.IsDigit) && password.Any(char.IsAsciiLetterUpper))
{
    Console.WriteLine("This is an even better password");
}
else if (password?.Length > 8 && password.Any(char.IsAsciiLetterUpper))
{
    Console.WriteLine("This a Better Password");
}
else if (password?.Length > 8)
{
    Console.WriteLine("This is an OK Password.");
}
else
{
    Console.WriteLine("This Password is BAD!");
}