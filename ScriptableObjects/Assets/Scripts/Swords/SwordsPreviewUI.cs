using System;
using UnityEngine;
using UnityEngine.UI;

namespace Swords
{
    public class SwordsPreviewUI : MonoBehaviour
    {
        [SerializeField] private SwordData swordData;
        
        [SerializeField] private Transform rootPoint;
        
        [SerializeField] private Text nameLabel;
        [SerializeField] private Text descriptionLabel;
        [SerializeField] private Text costLabel;
        [SerializeField] private Text damageLabel;
        
        [SerializeField] private Image iconImage;

        private GameObject swordObject;

        private void Start()
        {
            SetupData();
        }

        private void Update()
        {
            rootPoint.Rotate(Time.deltaTime * swordData.RotationSpeed * Vector3.up, Space.World);
        }

        public void SetupData()
        {
            if (swordObject!=null)
            {
                Destroy(swordObject);
            }
            
            swordObject = Instantiate(swordData.Prefab, rootPoint);
            nameLabel.text = swordData.SwordName;
            descriptionLabel.text = swordData.Description;
            costLabel.text = $"Cost: {swordData.Cost}";
            damageLabel.text = $"Damage: {swordData.Damage}";
            iconImage.sprite = swordData.Icon;
        }
    }
}
