using UnityEngine;

public class PlayerMovement : MonoBehaviour{

    public Rigidbody rb;
    
    void Start(){
        rb.AddForce(0, 1000, 0);
    }

    
    void Update(){
        
    }
}
