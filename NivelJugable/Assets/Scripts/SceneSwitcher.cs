using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSwitcher : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(sceneBuildIndex:1);
    }
    public void Regresar()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }
}
