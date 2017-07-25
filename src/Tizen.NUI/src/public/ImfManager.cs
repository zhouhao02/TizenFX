/** Copyright (c) 2017 Samsung Electronics Co., Ltd.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

namespace Tizen.NUI
{
    using System;
    using System.Runtime.InteropServices;


    public class ImfManager : BaseHandle
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal ImfManager(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NDalicManualPINVOKE.ImfManager_SWIGUpcast(cPtr), cMemoryOwn)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ImfManager obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        protected override void Dispose(DisposeTypes type)
        {
            if (disposed)
            {
                return;
            }

            if (type == DisposeTypes.Explicit)
            {
                //Called by User
                //Release your own managed resources here.
                //You should release all of your own disposable objects here.

            }

            //Release your own unmanaged resources here.
            //You should not access any managed member here except static instance.
            //because the execution order of Finalizes is non-deterministic.

            if (swigCPtr.Handle != global::System.IntPtr.Zero)
            {
                if (swigCMemOwn)
                {
                    swigCMemOwn = false;

                    //Unreference this instance from Registry.
                    Registry.Unregister(this);

                    NDalicManualPINVOKE.delete_ImfManager(swigCPtr);
                }
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
            }

            base.Dispose(type);
        }

        public class ImfEventData : global::System.IDisposable
        {
            private global::System.Runtime.InteropServices.HandleRef swigCPtr;
            protected bool swigCMemOwn;

            internal ImfEventData(global::System.IntPtr cPtr, bool cMemoryOwn)
            {
                swigCMemOwn = cMemoryOwn;
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
            }

            internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ImfEventData obj)
            {
                return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
            }

            //A Flag to check who called Dispose(). (By User or DisposeQueue)
            private bool isDisposeQueued = false;
            //A Flat to check if it is already disposed.
            protected bool disposed = false;


            ~ImfEventData()
            {
                if (!isDisposeQueued)
                {
                    isDisposeQueued = true;
                    DisposeQueue.Instance.Add(this);
                }
            }

            public void Dispose()
            {
                //Throw excpetion if Dispose() is called in separate thread.
                if (!Window.IsInstalled())
                {
                    throw new System.InvalidOperationException("This API called from separate thread. This API must be called from MainThread.");
                }

                if (isDisposeQueued)
                {
                    Dispose(DisposeTypes.Implicit);
                }
                else
                {
                    Dispose(DisposeTypes.Explicit);
                    System.GC.SuppressFinalize(this);
                }
            }

            protected virtual void Dispose(DisposeTypes type)
            {
                if (disposed)
                {
                    return;
                }

                if (type == DisposeTypes.Explicit)
                {
                    //Called by User
                    //Release your own managed resources here.
                    //You should release all of your own disposable objects here.

                }

                //Release your own unmanaged resources here.
                //You should not access any managed member here except static instance.
                //because the execution order of Finalizes is non-deterministic.

                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        NDalicManualPINVOKE.delete_ImfManager_ImfEventData(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }

                disposed = true;
            }

            public ImfEventData() : this(NDalicManualPINVOKE.new_ImfManager_ImfEventData__SWIG_0(), true)
            {
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }

            public ImfEventData(ImfManager.ImfEvent aEventName, string aPredictiveString, int aCursorOffset, int aNumberOfChars) : this(NDalicManualPINVOKE.new_ImfManager_ImfEventData__SWIG_1((int)aEventName, aPredictiveString, aCursorOffset, aNumberOfChars), true)
            {
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }

            public string predictiveString
            {
                set
                {
                    NDalicManualPINVOKE.ImfManager_ImfEventData_predictiveString_set(swigCPtr, value);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                }
                get
                {
                    string ret = NDalicManualPINVOKE.ImfManager_ImfEventData_predictiveString_get(swigCPtr);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                    return ret;
                }
            }

            public ImfManager.ImfEvent eventName
            {
                set
                {
                    NDalicManualPINVOKE.ImfManager_ImfEventData_eventName_set(swigCPtr, (int)value);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                }
                get
                {
                    ImfManager.ImfEvent ret = (ImfManager.ImfEvent)NDalicManualPINVOKE.ImfManager_ImfEventData_eventName_get(swigCPtr);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                    return ret;
                }
            }

            public int cursorOffset
            {
                set
                {
                    NDalicManualPINVOKE.ImfManager_ImfEventData_cursorOffset_set(swigCPtr, value);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                }
                get
                {
                    int ret = NDalicManualPINVOKE.ImfManager_ImfEventData_cursorOffset_get(swigCPtr);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                    return ret;
                }
            }

            public int numberOfChars
            {
                set
                {
                    NDalicManualPINVOKE.ImfManager_ImfEventData_numberOfChars_set(swigCPtr, value);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                }
                get
                {
                    int ret = NDalicManualPINVOKE.ImfManager_ImfEventData_numberOfChars_get(swigCPtr);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                    return ret;
                }
            }

        }

        public class ImfCallbackData : global::System.IDisposable
        {
            private global::System.Runtime.InteropServices.HandleRef swigCPtr;
            protected bool swigCMemOwn;

            internal ImfCallbackData(global::System.IntPtr cPtr, bool cMemoryOwn)
            {
                swigCMemOwn = cMemoryOwn;
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
            }

            internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ImfCallbackData obj)
            {
                return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
            }

            //A Flag to check who called Dispose(). (By User or DisposeQueue)
            private bool isDisposeQueued = false;
            //A Flat to check if it is already disposed.
            protected bool disposed = false;


            ~ImfCallbackData()
            {
                if (!isDisposeQueued)
                {
                    isDisposeQueued = true;
                    DisposeQueue.Instance.Add(this);
                }
            }

            public void Dispose()
            {
                //Throw excpetion if Dispose() is called in separate thread.
                if (!Window.IsInstalled())
                {
                    throw new System.InvalidOperationException("This API called from separate thread. This API must be called from MainThread.");
                }

                if (isDisposeQueued)
                {
                    Dispose(DisposeTypes.Implicit);
                }
                else
                {
                    Dispose(DisposeTypes.Explicit);
                    System.GC.SuppressFinalize(this);
                }
            }

            protected virtual void Dispose(DisposeTypes type)
            {
                if (disposed)
                {
                    return;
                }

                if (type == DisposeTypes.Explicit)
                {
                    //Called by User
                    //Release your own managed resources here.
                    //You should release all of your own disposable objects here.

                }

                //Release your own unmanaged resources here.
                //You should not access any managed member here except static instance.
                //because the execution order of Finalizes is non-deterministic.

                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        NDalicManualPINVOKE.delete_ImfManager_ImfCallbackData(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }

                disposed = true;
            }

            public ImfCallbackData() : this(NDalicManualPINVOKE.new_ImfManager_ImfCallbackData__SWIG_0(), true)
            {
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }

            public ImfCallbackData(bool aUpdate, int aCursorPosition, string aCurrentText, bool aPreeditResetRequired) : this(NDalicManualPINVOKE.new_ImfManager_ImfCallbackData__SWIG_1(aUpdate, aCursorPosition, aCurrentText, aPreeditResetRequired), true)
            {
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }

            public string currentText
            {
                set
                {
                    NDalicManualPINVOKE.ImfManager_ImfCallbackData_currentText_set(swigCPtr, value);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                }
                get
                {
                    string ret = NDalicManualPINVOKE.ImfManager_ImfCallbackData_currentText_get(swigCPtr);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                    return ret;
                }
            }

            public int cursorPosition
            {
                set
                {
                    NDalicManualPINVOKE.ImfManager_ImfCallbackData_cursorPosition_set(swigCPtr, value);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                }
                get
                {
                    int ret = NDalicManualPINVOKE.ImfManager_ImfCallbackData_cursorPosition_get(swigCPtr);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                    return ret;
                }
            }

            public bool update
            {
                set
                {
                    NDalicManualPINVOKE.ImfManager_ImfCallbackData_update_set(swigCPtr, value);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                }
                get
                {
                    bool ret = NDalicManualPINVOKE.ImfManager_ImfCallbackData_update_get(swigCPtr);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                    return ret;
                }
            }

            public bool preeditResetRequired
            {
                set
                {
                    NDalicManualPINVOKE.ImfManager_ImfCallbackData_preeditResetRequired_set(swigCPtr, value);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                }
                get
                {
                    bool ret = NDalicManualPINVOKE.ImfManager_ImfCallbackData_preeditResetRequired_get(swigCPtr);
                    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                    return ret;
                }
            }

        }

        public static ImfManager Get()
        {
            ImfManager ret = new ImfManager(NDalicManualPINVOKE.ImfManager_Get(), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void Activate()
        {
            NDalicManualPINVOKE.ImfManager_Activate(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public void Deactivate()
        {
            NDalicManualPINVOKE.ImfManager_Deactivate(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public bool RestoreAfterFocusLost()
        {
            bool ret = NDalicManualPINVOKE.ImfManager_RestoreAfterFocusLost(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void SetRestoreAfterFocusLost(bool toggle)
        {
            NDalicManualPINVOKE.ImfManager_SetRestoreAfterFocusLost(swigCPtr, toggle);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public new void Reset()
        {
            NDalicManualPINVOKE.ImfManager_Reset(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public void NotifyCursorPosition()
        {
            NDalicManualPINVOKE.ImfManager_NotifyCursorPosition(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public void SetCursorPosition(uint cursorPosition)
        {
            NDalicManualPINVOKE.ImfManager_SetCursorPosition(swigCPtr, cursorPosition);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public uint GetCursorPosition()
        {
            uint ret = NDalicManualPINVOKE.ImfManager_GetCursorPosition(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void SetSurroundingText(string text)
        {
            NDalicManualPINVOKE.ImfManager_SetSurroundingText(swigCPtr, text);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public string GetSurroundingText()
        {
            string ret = NDalicManualPINVOKE.ImfManager_GetSurroundingText(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void NotifyTextInputMultiLine(bool multiLine)
        {
            NDalicManualPINVOKE.ImfManager_NotifyTextInputMultiLine(swigCPtr, multiLine);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public ImfManager.TextDirection GetTextDirection()
        {
            ImfManager.TextDirection ret = (ImfManager.TextDirection)NDalicManualPINVOKE.ImfManager_GetTextDirection(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public Rectangle GetInputMethodArea()
        {
            Rectangle ret = new Rectangle(NDalicManualPINVOKE.ImfManager_GetInputMethodArea(swigCPtr), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal void ApplyOptions(SWIGTYPE_p_InputMethodOptions options)
        {
            NDalicManualPINVOKE.ImfManager_ApplyOptions(swigCPtr, SWIGTYPE_p_InputMethodOptions.getCPtr(options));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public void SetInputPanelUserData(string text)
        {
            NDalicManualPINVOKE.ImfManager_SetInputPanelUserData(swigCPtr, text);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public void GetInputPanelUserData(string text)
        {
            NDalicManualPINVOKE.ImfManager_GetInputPanelUserData(swigCPtr, text);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public ImfManager.State GetInputPanelState()
        {
            ImfManager.State ret = (ImfManager.State)NDalicManualPINVOKE.ImfManager_GetInputPanelState(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void SetReturnKeyState(bool visible)
        {
            NDalicManualPINVOKE.ImfManager_SetReturnKeyState(swigCPtr, visible);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public void AutoEnableInputPanel(bool enabled)
        {
            NDalicManualPINVOKE.ImfManager_AutoEnableInputPanel(swigCPtr, enabled);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public void ShowInputPanel()
        {
            NDalicManualPINVOKE.ImfManager_ShowInputPanel(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public void HideInputPanel()
        {
            NDalicManualPINVOKE.ImfManager_HideInputPanel(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /*
        public SWIGTYPE_p_Dali__SignalT_void_fDali__ImfManager_RF_t ActivatedSignal()
        {
            SWIGTYPE_p_Dali__SignalT_void_fDali__ImfManager_RF_t ret = new SWIGTYPE_p_Dali__SignalT_void_fDali__ImfManager_RF_t(NDalicManualPINVOKE.ImfManager_ActivatedSignal(swigCPtr), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public SWIGTYPE_p_Dali__SignalT_Dali__ImfManager__ImfCallbackData_fDali__ImfManager_R_Dali__ImfManager__ImfEventData_const_RF_t EventReceivedSignal()
        {
            SWIGTYPE_p_Dali__SignalT_Dali__ImfManager__ImfCallbackData_fDali__ImfManager_R_Dali__ImfManager__ImfEventData_const_RF_t ret = new SWIGTYPE_p_Dali__SignalT_Dali__ImfManager__ImfCallbackData_fDali__ImfManager_R_Dali__ImfManager__ImfEventData_const_RF_t(NDalicManualPINVOKE.ImfManager_EventReceivedSignal(swigCPtr), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public WindowFocusSignalType StatusChangedSignal()
        {
            WindowFocusSignalType ret = new WindowFocusSignalType(NDalicManualPINVOKE.ImfManager_StatusChangedSignal(swigCPtr), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public VoidSignal ResizedSignal()
        {
            VoidSignal ret = new VoidSignal(NDalicManualPINVOKE.ImfManager_ResizedSignal(swigCPtr), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public VoidSignal LanguageChangedSignal()
        {
            VoidSignal ret = new VoidSignal(NDalicManualPINVOKE.ImfManager_LanguageChangedSignal(swigCPtr), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }
        */

        public ImfManager() : this(NDalicManualPINVOKE.new_ImfManager__SWIG_0(), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal ImfManager(SWIGTYPE_p_Dali__Internal__Adaptor__ImfManager imfManager) : this(NDalicManualPINVOKE.new_ImfManager__SWIG_1(SWIGTYPE_p_Dali__Internal__Adaptor__ImfManager.getCPtr(imfManager)), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public enum TextDirection
        {
            LeftToRight,
            RightToLeft
        }

        public enum ImfEvent
        {
            VOID,
            PREEDIT,
            COMMIT,
            DELETESURROUNDING,
            GETSURROUNDING,
            PRIVATECOMMAND
        }

        public enum State
        {
            DEFAULT,
            SHOW,
            HIDE,
            WILL_SHOW
        }



        ///////////////////////////////////////////////////////////////////////////////
        internal static ImfManager GetImfManagerFromPtr(global::System.IntPtr cPtr)
        {
            ImfManager ret = new ImfManager(cPtr, false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public class ImfManagerActivatedEventArgs : EventArgs
        {
            public ImfManager ImfManager
            {
                get;
                set;
            }
        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void ImfManagerActivatedEventCallbackType(global::System.IntPtr data);
        private ImfManagerActivatedEventCallbackType _imfManagerActivatedEventCallback;

        private event EventHandler<ImfManagerActivatedEventArgs> _imfManagerActivatedEventHandler;

        public event EventHandler<ImfManagerActivatedEventArgs> ImfManagerActivated
        {
            add
            {
                if (_imfManagerActivatedEventHandler == null)
                {
                    _imfManagerActivatedEventCallback = OnImfManagerActivated;
                    ActivatedSignal().Connect(_imfManagerActivatedEventCallback);
                }

                _imfManagerActivatedEventHandler += value;
            }
            remove
            {
                _imfManagerActivatedEventHandler -= value;

                if (_imfManagerActivatedEventHandler == null && _imfManagerActivatedEventCallback != null)
                {
                    ActivatedSignal().Disconnect(_imfManagerActivatedEventCallback);
                }
            }
        }

        private void OnImfManagerActivated(global::System.IntPtr data)
        {
            ImfManagerActivatedEventArgs e = new ImfManagerActivatedEventArgs();

            e.ImfManager = ImfManager.GetImfManagerFromPtr(data);

            if (_imfManagerActivatedEventHandler != null)
            {
                _imfManagerActivatedEventHandler(this, e);
            }
        }

        public ActivatedSignalType ActivatedSignal()
        {
            ActivatedSignalType ret = new ActivatedSignalType(NDalicManualPINVOKE.ImfManager_ActivatedSignal(swigCPtr), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        // EventReceivedSignal
        public class ImfManagerEventReceivedEventArgs : EventArgs
        {
            public ImfManager ImfManager
            {
                get;
                set;
            }
        }

        private delegate void ImfManagerEventReceivedEventCallbackType(global::System.IntPtr data);
        private ImfManagerEventReceivedEventCallbackType _imfManagerEventReceivedEventCallback;

        private event EventHandler<ImfManagerEventReceivedEventArgs> _imfManagerEventReceivedEventHandler;
        public event EventHandler<ImfManagerEventReceivedEventArgs> ImfManagerEventReceived
        {
            add
            {
                if (_imfManagerEventReceivedEventHandler == null)
                {
                    _imfManagerEventReceivedEventCallback = OnImfManagerEventReceived;
                    EventReceivedSignal().Connect(_imfManagerEventReceivedEventCallback);
                }

                _imfManagerEventReceivedEventHandler += value;
            }
            remove
            {
                _imfManagerEventReceivedEventHandler -= value;

                if (_imfManagerEventReceivedEventHandler == null && _imfManagerEventReceivedEventCallback != null)
                {
                    EventReceivedSignal().Disconnect(_imfManagerEventReceivedEventCallback);
                }
            }
        }

        private void OnImfManagerEventReceived(global::System.IntPtr data)
        {
            ImfManagerEventReceivedEventArgs e = new ImfManagerEventReceivedEventArgs();

            e.ImfManager = ImfManager.GetImfManagerFromPtr(data);

            if (_imfManagerEventReceivedEventHandler != null)
            {
                _imfManagerEventReceivedEventHandler(this, e);
            }
        }

        public ImfEventSignalType EventReceivedSignal()
        {
            ImfEventSignalType ret = new ImfEventSignalType(NDalicManualPINVOKE.ImfManager_EventReceivedSignal(swigCPtr), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        // StatusChangedSignal
        public class ImfManagerStatusChangedEventArgs : EventArgs
        {
            public ImfManager ImfManager
            {
                get;
                set;
            }
        }

        private delegate void ImfManagerStatusChangedEventCallbackType(global::System.IntPtr data);
        private ImfManagerStatusChangedEventCallbackType _imfManagerStatusChangedEventCallback;

        private event EventHandler<ImfManagerStatusChangedEventArgs> _imfManagerStatusChangedEventHandler;

        public event EventHandler<ImfManagerStatusChangedEventArgs> ImfManagerStatusChanged
        {
            add
            {
                if (_imfManagerStatusChangedEventHandler == null)
                {
                    _imfManagerStatusChangedEventCallback = OnImfManagerStatusChanged;
                    StatusChangedSignal().Connect(_imfManagerStatusChangedEventCallback);
                }

                _imfManagerStatusChangedEventHandler += value;
            }
            remove
            {
                _imfManagerStatusChangedEventHandler -= value;

                if (_imfManagerStatusChangedEventHandler == null && _imfManagerStatusChangedEventCallback != null)
                {
                    StatusChangedSignal().Disconnect(_imfManagerStatusChangedEventCallback);
                }
            }
        }

        private void OnImfManagerStatusChanged(global::System.IntPtr data)
        {
            ImfManagerStatusChangedEventArgs e = new ImfManagerStatusChangedEventArgs();

            e.ImfManager = ImfManager.GetImfManagerFromPtr(data);

            if (_imfManagerStatusChangedEventHandler != null)
            {
                _imfManagerStatusChangedEventHandler(this, e);
            }
        }

        public StatusSignalType StatusChangedSignal()
        {
            StatusSignalType ret = new StatusSignalType(NDalicManualPINVOKE.ImfManager_StatusChangedSignal(swigCPtr), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        // ResizedSignal
        public class ImfManagerResizedEventArgs : EventArgs
        {
            public ImfManager ImfManager
            {
                get;
                set;
            }
        }

        private delegate void ImfManagerResizedEventCallbackType(global::System.IntPtr data);
        private ImfManagerResizedEventCallbackType _imfManagerResizedEventCallback;

        private event EventHandler<ImfManagerResizedEventArgs> _imfManagerResizedEventHandler;

        public event EventHandler<ImfManagerResizedEventArgs> ImfManagerResized
        {
            add
            {
                if (_imfManagerResizedEventHandler == null)
                {
                    _imfManagerResizedEventCallback = OnImfManagerResized;
                    ResizedSignal().Connect(_imfManagerResizedEventCallback);
                }

                _imfManagerResizedEventHandler += value;
            }
            remove
            {
                _imfManagerResizedEventHandler -= value;

                if (_imfManagerResizedEventHandler == null && _imfManagerResizedEventCallback != null)
                {
                    ResizedSignal().Disconnect(_imfManagerResizedEventCallback);
                }
            }
        }

        private void OnImfManagerResized(global::System.IntPtr data)
        {
            ImfManagerResizedEventArgs e = new ImfManagerResizedEventArgs();

            e.ImfManager = ImfManager.GetImfManagerFromPtr(data);

            if (_imfManagerResizedEventHandler != null)
            {
                _imfManagerResizedEventHandler(this, e);
            }
        }

        public ImfVoidSignalType ResizedSignal()
        {
            ImfVoidSignalType ret = new ImfVoidSignalType(NDalicManualPINVOKE.ImfManager_ResizedSignal(swigCPtr), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        // LanguageChangedSignal
        public class ImfManagerLanguageChangedEventArgs : EventArgs
        {
            public ImfManager ImfManager
            {
                get;
                set;
            }
        }

        private delegate void ImfManagerLanguageChangedEventCallbackType(global::System.IntPtr data);
        private ImfManagerLanguageChangedEventCallbackType _imfManagerLanguageChangedEventCallback;

        private event EventHandler<ImfManagerLanguageChangedEventArgs> _imfManagerLanguageChangedEventHandler;

        public event EventHandler<ImfManagerLanguageChangedEventArgs> ImfManagerLanguageChanged
        {
            add
            {
                if (_imfManagerLanguageChangedEventHandler == null)
                {
                    _imfManagerLanguageChangedEventCallback = OnImfManagerLanguageChanged;
                    LanguageChangedSignal().Connect(_imfManagerLanguageChangedEventCallback);
                }

                _imfManagerLanguageChangedEventHandler += value;
            }
            remove
            {
                _imfManagerLanguageChangedEventHandler -= value;

                if (_imfManagerLanguageChangedEventHandler == null && _imfManagerLanguageChangedEventCallback != null)
                {
                    LanguageChangedSignal().Disconnect(_imfManagerLanguageChangedEventCallback);
                }
            }
        }

        private void OnImfManagerLanguageChanged(global::System.IntPtr data)
        {
            ImfManagerLanguageChangedEventArgs e = new ImfManagerLanguageChangedEventArgs();

            e.ImfManager = ImfManager.GetImfManagerFromPtr(data);

            if (_imfManagerLanguageChangedEventHandler != null)
            {
                _imfManagerLanguageChangedEventHandler(this, e);
            }
        }

        public ImfVoidSignalType LanguageChangedSignal()
        {
            ImfVoidSignalType ret = new ImfVoidSignalType(NDalicManualPINVOKE.ImfManager_LanguageChangedSignal(swigCPtr), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }
    }

    ///////////////////////////////////////////////////////////////////////////////
    internal class SWIGTYPE_p_Dali__Internal__Adaptor__ImfManager
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal SWIGTYPE_p_Dali__Internal__Adaptor__ImfManager(global::System.IntPtr cPtr, bool futureUse)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        protected SWIGTYPE_p_Dali__Internal__Adaptor__ImfManager()
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SWIGTYPE_p_Dali__Internal__Adaptor__ImfManager obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }
    }

    internal class SWIGTYPE_p_InputMethodOptions
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal SWIGTYPE_p_InputMethodOptions(global::System.IntPtr cPtr, bool futureUse)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        protected SWIGTYPE_p_InputMethodOptions()
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SWIGTYPE_p_InputMethodOptions obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }
    }

    ///////////////////////////////////////////////////////////////////////////////
    public class ActivatedSignalType : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal ActivatedSignalType(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ActivatedSignalType obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        //A Flag to check who called Dispose(). (By User or DisposeQueue)
        private bool isDisposeQueued = false;
        //A Flat to check if it is already disposed.
        protected bool disposed = false;


        ~ActivatedSignalType()
        {
            if (!isDisposeQueued)
            {
                isDisposeQueued = true;
                DisposeQueue.Instance.Add(this);
            }
        }

        public void Dispose()
        {
            //Throw excpetion if Dispose() is called in separate thread.
            if (!Window.IsInstalled())
            {
                throw new System.InvalidOperationException("This API called from separate thread. This API must be called from MainThread.");
            }

            if (isDisposeQueued)
            {
                Dispose(DisposeTypes.Implicit);
            }
            else
            {
                Dispose(DisposeTypes.Explicit);
                System.GC.SuppressFinalize(this);
            }
        }

        protected virtual void Dispose(DisposeTypes type)
        {
            if (disposed)
            {
                return;
            }

            if (type == DisposeTypes.Explicit)
            {
                //Called by User
                //Release your own managed resources here.
                //You should release all of your own disposable objects here.

            }

            //Release your own unmanaged resources here.
            //You should not access any managed member here except static instance.
            //because the execution order of Finalizes is non-deterministic.

            if (swigCPtr.Handle != global::System.IntPtr.Zero)
            {
                if (swigCMemOwn)
                {
                    swigCMemOwn = false;
                    NDalicManualPINVOKE.delete_ActivatedSignalType(swigCPtr);
                }
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
            }

            disposed = true;
        }

        public bool Empty()
        {
            bool ret = NDalicManualPINVOKE.ActivatedSignalType_Empty(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public uint GetConnectionCount()
        {
            uint ret = NDalicManualPINVOKE.ActivatedSignalType_GetConnectionCount(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void Connect(System.Delegate func)
        {
            System.IntPtr ip = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(func);
            {
                NDalicManualPINVOKE.ActivatedSignalType_Connect(swigCPtr, new System.Runtime.InteropServices.HandleRef(this, ip));
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void Disconnect(System.Delegate func)
        {
            System.IntPtr ip = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(func);
            {
                NDalicManualPINVOKE.ActivatedSignalType_Disconnect(swigCPtr, new System.Runtime.InteropServices.HandleRef(this, ip));
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void Emit(bool arg)
        {
            NDalicManualPINVOKE.ActivatedSignalType_Emit(swigCPtr, arg);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public ActivatedSignalType() : this(NDalicManualPINVOKE.new_ActivatedSignalType(), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

    }

    ///////////////////////////////////////////////////////////////////////////////
    public class ImfEventSignalType : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal ImfEventSignalType(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ImfEventSignalType obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        //A Flag to check who called Dispose(). (By User or DisposeQueue)
        private bool isDisposeQueued = false;
        //A Flat to check if it is already disposed.
        protected bool disposed = false;


        ~ImfEventSignalType()
        {
            if (!isDisposeQueued)
            {
                isDisposeQueued = true;
                DisposeQueue.Instance.Add(this);
            }
        }

        public void Dispose()
        {
            //Throw excpetion if Dispose() is called in separate thread.
            if (!Window.IsInstalled())
            {
                throw new System.InvalidOperationException("This API called from separate thread. This API must be called from MainThread.");
            }

            if (isDisposeQueued)
            {
                Dispose(DisposeTypes.Implicit);
            }
            else
            {
                Dispose(DisposeTypes.Explicit);
                System.GC.SuppressFinalize(this);
            }
        }

        protected virtual void Dispose(DisposeTypes type)
        {
            if (disposed)
            {
                return;
            }

            if (type == DisposeTypes.Explicit)
            {
                //Called by User
                //Release your own managed resources here.
                //You should release all of your own disposable objects here.

            }

            //Release your own unmanaged resources here.
            //You should not access any managed member here except static instance.
            //because the execution order of Finalizes is non-deterministic.

            if (swigCPtr.Handle != global::System.IntPtr.Zero)
            {
                if (swigCMemOwn)
                {
                    swigCMemOwn = false;
                    NDalicManualPINVOKE.delete_ImfEventSignalType(swigCPtr);
                }
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
            }

            disposed = true;
        }

        public bool Empty()
        {
            bool ret = NDalicManualPINVOKE.ImfEventSignalType_Empty(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public uint GetConnectionCount()
        {
            uint ret = NDalicManualPINVOKE.ImfEventSignalType_GetConnectionCount(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void Connect(System.Delegate func)
        {
            System.IntPtr ip = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(func);
            {
                NDalicManualPINVOKE.ImfEventSignalType_Connect(swigCPtr, new System.Runtime.InteropServices.HandleRef(this, ip));
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void Disconnect(System.Delegate func)
        {
            System.IntPtr ip = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(func);
            {
                NDalicManualPINVOKE.ImfEventSignalType_Disconnect(swigCPtr, new System.Runtime.InteropServices.HandleRef(this, ip));
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void Emit(bool arg1, bool arg2)
        {
            NDalicManualPINVOKE.ImfEventSignalType_Emit(swigCPtr, arg1, arg2);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public ImfEventSignalType() : this(NDalicManualPINVOKE.new_ImfEventSignalType(), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

    }

    ///////////////////////////////////////////////////////////////////////////////
    public class StatusSignalType : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal StatusSignalType(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(StatusSignalType obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        //A Flag to check who called Dispose(). (By User or DisposeQueue)
        private bool isDisposeQueued = false;
        //A Flat to check if it is already disposed.
        protected bool disposed = false;


        ~StatusSignalType()
        {
            if (!isDisposeQueued)
            {
                isDisposeQueued = true;
                DisposeQueue.Instance.Add(this);
            }
        }

        public void Dispose()
        {
            //Throw excpetion if Dispose() is called in separate thread.
            if (!Window.IsInstalled())
            {
                throw new System.InvalidOperationException("This API called from separate thread. This API must be called from MainThread.");
            }

            if (isDisposeQueued)
            {
                Dispose(DisposeTypes.Implicit);
            }
            else
            {
                Dispose(DisposeTypes.Explicit);
                System.GC.SuppressFinalize(this);
            }
        }

        protected virtual void Dispose(DisposeTypes type)
        {
            if (disposed)
            {
                return;
            }

            if (type == DisposeTypes.Explicit)
            {
                //Called by User
                //Release your own managed resources here.
                //You should release all of your own disposable objects here.

            }

            //Release your own unmanaged resources here.
            //You should not access any managed member here except static instance.
            //because the execution order of Finalizes is non-deterministic.

            if (swigCPtr.Handle != global::System.IntPtr.Zero)
            {
                if (swigCMemOwn)
                {
                    swigCMemOwn = false;
                    NDalicManualPINVOKE.delete_StatusSignalType(swigCPtr);
                }
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
            }

            disposed = true;
        }

        public bool Empty()
        {
            bool ret = NDalicManualPINVOKE.StatusSignalType_Empty(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public uint GetConnectionCount()
        {
            uint ret = NDalicManualPINVOKE.StatusSignalType_GetConnectionCount(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void Connect(System.Delegate func)
        {
            System.IntPtr ip = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(func);
            {
                NDalicManualPINVOKE.StatusSignalType_Connect(swigCPtr, new System.Runtime.InteropServices.HandleRef(this, ip));
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void Disconnect(System.Delegate func)
        {
            System.IntPtr ip = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(func);
            {
                NDalicManualPINVOKE.StatusSignalType_Disconnect(swigCPtr, new System.Runtime.InteropServices.HandleRef(this, ip));
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void Emit(bool arg)
        {
            NDalicManualPINVOKE.StatusSignalType_Emit(swigCPtr, arg);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public StatusSignalType() : this(NDalicManualPINVOKE.new_StatusSignalType(), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

    }

    ///////////////////////////////////////////////////////////////////////////////
    public class ImfVoidSignalType : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal ImfVoidSignalType(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ImfVoidSignalType obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        //A Flag to check who called Dispose(). (By User or DisposeQueue)
        private bool isDisposeQueued = false;
        //A Flat to check if it is already disposed.
        protected bool disposed = false;


        ~ImfVoidSignalType()
        {
            if (!isDisposeQueued)
            {
                isDisposeQueued = true;
                DisposeQueue.Instance.Add(this);
            }
        }

        public void Dispose()
        {
            //Throw excpetion if Dispose() is called in separate thread.
            if (!Window.IsInstalled())
            {
                throw new System.InvalidOperationException("This API called from separate thread. This API must be called from MainThread.");
            }

            if (isDisposeQueued)
            {
                Dispose(DisposeTypes.Implicit);
            }
            else
            {
                Dispose(DisposeTypes.Explicit);
                System.GC.SuppressFinalize(this);
            }
        }

        protected virtual void Dispose(DisposeTypes type)
        {
            if (disposed)
            {
                return;
            }

            if (type == DisposeTypes.Explicit)
            {
                //Called by User
                //Release your own managed resources here.
                //You should release all of your own disposable objects here.

            }

            //Release your own unmanaged resources here.
            //You should not access any managed member here except static instance.
            //because the execution order of Finalizes is non-deterministic.

            if (swigCPtr.Handle != global::System.IntPtr.Zero)
            {
                if (swigCMemOwn)
                {
                    swigCMemOwn = false;
                    NDalicManualPINVOKE.delete_ImfVoidSignalType(swigCPtr);
                }
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
            }

            disposed = true;
        }

        public bool Empty()
        {
            bool ret = NDalicManualPINVOKE.ImfVoidSignalType_Empty(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public uint GetConnectionCount()
        {
            uint ret = NDalicManualPINVOKE.ImfVoidSignalType_GetConnectionCount(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void Connect(System.Delegate func)
        {
            System.IntPtr ip = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(func);
            {
                NDalicManualPINVOKE.ImfVoidSignalType_Connect(swigCPtr, new System.Runtime.InteropServices.HandleRef(this, ip));
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void Disconnect(System.Delegate func)
        {
            System.IntPtr ip = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(func);
            {
                NDalicManualPINVOKE.ImfVoidSignalType_Disconnect(swigCPtr, new System.Runtime.InteropServices.HandleRef(this, ip));
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void Emit()
        {
            NDalicManualPINVOKE.ImfVoidSignalType_Emit(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public ImfVoidSignalType() : this(NDalicManualPINVOKE.new_ImfVoidSignalType(), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

    }

}
