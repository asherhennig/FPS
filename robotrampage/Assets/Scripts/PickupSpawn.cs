using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject[] pickups;

    //1
    void spawnPickup()
    {
        //Instantiate a random pickup
        GameObject pickup = Instantiate(pickups[Random.Range(0,
            pickups.Length)]);
        pickup.transform.position = transform.position;
        pickup.transform.parent = transform;
    }

    //2
    IEnumerator respawnPickup()
    {
        yield return new WaitForSeconds(20);
        spawnPickup();
    }

    //3 Start is called before the first frame update
    void Start()
    {
        spawnPickup(); 
    }

    //4
    public void PickupWasPickedUp()
    {
        StartCoroutine("respawnPickup");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
