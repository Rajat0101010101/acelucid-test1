Module programetoprintpattern



Sub Main() 

Dim i, n, j, k As Integer 
Dim space As Integer = 1 
Console.WriteLine(" enter height") 

n = Console.ReadLine() 
Console.WriteLine() 

For i = 1 To n 

For j = 1 To n - 1 
Console.Write(" ") 
Next 
For k = 1 To 2 * i - 1 
Console.Write("*" + "") 
Next 
Console.WriteLine("") 
n -= 1 
Next 
Console.WriteLine(" Press any key to exit...") 
Console.ReadKey() 
End Sub 


End Module











private string GetNumbers(String InputString)
{
String Result = "";
string Numbers = "0123456789";
int i = 0;

for (i = 0; i < InputString.Length; i++)
{
if(Numbers.Contains(InputString.ElementAt(i)))
{
Result += InputString.ElementAt(i);
}
}
return Result;
}
