
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocidade = 5f;
    public float alturaPulo = 2f;
    public float gravidade = -9.81f;

    private CharacterController controller;
    private Vector3 velocidadeVertical;

    private bool puloUtilizado = false;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Movimento horizontal
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movimento = transform.right * horizontal +
                            transform.forward * vertical;

        controller.Move(movimento * velocidade * Time.deltaTime);

        
        if (controller.isGrounded)
        {
            
            if (velocidadeVertical.y < 0)
            {
                velocidadeVertical.y = -2f;
            }

            
            puloUtilizado = false;
        }

        
        if (Input.GetKeyDown(KeyCode.Space) &&
            !puloUtilizado)
        {
            velocidadeVertical.y =
                Mathf.Sqrt(alturaPulo * -2f * gravidade);

            puloUtilizado = true;
        }
        velocidadeVertical.y += gravidade * Time.deltaTime;
        controller.Move(velocidadeVertical * Time.deltaTime);
    }
}
