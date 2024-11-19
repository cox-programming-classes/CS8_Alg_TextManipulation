using CS8_Alg_TextManipulation;


Console.WriteLine("Enter a secret message:");
var secretMessage = Console.ReadLine()!;
Console.WriteLine("Enter a password:");
var password = Console.ReadLine()!;

var encrypted = secretMessage.ApplyCipher(password);
Console.WriteLine($"Your message encrypted:{Environment.NewLine}{encrypted}");

var decrypted = encrypted.ApplyCipher(password);
Console.WriteLine($"Your decrypted message:{Environment.NewLine}{decrypted}");

return;