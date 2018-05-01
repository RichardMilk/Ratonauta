using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Health : MonoBehaviour {

	/*public const int maxHealth = 100;
	public bool destroyOnDeath;

	[SyncVar(hook = "OnChangeHealth")]
	public int currentHealth = maxHealth;

	public RectTransform healthBar;

	private NetworkStartPosition[] spawnPoints;

	void Start ()
	{
		if (isLocalPlayer)
		{
			spawnPoints = FindObjectsOfType();
		}
	}

	public void TakeDamage(int amount)
	{
		if (!isServer)
			return;

		currentHealth -= amount;
		if (currentHealth &lt == 0)
		{
			if (destroyOnDeath)
			{
				Destroy(gameObject);
			} 
			else
			{
				currentHealth = maxHealth;

				// chamado no servidor, invocado nos clientes

				RpcRespawn();
			}
		}
	}

	void OnChangeHealth (int currentHealth )
	{
		healthBar.sizeDelta = new Vector2(currentHealth , healthBar.sizeDelta.y);
	}

	[ClientRpc]
	void RpcRespawn()
	{
		if (isLocalPlayer)
		{
			// Definir o ponto de origem como origem como um valor padrão
			Vector3 spawnPoint = Vector3.zero;

			// Se houver uma matriz de ponto de desova e a matriz não estiver vazia, escolha uma aleatoriamente
			//if (spawnPoints != null &amp;&amp; spawnPoints.Length &gt; 0)
			//{
			//	spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position;
			//}

			// Defina a posição do jogador para o ponto de desova escolhido

			transform.position = spawnPoint;
		}
	}*/
}
