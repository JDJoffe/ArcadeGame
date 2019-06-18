using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RubberSumo
{
    [RequireComponent(typeof(CharacterController))]
    public class Player : MonoBehaviour
    {
        //movement direction
        public Vector3 Movement;
        private CharacterController playercont;

        #region Variables

        [Header("Player Variables")]
        public float jumpHeight = 10f;
        public float moveSpeed = 20f;
        public float Gravity = 20f;

        #endregion
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
