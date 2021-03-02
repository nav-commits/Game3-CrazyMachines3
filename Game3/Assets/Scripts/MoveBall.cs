using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public float speed = 0.5f;


    void Update()
    {
        Move();

    }

    public void Move()
    {
        var move = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        var newpos = transform.position.x + move;
        transform.position = new Vector2(newpos, transform.position.y);
    }
}


