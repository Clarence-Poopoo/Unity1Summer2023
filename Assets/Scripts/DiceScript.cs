using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScript : MonoBehaviour
{
    public Transform throwPos;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        throwPos = GameObject.Find("Throw Point").transform;
        transform.rotation = Random.rotation;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        transform.position = throwPos.position;
        rb.AddForce(new Vector3(Random.Range(-5, -15), 2, 0), ForceMode.Impulse);

    }
}
