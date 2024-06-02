using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public float khambeKiGati;
    public GameObject paused;
    void Start()
    {
        paused = GameObject.FindGameObjectWithTag("Paused");
    }

    // Update is called once per frame
    void Update()
    {
        if (!paused.GetComponent<pauser>().paused)
        {
            transform.position += Vector3.left * khambeKiGati * Time.deltaTime;
            if (transform.position.x < -40)
            {
                Destroy(gameObject);
                Debug.Log("Baadal Baras gye");
            }
        }

    }
}
