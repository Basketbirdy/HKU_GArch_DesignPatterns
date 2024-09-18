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

    public static void AddListener(EventType eventType, Action<T> function)
    {
        if (!events.ContainsKey(eventType))
        {
            events.Add(eventType, null);
        }

        events[eventType] += function;
    }

    public static void RemoveListener(EventType eventType, Action<T> function)
    {
        if (events.ContainsKey(eventType) && events[eventType] != null)
        {
            events[eventType] -= function;
        }
        else if (events[eventType] == null) { Debug.Log("[EventSystem] Action does not exist within EventType"); }
        else { Debug.Log("[EventSystem] EventType does not exist"); }

    }

    public static void InvokeEvent(EventType eventType, T arg)
    {
        if (events.ContainsKey(eventType))
        {
            events[eventType]?.Invoke(arg);
        }
        else { Debug.Log("[EventSystem] EventType does not exist"); }
    }

    public static void DebugEvents(EventType eventType)
    {
        if (events.ContainsKey(eventType))
        {
            Debug.Log(events[eventType]);
        }
    }
}


