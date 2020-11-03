using UnityEngine;

namespace Characters
{
    [CreateAssetMenu(fileName = "Character", menuName = "Characters/Rin", order = 0)]
    public class CharacterData : ScriptableObject
    {
        [Range(0.75f, 1.25f)] [SerializeField] private float legSize = 1f;
        [Range(0.75f, 1.4f)] [SerializeField] private float kneeSize = 1f;
        [Range(0.9f, 1.1f)] [SerializeField] private float chestSize = 1f;
        [Range(0.8f, 1.4f)] [SerializeField] private float neckSize = 1f;
        [Range(0.75f, 1.3f)] [SerializeField] private float breastSize = 1f;

        public Vector3 GetLegSize(Vector3 size)
        {
            return new Vector3(legSize, size.y, legSize);
        }
        
        public Vector3 GetKneeSize(Vector3 size)
        {
            return new Vector3(kneeSize, size.y, kneeSize);
        }

        public Vector3 ChestSize => new Vector3(chestSize, chestSize, chestSize);

        public Vector3 NeckSize => new Vector3(neckSize, neckSize, neckSize);

        public Vector3 BreastSize => new Vector3(breastSize, breastSize, breastSize);
    }
}