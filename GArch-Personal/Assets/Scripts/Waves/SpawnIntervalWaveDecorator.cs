using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnIntervalWaveDecorator : IWaveInfo
{
    private IWaveInfo waveInfo;
    private float change;
    private Vector2 intervalRange = new Vector2(-0.4f, 0.4f);

    public SpawnIntervalWaveDecorator(IWaveInfo _waveInfo)
    {
        waveInfo = _waveInfo;
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
