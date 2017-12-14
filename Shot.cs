/* Gun'em Down
 * Shot.cs
 * Created by Mauro J. Pappaterra on 07 of July 2017.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour {

    public float speed;

    void Start(){
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }
}
