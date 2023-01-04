using System.Collections;
using HTC.UnityPlugin.Vive;
using UnityEngine;

namespace _root.Scripts.Lesson2
{
    public class MyTeleport : Teleportable
    {
        [SerializeField] private float Speed;
        [SerializeField] private float CoolDoown;

        public override IEnumerator StartTeleport(Vector3 position, float duration)
        {
            while (true)
            {
                yield return new WaitForFixedUpdate();

                target.rotation = Vector3.MoveTowards(target.position, position, Speed * Time.deltaTime);

                Vector3 v = position;
                v.y = target.position.y;

                if (Vector3.Distance(target.position, v) < 0.1f)
                {
                    yield return new WaitForSeconds(CoolDoown);
                    teleportCoroutine = null;
                    yield break;
                }
            }
        }
    }
}