using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour
{

    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        ////
        ///Don't forget Triger enter of Check!!
        ///
        if (other.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
