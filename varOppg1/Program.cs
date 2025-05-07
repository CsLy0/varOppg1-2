namespace varOppg1
{
    internal class Datatyper
    {

        int tall = 1;

        float desimalTall = 1.01F; //F = nøyaktig
        double desimalTall2 = 1.01;
        decimal desimalTall3 = 1.01M; //M = veldig nøyaktig

        char bokstav = 'a';
        string tekst = "Hei";

        bool santUsant = true; //eller false

        int[] tallArray = { 1, 2, 3 };
        string[] tekstArray = { "Hei", "på", "deg" };

        List<int> listeMedTall = new List<int>(); //lager liste med tall

        public int NumberFive()
        {
            return 5;
        }
    }
}

