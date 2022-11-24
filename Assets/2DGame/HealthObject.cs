
using System;
using UnityEngine;
using TMPro;

class HealthObject : MonoBehaviour
{
    [SerializeField] TMP_Text textComponent;
    [SerializeField] int maxHealth=100;

    [SerializeField] Color maxHealthColor, zeroHealthColor;

    int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateText();
    }

    void UpdateText()
    {
        textComponent.text = "Health:" + currentHealth;
        float healthRatio = (float)currentHealth / maxHealth;
        textComponent.color = Color.Lerp(zeroHealthColor,maxHealthColor, healthRatio);
    }

    public void Kill()
    {
        currentHealth = 0;
        UpdateText();
    }

    public bool IsDead()
    {
        return currentHealth <= 0;
    }

    public void Damage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateText();
    }
}
