using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorusScript : MonoBehaviour {

	GameObject playerGameObject;
	playerScript player;
    public GameObject Box;
	bool touchedBad = false;
	bool gotPoint = false;
	// Use this for initialization
	void Start () {
		playerGameObject = GameObject.FindWithTag ("Player");
		if (playerGameObject != null)
			player = playerGameObject.GetComponent<playerScript> ();
	}
	
	// на даному етапі ми перевіряємо взаємодію гравця з об'єктами(кільцями)
	
	void Update () {
		if ((player.transform.position.x > transform.position.x + 2f) && (player.transform.position.x < transform.position.x + 3f)) {
			if (!gotPoint) {
				player.gameOver = true;
				Debug.Log ("Game Over!");	
			}
		}
		if (player.transform.position.x > transform.position.x + 4f) {
			if (gotPoint) {
				gotPoint = false;
				touchedBad = false;
			}
		}

		// на даному етапі ми бачимо ускладнення ігрового процесу 

        if (player.score >=10)
        {
            player.forwardSpeed = 5;
        }
		//ускладнення відбувається відповідно набраних гравцем очок
        if (player.score >= 20)
        {
            player.forwardSpeed = 6;
        }

        if (player.score >= 30)
        {
            player.forwardSpeed = 7;
        }

        if (player.score >= 40)
        {
            player.forwardSpeed = 7.5f;
        }

        if (player.score >= 50)
        {
            player.forwardSpeed = 8f;
        }
    }

	//void OnCollisionEnter2D(Collision2D other)
	//{
	//	if (other.gameObject.tag == "Player") {
	//		player.combo = 1;
	//		touchedBad = true;
	//	}
	//}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") {
            if (!gotPoint) {
                gotPoint = true;
                if (!touchedBad)
                    player.combo++; 
            }
            player.score += player.combo;
            Box.SetActive(false);

        }
        else
        {
            Box.SetActive(true);
        }

    }
}
