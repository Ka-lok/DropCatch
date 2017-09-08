using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour {

   public Button BeginLevel;
	// Use this for initialization
	void Start () {
        Button btn = BeginLevel.GetComponent<Button>();
        btn.onClick.AddListener(BeginGame);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void BeginGame()
    {
        
        SceneManager.LoadScene("Scene1");
    }
}
