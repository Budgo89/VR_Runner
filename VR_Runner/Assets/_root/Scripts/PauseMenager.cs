using UnityEngine;

namespace _root.Scripts
{
    public class PauseMenager : MonoBehaviour
    {
        private bool _isPause = false;

        public bool IsPause()
        {
            return _isPause;
        }

        /// <summary>
        /// Включить паузу
        /// </summary>
        public void EnablePause()
        {
            _isPause = true;
        }
        
        /// <summary>
        /// Отключить паузу
        /// </summary>
        public void DisablePause()
        {
            _isPause = false;
        }
    }
}