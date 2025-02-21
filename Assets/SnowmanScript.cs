using UnityEngine;


public class SnowmanScript : MonoBehaviour
{
    [SerializeField]
    private float Speed = 5.0f;
    [SerializeField]
    private float rotationSpeed = 100.0f;


    private float translation = 0, rotation = 0;
    private bool isRotating = false; 


    void Start()
    {
        Debug.Log("SnowmanScript initialized.");
    }


    void Update()
    {
        isRotating = Input.GetKey(KeyCode.Space);


        if (isRotating)
        {
            transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
        }
        else
        {
            translation = Speed * Time.deltaTime;


            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(Vector2.left * translation, Space.World);
            }


            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(Vector2.right * translation, Space.World);
            }


            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(Vector2.up * translation, Space.World);
            }


            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector2.down * translation, Space.World);
            }
        }
    }
}
