using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TouchFloor : MonoBehaviour {

    //public Text Score;
    public AudioSource GameOverAudioSource;



	// Use this for initialization
	void Start () {
        //   Score = GameObject.FindWithTag("ScoreText").GetComponent<Text>();
      //  GameOverAudioSource = GetComponent<AudioSource>();
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject.CompareTag("Floor")) )
        {
            //GameOverAudioSource.Play(); 
            TouchReaction t = new TouchReaction();
            t.resetScore();
            SceneManager.LoadScene("GameOver");
            //DelayedLoad();
         
        }
    }

    IEnumerator DelayedLoad()
    {
        //Play the clip once
        GameOverAudioSource.Play();

        //Wait until clip finish playing
        yield return new WaitForSeconds(GameOverAudioSource.clip.length);

        //Load scene here
        SceneManager.LoadScene("GameOver");

    }
}
