using UnityEngine;

public class DestroyBlocks : MonoBehaviour
{

    public int cost;
    private void Start()
    {
        //GameManager.money -= cost;
    }
    void Update()
    {
        DestroyBlock();
    }
    private void OnDestroy()
    {
        GameManager.instance.AddMoney(cost);
    }
    public void DestroyBlock()
    {
        if (Input.GetMouseButtonDown(1)) 
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
            RaycastHit hit; 


            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                GameManager.instance.AddMoney(cost);

                Destroy(gameObject);
            }
            
        }
        
    }
}