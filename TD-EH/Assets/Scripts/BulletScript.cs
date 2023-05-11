using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Transform target;

    public float speed = 70f;

    public void LookForEnemy(Transform _target)
    {
        target = _target;
    }

    void Update()
    {
        
        if(target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 direction = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if(direction.magnitude <= distanceThisFrame)
        {

            HitTarget();
            return;
        }
        transform.Translate(direction.normalized * distanceThisFrame, Space.World);
    }

    void HitTarget()
    {
        Debug.Log("We hit something");
    }
}
