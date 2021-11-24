using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] float speed = 20;
    [SerializeField] GameObject fireball;
    [SerializeField] Transform shootingPoint;
    //[SerializeField] AudioSource audioSource;
    //[SerializeField] AudioClip audioClip;

    public void Fireball()
    {
        GameObject spawnedFireball = Instantiate(fireball, shootingPoint.position, shootingPoint.rotation);
        spawnedFireball.GetComponent<Rigidbody>().velocity = speed * shootingPoint.forward;
        Destroy(spawnedFireball, 2);
    }
}
