using UnityEngine;
using System.Collections;
using Prototypes.Ingame;

namespace Prototypes.Backbone
{

    /// <summary>
    /// InputController manages the main update-routine and 
    /// stops updating if the game is pausing
    /// </summary>

    public class InputController : MonoBehaviour
    {

        #region class intern values

        private InputContainer _inputContainer = null;
        private GameManager _gm = null;

        #endregion class intern values

        #region init

        private void Awake()
        {
            // initialize all classintern things here
            _inputContainer = new InputContainer();
        }

        private void Start()
        {
            // get references from other classes here
            if (GameManager.Instance != null) _gm = GameManager.Instance;
            else Debug.Log("there is no GameManager");
        }

        #endregion init

        // Update is called once per frame
        private void Update()
        {
            if (!_gm.Pause)
            {
                // reset InputContainer
                _inputContainer.ResetInputContainer();

                // get current input

            }
        }
    }
}