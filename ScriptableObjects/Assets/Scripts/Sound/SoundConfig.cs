using System.Linq;
using UnityEngine;

namespace Sound
{
    [CreateAssetMenu(fileName = "SoundConfig", menuName = "Sound/SoundConfig", order = 0)]
    public class SoundConfig : ScriptableObject
    {
        [SerializeField] private SoundGroup[] groups;

        public string[] GetGroupsIds()
        {
            return groups.Select(soundGroup => soundGroup.ID).ToArray();
        }

        public string[] GetSoundsIds(string groupId)
        {
            var soundGroup = groups.FirstOrDefault(group => group.ID == groupId);
            return soundGroup == null ? null : soundGroup.GetIds();
        }

        public SoundInfo GetSoundInfo(string id)
        {
            foreach (var soundGroup in groups)
            {
                var sound = soundGroup.GetSoundInfo(id);
                if (sound != null)
                {
                    return sound;
                }
            }

            return null;
        }
    }
}