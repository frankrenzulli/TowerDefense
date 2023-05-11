using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [Header ("Target To Shoot")]
    private Transform Target;

    [Header("Shooting Variables")]
    public float range = 15;
    public float fireRate = 1f;
    private float fireCountdown = 0f;


    [Header("Turret Rotation")]
    public Transform RotationTurret;
    public float rotationSpeed;

    public GameObject bulletPrefab;
    public Transform firePoint;


    void Start()
    {

        InvokeRepeating("UpdateTarget", 0f, 0.5f);

    }

    void UpdateTarget()
    {
        //ricerca enemy con tag Enemy
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        //per ogni enemy nell'array enemies
        foreach (GameObject enemy in enemies)
        {
            //distanza dall'enemy
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            //se la distanza dall'enemy è minore della shortestdistance
            if(distanceToEnemy < shortestDistance)
            {
                //sceglie il nemico piu vicino
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }
        //il target diventa il nemico piu vicino dentro il range
        if(nearestEnemy != null && shortestDistance <= range)
        {
            Target = nearestEnemy.transform;
        }
        else
        {
            //Reset del target una volta uscito dal range
            Target = null;
        }

    }

    void Update()
    {
        //non fare nulla se non si trova un nemico
        if (Target == null)
            return;

        Vector3 direction = Target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(direction);
        Vector3 rotation = Quaternion.Lerp(RotationTurret.rotation, lookRotation, Time.deltaTime * rotationSpeed).eulerAngles;
        RotationTurret.rotation = Quaternion.Euler(0f, rotation.y, 0f);

        if (fireCountdown <= 0f)
        {
            Shoot();
            fireCountdown = 1f / fireRate;
        }

        fireCountdown -= Time.deltaTime;
    }

    void Shoot()
    {

        GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        BulletScript bullet = bulletGO.GetComponent<BulletScript>();

        if (bullet != null)
            bullet.LookForEnemy(Target);

    }



    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);

    }
}
