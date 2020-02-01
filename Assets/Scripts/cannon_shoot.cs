using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannon_shoot : MonoBehaviour
{

    public GameObject ball;
    public Transform shooterPoint;

    public int force;

    public int normalTime = 10; //El normal time se usa cuando el jugador tiene menos de 10 de vida
    public int speedTime = 5; //El speed time se usa cuando el jugador tiene 10 de vida

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Shoot()
    {

        GameObject currBall = Instantiate(ball, shooterPoint.position, Quaternion.identity);
        currBall.transform.rotation = gameObject.transform.rotation;

        Rigidbody2D rb2d = currBall.GetComponent<Rigidbody2D>();

        rb2d.AddForce(force * transform.right);

    } // ()
}
