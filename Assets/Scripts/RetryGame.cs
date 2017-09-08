using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RetryGame : MonoBehaviour {

    public Button BeginLevel;

    // Use this for initialization
    void Start()
    {
        Button btn = BeginLevel.GetComponent<Button>();
        btn.onClick.AddListener(RestartGame);
    }

    // Update is called once per frame
    void Update () {
		
	}

    void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Scene1");

    }
}
