/* // Пример номер 1. Вывод вариантов слов из предоставленных букв

FindWords("аисв", new char[2]);

///////////////////////////////

int n = 1;
void FindWords(string alphabet, char[] word, int lenght = 0)
{
    if (lenght == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[lenght] = alphabet[i];
        FindWords(alphabet, word, lenght + 1);
    }
} */

/* // Пример номер 2. Вывод сведений о папаках.

string path = @"/Users/opvsn/Documents/Study/3. Basics of programming languages/Examples/Example001_HelloConsole";
CatalogInfo(path);

///////////////////////////////

void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + "  ");
    }

    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
} */

/* // Пример номер 3. Игра в Башенки

Towers();

///////////////////////////////

void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
} */

/* // Пример номер 4. Обход структур
string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
InOrderTraversal();

///////////////////////////////
void InOrderTraversal(int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.WriteLine(tree[pos]);
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
} */

// Пример номер 5. Сравнение рекурсии и итеративного алгоритма

decimal fRec = 0;
decimal fIte = 0;

decimal FibonacciRecursion(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
}

decimal FibonacciIteration(int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for(int i = 2; i <= n; i++)
    {
        result = f0 + f1;
        
        f0 = f1;
        f1 = result;
    }
    return result;
}

Console.ReadLine();
DateTime dt = DateTime.Now;
for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte.ToString("### ### ###"), -15}");
    fIte = 0;
}
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
Console.WriteLine();
Console.ReadLine();

dt = DateTime.Now;
for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"), -15}");
    fRec = 0;
}
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);