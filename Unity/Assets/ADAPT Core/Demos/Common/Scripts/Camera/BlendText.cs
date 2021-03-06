#region License
/*
* Agent Development and Prototyping Testbed
* https://github.com/ashoulson/ADAPT
* 
* Copyright (C) 2011-2015 Alexander Shoulson - ashoulson@gmail.com
*
* This file is part of ADAPT.
* 
* ADAPT is free software: you can redistribute it and/or modify
* it under the terms of the GNU Lesser General Public License as published
* by the Free Software Foundation, either version 3 of the License, or
* (at your option) any later version.
* 
* ADAPT is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU Lesser General Public License for more details.
* 
* You should have received a copy of the GNU Lesser General Public License
* along with ADAPT.  If not, see <http://www.gnu.org/licenses/>.
*/
#endregion

using UnityEngine;
using System.Collections;

public class BlendText : MonoBehaviour
{
    public string[] helptext;
    public Coordinator coordinator;

    void OnGUI()
    {
        GUIStyle style = new GUIStyle();
        style.normal.textColor = Color.black;
        for (int i = 0; i < helptext.Length; i++)
            GUILayout.Label(helptext[i], style);

        GUILayout.Label("Sitting: " + coordinator.sWeight.Value, style);
        GUILayout.Label("Gesture: " + coordinator.aWeight.Value, style);
        GUILayout.Label("HeadLook: " + coordinator.hWeight.Value, style);
        GUILayout.Label("Reaching: " + coordinator.rWeight.Value, style);
        GUILayout.Label("Ragdoll: " + coordinator.dWeight.Value, style);
    }
}
