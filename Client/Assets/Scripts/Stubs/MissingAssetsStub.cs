using UnityEngine;
using System.Collections.Generic;
using System;

// Stubs for missing FingerGestures assets to allow compilation
public class PinchRecognizer : MonoBehaviour { 
    public Action<PinchGesture> OnGesture; 
}

public class DragRecognizer : MonoBehaviour { 
    public Action<DragGesture> OnGesture; 
}

public class FingerDownDetector : MonoBehaviour { 
    public Action<FingerDownEvent> OnFingerDown; 
}

public class FingerUpDetector : MonoBehaviour { 
    public Action<FingerUpEvent> OnFingerUp; 
}

public enum ContinuousGesturePhase { None, Started, Updated, Ended }

public class PinchGesture {
    public ContinuousGesturePhase Phase;
    public float Delta;
    public List<Finger> Fingers = new List<Finger>();
}

public class DragGesture {
    public ContinuousGesturePhase Phase;
    public int ClusterId;
    public Vector2 DeltaMove;
    public Vector2 StartPosition;
}

public class FingerDownEvent { }

public class FingerUpEvent { 
    public Vector2 Position; 
    public Finger Finger;
}

public class Finger {
    public Vector2 Position;
    public Vector2 StartPosition;
}

// Stubs for missing Forge3D assets
public class F3DBeam : MonoBehaviour {
    public float MaxBeamLength; // Added missing property
}

public class F3DFXController : MonoBehaviour
{
    public static F3DFXController instance;
    public void Fire() { }
}

// Stubs for missing ScreenBlur
public class ScreenBlurRadial : MonoBehaviour
{
}
