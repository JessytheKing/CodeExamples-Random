
class Enums

{
    enum Rank { Private = 1, PFC = 2, LCPL = 3, CPL = 4, SGT = 5, SSGT = 6, GUNNY = 7, FIRSTSGT = 8, MASTERSGT = 9, SGTMAJOR = 10, MASTERGUNNERYSGT = 10 }
    static void Main(string[] args)
    {
        int CPL = (int)Rank.CPL;
        int SGT = (int)Rank.SGT;

        System.Console.WriteLine($"Jesus's rank makes up the backbone of the Marine Corps an E-{CPL}");
        System.Console.WriteLine($"Jacob is an E-{SGT} ");
        

    }

    

}
