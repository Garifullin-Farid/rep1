
namespace Гарифуллин_Ф.М_Курсовая_работа
{
    public class Storage
    {

        public List<State> _states;
        private int _currentIndex;
        public Storage()
        {
            _states = new List<State>();
          
        }

        public void AddState(State state)
        {
            _states.Add(state);
        }

        public IEnumerable<object> IterateStates()
        {
            for (int i = 0; i < _states.Count; i++)
            {
                yield return _states[i];
            }
        }
        public void Reset()
        {
          
        }
    }
}
