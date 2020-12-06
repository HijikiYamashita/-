using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_ : MonoBehaviour
{
    public int power;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "P1")
        {
            Debug.Log("わ");
            this.gameObject.GetComponent<Rigidbody>().AddForce(-power, power, 0);
        }
        if (col.gameObject.name == "P2")
        {
            Debug.Log("わ");
            this.gameObject.GetComponent<Rigidbody>().AddForce(power, power, 0);
        }
        if (col.gameObject.tag == "Baka")
        {
            Destroy(col.gameObject);
        }
    }
}
