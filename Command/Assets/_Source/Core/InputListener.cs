using UnityEngine;
using Command;

namespace Core
{
    public class InputListener : MonoBehaviour
    {
        private CommandInvoker _commandInvoker;
        private Camera _mainCamera;

        public void Construct(Camera mainCamera, CommandInvoker commandInvoker)
        {
            _mainCamera = mainCamera;
            _commandInvoker = commandInvoker;
        }
        
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
                _commandInvoker.Execute(ClickType.LeftClick, _mainCamera.ScreenToWorldPoint(Input.mousePosition));
            else if (Input.GetMouseButtonDown(1))
                _commandInvoker.Execute(ClickType.RightClick, _mainCamera.ScreenToWorldPoint(Input.mousePosition));
            else if (Input.GetMouseButtonDown(2))
                _commandInvoker.Undo();
            else if (Input.GetKeyDown(KeyCode.KeypadEnter))
                _commandInvoker.ExecuteRightClickCommands();
        }
    }
}