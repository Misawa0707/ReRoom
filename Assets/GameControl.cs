using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {

    public GameObject[] map;

	// Use this for initialization
	void Start () {
        
        int number = Random.Range(0, map.Length);
        Instantiate(map[number], transform.position, transform.rotation);
        Instantiate(map[Random.Range(0, map.Length)], transform.position, transform.rotation);
        Instantiate(map[Random.Range(0, map.Length)], transform.position, transform.rotation);
        Instantiate(map[Random.Range(0, map.Length)], transform.position, transform.rotation);
        Instantiate(map[Random.Range(0, map.Length)], transform.position, transform.rotation);
        Instantiate(map[Random.Range(0, map.Length)], transform.position, transform.rotation);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
