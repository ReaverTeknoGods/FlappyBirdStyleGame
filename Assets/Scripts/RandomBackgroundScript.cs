using UnityEngine;
using System.Collections;


public class RandomBackgroundScript : MonoBehaviour {
	public RandomBackgroundScript RandomBackgroundScriptMaster;
	public int PictureValue = 0;
	public bool SetMaster = false;
	// Use this for initialization
	void Start () 
	{
		if (RandomBackgroundScriptMaster == null)
		{
			PictureValue = Random.Range(0, Backgrounds.Length);
			(GetComponent<Renderer>() as SpriteRenderer).sprite = Backgrounds[PictureValue];
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(!SetMaster && RandomBackgroundScriptMaster != null)
        {
			(GetComponent<Renderer>() as SpriteRenderer).sprite = Backgrounds[RandomBackgroundScriptMaster.PictureValue];
			SetMaster = true;
		}
	}

    public Sprite[] Backgrounds;
}
