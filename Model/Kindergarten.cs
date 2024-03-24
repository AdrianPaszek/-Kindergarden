using System;
using System.Collections.Generic;


namespace Kindergarden.Model
{
    public class Kindergarten
    {
        private List<Preschooler> preschoolers = new List<Preschooler>();
        public void AddPreschooler(Preschooler preschooler)
        {
            preschoolers.Add(preschooler);
        }

        public void PerformActivity(string activity)
        {
            int cryingPreschooler = 0;

            foreach (var preschooler in preschoolers)
            { switch (activity)
                {
                    case "Sing":
                        if(preschooler is Musiclover musiclover)
                        {
                            musiclover.Sing();
                        }
                        else
                        {
                            preschooler.Cry();
                        }
                        break;
                    case "Dance":
                        if (preschooler is Musiclover || preschooler is FuturePainter)
                        {
                            continue;
                        }
                        break;
                    case "PlayBall":
                        if (preschooler is SoccerFan soccerFan)
                        {
                            soccerFan.PlayBall();
                        }
                        else 
                        {
                            preschooler.Cry();
                        }
                        break;
                    case "Draw":
                        if (preschooler is FuturePainter futurePainter)
                            futurePainter.Draw();
                        else
                        {
                            preschooler.Cry();
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Invalid activity!");
                        }
                        break;
                }

                if (preschooler.Satisfaction == 0)
                    { 
                        cryingPreschooler++;
                    } 
            }
            if (cryingPreschooler >= 3)
            {
                Console.WriteLine("The kindergarten teacher can no longer maintain order!");
            }
        }
    }
}
