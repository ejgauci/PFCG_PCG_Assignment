using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    private string nextScene;

    private void Start()
    {
        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == "Task3_L1")
        {
            
             nextScene = "Task3_L2";

        }else if (scene.name == "Task3_L2")
        {
            nextScene = "Task3_L3";
        }
        else if (scene.name == "Task3_L3")
        {
            nextScene = "Task3_L1";
        }
    }
    private void OnTriggerEnter(Collider other)
    {

        print("finished race track");

        SceneManager.LoadScene(nextScene);


    }
}
