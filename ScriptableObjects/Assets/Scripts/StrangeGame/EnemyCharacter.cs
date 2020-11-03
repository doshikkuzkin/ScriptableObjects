using System;
using UnityEngine;

namespace StrangeGame
{
    public class EnemyCharacter : CharacterBase
    {
        [SerializeField] private Transform player;
        [SerializeField] private FloatVariable playerHp;

        protected void Update()
        {
            if (Mathf.Abs(player.transform.position.x - transform.position.x) > 1f)
            {
                transform.Translate(Time.deltaTime * characterInfo.Speed * transform.forward, Space.World);
                return;
            }

            playerHp.Value -= Time.deltaTime;
        }
    }
}