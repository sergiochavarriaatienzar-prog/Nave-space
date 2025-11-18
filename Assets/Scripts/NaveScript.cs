using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveScript : MonoBehaviour
{
    private Rigidbody2D rb;

    [Header("Movimiento")]
    public float movementSpeed = 7f;

    [Header("Disparo")]
    public GameObject balaPrefab;
    public Transform puntoDisparo;
    public float fireRate = 0.3f;   // tiempo entre disparos
    private float nextFireTime = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Disparo con cooldown
        if (Input.GetKey(KeyCode.Space) && Time.time >= nextFireTime)
        {
            Disparar();
            nextFireTime = Time.time + fireRate;
        }
    }

    void FixedUpdate()
    {
        float movement = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(movement * movementSpeed, 0f);
    }

    void Disparar()
    {
        Instantiate(balaPrefab, puntoDisparo.position, Quaternion.identity);
    }
}
