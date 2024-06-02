using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class baadalKiScript : MonoBehaviour
{
    public GameObject baadal;
    public float spawnRate;
    private float timer = 0;
    public float heightOffset;
    public GameObject paused;
    void Update()
    {
        if (!paused.GetComponent<pauser>().paused)
        {
            if (timer < spawnRate)
            {

                timer += Time.deltaTime;
            }
            else
            {
                spawn();
                timer = 0;
            }
        }
    }
    void spawn()
    {
        float low = transform.position.y - heightOffset;
        float high = transform.position.y + heightOffset;
        Instantiate(baadal, new Vector3(transform.position.x, Random.Range(low, high), 2), transform.rotation);

    }

}
