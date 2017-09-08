using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIControls : MonoBehaviour {


    public Button RefreshButton;
    
    // Use this for initialization
    void Start () {
        Button btn = RefreshButton.GetComponent<Button>();
        btn.onClick.AddListener(RestartGame);



    }

    // Update is called once per frame
    void Update () {
		
	}
    void RestartGame()
    {
        SceneManager.LoadScene("Scene1");
        TouchReaction t = new TouchReaction();
        t.resetScore();
    }
}
