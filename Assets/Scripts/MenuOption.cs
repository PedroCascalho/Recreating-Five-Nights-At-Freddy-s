using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class MenuOption : MonoBehaviour
{
    public RectTransform arrowTransform; // Transform da imagem da seta
    public RectTransform newGameTransform; // Transform da opção "New Game"
    public RectTransform continueTransform; // Transform da opção "Continue"

    public float arrowMoveSpeed = 10f; // Velocidade de movimento da seta

    private void Update()
    {
        // Movimento da seta com as setas do teclado
        float verticalInput = Input.GetAxis("Vertical");
        if (verticalInput > 0) // Setor para cima
        {
            arrowTransform.position = Vector3.MoveTowards(arrowTransform.position, newGameTransform.position, arrowMoveSpeed * Time.deltaTime);
        }
        else if (verticalInput < 0) // Setor para baixo
        {
            arrowTransform.position = Vector3.MoveTowards(arrowTransform.position, continueTransform.position, arrowMoveSpeed * Time.deltaTime);
        }

        // Movimento da seta com o mouse
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (newGameTransform.rect.Contains(mousePosition)) // Se o mouse estiver sobre a opção "New Game"
        {
            arrowTransform.position = Vector3.MoveTowards(arrowTransform.position, newGameTransform.position, arrowMoveSpeed * Time.deltaTime);
        }
        else if (continueTransform.rect.Contains(mousePosition)) // Se o mouse estiver sobre a opção "Continue"
        {
            arrowTransform.position = Vector3.MoveTowards(arrowTransform.position, continueTransform.position, arrowMoveSpeed * Time.deltaTime);
        }
    }
}
