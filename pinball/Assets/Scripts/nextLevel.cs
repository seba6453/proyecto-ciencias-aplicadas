using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    public void next_level(string level)
    {
        SceneManager.LoadScene(level);
    }
}
