using System.Collections.Generic;
using UnityEngine;

namespace GameEvents
{
    [CreateAssetMenu(fileName = "GameEvent", menuName = "Items/GameEvent")]
    public class GameEvent : ScriptableObject
    {
        private readonly List<GameEventsListener> listeners = new List<GameEventsListener>();
        
        public void Raise()
        {
            for (int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].OnEventRaised();
            }
        }

        public void RegisterListener(GameEventsListener listener)
        {
            listeners.Add(listener);
        }
        
        public void UnregisterListener(GameEventsListener listener)
        {
            listeners.Remove(listener);
        }
    }
}
