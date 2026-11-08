# Assignment 4 — Introduction to Augmented Reality

**Name:** Yao Chen  
**JHED:** ychen777

Course: EN.601.654 / EN.601.454, Fall 2026.

## Repository contents

- `Q1/Q1e.py`: 1D position/velocity Kalman filter with prediction and measurement correction.
- `Q1/Q1f.py`: prediction-only version without measurement correction.
- `Q1/Q1e_output.png`, `Q1/Q1f_output.png`: output plots.
- `Q2/Roll/`: Unity Roll-a-ball project, including Assets, Packages, and ProjectSettings.
- `Q2/ScreenRecording.mp4`: gameplay screen recording.

## Run Q1

Use Python 3 with NumPy and Matplotlib:

```sh
python3 -m venv .venv
source .venv/bin/activate
python3 -m pip install numpy matplotlib
python3 Q1/Q1e.py
python3 Q1/Q1f.py
```

Each script displays a plot. Random simulation noise means repeated runs may produce different results.

## Run Q2

1. Install Unity Hub and Unity Editor **6000.3.24f1**, the version recorded in `ProjectSettings/ProjectVersion.txt`.
2. In Unity Hub, add `Q2/Roll` as an existing project. Allow Unity to restore its packages.
3. Open `Assets/Scenes/SampleScene.unity` and enter Play mode.
4. Click **Start**. Use **WASD / arrow keys** to move and **Space** to jump.
5. Collect the cubes, including the elevated cubes. After all cubes are collected, collect the power-up capsule to change color, gain speed, and activate the on-screen power-up indicator.
6. Break the special wall while powered up, then jump the gap into the goal zone to display the win message.

The project includes a Unity `.gitignore` that excludes generated Library, Temp, build, log, and user-settings folders. The gameplay recording is available at [Q2/ScreenRecording.mp4](Q2/ScreenRecording.mp4).
