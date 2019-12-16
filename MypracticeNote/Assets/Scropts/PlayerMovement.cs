using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float _speed=0;
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //// summary getAxis 
        ///Edit/ProjectSetting/Input/Axis
        ///file:///D:/Unity/Unity%20Editor/2018.4.5f1/Editor/Data/Documentation/en/Manual/class-InputManager.html
        ///

        float horaizontal_input = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horaizontal_input,0,0) * _speed * Time.deltaTime);

        /// summary right or left
        ///right is shorthad for writting Vector3(1,0,0)
        ///leftis shorthad for writting Vector3(-1,0,0)
        //transform.Translate(Vector3.right*_speed*Time.deltaTime);
    }
}
