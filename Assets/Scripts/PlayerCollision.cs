using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private GameObject gameManager;

    void OnCollisionEnter(Collision collisionInfo)
	{
		if (collisionInfo.collider.CompareTag("Wall"))
		{
            gameManager.GetComponent<GameManager>().SetPlayerDeath();
		}
        if(collisionInfo.collider.CompareTag("Win_Ground"))
        {
            gameManager.GetComponent<GameManager>().SetPlayerWin();
        }
	}
}
