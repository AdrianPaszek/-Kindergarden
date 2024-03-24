

namespace Kindergarden.Model
{
    public class SoccerFan : Preschooler
    {
        public SoccerFan(string name, int initialSatisfaction) : base(name, initialSatisfaction)
        {

        }
        public void Sing()
        {
            ChangeSatisfaction(-1);
        }

        public void Dance()
        {

        }

        public void PlayBall() 
        {
            ChangeSatisfaction(3);
        }

        public void Draw()
        {
            ChangeSatisfaction(-1);
        }

    }
}
