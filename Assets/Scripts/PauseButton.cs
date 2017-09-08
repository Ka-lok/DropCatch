using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{

    public Button _PauseButton;
    public Sprite PlaySprite;
    public Sprite PauseSprite;


    // Use this for initialization
    void Start()
    {
        Button btn = _PauseButton.GetComponent<Button>();
        btn.onClick.AddListener(CheckIfPausingOrUnPausing);
       
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CheckIfPausingOrUnPausing()
    {
        if (Time.timeScale == 0)
        {
            UnPauseGame();
            
        } else
        {
            PauseGame();
        }
    }

    void PauseGame()
    {
  
        Time.timeScale = 0;
        _PauseButton.GetComponent<Image>().sprite = PlaySprite;
        
    }

    void UnPauseGame()
    {
        _PauseButton.GetComponent<Image>().sprite = PauseSprite;
        Time.timeScale = 1;
    
    }

}
