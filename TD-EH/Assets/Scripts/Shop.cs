using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{

    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void SelectStandardTurret()
    {
        if (GameManager.money >= 100)
        {
            Debug.Log("StandardTurret");
            buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
        }
    }
    public void SelectMachineGunTurret()
    {
        if (GameManager.money >= 150)
        {
            Debug.Log("MachineGunTurret");
            buildManager.SetTurretToBuild(buildManager.MachineGunTurretPrefab);
        }
    }
    public void SelectCannonTurret()
    {
        if (GameManager.money >= 250)
        {
            Debug.Log("CannonTurret");
            buildManager.SetTurretToBuild(buildManager.CannonTurretPrefab);
        }

    }
    public void SelectDamageBuff()
    {
        if (GameManager.money >= 150)
        {
            Debug.Log("CannonTurret");
            buildManager.SetTurretToBuild(buildManager.DamageBuffPrefab);
        }

    }
    public void SelectRangeBuff()
    {
        if (GameManager.money >= 150)
        {
            Debug.Log("CannonTurret");
            buildManager.SetTurretToBuild(buildManager.RangeBuffPrefab);
        }

    }
    public void SelectFireRateBuff()
    {
        if (GameManager.money >= 150)
        {
            Debug.Log("CannonTurret");
            buildManager.SetTurretToBuild(buildManager.FireRateBuffPrefab);
        }

    }
}
