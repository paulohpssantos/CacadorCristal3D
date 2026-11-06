using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform jogador;

    public Vector3 deslocamento = new Vector3(0f, 12f, -12f);

    void LateUpdate()
    {
        if(jogador == null)
            return;

        transform.position = jogador.position + deslocamento;

        transform.LookAt(jogador);       
    }     
    
}
