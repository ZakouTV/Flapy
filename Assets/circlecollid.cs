using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circlecollid : MonoBehaviour
{

    public bool isOutOfCamera;
    public Camera mainCamera;
    public Logicadmin logic;
    public float move;
    public Transform trans;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        move = trans.position.y;
        bool movementtrue = move < -120 || move > 40;
        if (movementtrue)
        {
            logic.newscene();
            
        }


    }
}
