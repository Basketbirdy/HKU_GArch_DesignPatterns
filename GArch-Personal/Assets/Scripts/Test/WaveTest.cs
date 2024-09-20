using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class WaveTest : MonoBehaviour
{
    IWaveInfo waveInfo;
    List<GroupInfo> shapes = new List<GroupInfo>();

    private void Start()
    {
        //Debug.Log("[Wave]----------------------------------------------- ");

        //waveInfo = new WaveInfoBase();

        //DebugWaveInfo();

        //waveInfo = new ShapeWaveDecorator(waveInfo, new GroupInfo(Shape.SQUARE));

        //waveInfo = new ShapeWaveDecorator(waveInfo, new GroupInfo(Shape.STAR));

        //DebugWaveInfo();

        ////waveInfo = new SpawnIntervalWaveDecorator(waveInfo, -.2f);

        //DebugWaveInfo();

        //Debug.Log("----------------------------------------------------- ");
    }

    private void DebugWaveInfo()
    {
        Debug.Log("[Wave] SpawnInterval: ");
        Debug.Log("[Wave] " + waveInfo.GetSpawnInterval().ToString());

        shapes = waveInfo.GetGroupInfo();
        Debug.Log("[Wave] Spawn Shapes: ");
        if (shapes.Count == 0) { Debug.Log("[Wave] -"); }
        foreach (GroupInfo shapeInfo in shapes)
        {
            Debug.Log("[Wave] Shape: " + shapeInfo.shape.ToString() + "; Direction: " + shapeInfo.direction.ToString());
        }
    }
}
