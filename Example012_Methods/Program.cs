// вид метода 1

/*
void Method1()
{
    Console.WriteLine("Автор Липатников Александр");
}

Method1();
*/

// вид метода 2

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
Method21("Текст", 4);