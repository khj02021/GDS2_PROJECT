﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void StartGame() {
        AudioManager.Instance.PlayLevelSelect();
        SceneManager.LoadScene("Level_1");
    }

    public void ResetGems() {
        AudioManager.Instance.PlayStartGame();
        PlayerPrefs.SetString("GemTracker", "");
        PlayerPrefs.SetFloat("Score", 0f);
    }
}
