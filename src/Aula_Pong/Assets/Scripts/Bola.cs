using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;
    void Start()
    {
        float x = Random.Range(0,2) == 0 ? -1:1;
        float y = Random.Range(0,2) == 0 ? -1:1;

        GetComponent<Rigidbody>().velocity = new Vector2(10*x,10*y);
        /*if(Random.Range(0,1)==0)
        {
            x=-1;
        }else
        {
            x=1;
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision batida)
    {
        audioSource.Play();
        if(batida.gameObject.name == "BarreiraEsquerda")
        {
            transform.position = new Vector3(0,0,12);
            Start();
        }
    }
}
