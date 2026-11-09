# Assignment 4

**Name:** Yao Chen  
**JHED:** ychen777

## Repository contents

- `Q1/Q1e.py`: 1D position/velocity Kalman filter with prediction and measurement correction.
- `Q1/Q1f.py`: prediction-only version without measurement correction.
- `Q1/Q1e_output.png`, `Q1/Q1f_output.png`: output plots.
- `Q2/Roll/`: Unity Roll-a-ball project, including Assets, Packages, and ProjectSettings.
- `Q2/ScreenRecording.mp4`: gameplay screen recording.

## Run Q1

```sh
python3 Q1/Q1e.py
python3 Q1/Q1f.py
```

Each script displays a plot. Random simulation noise means repeated runs may produce different results.

## Run Q2

1. In Unity Hub, add `Q2/Roll` as an existing project. Allow Unity to restore its packages.
2. Open `Assets/Scenes/SampleScene.unity` and enter Play mode.
3. Click **Start**. Use **WASD / arrow keys** to move and **Space** to jump.
4. Collect the cubes, including the elevated cubes. After all cubes are collected, collect the power-up capsule to change color, gain speed, and activate the on-screen power-up indicator.
5. Break the special wall while powered up, make sure you move the ball to the edge of the plane, then jump the gap into the goal zone to display the win message.

