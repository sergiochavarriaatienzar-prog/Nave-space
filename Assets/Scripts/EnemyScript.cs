using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        // Si pasa al jugador → GAME OVER
        if (transform.position.y < -5f)
        {
            GameManagerScript.instance.GameOver();
        }
    }
}
