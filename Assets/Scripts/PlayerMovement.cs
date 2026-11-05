using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocidade = 5f;

    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movimento = new Vector3(
            horizontal, 0f, vertical
        );

        movimento = Vector3.ClampMagnitude(movimento, 1f);

        controller.Move(
            movimento * velocidade * Time.deltaTime
        );
    }   
}
