using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Wave
{
    //public List<EnemyBase> enemies;
    public IWaveInfo waveInfo;

    private Vector2 intervalRange = new Vector2(-.4f, .4f);

    public Wave()
    {
        waveInfo = GenerateWaveInfo();
    }

    //private List<EnemyBase> GenerateEnemyTypes()
    //{
    //    List<EnemyInfo> enemyInfos = new List<EnemyInfo>();

    //    // add random enemy infos to list

    //    return enemyInfos;
    //}

    private IWaveInfo GenerateWaveInfo()
    {
        IWaveInfo newWaveInfo = new WaveInfoBase();

        //determine what decorators to put on the wave
        newWaveInfo = new SpawnIntervalWaveDecorator(newWaveInfo, Random.Range(intervalRange.x, intervalRange.y));

        newWaveInfo = new ShapeWaveDecorator(newWaveInfo, new ShapeInfo(Shape.DOT));

        newWaveInfo = new ShapeWaveDecorator(newWaveInfo, new ShapeInfo(Shape.STAR));

        return newWaveInfo;
    }
}
   
