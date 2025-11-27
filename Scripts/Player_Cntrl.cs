using UnityEngine;

public class Player_Cntrl : MonoBehaviour
{
    private float horizontal;
    private float vertical;

    public float speed;
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");   
        vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.back * vertical * speed * Time.deltaTime);
        transform.Translate(Vector3.left * horizontal * speed * Time.deltaTime);
    }
}
