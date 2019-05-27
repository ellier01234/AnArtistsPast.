using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour {


    public float enemyMaxHealth;

    private float currentHealth; 
    
	// Use this for initialization
	void Start () {
        currentHealth = enemyMaxHealth;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddDamage(float damage)
    {
        currentHealth = currentHealth - damage;
        if (currentHealth <= 0) MakeDead();
    }

    void MakeDead()
    {
        Destroy(gameObject);
    }
}
