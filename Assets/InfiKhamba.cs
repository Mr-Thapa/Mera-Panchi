using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class InfiKhamba : MonoBehaviour
{
    public GameObject khamba;
    public float spawnRate;
    private float timer;
    public float heightOffset;
    public GameObject paused;
    // Start is called before the first frame update
    void Start()
    {
        spawn();

    }

    // Update is called once per frame
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
                timer = 0;
                spawn();

            }

        }
    }
        void spawn()
        {
            float low = transform.position.y - heightOffset;
            float high = transform.position.y + heightOffset;
            Instantiate(khamba, new Vector3(transform.position.x, Random.Range(low, high), 0), transform.rotation);

        }
    
}
