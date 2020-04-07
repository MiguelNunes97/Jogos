using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    public GameObject cauda;
    private Rigidbody2D rb1;

    float speed = 1.5f;

    public void Start()
    {
        StartCoroutine(tail());
        rb1 = GetComponent<Rigidbody2D>();
    }
    void Update()
    {

        if (Input.GetKey("w"))

            transform.Translate(Vector3.up * speed * Time.deltaTime);

        if (Input.GetKey("s"))

            transform.Translate(- Vector3.up * speed * Time.deltaTime);
        if (Input.GetKey("d"))

            transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (Input.GetKey("a"))
            transform.Translate(- Vector3.right * speed * Time.deltaTime);

    }


    IEnumerator tail()
    {
        while (true)
        {
            Instantiate(cauda, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(0.15f);
        }
    }
}
