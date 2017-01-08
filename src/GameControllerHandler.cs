/// <summary>
/// Game Controller Handler takes care of the various operating systems issue.
/// The class will detect which OS is running, and adjust the controller input accordingly.
/// </summary>
/// 
/// http://wiki.unity3d.com/index.php?title=Xbox360Controller

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerHandler : MonoBehaviour {

	private System.String OperatingSystem;

	// Buttons to represent input names
	private string buttonA, buttonB, buttonX, buttonY;
	private string buttonSelect, buttonStart;
	private string buttonRightBumper, buttonLeftBumper;
	private string buttonLeftStickClick, buttonRightStickClick;
	private string axisLeftAnalogX, axisLeftAnalogY, axisRightAnalogX, axisRightAnalogY;
	private string axisLeftTrigger, axisRightTrigger;

	// Properties to access private buttons
	public string ButtonA { get { return this.buttonA; } }
	public string ButtonB { get { return this.buttonB; } }
	public string ButtonX { get { return this.buttonX; } }
	public string ButtonY { get { return this.buttonY; } }
	public string ButtonSelect { get { return this.buttonSelect; } }
	public string ButtonStart { get { return this.buttonStart; } }
	public string ButtonRightBumper { get { return this.buttonRightBumper; } }
	public string ButtonLeftBumper { get { return this.buttonLeftBumper; } }
	public string ButtonLeftStickClick { get { return this.buttonLeftStickClick; } }
	public string ButtonRightStickClick { get { return this.buttonRightStickClick; } }
	public string AxisLeftAnalogX { get { return this.axisLeftAnalogX; } }
	public string AxisLeftAnalogY { get { return this.axisLeftAnalogY; } }
	public string AxisRightAnalogX { get { return this.axisRightAnalogX; } }
	public string AxisRightAnalogY { get { return this.axisRightAnalogY; } }
	public string AxisLeftTrigger { get { return this.AxisLeftTrigger; } }
	public string AxisRightTrigger { get { return this.axisRightTrigger; } }

	private void Start()
	{
		this.OperatingSystem = SystemInfo.operatingSystem;
		InitializeController ();
	}

	/// <summary>
	/// Determines what OS is running and calls platform-specific Initialize function.
	/// </summary>
	private void InitializeController()
	{
		if (OperatingSystem.Contains ("Mac")) {
			Debug.Log ("Mac OS.");
			InitializeForMac ();
		} else if (OperatingSystem.Contains ("Windows")) {
			Debug.Log ("Windows OS.");
			InitializeForWindows ();
		} else if (OperatingSystem.Contains ("Linux")) {
			Debug.Log ("Linux OS.");
			InitializeForLinux ();
		} else {
			Debug.Log ("Unknown OS.");
		}
	}

	/// <summary>
	/// Maps input buttons for controller on MacOS systems.
	/// </summary>
	private void InitializeForMac()
	{
		// Map all buttons to 'Settings > Input' names.
		buttonA = "MacButtonA";
		buttonB = "MacButtonB";
		buttonX = "MacButtonX";
		buttonY = "MacButtonY";
		buttonSelect = "MacButtonSelect";
		buttonStart = "MacButtonStart";
		buttonRightBumper = "MacButtonRightBumper";
		buttonLeftBumper = "MacButtonLeftBumper";
		buttonRightStickClick = "MacButtonRightStickClick";
		buttonLeftStickClick = "MacButtonLeftStickClick";

		// Map all analog inputs to 'Settings > Input'.
		axisLeftAnalogX = "MacAxisLeftAnalogX";
		axisLeftAnalogY = "MacAxisLeftAnalogY";
		axisRightAnalogX = "MacAxisRightAnalogX";
		axisRightAnalogY = "MacAxisRightAnalogY";
		axisLeftTrigger = "MacAxisLeftTrigger";
		axisRightTrigger = "MacAxisRightTrigger";
	}

	/// <summary>
	/// Maps input buttons for controller on Windows systems.
	/// </summary>
	private void InitializeForWindows()
	{
		// Map all buttons to 'Edit > Project Settings > Input' names.
		buttonA = "WindowsButtonA";
		buttonB = "WindowsButtonB";
		buttonX = "WindowsButtonX";
		buttonY = "WindowsButtonY";
		buttonSelect = "WindowsButtonSelect";
		buttonStart = "WindowsButtonStart";
		buttonRightBumper = "WindowsButtonRightBumper";
		buttonLeftBumper = "WindowsButtonLeftBumper";
		buttonRightStickClick = "WindowsButtonRightStickClick";
		buttonLeftStickClick = "WindowsButtonLeftStickClick";

		// Map all analog inputs to 'Settings > Input'.
		axisLeftAnalogX = "WindowsAxisLeftAnalogX";
		axisLeftAnalogY = "WindowsAxisLeftAnalogY";
		axisRightAnalogX = "WindowsAxisRightAnalogX";
		axisRightAnalogY = "WindowsAxisRightAnalogY";
		axisLeftTrigger = "WindowsAxisLeftTrigger";
		axisRightTrigger = "WindowsAxisRightTrigger";
	}

	/// <summary>
	/// Maps input buttons for controller on Linux systems.
	/// TODO: Write support for Linux systems.
	/// </summary>
	private void InitializeForLinux()
	{

	}
}