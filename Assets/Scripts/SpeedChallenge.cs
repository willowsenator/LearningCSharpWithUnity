using UnityEngine;

public class SpeedChallenge : MonoBehaviour
{
    [SerializeField]
    private GameObject cube;

    private Rigidbody cubeRigidBody;
    [SerializeField]
    private float speed;
    private void Start()
    {
        cubeRigidBody = cube.GetComponent<Rigidbody>();
        cubeRigidBody.velocity = new Vector3();
    }

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            speed += 0.5f;
           
            cubeRigidBody.velocity = cube.transform.forward * speed;
        }

        if (Input.GetKeyDown(KeyCode.A) && speed > 0)
        {
            speed -= 0.5f;
            cubeRigidBody.velocity = cube.transform.forward * speed;
        }

        if (speed > 20)
        {
            Debug.Log("Slow down !!!");
        }
        if (speed ==  0)
        {
            Debug.Log("You need to speed Up!!!");
        }
        else if (speed < 0)
        {
            speed = 0;
        }
    }
}
