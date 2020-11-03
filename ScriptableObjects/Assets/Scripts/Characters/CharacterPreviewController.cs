#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

namespace Characters
{
    public class CharacterPreviewController : MonoBehaviour
    {
        [SerializeField] private CharacterData characterData;
        [SerializeField] private Transform[] legs;
        [SerializeField] private Transform[] knees;
        [SerializeField] private Transform chest;
        [SerializeField] private Transform neck;
        [SerializeField] private Transform[] breasts;

        private void Start()
        {
            UpdateCharacter();
        }

#if UNITY_EDITOR
        private void Update()
        {
            if (Selection.activeGameObject != gameObject)
            {
                return;
            }
            UpdateCharacter();
        }
#endif
        
        private void UpdateCharacter()
        {
            foreach (var t in legs)
            {
                t.localScale = characterData.GetLegSize(t.localScale);
            }
            
            foreach (var t in knees)
            {
                t.localScale = characterData.GetKneeSize(t.localScale);
            }
            
            foreach (var t in breasts)
            {
                t.localScale = characterData.BreastSize;
            }

            chest.localScale = characterData.ChestSize;
            neck.localScale = characterData.NeckSize;
        }
    }
}