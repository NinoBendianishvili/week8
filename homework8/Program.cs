// See https://aka.ms/new-console-template for more information

#region task1

using System.Text;

static double intfinder(double a, double b, double n)
{
    return (Math.Ceiling(Math.Pow(b, 1 / n) - Math.Pow(a, 1 / n)));
}
#endregion

#region task2

static int pairfinder(string st)
{
    char[] arr = st.ToCharArray();
    Dictionary<char, int> dict = new Dictionary<char, int>();
    for (int i = 0; i < arr.Length; i++)
    {
        if (!dict.ContainsKey(arr[i])) dict.Add(arr[i], 1);
        else dict[arr[i]]++;
    }

    int[] valarr = dict.Values.ToArray();
    int sum = 0;
    for (int i = 0; i < valarr.Length; i++)
    {
        sum += valarr[i] / 2;
    }
    return sum;
}

#endregion

#region task3
static String stringfinder (string full)
{
    String[] phs = full.Split(", ");
    char[] ph1 = phs[0].ToCharArray();
    char[] ph2 = phs[1].ToCharArray();
    string st = "";
    int i = ph1.Length - 1;
    while (ph1[i] == ph2[i])
    {
        st = ph1[i] + st;
        i--;
    }

    return st;
}
#endregion

#region task4

static void parselist<T>(List<T> l)
{
    if (l.GetType() == typeof(string))
    {
        actionstring(l as dynamic);
    }
    if (l.GetType() == typeof(int))
    {
        actionint(l as dynamic);
    }
    if (l.GetType() == typeof(bool))
    {
        actionbool(l as dynamic);
    }
}

static void actionstring(List<string> l)
{
    for (int i = 0; i < l.Count; i++)
    {
        Console.WriteLine(l[i].ToUpper());
    }
}

static void actionint(List<int> l)
{
    int sum = 0;
    for (int i = 0; i < l.Count; i++)
    {
        sum += l[i];
    }
    Console.WriteLine(sum);
}

static void actionbool(List<bool> l)
{
    Console.WriteLine($"First element is {l[0]}");
    Console.WriteLine($"Last element is {l[l.Count]}");
    Console.WriteLine($"Middle element is {l[l.Count/2]}");
}
#endregion

#region task5

static void numprinter(int a)
{
    if (a / 10 == 0) Console.Write($"{a} - ");
    else
    {
        numprinter(a / 10);
        Console.Write($"{a % 10} - ");
    }

}

numprinter(2467);
#endregion

#region task6

static bool duplicatechecker(int[] arr)
{
    bool answer = false;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[i] == arr[j] && i != j) answer = true;
        }
    }

    return answer;
}

Console.WriteLine(duplicatechecker(new []{2,4,7,1,}));
#endregion