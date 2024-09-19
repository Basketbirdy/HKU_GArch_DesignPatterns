using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveHandler : MonoBehaviour
{
    [SerializeField] IWaveInfo[] possibleWaveInfos;

    [SerializeField] Wave currentWave;

    private int waveCount = 0;

    private void OnEnable()
    {
        EventSystem<int>.AddListener(EventType.WAVE_END, OnWaveEnd);
        EventSystem<int>.AddListener(EventType.WAVE_GENERATE, CreateNewWave);
    }

    private void OnDisable()
    {
        EventSystem<int>.RemoveListener(EventType.WAVE_END, OnWaveEnd);
        EventSystem<int>.RemoveListener(EventType.WAVE_GENERATE, CreateNewWave);
    }

    private Wave GenerateWave()
    {
        Wave newWave = new Wave();
        return newWave;
    }

    private void CreateNewWave(int nullable)
    {
        // generate wave
        currentWave = GenerateWave();

        // get the wave to spawn through enemy handler
        EventSystem<Wave>.InvokeEvent(EventType.WAVE_START, currentWave);
    }

    // trigger 
    private void OnWaveEnd(int arg)
    {
        Debug.Log("[Wavehandler] Wave ended (entering grace period)");
        // start timer for grace period between waves

        // trigger new wave
        Debug.Log("[Wavehandler] Grace period over generating a new wave");
        EventSystem<int>.InvokeEvent(EventType.WAVE_GENERATE, 0);
    }
}
