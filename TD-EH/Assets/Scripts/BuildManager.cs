using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    private void Awake()
    {
        instance = this;
    }
    public GameObject standardTurretPrefab;
    public GameObject MachineGunTurretPrefab;
    public GameObject CannonTurretPrefab;
    public GameObject DamageBuffPrefab;
    public GameObject RangeBuffPrefab;
    public GameObject FireRateBuffPrefab;

    private GameObject turretToBuild;


    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    public void SetTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }
    
}
