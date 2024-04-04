using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class pipespawn : MonoBehaviour
{
    public GameObject oldpipe;
    public float spawntimes = 2;
    private float timer = 0;
    public float height = 10;
    // Start is called before the first frame update

    void Start()
    {
        spawns();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawntimes)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawns();
            timer = 0;
        }

    }
    void spawns()
    {
        float lowerheight = transform.position.y - height;
        float higherheight = transform.position.y + height;
        Instantiate(oldpipe, new Vector3(transform.position.x, Random.Range(lowerheight, higherheight), 0), transform.rotation);

    }


}
