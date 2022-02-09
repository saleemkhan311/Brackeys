
using UnityEngine;

public class playerMovemet : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sideWaysForce = 500f;
    public gameManager Manager;

    
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
       
        if (rb.position.y < -1 )//&& Manager.levelcmplt == false)
        {
            FindObjectOfType<gameManager>().endGame();
        }
    }
}
