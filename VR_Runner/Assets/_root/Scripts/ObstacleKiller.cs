using System;
using System.Collections.Generic;
using UnityEngine;

namespace _root.Scripts
{
    public class ObstacleKiller : MonoBehaviour
    {
        [SerializeField] private Transform _plauer;
        [SerializeField] private ObstacleSpawner _spawner;
        [SerializeField] private float _killDisnranceZ;

        private void Update()
        {
            List<Transform> obstacles = _spawner.spawnedObstacles;
            for (int i = 0; i < obstacles.Count; i++)
            {
                if (_plauer.position.z > obstacles[i].position.z + _killDisnranceZ)
                    Destroy(obstacles[i].gameObject);
            }
        }
    }
}