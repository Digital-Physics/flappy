using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;
    birdScript birdScript; 

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        birdScript = GameObject.FindGameObjectWithTag("Bird").GetComponent<birdScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        // this checks whether the collision was actually with the bird object, which was just a layer (#3) named "bird"
        if (collision.gameObject.layer == 3 && birdScript.birdIsAlive) {
            logic.addScore(10);
        }
    }
}
