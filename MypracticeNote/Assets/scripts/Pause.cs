using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    /// <summary>
    /// When you show objects like Pause ,Please compound Camera
    /// stop Time.timeScale = 0;
    /// slow Time.timeScale = 0.25f;
    /// restart Time.timeScale = 1;
    /// </summary>
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //Stop Movement
            Time.timeScale = 0;
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            //Restart movement
            Time.timeScale = 1;

        }

    }
}
