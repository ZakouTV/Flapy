using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class pipemove : MonoBehaviour
{
    public float deal = -80f;
    public float movements = 5f ;
    public float accelerationspeed = 0.1f;
    private float currentmovement;
    
    void Start()
    {
        currentmovement = movements;
    }

    void Update()
    {
 
        transform.position += Vector3.left * movements * Time.deltaTime;
        accelerationspeed += currentmovement * Time.deltaTime;
        if (transform.position.x < deal)
        {
            //Debug.Log("tower deleted");
            Destroy(gameObject);
        }

    }
}
