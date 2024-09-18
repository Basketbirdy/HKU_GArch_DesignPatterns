using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnIntervalWaveDecorator : IWaveInfo
{
    IWaveInfo waveInfo;
    float change;

    public SpawnIntervalWaveDecorator(IWaveInfo waveInfo, float change)
    {
        this.waveInfo = waveInfo;
        this.change = change;
    }

    public List<ShapeInfo> GetShapeInfo()
    {
        return waveInfo.GetShapeInfo();
    }

    public float GetSpawnInterval()
    {
        return waveInfo.GetSpawnInterval() + change;
    }
}
