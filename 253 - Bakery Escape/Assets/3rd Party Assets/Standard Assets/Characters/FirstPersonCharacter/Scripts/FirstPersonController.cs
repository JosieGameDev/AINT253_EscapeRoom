using System;

using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;
using Random = UnityEngine.Random;

namespace UnityStandardAssets.Characters.FirstPerson
{
    [RequireComponent(typeof (CharacterController))]
    //[RequireComponent(typeof (AudioSource))]
    public class FirstPersonController : MonoBehaviour
    {
        [SerializeField] private bool m_IsWalking;
        [SerializeField] private float m_WalkSpeed;
       
        [SerializeField] private MouseLook m_MouseLook;
        

        private Camera m_Camera;
        private bool m_Jump;
        private float m_YRotation;
        private Vector2 m_Input;
        private Vector3 m_MoveDir = Vector3.zero;
        private CharacterController m_CharacterController;
        private CollisionFlags m_CollisionFlags;
        //private bool m_PreviouslyGrounded;
        private Vector3 m_OriginalCameraPosition;
       
        private float m_NextStep;
        
        public float speed = 4;

        public bool mouseLookOn = true;

        // Use this for initialization
        private void Start()
        {
            m_CharacterController = GetComponent<CharacterController>();
            m_Camera = Camera.main;
            m_OriginalCameraPosition = m_Camera.transform.localPosition;
           
			m_MouseLook.Init(transform , m_Camera.transform);
            
            m_MouseLook.SetCursorLock(true);
        }


        // Update is called once per frame
        private void Update()
        {
            if (mouseLookOn)
            {
                RotateView();
            }
        }

        public void stopMouseLook()
        {
            mouseLookOn = false;
        }

        public void restartMouseLook()
        {
            mouseLookOn = true;
        }
       

        private void FixedUpdate()
        {
            if (mouseLookOn)
            {

                GetInput();
                // always move along the camera forward as it is the direction that it being aimed at
                Vector3 desiredMove = transform.forward * m_Input.y + transform.right * m_Input.x;

                // get a normal for the surface that is being touched to move along it
                RaycastHit hitInfo;
                Physics.SphereCast(transform.position, m_CharacterController.radius, Vector3.down, out hitInfo,
                                   m_CharacterController.height / 2f, Physics.AllLayers, QueryTriggerInteraction.Ignore);
                desiredMove = Vector3.ProjectOnPlane(desiredMove, hitInfo.normal).normalized;

                m_MoveDir.x = desiredMove.x * speed;
                m_MoveDir.z = desiredMove.z * speed;



                m_CollisionFlags = m_CharacterController.Move(m_MoveDir * Time.fixedDeltaTime);

                //ProgressStepCycle(speed);
                UpdateCameraPosition(speed);

            }
        }


        public void lockCursor()
        {
            m_MouseLook.SetCursorLock(true);
        }

        public void unlockCursor()
        {
            m_MouseLook.SetCursorLock(false);
        }


        private void UpdateCameraPosition(float speed)
        {
            Vector3 newCameraPosition;
            
            newCameraPosition = m_Camera.transform.localPosition;
            m_Camera.transform.localPosition = newCameraPosition;
        }


        private void GetInput()
        {
            // Read input
            float horizontal = CrossPlatformInputManager.GetAxis("Horizontal");
            float vertical = CrossPlatformInputManager.GetAxis("Vertical");


            m_Input = new Vector2(horizontal, vertical);

            // normalize input if it exceeds 1 in combined length:
            if (m_Input.sqrMagnitude > 1)
            {
                m_Input.Normalize();
            }

           
        }


        private void RotateView()
        {
            

                m_MouseLook.LookRotation(transform, m_Camera.transform);
            
        }


    }
}
