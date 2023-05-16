using Unity.VisualScripting;
using UnityEngine;

public class BuffBlocks : MonoBehaviour
{
    public float rangeBuff = 5f;
    public float firerateBuff = 10f;
    public int damageBuff = 20;

    public bool isFirerateBuff = false;
    public bool isDamageBuff = false;
    public bool isRangeBuff = false;
    void Start()
    {

        GameObject[] turretObjects = GameObject.FindGameObjectsWithTag("turret");

        foreach (GameObject turretObject in turretObjects)
        {

            if (turretObject.transform.position.x == transform.position.x &&
                turretObject.transform.position.z == transform.position.z)
            {

                Turret turretScript = turretObject.GetComponent<Turret>();

                if (isRangeBuff)
                {
                    turretScript.RangeBuff(rangeBuff);
                }
                else if (isFirerateBuff)
                {
                    turretScript.FirerateBuff(firerateBuff);
                }else if (isDamageBuff)
                {
                    turretScript.DamageBuff(damageBuff);
                }
            }
        }
        
    }
    
    }




