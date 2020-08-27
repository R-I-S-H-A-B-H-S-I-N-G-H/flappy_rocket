using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
   // public Transform firepos;
    public GameObject fire;
    public float ypos;
    List<GameObject> l;
    public float jumpforce=100f;
    GameObject o;
    public Rigidbody2D rb;
    float timer=0;

    private void Start()
    {
        l=new List<GameObject>();
    }
    private void Update()
    {
        ypos=this.transform.position.y;
        if(Input.GetKeyDown("space")||Input.GetMouseButtonDown(0)){
            jump();
        }
     //  transform.eulerAngles=new Vector3(0,0,rb.velocity.y*0.1f);
    }
    void jump(){
        
        rb.velocity=Vector2.up* jumpforce;
        if(o!=null){
            o.SetActive(false);
            Destroy(o);

        }
        o= Instantiate(fire,fire.transform.position,Quaternion.identity);
       o.SetActive(true);
       l.Add(o);
       //Destroy(o);

    }
//     void destroy(){
//         timer=0;
//         if(l.Count>0){
//             if(l.Count>=15){
//                 for(int i=0;i<=10;i++){
//                     Destroy( l[i]);
//                     l.RemoveAt(i);

//                 } 

            
//            else{
//                 Destroy( l[0]);
//                 l.RemoveAt(0);
//            }
//         }
//     }
// }
}

