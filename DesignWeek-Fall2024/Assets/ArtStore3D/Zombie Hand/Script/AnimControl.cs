using UnityEngine;
//ArtStore3D
public class AnimControl : MonoBehaviour
{
    Animator anim;
    int num=1;
    void Start()
    {
        anim=GetComponent<Animator>();
     Debug.Log("ArtStore3D");
    }

    // Update is called once per frame
    void Update()
    {

          if (Input.GetKeyDown(KeyCode.Space))

        {
            num = (num % 5) + 1;
            anim.SetFloat("Num", num);

        }
    }
}
