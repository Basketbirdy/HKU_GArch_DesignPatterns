using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Wave
{
    //public List<EnemyBase> enemies;
    public IWaveInfo waveInfo;

    private int maxDecoratorCount = 5;
    private Vector2 intervalRange = new Vector2(-.4f, .4f);
    private List<Type> possibleDecorators = new List<Type>();

    public Wave()
    {
        //generate list of all possible decorators
        possibleDecorators = new List<Type>()
        {
            typeof(SpawnIntervalWaveDecorator),
            typeof(ShapeWaveDecorator)
        };
        //new spawnintervalblabla
        //new shapewave
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
        //newWaveInfo = new SpawnIntervalWaveDecorator(newWaveInfo);

        //newWaveInfo = new ShapeWaveDecorator(newWaveInfo, new GroupInfo(Shape.DOT));

        //newWaveInfo = new ShapeWaveDecorator(newWaveInfo, new GroupInfo(Shape.STAR));

        //generate number of decorators
        //2 ? 3 ?
        //for number of decorators
        //{
        //add decorator list[Random.Range()]
        //}

        int randDecoratorCount = UnityEngine.Random.Range(0, maxDecoratorCount);

        for (int i = 0; i < randDecoratorCount; i++)
        {
            int rand = UnityEngine.Random.Range(0, possibleDecorators.Count);
            newWaveInfo = (IWaveInfo)Activator.CreateInstance(possibleDecorators[rand], newWaveInfo);
            Debug.Log("[Wave] Applying decorator" + possibleDecorators[rand].ToString());
        }

        return newWaveInfo;
    }
}
   
