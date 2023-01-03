using System;
using UnityEngine;

namespace _root.Scripts
{
    public class CollisionWithObstacle : MonoBehaviour
    {
        private PlayersHealth _playersHealth;

        private void Start()
        {
            _playersHealth = GameObject.FindObjectOfType<PlayersHealth>();
        }

        private void OnTriggerEnter(Collider other)
        {
            
            Debug.Log("Удар");
            _playersHealth.SetHp();
            
            this.gameObject.SetActive(false);
        }
    }
}