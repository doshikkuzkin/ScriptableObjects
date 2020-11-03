using System;
using UnityEngine;
using UnityEngine.UI;

namespace Sound
{
    public class SoundButton : MonoBehaviour
    {
        [SerializeField] private Button button;
        [SerializeField] private Text buttonText;

        private string id;
        private Action<string> OnPlaySoundCallback;

        public void Setup(string soundId, Action<string> callback)
        {
            buttonText.text = soundId;
            id = soundId;
            OnPlaySoundCallback = callback;
        }

        private void OnEnable()
        {
            button.onClick.AddListener(OnSoundButtonClicked);
        }

        private void OnDisable()
        {
            button.onClick.RemoveListener(OnSoundButtonClicked);
        }

        private void OnSoundButtonClicked()
        {
            OnPlaySoundCallback?.Invoke(id);
        }
    }
}