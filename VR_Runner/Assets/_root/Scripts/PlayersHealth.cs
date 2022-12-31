using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace _root.Scripts
{
    public class PlayersHealth : MonoBehaviour
    {
        [SerializeField] private int _hp = 10;
        [SerializeField] private PauseMenager _pauseMenager;
        [SerializeField] private GameObject _settingsMenu;
        [SerializeField] private TMP_Text _text;
         
        [SerializeField] private Button _continueButton;
        
        public void SetHp()
        {
            _hp--;
        }

        public void Update()
        {
            if (_pauseMenager.IsPause())
                return;

            if (_hp <= 0)
            {
                _pauseMenager.EnablePause();
                GameOwer();
            }
        }

        private void GameOwer()
        {
            _settingsMenu.gameObject.SetActive(true);
            _continueButton.gameObject.SetActive(false);
            _text.gameObject.SetActive(true);
            _text.text = "Порожение";
        }
    }
}