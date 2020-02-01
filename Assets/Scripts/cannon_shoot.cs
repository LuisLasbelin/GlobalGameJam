using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannon_shoot : MonoBehaviour
{

    public GameObject ball;
    public Transform shooterPoint;

    public int force;

    public float setTime;
    public float currTime;

    // Start is called before the first frame update
    void Start()
    {
        currTime = setTime;
    }

    private void Update()
    {
        currTime -= Time.deltaTime;

        if(currTime <= 0)
        {
            Shoot();
            currTime = setTime;
        }
    }

    public void RestartTimer()
    {
        currTime = setTime;
    }

    public void Shoot()
    {

        GameObject currBall = Instantiate(ball, shooterPoint.position, Quaternion.identity);
        currBall.transform.rotation = gameObject.transform.rotation;

        Rigidbody2D rb2d = currBall.GetComponent<Rigidbody2D>();

        rb2d.AddForce(force * transform.right);

        currTime = setTime;

    } // ()
}
