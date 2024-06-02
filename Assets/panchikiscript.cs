using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class panchikiscript : MonoBehaviour
{
    public scr s;
    public Rigidbody2D rigid;
    public float flapStrength;
    private bool birdAlive=true;
    public GameObject sur;
    public GameObject loser;
    public GameObject udh;
    public GameObject paused;
    // Start is called before the first frame update
    void Start()
    {
         birdAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!paused.GetComponent<pauser>().paused)
        {


            if ((Input.GetKeyDown(KeyCode.Space)||Input.GetKeyDown(KeyCode.Mouse0)) && birdAlive)
            {
                rigid.velocity = Vector2.up * flapStrength;
                udh.GetComponent<AudioSource>().Play();
            }



        }
        if (paused.GetComponent<pauser>().paused)
        {
            rigid.velocity=Vector2.zero;
            rigid.gravityScale = 0;
        }
        else
        {

            rigid.gravityScale = (float)2.27;
        }
        if(!birdAlive && Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (birdAlive)
        {
            s.gameover();
            birdAlive = false;
            sur.SetActive(false);
            loser.GetComponent<AudioSource>().Play();
        }

    }
}
