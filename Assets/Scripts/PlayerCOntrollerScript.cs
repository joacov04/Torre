using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCOntrollerScript : MonoBehaviour
{
    public int maxHealth;
    public HealthBar healthbar;
    private int curHealth;
    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;
        
    }

    // Update is called once per frame
    public void TakeDamage(int damage)
    {
       curHealth -= damage; 
       healthbar.UpdateHealth((float)curHealth / (float)maxHealth);
    }
}
