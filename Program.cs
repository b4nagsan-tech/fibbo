int abs_max(int a, int b)
{
    if (0 > a)
    {
        a = -a;
    }
    if (0 > b)
    {
        b = -b;
    }
    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}
Console.WriteLine(abs_max(12, -15));



Console.WriteLine();



List<int> fiboszamok = new();

int fibo(int n)
{
    fiboszamok.Add(0);
    fiboszamok.Add(1);
    for (int i = 0; i < n + 1; i++)
    {
        int szam = fiboszamok[i] + fiboszamok[i + 1];
        fiboszamok.Add(szam);
    }
    return fiboszamok[n];
}

Console.WriteLine(fibo(45));



Console.WriteLine();



Console.Write("Kérem a jelszót: ");

string jelszo = Console.ReadLine();

List<char> specialis = new() { '_', '-', '.' };

int jelszoerosseg(string jelszo)
{
    int ero = 1;

    if (jelszo.Length >= 5)
    {
        ero++;
    }

    if (jelszo.Length >= 8)
    {
        ero += 2;
    }

    foreach (char c in jelszo)
    {
        if (specialis.Contains(c))
        {
            ero += 2;
        }
    if (jelszo.Contains("123"))
        {
            ero = 0;
        }
    if (jelszo.Contains("jelszo"))
        {
            ero = 0;
        }
    }
    if (jelszo is null or "")
    {
        ero = 0;
    }
    return ero;
}

Console.WriteLine(jelszoerosseg(jelszo));



Console.WriteLine();



Console.Write("Szöveget: ");
string szoveg = Console.ReadLine();

string maganhangzot_torol (string szoveg)
{
    foreach (char c in szoveg)
    {
        if ("aeiouáéíóöőúüűAEIOUÁÉÍÓÖŐÚÜŰ".Contains(c))
        {
            szoveg = szoveg.Replace(c.ToString(), "");
        }
    }
    return szoveg;
}

Console.WriteLine(maganhangzot_torol(szoveg));



Console.WriteLine();



Console.WriteLine("Kérem a szöveget: ");
string szovege = Console.ReadLine();
Console.Write("Kérem hogy hány betűt akar hozzáadni: ");
int hanyszor = int.Parse(Console.ReadLine());
Console.Write("Titkos betű: ");
string titkos_betu = Console.ReadLine();

string kodol(string szoveg, int n, string c)
{
    string betu = "";

    foreach (char e in szoveg)
    {
        betu += e;
        for (int i = 0; i < n; i++)
        {
            szoveg =  betu += c;
        }
    }
    return szoveg;
}

Console.WriteLine(kodol(szovege, hanyszor, titkos_betu));
