using System;
using UnityEngine;

namespace _root.Scripts
{
    public class BonusManeger : MonoBehaviour
    {
        private PlayersBonus _playersBonus;

        private void Start()
        {
            _playersBonus = GameObject.FindObjectOfType<PlayersBonus>();
        }

        private void OnTriggerEnter(Collider other)
        {
            _playersBonus.SetBonus();
            Debug.Log("Есть контакт");
            this.gameObject.SetActive(false);
        }
    }
}