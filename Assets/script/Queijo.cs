using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Queijo : MonoBehaviour {

    public GameObject queijo;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("pegarqueijo"))
        {
            Debug.Log("Colisão OK");
            Destroy(queijo);
        }
    }
}
