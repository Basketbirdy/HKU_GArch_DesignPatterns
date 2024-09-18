using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveInfoBase : IWaveInfo
{
    public List<ShapeInfo> GetShapeInfo()
    {
        List<ShapeInfo> shapes = new List<ShapeInfo>();
        
        return shapes;
    }

    public float GetSpawnInterval()
    {
        return 1;
    }
}
