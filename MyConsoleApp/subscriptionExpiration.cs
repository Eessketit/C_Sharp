Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// my code

if (daysUntilExpiration <= 0)
{
    System.Console.WriteLine("Your subcription has expired.");
}
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    System.Console.WriteLine("Your subcription expires within day!");
}
else if (daysUntilExpiration < 5)
{
    discountPercentage = 10;
    System.Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days");
}

else if (daysUntilExpiration < 10)
{
    System.Console.WriteLine("Your subscription will expire soon. Renew now!");

}
else
{
    System.Console.WriteLine("nothing...");
}
if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}