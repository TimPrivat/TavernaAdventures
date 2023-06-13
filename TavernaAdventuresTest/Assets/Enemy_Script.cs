using UnityEngine;

// This is the enemy script that defines the enemy's health and damage
public class Enemy_Script : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 0.1f;
    private bool t = false;
    private float dis;
    public float range_en;

    void FixedUpdate()
    {
        dis = Vector3.Distance(player.position, this.gameObject.transform.position);
        if (dis < range_en)
        {
            Debug.Log(dis + this.gameObject.name);
            transform.position = Vector3.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
        }
    }

}
