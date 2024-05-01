using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadingScene : MonoBehaviour {

    public void Start()
    {
        StartCoroutine(LoadMenu());
    }

    public IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("escapeLab game");
    }
}
