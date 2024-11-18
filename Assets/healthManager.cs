using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthManager : MonoBehaviour
{
	// 3D compatible version of 2D tutorial here: https://www.youtube.com/watch?v=0tDPxNB2JNs
	// this accesses the rect transform of the heathbar green "background Image"
	// in a full 3d scene, you would need to import sprites to do the 2D youtube tutorial as is
	// one issue with the 2d tut is it used the image as filled an dnot sliced, and this gave rounded corners unless edited
	// this is the alternative, and is full 3d compatible
	// the background image needs the X pivot set to 0 in inspector to scale from the left
	// there are many ways to do this, this is one that uses just the UI background image, sliced images, and RectTransform to scale width (x in 2d vector))
	// you could also access with: RectTransform healthBarRT = healthBar.GetComponent<RectTransform>();

	//This accesses the RectTransform: X and Y or Width and Height of the green health bar dragged into public variable below exposed in the inspector
	public RectTransform healthBarRT;
	public float healthAmount = 450f;


	// Update is called once per frame
	void Update()
	{
		if (healthAmount <= 0)
		{
			Application.LoadLevel(Application.loadedLevel); // Reload the current level
		}

		if (Input.GetKeyDown(KeyCode.Return))
		{
			TakeDamage(20); // Take 20 damage when the Enter key is pressed
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{
			Heal(5); // Heal 5 health when the Space key is pressed
		}
	}

	public void TakeDamage(float damage)
	{
		healthAmount -= damage;
		//scale width (x) of green image (drag green health bar into exposed variable box in inspector script)
		healthBarRT.sizeDelta = new Vector2(healthAmount, 100);
	}

	public void Heal(float healingAmount)
	{
		healthAmount += healingAmount;
		healthAmount = Mathf.Clamp(healthAmount, 0, 450f);
		
		healthBarRT.sizeDelta = new Vector2(healthAmount, 100);
	}
}
