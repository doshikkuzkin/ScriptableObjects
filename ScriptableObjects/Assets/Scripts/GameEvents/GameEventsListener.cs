using System;
using UnityEngine;
using UnityEngine.Events;

namespace GameEvents
{
    public class GameEventsListener : MonoBehaviour
    {
        [SerializeField] private GameEvent Event;
        [SerializeField] private UnityEvent Response;
        public void OnEventRaised()
        {
            Response.Invoke();
        }

        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.UnregisterListener(this);
        }
    }
}