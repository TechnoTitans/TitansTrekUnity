using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endScene : MonoBehaviour
{
    public Image tt;

    void Start(){
        tt.enabled = false;
        StartCoroutine(Appear());
    }

    public IEnumerator Appear() {
        yield return new WaitForSeconds(21f);
        tt.enabled = true;
    }
}
