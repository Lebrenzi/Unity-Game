using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Hazard : MonoBehaviour
    {
    private Controls player;
    public Transform start;
    public Collider2D coll;
    public bool isEntered;
    

    void Start()
    {
        player = FindObjectOfType<Controls>();
    }

    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
       
            player.transform.position = start.position;
        
    }
    public IEnumerator respawndelay()

    {
        
        player.enabled = false;
        player.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        player.GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(1);
        player.transform.position = start.position;
        player.GetComponent<Renderer>().enabled = true;
        player.enabled = true;

    }
}

