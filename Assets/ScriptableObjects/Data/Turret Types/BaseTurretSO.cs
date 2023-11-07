﻿using Turret;
using UnityEngine;
using static EnemySO;

[CreateAssetMenu(fileName = "New Base Turret", menuName = "Create Turret/Base Turret")]
public class BaseTurretSO : ScriptableObject
{
    public enum TurretTypes
    {
        Proyectile,
        Dispersion,
        Explosive,
        Defense,
        BadDefense,
    }

    public TurretTypes turretType;
    public BaseTurret asset;
    public float maxHealth;
    public Sprite sprite;
    public float deathTime = 0.8f;
}