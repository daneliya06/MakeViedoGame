using UnityEngine;

public class PlayerMovement : MonoBehaviour{

    public Rigidbody rb;
     
    void FixedUpdate(){
        rb.AddForce(0, 0, 1000 * Time.deltaTime);
    }
}
 