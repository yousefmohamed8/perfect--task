int n1, n2, sum = 0;
Console.Write("Enter Frist number: ");
n1 = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Perfect numbers  are: ");
Console.WriteLine("-----------------------------------------------------");
for (int i = n1; i <= n2; i++)
{
    sum = 0;
  
    
        for (int j = 1; j < i; j++)
        {
            if (i % j == 0)sum=sum + j;
            {
               
             
            }
        }
        if (sum == i)
        {
        Console.WriteLine(i);
    }
       
    
}

