using UnityEngine;

// This is the enemy script that defines the enemy's health and damage
public class Enemy_Script : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 2f;
    private float dis;
    public float range_en = 10f;
    public int Leben = 3;
    public int Schaden = 1;
    public float attck_cooldown = 1.5f;
    bool cooldown = false;
    public float targetTime;
    public Animator anim = null;

    void FixedUpdate()
    {
        dis = Vector3.Distance(player.position, this.gameObject.transform.position);
        if (dis < range_en && !cooldown)
        {
            setMoving(true);
            //Debug.Log(dis + this.gameObject.name);
            transform.position = Vector3.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
            transform.LookAt(new Vector3(player.position.x, transform.position.y, player.position.z));

        }
        else
        {
            setMoving(false);
        }
    }

    void setMoving(bool mov)
    {
        if(anim != null)
        {
            anim.SetBool("Moving", mov);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "sword_epic")
        {
            Debug.Log("sword_epicsword_epicsword_epicsword_epicsword_epicsword_epicsword_epic");
            Leben -= 3;
            die();
        }
    }

    public void die()
    {
        if(Leben <= 0)
        {
            Destroy(this.gameObject);
            Debug.Log("ENEMY KILLED");
        }
    }

    public bool getCooldown()
    {
        return cooldown;
    }

    public void setCooldown(bool cd)
    {
        this.cooldown = cd;
        targetTime = attck_cooldown;
    }

    private void Update()
    {
        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f && cooldown == true)
        {
            cooldown = false;
        }
    }
}

