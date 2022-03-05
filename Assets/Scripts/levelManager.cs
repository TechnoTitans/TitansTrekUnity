using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour {

    public Button[] levelButtons;
    public GameObject endButton;

    // void Start () {

    //     endButton.SetActive(false);

    //     int levelReached = PlayerPrefs.GetInt ("levelReached", 1);

    //     for (int i = 0; i < levelButtons.Length; i++) {
    //         if (i + 1 > levelReached) {
    //             levelButtons[i].interactable = false;
    //         }
    //     }
    // }

    // void hiddenButton () {
    //     if (levelButtons[2].interactable == true) {
    //         endButton.SetActive(true);
    //     }
    // }

    public void level1() {
        SceneManager.LoadScene("Level 1");
    }

    public void level2(){
        SceneManager.LoadScene("Level 2");
    }

    public void level3() {
        SceneManager.LoadScene("Level 3");
    }

    public void level4(){
        SceneManager.LoadScene("SampleScene");
    }

    public void endScene() {
        SceneManager.LoadScene("endScene");
    }

    public void homeButtonEnd(){
        SceneManager.LoadScene("map");
    }

    public void quitButton(){
        Application.Quit();
    }
}