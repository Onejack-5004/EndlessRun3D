using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float laneDistance = 2.5f;
    public float moveSpeed = 10f;

    private int currentLane = 1;

    void Update()
    {
        // กด A หรือ ลูกศรซ้าย
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveLeft();
        }

        // กด D หรือ ลูกศรขวา
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveRight();
        }

        // ตำแหน่ง X เป้าหมายของ Lane
        float targetX = (currentLane - 1) * laneDistance;

        // เคลื่อนที่ไปยัง Lane ที่เลือก
        Vector3 targetPosition = new Vector3(
            targetX,
            transform.position.y,
            transform.position.z
        );

        transform.position = Vector3.Lerp(
            transform.position,
            targetPosition,
            moveSpeed * Time.deltaTime
        );
    }

    void MoveLeft()
    {
        // ห้ามออกจาก Lane ซ้ายสุด
        if (currentLane > 0)
        {
            currentLane--;
        }
    }

    void MoveRight()
    {
        // ห้ามออกจาก Lane ขวาสุด
        if (currentLane < 2)
        {
            currentLane++;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            GameManager.instance.GameOver();
            gameObject.SetActive(false);
        }
    }
}