using GameEvents;
using UnityEngine;

namespace Swords
{
    [CreateAssetMenu(fileName = "SwordData", menuName = "Items/Swords", order = 0)]
    public class SwordData : ScriptableObject
    {
        [SerializeField] private string swordName;
        [SerializeField] private string description;
        [SerializeField] private GameObject prefab;
        [SerializeField] private Sprite icon;
        [SerializeField] private int cost;
        [SerializeField] private int damage;

        [Range(0, 180f)] [SerializeField] private float rotationSpeed;

        public string SwordName => swordName;

        public string Description => description;

        public GameObject Prefab => prefab;

        public Sprite Icon => icon;

        public int Cost => cost;

        public int Damage => damage;

        public float RotationSpeed => rotationSpeed;

        [SerializeField] private GameEvent updateEvent;

        [ContextMenu("Update Event")]
        public void UpdateData()
        {
            updateEvent.Raise();
        }
    }
}
