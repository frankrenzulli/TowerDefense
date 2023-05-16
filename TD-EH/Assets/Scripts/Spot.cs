using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spot : MonoBehaviour
{

    private GameObject turret;

    //color variables
    public Color hoverColor;
    private Color startColor;

    //refs
    private Renderer rend;
    BuildManager buildManager;
    // Lista di torrette nello stesso spot
    private List<GameObject> turrets = new List<GameObject>();

    public float turretHeight = 1f;



    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = BuildManager.instance;

    }

    private void OnMouseDown()
    {

        if (buildManager.GetTurretToBuild() == null)
            return;
        if (GameManager.money > 0)
        {
            GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
            Vector3 turretPosition = transform.position + Vector3.up * turretHeight * turrets.Count + Vector3.up * turretToBuild.GetComponent<Renderer>().bounds.size.y / 1.25f;
            GameObject turret = (GameObject)Instantiate(turretToBuild, turretPosition, transform.rotation);
            GameManager.instance.RemoveMoney(100);

            turrets.Add(turret);
        }

    }

    private void OnMouseEnter()
    {
        if (buildManager.GetTurretToBuild() == null)
            return;
        rend.material.color = hoverColor;
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
