using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirGatos : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Invoke("Destruir", 3f);
    }

    private void OnconllisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "player")
        {
            Invoke("Destruir", 0.5f);
        }
    }

    void Destruir()
    {
        Destroy(this.gameObject);
    }
}
