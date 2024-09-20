using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareShapeWaveDecorator : IWaveInfo
{
    IWaveInfo waveInfo;

    public SquareShapeWaveDecorator(IWaveInfo waveInfo)
    {
        this.waveInfo = waveInfo;
    }

    public List<GroupInfo> GetGroupInfo()
    {
        List<GroupInfo> decoratedShapes = waveInfo.GetGroupInfo();
        decoratedShapes.Add(new GroupInfo(Shape.SQUARE));
        return decoratedShapes;
    }

    public float GetSpawnInterval()
    {
        return waveInfo.GetSpawnInterval();
    }
}
