namespace Codility
{
    internal class AsmlAssignment
    {
        public static void solution(string line)
        {
            double valH, valS, valV;
            double valR = 0, valG = 0, valB = 0;
            double valC, valX, valm;

            var inputs = line.Split(',');
            valH = int.Parse(inputs[0]);
            valS = int.Parse(inputs[1]);
            valV = int.Parse(inputs[2]);

            valC = valS * valV / 10000;
            valX = valC * (1 - Math.Abs((valH/60)%2 - 1));
            valm = valV / 100 - valC;


            if (valH >= 0 && valH < 60) { valR = valC; valG = valX; valB = 0; }
            else if (valH >= 60 && valH < 120) { valR = valX; valG = valC; valB = 0; }
            else if (valH >= 120 && valH < 180) { valR = 0; valG = valC; valB = valX; }
            else if (valH >= 120 && valH < 180) { valR = 0; valG = valX; valB = valC; }
            else if (valH >= 240 && valH < 300) { valR = valX; valG = 0; valB = valC; }
            else if (valH >= 300 && valH < 360) { valR = valC; valG = 0; valB = valX; }


            valR = (valR + valm) * 255;
            valG = (valG + valm) * 255;
            valB = (valB + valm) * 255;

            Console.WriteLine("{0},{1},{2}",
                Math.Round(valR,0).ToString("000"), Math.Round(valG).ToString("000"), Math.Round(valB).ToString("000"));
        }
    }
}
