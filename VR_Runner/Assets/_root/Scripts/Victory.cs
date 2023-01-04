using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _root.Scripts
{
    public class Victory : MonoBehaviour
    {
        [SerializeField] private float _distansVictory = 1000;
        [SerializeField] private GameObject _player;
        [SerializeField] private PauseMenager _pauseMenager;
        [SerializeField] private GameObject _settingsMenu;
        [SerializeField] private PlayersBonus _playersBonus;
        
        [SerializeField] private TMP_Text _text;
         
        [SerializeField] private Button _continueButton;
        
        private void Update()
        {
            if (_pauseMenager.IsPause())
                return;

            var dis = Vector3.Distance(_player.transform.position, new Vector3(0, 0, 0));
            if (dis >= _distansVictory)
                StartVictory();
        }

        private void StartVictory()
        {
            _pauseMenager.EnablePause();
            _settingsMenu.SetActive(true);
            _continueButton.gameObject.SetActive(false);
            _text.gameObject.SetActive(true);
            _text.text = $"Победа, наброно {_playersBonus.GetBonus().ToString()} очков";
        }
    }
}