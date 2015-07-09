using UnityEngine;
using System.Collections;

namespace Prototypes.Backbone
{

    /// <summary>
    /// InputContainer gets instantiated by the InputController, 
    /// gets values overwritten by the InputReader and 
    /// and updates all classes through the InputController
    /// </summary>

    public class InputContainer : MonoBehaviour
    {

        #region data structures

        public struct InputValues
        {
           //bool touch = false;

        }

        #endregion data structures

        #region class intern values

        private InputValues _inputValues;

        #endregion class intern values

        #region init

        private void Awake()
        {
            //_inputValues = new InputValues();
        }

        #endregion init

        #region interface

        public void ResetInputContainer()
        {
            // reset all values before getting new ones

        }

        #endregion interface

    }
}