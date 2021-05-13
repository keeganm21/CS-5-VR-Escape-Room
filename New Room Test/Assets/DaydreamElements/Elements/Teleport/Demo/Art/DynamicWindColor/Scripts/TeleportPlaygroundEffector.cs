﻿// Copyright 2017 Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DaydreamElements.Common;

namespace DaydreamElements.Teleport {
  public class TeleportPlaygroundEffector : MonoBehaviour {
    public TeleportController teleportController;
    public GlobalDynamicWindColorSimple windSystem;

    void OnDrawGizmosSelected() {
      if (teleportController == null) {
        teleportController = FindObjectOfType( typeof(TeleportController)) as TeleportController;
      }
      if (windSystem == null) {
        windSystem = FindObjectOfType( typeof(GlobalDynamicWindColorSimple)) as GlobalDynamicWindColorSimple;
      }
    }

    void Update() {
      if (teleportController.IsTeleporting == true) {
        windSystem.effectorA.radius = 0f;
        windSystem.effectorA.growthSpeed = 0f;
      }
    }
  }
}
