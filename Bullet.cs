using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed=100f;

    public float lifetime;
    public Camerashake shake;

    public GameObject destroyeffect;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyProjectile",lifetime);
        shake = GameObject.FindGameObjectWithTag("camshake").GetComponent<Camerashake>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right*Time.deltaTime*speed);
    }

    void DestroyProjectile()
    { 
        shake.Camshake();
            Instantiate(destroyeffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
