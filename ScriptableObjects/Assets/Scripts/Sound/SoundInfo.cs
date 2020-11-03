using UnityEngine;

namespace Sound
{
    [CreateAssetMenu(fileName = "SoundInfo", menuName = "Sound/SoundInfo", order = 0)]
    public class SoundInfo : ScriptableObject
    {
        [SerializeField] private string id;
        [SerializeField] private AudioClip clip;
        [SerializeField] private bool loop;
        [SerializeField] [Range(0, 1f)] private float volume = 1f;
        [SerializeField] [Range(0, 3f)] private float pitch = 1f;

        public string ID => id;

        public AudioClip Clip => clip;

        public bool Loop => loop;

        public float Volume => volume;

        public float Pitch => pitch;
    }
}