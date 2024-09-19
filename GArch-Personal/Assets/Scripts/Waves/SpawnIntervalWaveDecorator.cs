using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnIntervalWaveDecorator : IWaveInfo
{
    IWaveInfo waveInfo;
    float change;
    Vector2 intervalRange = new Vector2(-0.4f, 0.4f);

    public SpawnIntervalWaveDecorator(IWaveInfo waveInfo)
    {
        this.waveInfo = waveInfo;
        change = Random.Range(intervalRange.x, intervalRange.y);
    }

    public List<GroupInfo> GetGroupInfo()
    {
        return waveInfo.GetGroupInfo();
    }

    public float GetSpawnInterval()
    {
        return waveInfo.GetSpawnInterval() + change;
    }
}
