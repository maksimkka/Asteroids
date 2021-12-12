using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetInfoPlayer : MonoBehaviour
{
    [SerializeField] private Text speedText;
    [SerializeField] private Text positionText;
    [SerializeField] private Text rotationText;
    public const int speedCoeficient = 100;
    private const int positionCoeficient = 130;

    public void OutputSpeed(float speed)
    {
        // отвечает за то какая скорость выводится на экран делая иллюзию большой скорость
        speed *= speedCoeficient;
        speedText.text = $"Speed:{(int)speed}";
    }

    public void OutputRotation(Quaternion rotation)
    {
        rotationText.text = $"{(int)rotation.eulerAngles.z}";
    }

    public void OutputPosition(Vector2 position)
    {
        // отвечает за то какая позиция выводится на экран делая иллюзию больших масштабов
        position.x *= positionCoeficient;
        position.y *= positionCoeficient;
        positionText.text = $"X({(int)position.x})/Y({(int)position.y})";
    }
}
