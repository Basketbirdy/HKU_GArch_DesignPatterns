using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveInfoBase : IWaveInfo
{
    public List<GroupInfo> GetGroupInfo()
    {
        List<GroupInfo> shapes = new List<GroupInfo>();

        // make sure the wave has at least one group
        shapes.Add(new GroupInfo(Shape.DOT));

        return shapes;
    }

    public float GetSpawnInterval()
    {
        return 1;
    }
}
