using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Weapon : MonoBehaviour
{
   // public TargetFollow _Target;
    public GameObject projectile;

    public Transform shootinpos;

    public float speed;
    private float time_btwshoot;

    public float start_timebtwshoot;

    public Transform Cursore;

    

    private float lookangle;
    // Update is called once per frame
    void Update()
    {
        
        if (time_btwshoot <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            { 
                Shoot();
              time_btwshoot = start_timebtwshoot;
            }
        }
        else
        {
            time_btwshoot -= Time.deltaTime;
        }
    }

    void Shoot()
    {
      Vector2  lookdirection = new Vector2(Cursore.position.x,Cursore.position.y);
      Vector2  shootdirection=new Vector2(shootinpos.position.x,shootinpos.position.y);
      RaycastHit2D hit = Physics2D.Raycast(shootdirection, lookdirection - shootdirection, 100);
      Shootbullet();
     // Debug.DrawLine(shootdirection,lookdirection,Color.black);

      void Shootbullet()
      {
          Instantiate(projectile, shootinpos.position, shootinpos.rotation);
      }










      //  lookangle = Mathf.Atan2(lookdirection.y, lookdirection.x) * (Mathf.Rad2Deg);
      //shootinpos.rotation=Quaternion.Euler(0,0,lookangle);

    }
}
