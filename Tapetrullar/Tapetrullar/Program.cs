using System;

namespace Tapetrullar
{
    class Program
    {
        static void Main(string[] args)
        {
            var mönsterrapport = 26.5; // Centimeter.
            var takhöjd = 2.5; // Meter.
            var tapetrulleMått = "10 x 0,53"; // Meter.
            var löpmeter = 15.0; // Meter.
            var fönsterBredd = 1.5; // Meter.
            var dörrBredd = 0.7; // Meter.
            var tapetensBredd = 0.53; // Meter
            var rapportAmount = takhöjd * 100 / mönsterrapport;
            var vådlängd = Math.Ceiling(rapportAmount) * mönsterrapport;
            var våderPerRulle = Math.Ceiling(rapportAmount) / (mönsterrapport / 10); // (/ 10) gör att vi omvandlar CM till M.
            var rummet = "4 x 3,5m (4 + 4 + 3,5 + 3,5)";
            var antalVåder = (löpmeter - fönsterBredd - dörrBredd) / tapetensBredd;
            var antalRullar = (Math.Ceiling(antalVåder) / Math.Floor(våderPerRulle));

            // 1.)
            Console.WriteLine($"1.) Takhöjden är {takhöjd * 100} cm.");
            Console.WriteLine($"Tapetrullens mått är {tapetrulleMått} och har en mönsterrapport på {mönsterrapport}cm");
            Console.WriteLine($"{takhöjd * 100} / {mönsterrapport} = {Math.Round(rapportAmount, 2)}");
            Console.WriteLine($"Det krävs alltså {Math.Ceiling(rapportAmount)} stycken rapporter.");
            Console.WriteLine($"{Math.Ceiling(rapportAmount)} x {mönsterrapport} = {vådlängd}cm vådlängd");
            Console.WriteLine("");
            // 2.)
            Console.WriteLine($"2.) {Math.Ceiling(rapportAmount)} / {(mönsterrapport / 10)} = {Math.Round(våderPerRulle, 2)}");
            Console.WriteLine($"Man får då ut {Math.Floor(våderPerRulle)} våder /rulle.");
            Console.WriteLine("");
            // 3.)
            Console.WriteLine($"3.) Rummet är {rummet}");
            Console.WriteLine($"Löpmetern är då {löpmeter}m.");
            Console.WriteLine($"Ett fönster finns, {fönsterBredd * 100}cm brett.");
            Console.WriteLine($"En dörr finns, {dörrBredd * 100}cm bred.");
            Console.WriteLine($"Detta räknar man bort: {löpmeter}m - {fönsterBredd} - {dörrBredd} = {(löpmeter - fönsterBredd - dörrBredd)}m");
            Console.WriteLine($"{(löpmeter - fönsterBredd - dörrBredd)} / {tapetensBredd}(tapetens bredd) = {Math.Round(antalVåder, 2)}");
            Console.WriteLine($"Det blir hela {Math.Ceiling(antalVåder)} våder.");
            Console.WriteLine("");
            // 4.)
            Console.WriteLine($"4.) {Math.Ceiling(antalVåder)} (våder) / {Math.Floor(våderPerRulle)} (våder/rulle) = {Math.Round(antalRullar, 1)} rullar ");
            Console.WriteLine($"Avrundat blir det {Math.Ceiling(antalRullar)} rullar. Du får dessutom över till passbitar över fönster och dörr.\n\n");
            Console.WriteLine("Press any key to quit!");
            Console.ReadLine();
        }
    }
}