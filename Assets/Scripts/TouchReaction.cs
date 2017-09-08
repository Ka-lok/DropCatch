using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(AudioSource))]

public class TouchReaction : MonoBehaviour {

    // Use this for initialization
    public GameObject Ball;
    public static int currentScore = 0;
    public Text Score;
   

    public  AudioSource audioSource;
    private bool touched = false;

    void Start () {
        Score = GameObject.FindWithTag("ScoreText").GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {

            //Instantiate(Ball, new Vector3(0, 0, 0), Quaternion.identity);

            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);
            if (hit != null && hit.collider != null)
            {

                if (hit.collider.gameObject.CompareTag("Ball") && (!touched) && Time.timeScale.Equals(1))
                {
                    hit.collider.gameObject.GetComponent<Renderer>().enabled = false;
                    hit.collider.gameObject.GetComponent<Collider2D>().enabled = false;
                    audioSource.Play();
                    touched = true;
                    currentScore = currentScore + 1;
                    Score.text = ("Score : " + currentScore);

                    //  hit.collider.gameObject.SetActive(false);
                    //hit.collider.gameObject.GetComponent<Renderer>().enabled = false;
                    
                    Destroy(hit.collider.gameObject,audioSource.clip.length);
                }

                // Instantiate(Ball, new Vector3(0, 0, 0), Quaternion.identity);
            }
        }


    }

    private void playPopSound()
    {
        audioSource.Play();
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Floor"))
    //    {
    //        resetScore();
    //    }
    //}

    public void resetScore()
    {
        currentScore = 0;
    }

    
}
