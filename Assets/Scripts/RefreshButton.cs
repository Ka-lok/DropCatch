using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class RefreshButton : MonoBehaviour {

    public Button _RefreshButton;

    // Use this for initialization
    void Start()
    {
        Button btn = _RefreshButton.GetComponent<Button>();
        btn.onClick.AddListener(RestartGame);



    }

    // Update is called once per frame
    void Update()
    {

    }
    void RestartGame()
    {
        SceneManager.LoadScene("Scene1");
        TouchReaction t = new TouchReaction();
        t.resetScore();
    }
}
