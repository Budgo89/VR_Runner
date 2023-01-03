using UnityEngine;

namespace _root.Scripts
{
    public class PlayersBonus : MonoBehaviour
    {
        private int _bonus;

        public int GetBonus()
        {
            return _bonus;
        }

        public void SetBonus()
        {
            _bonus++;
        }
    }
}