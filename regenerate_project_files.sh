#!/bin/bash

UNITY_PATH="/Applications/Unity/Hub/Editor/6000.0.32f1/Unity.app/Contents/MacOS/Unity"
PROJECT_PATH=$(pwd)

echo Regenerating project files for $PROJECT_PATH

"$UNITY_PATH" -projectPath "$PROJECT_PATH" -batchmode -quit -nographics -logFile - -executeMethod "UnityEditor.SyncVS.SyncSolution"
