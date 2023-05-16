using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int Health, maxHealth = 100;
    [SerializeField] Slider healthBar;

    private void Awake()
    {
        healthBar = GetComponentInChildren<Slider>();
    }
    private void Start()
    {
        Health = maxHealth;
        healthBar.value = Health ;
    }
    public void TakeDamage(int damage)
    {
        Debug.Log("prendo danno");
        Health -= damage;
        healthBar.value = Health;
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
        
    }
}
