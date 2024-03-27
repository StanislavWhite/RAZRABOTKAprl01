using ConsoleApp6;

class Program
{
    static void Main(string[] args)
    {
        var GranMo1 = new Woman ("GranMo1");
        var GranFa1 = new Man("GranFa1");

        var Mother = new Woman("Mother");
        var MotherBrother = new Man("MotherBrother");

        var MotherBrotherDaughter = new Woman("MotherBrotherDaughter");

        var GranMo2 = new Woman("GranMo2");
        var GranFa2 = new Man("GranFa2");

        var Father = new Man("Father");
        var FatherSyster = new Woman("FatherSyster");

        var FatherSysterSoon = new Man("FatherSysterSoon");
        var FatherSysterDaughter = new Woman("FatherSysterDaughter");

        var SoonGirl = new Man("SoonGirl");

        var Soon = new Man("Soon");

        GranMo1.AddFamilyInfo(null, null, GranFa1, Mother, MotherBrother);
        GranFa1.AddFamilyInfo(null, null, GranMo1, Mother, MotherBrother);

        GranMo2.AddFamilyInfo(null, null, GranFa2, Father, FatherSyster);
        GranFa2.AddFamilyInfo(null, null, GranMo2, Father, FatherSyster);

        MotherBrother.AddFamilyInfo(GranFa1, GranMo1, null, MotherBrotherDaughter);

        FatherSyster.AddFamilyInfo(GranFa2, GranMo2, null, FatherSysterSoon, FatherSysterDaughter);

        Mother.AddFamilyInfo(GranFa1, GranMo1, Father, Soon);

        Father.AddFamilyInfo(GranFa2, GranMo2, Mother, Soon);

        SoonGirl.AddFamilyInfo(null, null, Soon);

        Soon.AddFamilyInfo(Father, Mother, SoonGirl);

        GranFa2.GetFamilyInfo();
        GranFa1.GetFamilyInfo();
    }
}