using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OX : MonoBehaviour 
{
	public GameObject Drawn;
	public GameObject Xwin;
	public GameObject Owin;
	private bool num1;
	public Text t1;
	public Text t2;
	public Text t3;
	public Text t4;
	public Text t5;
	public Text t6;
	public Text t7;
	public Text t8;
	public Text t9;
	public int Drawns;



	void Start () {
		num1 = true;
		Drawns = 0;
	}
	void Update () {
		WinGame ();
		xwin ();
		owin ();
		drawn();
	}

	public void text1 ()
	{
		//print ("AAA");
		if(num1){
			t1.text = "X";
		num1 = false;
		}
		else{
			t1.text = "O";
			num1 = true;
		}
		Drawns +=1;
	}
	public void text2 ()
	{
		if(num1){
			t2.text = "X";
			num1 = false;
		}
		else{
			t2.text = "O";
			num1 = true;
		}
		Drawns +=1;
	}
	public void text3 ()
	{
		if(num1){
			t3.text = "X";
			num1 = false;
		}
		else{
			t3.text = "O";
			num1 = true;
		}
		Drawns +=1;
	}
	public void text4 ()
	{
		if(num1){
			t4.text = "X";
			num1 = false;
		}
		else{
			t4.text = "O";
			num1 = true;
		}
		Drawns +=1;
	}
	public void text5 ()
	{
		if(num1){
			t5.text = "X";
			num1 = false;
		}
		else{
			t5.text = "O";
			num1 = true;
		}
		Drawns +=1;
	}
	public void text6 ()
	{
		if(num1){
			t6.text = "X";
			num1 = false;
		}
		else{
			t6.text = "O";
			num1 = true;
		}
		Drawns +=1;
	}
	public void text7 ()
	{
		if(num1){
			t7.text = "X";
			num1 = false;
		}
		else{
			t7.text = "O";
			num1 = true;
		}
		Drawns +=1;
	}
	public void text8 ()
	{
		if(num1){
			t8.text = "X";
			num1 = false;
		}
		else{
			t8.text = "O";
			num1 = true;
		}
		Drawns +=1;
	}
	public void text9 ()
	{
		if(num1){
			t9.text = "X";
			num1 = false;
		}
		else{
			t9.text = "O";
			num1 = true;
		}
		Drawns +=1;
	}
	

		void WinGame ()
		{
			if(t1.text == "X" && t2.text == "X" && t3.text == "X"){
				Debug.Log("X win");
			}
			else if(t1.text == "X" && t4.text == "X" && t7.text == "X"){
				Debug.Log("X win");
			}
			else if(t1.text == "X" && t5.text == "X" && t9.text == "X"){
				Debug.Log("X win");
			}
			else if(t1.text == "X" && t4.text == "X" && t7.text == "X"){
				Debug.Log("X win");
			}
			else if(t4.text == "X" && t5.text == "X" && t6.text == "X"){
				Debug.Log("X win");
			}
			else if(t7.text == "X" && t8.text == "X" && t9.text == "X"){
				Debug.Log("X win");
			}
			else if(t1.text == "O" && t2.text == "O" && t3.text == "O"){
				Debug.Log("O win");
			}
			else if(t1.text == "O" && t4.text == "O" && t7.text == "O"){
				Debug.Log("O win");
			}
			else if(t1.text == "O" && t5.text == "O" && t9.text == "O"){
				Debug.Log("O win");
			}
			else if(t1.text == "O" && t4.text == "O" && t7.text == "O"){
				Debug.Log("O win");
			}
			else if(t4.text == "O" && t5.text == "O" && t6.text == "O"){
				Debug.Log("O win");
			}
			else if(t7.text == "O" && t8.text == "O" && t9.text == "O"){
				Debug.Log("O win");
			}
			else {
				Debug.Log ("Drawn");
			}
		}

	public void xwin ()
	{
		if(t1.text == "X" && t2.text == "X" && t3.text == "X"){
			Xwin.SetActive(true);
			Invoke ("Load", 2);
			}
			else if(t1.text == "X" && t4.text == "X" && t7.text == "X"){
			Xwin.SetActive(true);
			Invoke ("Load", 2);
			}
			else if(t1.text == "X" && t5.text == "X" && t9.text == "X"){
			Xwin.SetActive(true);
			Invoke ("Load", 2);
			}
			else if(t1.text == "X" && t4.text == "X" && t7.text == "X"){
			Xwin.SetActive(true);
			Invoke ("Load", 2);
			}
			else if(t4.text == "X" && t5.text == "X" && t6.text == "X"){
			Xwin.SetActive(true);
			Invoke ("Load", 2);
			}
			else if(t7.text == "X" && t8.text == "X" && t9.text == "X"){
			Xwin.SetActive(true);
			Invoke ("Load", 2);
			}
			else if(t2.text == "X" && t5.text == "X" && t8.text == "X"){
			Xwin.SetActive(true);
			Invoke ("Load", 2);
		}       

	}
	public void owin ()
	{
		if(t1.text == "O" && t2.text == "O" && t3.text == "O"){
			Owin.SetActive(true);
			Invoke ("Load", 2);
		}
		else if(t1.text == "O" && t4.text == "O" && t7.text == "O"){
			Owin.SetActive(true);
			Invoke ("Load", 2);
		}
		else if(t1.text == "O" && t5.text == "O" && t9.text == "O"){
			Owin.SetActive(true);
			Invoke ("Load", 2);
		}
		else if(t1.text == "O" && t4.text == "O" && t7.text == "O"){
			Owin.SetActive(true);
			Invoke ("Load", 2);
		}
		else if(t4.text == "O" && t5.text == "O" && t6.text == "O"){
			Owin.SetActive(true);
			Invoke ("Load", 2);
		}
		else if(t7.text == "O" && t8.text == "O" && t9.text == "O"){
			Owin.SetActive(true);
			Invoke ("Load", 2);
		}
	}
	public void drawn()
	{
		if(Drawns == 9)
		{
			Drawn.SetActive(true);
		}
	}
	public void Load()
	{
		Application.LoadLevel("OX");
	}
}
		


	




































