using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelManager : MonoBehaviour {

    public Button[] levelButtons;
    public GameObject endButton;

    void Start () {

        endButton.SetActive(false);

        int levelReached = PlayerPrefs.GetInt ("levelReached", 1);

        for (int i = 0; i < levelButtons.Length; i++) {
            if (i + 1 > levelReached) {
                levelButtons[i].interactable = false;
            }
        }
    }

    void hiddenButton () {
        if (levelButtons[2].interactable == true) {
            endButton.SetActive(true);
        }
    }
}