﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnClick1 : MonoBehaviour
{
    public void BtnNewScene()
    {
        SceneManager.LoadScene("1_match");
    }
}