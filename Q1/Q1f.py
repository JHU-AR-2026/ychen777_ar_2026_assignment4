









import numpy as np
import matplotlib.pyplot as plt


dt = 0.1
num_steps = 50


A = np.array([[1, dt],
              [0, 1]])
B = np.array([[0.5*dt**2],
              [dt]])
H = np.array([[1, 0]])


sigma_process = 0.5
sigma_measure = 2.0
Q = sigma_process**2 * np.array([[dt**4/4, dt**3/2],
                                 [dt**3/2, dt**2]])
R = np.array([[sigma_measure**2]])


x_true = np.array([[0.0], [1.0]])
x_est = np.array([[0.0], [0.0]])
P = np.eye(2) * 1.0


true_positions = []
measured_positions = []
estimated_positions = []


for k in range(num_steps):

    a = 2.0
    process_noise = np.random.multivariate_normal([0.1, 0], Q).reshape(2, 1)
    x_true = A @ x_true + B * a + process_noise


    measurement_noise = np.random.normal(0, sigma_measure)
    z = H @ x_true + measurement_noise




    x_pred = A @ x_est + B * a
    P_pred = A @ P @ A.T + Q


    x_est = x_pred
    P = P_pred


    true_positions.append(x_true[0, 0])
    measured_positions.append(z[0, 0])
    estimated_positions.append(x_est[0, 0])


t = (np.arange(num_steps) + 1) * dt
plt.figure(figsize=(10, 5))
plt.plot(t, true_positions, 'g-', label='True Position', linewidth=2)
plt.plot(t, measured_positions, 'b*', label='Measured (Noisy)')
plt.plot(t, estimated_positions, 'r.', label='Prediction Only (No Correction)')
plt.xlabel('Time [s]')
plt.ylabel('Position')
plt.title('1D Motion Prediction Without Measurement Correction')
plt.legend()
plt.grid(True)
plt.show()
