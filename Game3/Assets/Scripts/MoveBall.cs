using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour

{
    [SerializeField] MoveBall ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 ball = new Vector2(5f, transform.position.y) ;
        transform.position = ball;
    }
}
