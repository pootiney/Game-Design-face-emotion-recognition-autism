using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class make_face : MonoBehaviour
{
    public int sprite_count; // this variable changes the face 
    public GameObject eye_l; // this is the left eye game object (Base class for all entities in Unity Scenes.)
    public GameObject eye_r; // this is the right eye game object
    public GameObject mouth; // this is the mouth game object
    public Transform tr_1; //Every object in a Scene has a Transform. It's used to store and manipulate the position, rotation and scale of the object.
    public Transform tr_2;
    public Transform tr_3;
    public Vector3 v;
    public Vector3 v1;
    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;
    public Sprite[] spriteArray_1;
    public Sprite[] spriteArray_2;
    public Sprite[] spriteArray_3;
    // Start is called before the first frame update
    void Start()
    {
        sprite_count = 0;
        tr_2 = eye_r.transform;
        tr_3 = mouth.transform;
        v = new Vector3(1.5f, -1, 0.5497855f);
        v1= new Vector3(2, -2, 0.5497855f);
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = spriteArray[sprite_count];
        spriteRenderer.sprite = spriteArray_1[sprite_count];
        spriteRenderer.sprite = spriteArray_2[sprite_count];
        spriteRenderer.sprite = spriteArray_3[sprite_count];

    }

    // Update is called once per frame
    void Update()
    {

        tr_1 = eye_l.transform;
        print(eye_l.transform.localPosition);
        if (tr_1.localPosition.x > v.x && tr_1.localPosition.x < v1.x && tr_1.localPosition.y < v.y && tr_1.localPosition.y > v1.y)
        {
            sprite_count += 1;
            print("yes");
            spriteRenderer.sprite = spriteArray[sprite_count];

        }
      
    }
}