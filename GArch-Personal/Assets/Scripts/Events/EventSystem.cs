using System;
using System.Collections.Generic;
using UnityEngine;

public enum EventType
{
    WAVE_GENERATE,
    WAVE_START,
    WAVE_END
}

public static class EventSystem<T>
{
    public static Dictionary<EventType, Action<T>> events = new Dictionary<EventType, Action<T>>();

    public static void AddListener(EventType _eventType, Action<T> _function)
    {
        if (!events.ContainsKey(_eventType))
        {
            events.Add(_eventType, null);
        }

        events[_eventType] += _function;
    }

    public static void RemoveListener(EventType _eventType, Action<T> _function)
    {
        if (events.ContainsKey(_eventType) && events[_eventType] != null)
        {
            events[_eventType] -= _function;
        }
        else if (events[_eventType] == null) { Debug.Log("[EventSystem] Action does not exist within EventType"); }
        else { Debug.Log("[EventSystem] EventType does not exist"); }

    }

    public static void InvokeEvent(EventType _eventType, T _arg)
    {
        if (events.ContainsKey(_eventType))
        {
            events[_eventType]?.Invoke(_arg);
        }
        else { Debug.Log("[EventSystem] EventType does not exist"); }
    }

    public static void DebugEvents(EventType _eventType)
    {
        if (events.ContainsKey(_eventType))
        {
            Debug.Log(events[_eventType]);
        }
    }
}


