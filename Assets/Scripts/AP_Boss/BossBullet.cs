using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour
{
    [HideInInspector] public float damage;

    [SerializeField] private Rigidbody rBody;
    private float maxLifeTime = 10f;

    public void Fire(float damage, float speed)
    {
        this.damage = damage;
        rBody.AddForce(this.transform.forward * speed);
        StartCoroutine(DestroySelf());
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Do Stuff
    }

    private IEnumerator DestroySelf()
    {
        yield return new WaitForSeconds(maxLifeTime);

        Destroy(gameObject);

    }


}
