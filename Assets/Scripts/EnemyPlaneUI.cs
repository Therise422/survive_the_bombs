using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlaneUI : MonoBehaviour
{
    public static EnemyPlaneUI Instance;
    public EnemyPlaneEntry uiPrefab;

    internal void Add(EnemyPlane enemyPlane)
    {
        EnemyPlaneEntry entry = Instantiate(uiPrefab, transform);
        entry.ConnectTo(enemyPlane);
    }

    void Awake()
    {
        Instance = this;
    }

}
