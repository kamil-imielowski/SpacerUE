using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    class Student : MonoBehaviour
    {
        void OnTriggerEnter(Collider other)
        {
            var gameController = GameObject.Find("GameManager").GetComponent<GameController>(); 
            if (other.gameObject.CompareTag("ECTS"))
            {
                AudioSource otherAudio = other.gameObject.GetComponent<AudioSource>();
                AudioSource.PlayClipAtPoint(otherAudio.clip, transform.position);
                other.gameObject.SetActive(false);

                gameController.AddEcts(1);
            }
        }
    }
}
