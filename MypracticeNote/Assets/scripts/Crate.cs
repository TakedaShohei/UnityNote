using UnityEngine;
using System.Collections;

public class Crate : MonoBehaviour
{
    public GameObject frature_crate_;
    public GameObject explotion_effect_;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
           
            Instantiate(explotion_effect_, transform.position, Quaternion.identity);

            ///// GetComponentInChildren
            ///  FCO is crate for entering Instanstiated objects. 
            ///  https://docs.unity3d.com/ja/current/ScriptReference/Component.GetComponentInChildren.html
            ///  ""

            GameObject fractuated_crate_obj = Instantiate(frature_crate_, transform.position, Quaternion.identity) as GameObject;
            Rigidbody[] allrigidbodies_ = fractuated_crate_obj.GetComponentInChildren<Rigidbody[]>();
            if (allrigidbodies_.Length > 0)
            {
                foreach(var body in allrigidbodies_)
                {
                    body.AddExplosionForce(500, transform.position,1);
                }
            }

            Destroy(this.gameObject);
        }
    }
}
