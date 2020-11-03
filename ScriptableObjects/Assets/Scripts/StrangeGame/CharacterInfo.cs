using UnityEngine;

namespace StrangeGame
{
    [CreateAssetMenu(fileName = "CharacterInfo", menuName = "Characters/CharacterInfo", order = 0)]
    public class CharacterInfo : ScriptableObject
    {
        [SerializeField] private FloatReference hp;
        [SerializeField] private FloatReference speed;

        public FloatReference Hp => hp;

        public FloatReference Speed => speed;
    }
}