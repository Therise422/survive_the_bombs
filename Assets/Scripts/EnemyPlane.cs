using System;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyPlane : MonoBehaviour
{
    public string callsign = "su90";
    public int hitPoints = 100;
    private int currentHitPoints;
    private EnemyPlaneEntry ui;

    void Start()
    {
        currentHitPoints = hitPoints;
        EnemyPlaneUI.Instance.Add(this);
    }

    public void Hit(int damage)
    {
        currentHitPoints -= damage;
        UpdateUI();
        if (currentHitPoints < 1)
        {
            Destroy(gameObject);
        }
    }

    private void UpdateUI()
    {
        ui.ChangeValues(callsign, (float)currentHitPoints / (float)hitPoints);
    }

    public void Subscribe(EnemyPlaneEntry enemyPlaneEntry)
    {
        ui = enemyPlaneEntry;
        UpdateUI();
    }
}
