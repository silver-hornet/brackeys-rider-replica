using UnityEngine;
using UnityEngine.SceneManagement;

public class CarController : MonoBehaviour
{
    bool move = false;
    bool isGrounded = false;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float speed = 20f;
    [SerializeField] float rotationSpeed = 7f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            move = true;
        if (Input.GetButtonUp("Fire1"))
            move = false;

        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void FixedUpdate()
    {
        if (move == true)
            if (isGrounded)
                rb.AddForce(transform.right * speed * Time.deltaTime * 100f, ForceMode2D.Force); // ForceMode2D.Force is the default anyway
            else
                rb.AddTorque(rotationSpeed * Time.deltaTime * 100f, ForceMode2D.Force);
    }

    void OnCollisionEnter2D()
    {
        isGrounded = true;
    }

    void OnCollisionExit2D()
    {
        isGrounded = false;
    }
}
