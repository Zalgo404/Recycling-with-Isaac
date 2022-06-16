using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Voltarmenu : MonoBehaviour
{
    public void Vortar(string Menu)
    {
        SceneManager.LoadScene(Menu);
    }
}
