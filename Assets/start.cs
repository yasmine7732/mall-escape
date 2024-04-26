using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class replayGame : MonoBehaviour
{

    public Button btnReplay;
    public string scene;

    // Start is called before the first frame update
    void Start()
    {
        btnReplay.onClick.AddListener(OnClick);
    }

    void OnClick() {

        SceneManager.LoadScene(scene);
    }
}
