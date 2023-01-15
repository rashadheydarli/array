
int[] a = { 100, 300, 200, 50 };
int temp;
int min;
for (int i = 0; i < a.Length; i++)
{
    min = a[i];
    for (int j = i + 1; j < a.Length; i++)
    {
        if (min > a[j])
        {
            min = a[j];
        }

    }
    temp = min;
    min = a[i];
    a[i] = temp;
}

Console.WriteLine(a);



//int[] n = { 1, 2, 3, 4 };
//int sum = 0;
//int orta;
//for (int i = 0; i < n.Length; i++)
//{

//    sum += n[i];

//}
//orta = sum / n.Length;
//Console.WriteLine(orta);


//int[] n = { 100, 200, 500, 400 };
//int min;
//for (int i = 0; i < n.Length; i++)
//{

//    for (int j = i + 1; j < n.Length; i++)
//    {
//        if ()
//    }
//}
//Console.WriteLine(n);


