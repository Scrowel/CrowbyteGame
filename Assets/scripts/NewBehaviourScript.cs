using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update()
	{
		//Preguntar por una tecla para accionar algo cuando es presionada (En este caso la flecha derecha)
		if (Input.GetKey(KeyCode.RightArrow))
		{
			//flipea la  imagen a la derecha si esta hacia la izquierda
			if (GetComponent<SpriteRenderer>().flipX == true)
			{
				GetComponent<SpriteRenderer>().flipX = false;
			}
			//mueve el personaje a la derechachacha
			if (!Input.GetKey (KeyCode.X) && !Input.GetKey (KeyCode.Z)) {
				GetComponent<Animator> ().SetBool ("caminar", true);
				transform.Translate (0.05f, 0, 0);
			}
		}
		//Preguntar por una tecla para accionar algo cuando es presionada (En este caso la flecha izquierda)
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			//flipea la  imagen a la izquierda si esta hacia la derecha
			if (GetComponent<SpriteRenderer>().flipX == false)
			{
				GetComponent<SpriteRenderer>().flipX = true;
			}
			//mueve el personaje a la izquierdadada
			if (!Input.GetKey (KeyCode.X) && !Input.GetKey (KeyCode.Z)) {
				GetComponent<Animator> ().SetBool ("caminar", true);
				transform.Translate (-0.05f, 0, 0);
			}
		}
		//esto es para cambiar la animacion a la de movimiento hacia la derechachacha
		if (Input.GetKeyUp(KeyCode.RightArrow))
		{
			GetComponent<Animator>().SetBool("caminar", false);
		}
		if (Input.GetKeyUp(KeyCode.LeftArrow))
		{
			GetComponent<Animator>().SetBool("caminar", false);
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			
			//mueve el personaje a la izquierdadada

				GetComponent<Animator> ().SetBool ("saltar", true);
				transform.Translate (0, 0.1f, 0);

		}
		if (!Input.GetKey(KeyCode.UpArrow))
		{

			//mueve el personaje a la izquierdadada
		
				GetComponent<Animator> ().SetBool ("saltar", false);
				transform.Translate (0, 0, 0);
			
		}
	}
	}