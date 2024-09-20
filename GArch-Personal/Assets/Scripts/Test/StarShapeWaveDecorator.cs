using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarShapeWaveDecorator : IWaveInfo
{
    IWaveInfo waveInfo;

    public StarShapeWaveDecorator(IWaveInfo waveInfo)
    {
        this.waveInfo = waveInfo;
    }

    public List<GroupInfo> GetGroupInfo()
    {
        List<GroupInfo> decoratedShapes = waveInfo.GetGroupInfo();
        decoratedShapes.Add(new GroupInfo(Shape.STAR));
        return decoratedShapes;
    }

    public float GetSpawnInterval()
    {
        return waveInfo.GetSpawnInterval();
    }
}
