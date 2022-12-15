
using System;
using UnityEngine;
using TMPro;

class HealthObject : MonoBehaviour
{
    [SerializeField] TMP_Text textComponent;
    [SerializeField] int maxHealth = 100;

    [SerializeField] GameObject objectToTurnOnWhenDie;

    [SerializeField] Color maxHealthColor, zeroHealthColor;

    int currentHealth;

    const string healthKey = "health";

   

    private void OnDestroy()
    {
        PlayerPrefs.SetInt(healthKey, currentHealth);
    }



    void Start()
    {
        if (PlayerPrefs.HasKey(healthKey))
        {
            currentHealth = PlayerPrefs.GetInt(healthKey);
        }
        if (currentHealth == 0)
        {
            currentHealth = maxHealth;

        }
        UpdateText();
    }

    void UpdateText()
    {
        textComponent.text = "Health:" + currentHealth;
        float healthRatio = (float)currentHealth / maxHealth;
        textComponent.color = Color.Lerp(zeroHealthColor, maxHealthColor, healthRatio);
    }

    public void Kill()
    {
        currentHealth = 0;
        UpdateText();
        TestDeath();
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
        TestDeath();
    }

    void TestDeath()
    {
        if (IsDead())
        {
            objectToTurnOnWhenDie?.SetActive(true); //?. arra kell hogy ha bekötött objectrl van szó, de nincs bekötve semmi akkor sem errort ad.
        }
    }
}
