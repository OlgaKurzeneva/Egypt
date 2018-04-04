using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pick : MonoBehaviour
{
    public int parts = 0;

    void OnCollisionEnter(Collision myCollision)
    {
        if (myCollision.gameObject.name == "f1" || myCollision.gameObject.name == "f")
        {
            // Обращаемся к имени объекта с которым столкнулись
            Destroy(myCollision.gameObject);
            Debug.Log("Good");
            parts++;
        }

        if (myCollision.gameObject.name == "door2" && parts == 2)
        {
            // Обращаемся к имени объекта с которым столкнулись
            Destroy(myCollision.gameObject.GetComponent<BoxCollider>());
        }
    }
}
//    void OnTriggerEnter(Collider myCollision)
//    {

//        if (myCollision.gameObject.name == "f1" || myCollision.gameObject.name == "f")
//        {
//        //    // Обращаемся к имени объекта с которым столкнулись
//            //Destroy(gameObject);
//            Debug.Log("Good");
//            parts++;
//        }

//        //if (myCollision.gameObject.name == "door2" && parts == 2)
//        //{
//        //    // Обращаемся к имени объекта с которым столкнулись
//        //    Destroy(myCollision.gameObject.GetComponent<BoxCollider>());
//        //}
//    }
//}
