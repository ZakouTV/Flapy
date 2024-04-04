using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyerscript : MonoBehaviour
{

    public Rigidbody2D rb;
    public float velocitybird;
    public bool flyer = true;
    public Logicadmin logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logicadmin>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && flyer == true)
        {
            rb.velocity = Vector2.up * velocitybird;
        }
    }
   public void OnCollisionEnter2D(Collision2D collision)
    {
        logic.newscene();
        flyer = false;
    } 
}
