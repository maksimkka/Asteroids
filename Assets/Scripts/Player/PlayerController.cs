using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float maxSpeed;

    [SerializeField] private GameObject nozzleShip;
    [SerializeField] private GameState gameState;

    private IGameOver gameOver;

    private float scaledMoveSpeed;

    private PlayerSpeed playerSpeed;
    private PlayerInput input;
    private GetInfoPlayer infoPlayer;

    private void Awake()
    {
        playerSpeed = new PlayerSpeed(moveSpeed, maxSpeed);
        gameOver = gameState.GetComponent<IGameOver>();

        infoPlayer = GetComponent<GetInfoPlayer>();
        input = new PlayerInput();
    }

    private void OnEnable()
    {
        input.Enable();
    }

    private void OnDisable()
    {
        input.Disable();
    }

    private void FixedUpdate()
    {
        float moveForvard = input.Player.Move.ReadValue<float>();
        float rotation = input.Player.Rotation.ReadValue<float>();
        scaledMoveSpeed = playerSpeed.SpeedIncrease(moveForvard);

        Move(scaledMoveSpeed);
        SetActiveNozzleFire(moveForvard);
        Rotate(rotation);
    }

    private void Update()
    {
        infoPlayer.OutputSpeed(scaledMoveSpeed);
        infoPlayer.OutputRotation(transform.rotation);
        infoPlayer.OutputPosition(transform.position);
    }

    private void Move(float scaledMoveSpeed)
    {
        Vector3 moveDirection = gameObject.transform.TransformDirection(new Vector3(0, scaledMoveSpeed * (Time.deltaTime / 2), 0));
        gameObject.transform.position += moveDirection * scaledMoveSpeed;
    }

    private void SetActiveNozzleFire(float moveForvard)
    {
        if (moveForvard > 0)
        {
            nozzleShip.SetActive(true);
        }

        else
        {
            nozzleShip.SetActive(false);
        }
    }

    public void Rotate(float rotation)
    {
        if (rotation > 0)
        {
            transform.Rotate(new Vector3(0, 0, -rotationSpeed * Time.deltaTime));
        }

        else if (rotation < 0)
        {
            transform.Rotate(new Vector3(0, 0, rotationSpeed * Time.deltaTime));
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        BigAsteroid bigAsteroid = collision.GetComponent<BigAsteroid>();
        SmallAsteroid smallAsteroid = collision.GetComponent<SmallAsteroid>();
        Ufo ufo = collision.GetComponent<Ufo>();

        if (bigAsteroid != null || smallAsteroid != null || ufo != null)
        {
            Dead();
        }
    }

    private void Dead()
    {
        Destroy(gameObject);
        gameOver.GameOver();
    }
}