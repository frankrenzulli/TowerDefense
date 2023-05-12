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

        Debug.Log("StandardTurret");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);

    }
    public void SelectMachineGunTurret()
    {

        Debug.Log("MachineGunTurret");
        buildManager.SetTurretToBuild(buildManager. MachineGunTurretPrefab);
    }
    public void SelectCannonTurret()
    {

        Debug.Log("CannonTurret");
        buildManager.SetTurretToBuild(buildManager.CannonTurretPrefab);

    }
}