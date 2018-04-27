using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gato : MonoBehaviour {
    public GameObject spawnGato;
    public GameObject gatoPrefab;
    IEnumerator Spawn;

	// Use this for initialization
	void Start () {
        StartCoroutine(SpawnGatos(1f));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator SpawnGatos(float time)
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            Instantiate(gatoPrefab, spawnGato.transform);
        }
    }
}
