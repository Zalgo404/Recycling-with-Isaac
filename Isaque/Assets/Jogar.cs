using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogar : MonoBehaviour
{
    public void Jorjar(string Tutorial)
    {
        SceneManager.LoadScene(Tutorial);
    }
}
