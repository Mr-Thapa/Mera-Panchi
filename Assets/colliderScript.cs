using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderScript : MonoBehaviour
{
    public scr s;
    // Start is called before the first frame update
    void Start()
    {
        s=GameObject.FindGameObjectWithTag("Logic").GetComponent<scr>();
    }

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        s.addScore();
    }
}
