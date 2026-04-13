using UnityEngine;

public class movement : MonoBehaviour
{
    public float movementSpeed = 5f;
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, 0, vertical);
        movement = movement.normalized * movementSpeed * Time.deltaTime;
        transform.Translate(movement);
    }
}

