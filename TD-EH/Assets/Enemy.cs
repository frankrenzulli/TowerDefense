using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5f; // Velocità dell'oggetto
    public Vector3 direction; // Direzione di movimento dell'oggetto

    private void Update()
    {
        direction = new Vector3(1, 0, 0);
        // Muovi l'oggetto nella direzione specificata alla velocità specificata
        transform.position += direction * speed * Time.deltaTime;
    }
}

