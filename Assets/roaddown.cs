using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roaddown : MonoBehaviour {
   
    [SerializeField]
    private GameObject startFinish;
    [SerializeField]
   private GameObject Manager;
	// Use this for initialization
	void Start () {
        transform.position = new Vector3(0, transform.position.y - 1, 0);
	}
	
	// Update is called once per frame
	void Update () {
        if (GameScript.go == true)
        {
            transform.position = new Vector3(0, transform.position.y - GameScript.speed, 0);
        }
        if (transform.position.y < -10)
        {
            transform.position = new Vector3(0, 10, 0);
            GameScript.speed *= 2;
        }
	}
}
