using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour {

	public float intervaloAtaque;
	private float contagemIntervalo;
	private bool atacou;
	public float distanciaAtaque;

	public GameObject player;
	public GameObject ataque;

	public Animator animator;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		var distancia = (player.transform.position.x - transform.position.x);
		if (distancia > 0) 
		{
			transform.eulerAngles = new Vector2(0, 180);
		} else 
		{
			transform.eulerAngles = new Vector2(0, 0);
		}

		if (!atacou && Mathf.Abs(distancia) <= distanciaAtaque) 
		{
            print("ataque");
			animator.SetTrigger("atacou");
            //Instantiate(ataque, transform.position, transform.rotation);
            GameObject tiro1 = (GameObject)Instantiate(ataque);
            tiro1.transform.position = transform.position;

            atacou = true;
		}
		if (atacou) 
		{
			contagemIntervalo += Time.deltaTime;
			if (contagemIntervalo >= intervaloAtaque) 
			{
				atacou = false;
				contagemIntervalo = 0;
			}
		}
	}

}
