using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class khambeKiScript : MonoBehaviour
{
    public float khambeKiGati=5;
    public GameObject paused;
    // Start is called before the first frame update
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
            if (transform.position.x < -20)
            {
                Debug.Log("Khamba Gir gya");
                Destroy(gameObject);
            }
        }
    }
}
