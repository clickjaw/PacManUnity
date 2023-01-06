using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    int scoreCounter = 0;
    [SerializeField] Text scoreText;
    [SerializeField] AudioSource collectionSound;

    private void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.CompareTag("PacManFood"))
        {
            //if you hit the food it's destroyed and score is increased.
            Destroy(other.gameObject);
            scoreCounter++;
            //Debug.Log("Score: " + scoreCounter);
            scoreText.text = "Score: " + scoreCounter;
            collectionSound.Play();
        }

        if (other.gameObject.CompareTag("SuperPacManFood"))
        {
            Destroy(other.gameObject);
            scoreCounter = scoreCounter + 2;
            //Debug.Log("Score: " + scoreCounter);
            scoreText.text = "Score: " + scoreCounter;
            collectionSound.Play();
        }


    }
}
