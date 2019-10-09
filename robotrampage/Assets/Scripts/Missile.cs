using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed = 30.0f;
    public int damage = 10;

    //1
    void Start()
    {
        StartCoroutine("deathTimer");
    }

    //2
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    //3
    IEnumerator deathTimer()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.GetComponent<Player>() != null
            && collider.gameObject.tag == "Player")
        {
            collider.gameObject.GetComponent<Player>().TakeDamage(damage);
        }

        Destroy(gameObject);

    }
}
