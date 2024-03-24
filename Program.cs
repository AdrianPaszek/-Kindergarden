using Kindergarden.Model;
using System;


namespace Kindergarden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kindergarden = new Kindergarten();
            Preschooler preschooler1 = new Musiclover("Ania", 3);
            Preschooler preschooler2 = new FuturePainter("Zenek", 4);
            Preschooler preschooler3 = new SoccerFan("Kazik", 2);

            Kindergarten.AddPreschooler(preschooler1);
            Kindergarten.AddPreschooler(preschooler2);
            Kindergarten.AddPreschooler(preschooler3);

            Kindergarten.PerformActivity("Sing");
            Kindergarten.PerformActivity("Dance");
            Kindergarten.PerformActivity("PlayBall");
            Kindergarten.PerformActivity("Draw");
            Kindergarten.PerformActivity("Sing");
            Kindergarten.PerformActivity("PlayBall");
            Kindergarten.PerformActivity("PlayBall");
        }
    }
}
