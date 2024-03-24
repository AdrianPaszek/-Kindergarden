

namespace Kindergarden.Model
{
    public class Musiclover : Preschooler
    {
        public Musiclover(string name, int initialSatisfaction) : base(name, initialSatisfaction)
        {

        }


        public void Sing() 
        {
            ChangeSatisfaction(4);
        }

        public void Dance()
        {

        }

        public void PlayBall()
        {
            ChangeSatisfaction(-1);
        }
    }
}
