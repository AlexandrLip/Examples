// вид метода 1

/*
void Method1()
{
    Console.WriteLine("Автор Липатников Александр");
}

Method1();
*/

// вид метода 2

/*
void Method2(string msg)
{
    Console.WriteLine(msg);
}

//Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i=0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++;

    }
}
Method21(msg: "Текст", count: 4);

*/

// вид метода 3

/*
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

*/

// вид метода 4

/*
string Method4(int count, string Text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + Text;
        i++;
    }
    return result;
}
string res = Method4(10, "клеим текст");
Console.WriteLine(res);
*/

// вид метода цикла for
/*
string Method4(int count, string Text)
{
        string result = String.Empty;
        for(int i = 0; i<count; i++)
        {
            result = result + Text;
        }
    return result;
}
string res = Method4(10, "клеим текст");
Console.WriteLine(res);
*/
//string Method4(int count, string Text)


for (int i =2; i <=10; j++)
{
    for (int j =2; j <=10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}
