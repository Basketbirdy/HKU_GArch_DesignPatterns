using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Wave
{
    public List<EnemyInfo> enemies;
    public IWaveInfo waveInfo;

    private Vector2 intervalRange = new Vector2(-.4f, .4f);

    public Wave()
    {
        enemies = GenerateEnemyTypes();
        waveInfo = GenerateWaveInfo();
    }

    private List<EnemyInfo> GenerateEnemyTypes()
    {
        List<EnemyInfo> enemyInfos = new List<EnemyInfo>();

        // add random enemy infos to list


        return enemyInfos;
    }

    private IWaveInfo GenerateWaveInfo()
    {
        IWaveInfo newWaveInfo = new WaveInfoBase();

        //determine what decorators to put on the wave
        newWaveInfo = new SpawnIntervalWaveDecorator(newWaveInfo, Random.Range(intervalRange.x, intervalRange.y));

        newWaveInfo = new SquareShapeWaveDecorator(newWaveInfo);

        newWaveInfo = new StarShapeWaveDecorator(newWaveInfo);

        return newWaveInfo;
    }
}
   
