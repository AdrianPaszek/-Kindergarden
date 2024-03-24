

namespace Kindergarden.Model
{
    class FuturePainter : Preschooler
    {
        public FuturePainter(string name, int initialSatisfaction) : base(name, initialSatisfaction)
        {

        }
        public void Sing()
        {
            
        }

        public void Dance()
        {
            
        }

        public void PlayBall()
        {
            ChangeSatisfaction(-2);
        }

        public void Draw()
        {
            ChangeSatisfaction(4);
        }
    }
}
